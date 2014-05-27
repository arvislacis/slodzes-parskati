using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace slodzes_parskati
{
	public partial class testetajiem : Form
	{
		Form sakuma_forma;
		
		NpgsqlCommand iev_kom;
		
		DataTable laidieniDT = new DataTable();
		DataTable problemasDT = new DataTable();
		DataTable sadalasDT = new DataTable();
		DataTable stavokliDT = new DataTable();
		
		NpgsqlDataAdapter laidieniA = new NpgsqlDataAdapter("SELECT * FROM laidieni ORDER BY nosaukums DESC;", MainForm.sav);
		NpgsqlDataAdapter problemasA = new NpgsqlDataAdapter("SELECT pz.problemas_id, pz.testetaja_id, pz.no_admin_konta, s.nosaukums, pz.iss_apraksts, pz.apraksts, pz.atkl_datums, l.nosaukums, st.nosaukums, pz.piezimes, COUNT(a.atsauksmes_id) atsauksmju_sk FROM problemu_zinojumi pz LEFT JOIN atsauksmes a ON (pz.problemas_id = a.problemas_id), laidieni l, sadalas s, stavokli st WHERE pz.laidiena_id = l.laidiena_id AND pz.sadalas_id = s.sadalas_id AND pz.stavokla_id = st.stavokla_id AND pz.testetaja_id = '" + MainForm.id + "' GROUP BY 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ORDER BY pz.atkl_datums DESC, l.nosaukums DESC, pz.problemas_id DESC;", MainForm.sav);
		NpgsqlDataAdapter sadalasA = new NpgsqlDataAdapter("SELECT * FROM sadalas ORDER BY sadalas_id;", MainForm.sav);
		NpgsqlDataAdapter stavokliA = new NpgsqlDataAdapter("SELECT * FROM stavokli;", MainForm.sav);
		
		void sagatavot_formu() {
			probl_id_iev.Text = MainForm.id + "_" + zinojuma_id(problemasDT).ToString();
			laidieni_cb.SelectedIndex = stavokli_cb.SelectedIndex = 0;
			no_admin_konta.Checked = true;
			probl_nosauk_iev.Text = probl_apraksta_iev.Text = piezimju_iev.Text = "";
			
			probl_zin_skats.Sort(probl_zin_skats.Columns["atkl_datums"], ListSortDirection.Descending);
		}
		
		void sagatavot_problemu_skatu() {
			probl_zin_skats.Columns["problemas_id"].HeaderText = "Problēmas ID";
			probl_zin_skats.Columns["no_admin_konta"].HeaderText = "No administratora konta";
			probl_zin_skats.Columns["nosaukums"].HeaderText = "SLODZES sadaļa";
			probl_zin_skats.Columns["iss_apraksts"].HeaderText = "Problēmas nosaukums";
			probl_zin_skats.Columns["apraksts"].HeaderText = "Problēmas apraksts [labot]";
			probl_zin_skats.Columns["atkl_datums"].HeaderText = "Problēmas atklāšanas datums";
			probl_zin_skats.Columns["nosaukums1"].HeaderText = "SLODZES laidiens";
			probl_zin_skats.Columns["nosaukums2"].HeaderText = "Kļūdas veids";
			probl_zin_skats.Columns["piezimes"].HeaderText = "Piezīmes [labot]";
			probl_zin_skats.Columns["atsauksmju_sk"].HeaderText = "Atsauksmes [skatīt]";
			
			probl_zin_skats.Columns["testetaja_id"].Visible = false;
			probl_zin_skats.Columns["problemas_id"].ReadOnly = probl_zin_skats.Columns["no_admin_konta"].ReadOnly = probl_zin_skats.Columns["nosaukums"].ReadOnly = probl_zin_skats.Columns["iss_apraksts"].ReadOnly = probl_zin_skats.Columns["atkl_datums"].ReadOnly = probl_zin_skats.Columns["nosaukums1"].ReadOnly = probl_zin_skats.Columns["nosaukums2"].ReadOnly = probl_zin_skats.Columns["atsauksmju_sk"].ReadOnly = true;
		}
		
		int zinojuma_id(DataTable dt) {
			int max_vertiba = 0;
			
			foreach (DataRow r in dt.Rows) {
				int vertiba = Convert.ToInt32(r["problemas_id"].ToString().Substring(4));
				
				if (vertiba > max_vertiba) {
					max_vertiba = vertiba;
				}
			}
			
			return max_vertiba + 1;
		}
		
		void nosaukuma_kluda() {
			if (probl_nosauk_iev.Text == "") {
				kludas.SetError(probl_nosauk_iev, "Problēmas ziņojuma nosaukuma laukam jābūt obligāti aizpildītam!");
			} else {
				kludas.SetError(probl_nosauk_iev, "");
			}
		}
		
		void apraksta_kluda() {
			if (probl_apraksta_iev.Text == "") {
				kludas.SetError(probl_apraksta_iev, "Problēmas ziņojuma apraksta laukam jābūt obligāti aizpildītam!");
			} else {
				kludas.SetError(probl_apraksta_iev, "");
			}
		}
		
		public testetajiem(Form f)
		{
			InitializeComponent();
			
			sakuma_forma = f;
			this.Text = Application.ProductName.ToString();
			
			MainForm.paz_mainit_paroli("testetajs");
			
			testetajs_txt.Text = MainForm.id + " - " + MainForm.vards + " " + MainForm.uzvards;
			statuss_txt.Text = MainForm.statusam;
			
			laidieniA.Fill(laidieniDT);
			problemasA.Fill(problemasDT);
			sadalasA.Fill(sadalasDT);
			stavokliA.Fill(stavokliDT);
			
			laidieni_cb.DataSource = laidieniDT;
			laidieni_cb.DisplayMember = "nosaukums";
			laidieni_cb.ValueMember = "laidiena_id";
			
			stavokli_cb.DataSource = stavokliDT;
			stavokli_cb.DisplayMember = "nosaukums";
			stavokli_cb.ValueMember = "stavokla_id";
			
			probl_zin_skats.DataSource = problemasDT;
			
			sagatavot_formu();
			sagatavot_problemu_skatu();
		}
		
		void Sadalas_koksClick(object sender, EventArgs e)
		{
			sadalas f = new sadalas(no_admin_konta.Checked, sadalasDT);
			
			if (f.ShowDialog() == DialogResult.OK) {
				sadalas_koks.Tag = f.sad_id;
				sadalas_koks.Text = f.sad_nosauk;
			}
		}
		
		void Probl_nosauk_ievValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			nosaukuma_kluda();
		}
		
		void Probl_apraksta_ievValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			apraksta_kluda();
		}
		
		void Pievienot_pogaClick(object sender, EventArgs e)
		{	
			if (probl_nosauk_iev.Text != "" && probl_apraksta_iev.Text != "" && sadalas_koks.Tag != null) {
				DataRow dr = problemasDT.NewRow();
				dr["problemas_id"] = probl_id_iev.Text;
				dr["testetaja_id"] = MainForm.id;
				dr["no_admin_konta"] = no_admin_konta.Checked;
				dr["nosaukums"] = sadalas_koks.Text;
				dr["iss_apraksts"] = probl_nosauk_iev.Text;
				dr["apraksts"] = probl_apraksta_iev.Text;
				dr["atkl_datums"] = DateTime.Now.Date;
				dr["nosaukums1"] = laidieni_cb.Text;
				dr["nosaukums2"] = stavokli_cb.Text;
				dr["piezimes"] = piezimju_iev.Text;
				dr["atsauksmju_sk"] = 0;
				problemasDT.Rows.Add(dr);
				problemasDT.AcceptChanges();
				
				iev_kom = new NpgsqlCommand("INSERT INTO problemu_zinojumi VALUES('" + probl_id_iev.Text + "', '" + MainForm.id + "', " + no_admin_konta.Checked +  ", " + (int)sadalas_koks.Tag + ", '" + probl_nosauk_iev.Text + "', '" + probl_apraksta_iev.Text + "', now(), " + laidieni_cb.SelectedValue + ", " + stavokli_cb.SelectedValue + ", '" + piezimju_iev.Text + "');", MainForm.sav);
				
				MainForm.sav.Open();
				int ieraksti = iev_kom.ExecuteNonQuery();
				MainForm.sav.Close();
				
				if (ieraksti != -1) {
					MessageBox.Show("Problēmas ziņojuma ieraksts veiksmīgi pievienots.", "Ieraksts pievienots", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sagatavot_formu();
				} else {
					MessageBox.Show("Problēmas ziņojuma ierakstu neizdevās pievienot.\nMēģiniet atkārtot datu ievadi vēlāk.", "Ierakstu neizdevās pievienot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			} else {
				nosaukuma_kluda();
				apraksta_kluda();
				
				MessageBox.Show("Problēmas ziņojuma ierakstu nevar pievienot, jo nav novērstas visas kļūdas. Skatiet kļūdas paziņojumus blakus ievadlaukiem un pārliecinieties, ka esat norādījis SLODZES laidienu.", "Problēmas ziņojuma ierakstu nevar pievienot", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		void TestetajiemFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm.id = MainForm.vards = MainForm.uzvards = MainForm.statusam = MainForm.md5 = MainForm.parole = "";
			sakuma_forma.Visible = true;
		}
		
		void IzietToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void MainītParoliToolStripMenuItemClick(object sender, EventArgs e)
		{
			paroles_maina p_m = new paroles_maina("testetajs");
			p_m.ShowDialog();
		}
		
		void SLODZESmājasLapaToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm.majas_lapa();
		}
		
		void SūtītAtsauksmiToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm.sutit_atsauksmi();
		}
		
		void ParToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm.par();
		}
		
		void Txt_filtrs_ievTextChanged(object sender, EventArgs e)
		{
			try {
				problemasDT.DefaultView.RowFilter = string.Format("problemas_id LIKE '%{0}%' OR nosaukums LIKE '%{0}%' OR iss_apraksts LIKE '%{0}%' OR apraksts LIKE '%{0}%' OR nosaukums1 LIKE '%{0}%' OR nosaukums2 LIKE '%{0}%' OR piezimes LIKE '%{0}%'", txt_filtrs_iev.Text);
			} catch (Exception) {
			}
		}
		
		void Probl_zin_skatsCellLeave(object sender, DataGridViewCellEventArgs e)
		{
			probl_zin_skats.Rows[e.RowIndex].ErrorText = "";
			
			NpgsqlCommand atj_kom = new NpgsqlCommand("UPDATE problemu_zinojumi SET apraksts=@apraksts, piezimes=@piezimes WHERE problemas_id=@id;", MainForm.sav);
			atj_kom.Parameters.Add(new NpgsqlParameter("@apraksts", DbType.String, 500, "apraksts"));
			atj_kom.Parameters.Add(new NpgsqlParameter("@piezimes", DbType.String, 255, "piezimes"));
			atj_kom.Parameters.Add(new NpgsqlParameter("@id", DbType.String, 7, "problemas_id"));
			
			problemasA.UpdateCommand = atj_kom;
			problemasA.Update(problemasDT);
		}
		
		void Probl_zin_skatsCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (probl_zin_skats.Columns[e.ColumnIndex].Name == "apraksts") {
				if (String.IsNullOrEmpty(e.FormattedValue.ToString()) && probl_zin_skats[e.ColumnIndex, e.RowIndex].IsInEditMode) {
					probl_zin_skats.Rows[e.RowIndex].ErrorText = "Problēmas ziņojuma apraksta laukam jābūt obligāti aizpildītam!";
					e.Cancel = true;
				}
			}
		}
		
		void Probl_zin_skatsCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (probl_zin_skats.Columns[e.ColumnIndex].Name != "apraksts" && probl_zin_skats.Columns[e.ColumnIndex].Name != "piezimes" && probl_zin_skats.Rows[e.RowIndex].Cells["atsauksmju_sk"].Value.ToString() != "0") {
				atsauksmes f = new atsauksmes(probl_zin_skats.Rows[e.RowIndex].Cells[0].Value.ToString());
				f.ShowDialog();
			}
		}
	}
}