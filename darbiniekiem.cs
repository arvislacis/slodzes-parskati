using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Npgsql;

namespace slodzes_parskati
{
	public partial class darbiniekiem : Form
	{
		Form sakuma_forma;
		
		public static DataSet db = new DataSet();
		
		DataTable amatiDT = new DataTable();
		DataTable atsauksmesDT = new DataTable();
		DataTable darbiniekiDT = new DataTable();
		DataTable laidieniDT = new DataTable();
		DataTable lemumiDT = new DataTable();
		DataTable problemasDT = new DataTable();
		DataTable sadalasDT = new DataTable();
		DataTable stavokliDT = new DataTable();
		DataTable stud_prog_veidiDT = new DataTable();
		DataTable stud_progDT = new DataTable();
		DataTable testetajiDT = new DataTable();
		
		DataRow[] ieraksti;
		DataTable laid_kop_DT = new DataTable();
		DataTable sad_kop_DT = new DataTable();
		DataTable stav_kop_DT = new DataTable();
		
		NpgsqlDataAdapter amatiA = new NpgsqlDataAdapter("SELECT * FROM amati;", MainForm.sav);
		NpgsqlDataAdapter atsauksmesA = new NpgsqlDataAdapter("SELECT * FROM atsauksmes ORDER BY datums DESC;", MainForm.sav);
		NpgsqlDataAdapter darbiniekiA = new NpgsqlDataAdapter("SELECT d.darbinieka_id, d.vards, d.uzvards, d.parole, d.amata_id, LEFT(d.vards, 1) || '. ' || d.uzvards v_uzvards FROM darbinieki d ORDER BY uzvards;", MainForm.sav);
		NpgsqlDataAdapter laidieniA = new NpgsqlDataAdapter("SELECT * FROM laidieni ORDER BY publ_datums DESC;", MainForm.sav);
		NpgsqlDataAdapter lemumiA = new NpgsqlDataAdapter("SELECT * FROM lemumi;", MainForm.sav);
		NpgsqlDataAdapter problemasA = new NpgsqlDataAdapter("SELECT pz.problemas_id, pz.testetaja_id, pz.no_admin_konta, pz.sadalas_id, pz.iss_apraksts, pz.apraksts, pz.atkl_datums, pz.laidiena_id, pz.stavokla_id, pz.piezimes, COUNT(a.atsauksmes_id) atsauksmju_sk FROM problemu_zinojumi pz LEFT JOIN atsauksmes a ON (pz.problemas_id = a.problemas_id) GROUP BY 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ORDER BY atkl_datums DESC, laidiena_id DESC, stavokla_id;", MainForm.sav);
		NpgsqlDataAdapter sadalasA = new NpgsqlDataAdapter("SELECT * FROM sadalas;", MainForm.sav);
		NpgsqlDataAdapter stavokliA = new NpgsqlDataAdapter("SELECT * FROM stavokli;", MainForm.sav);
		public static NpgsqlDataAdapter stud_prog_veidiA = new NpgsqlDataAdapter("SELECT * FROM stud_progr_veidi;", MainForm.sav);
		NpgsqlDataAdapter stud_progrA = new NpgsqlDataAdapter("SELECT * FROM stud_programmas ORDER BY programmas_kods;", MainForm.sav);
		NpgsqlDataAdapter testetajiA = new NpgsqlDataAdapter("SELECT t.testetaja_id, t.vards, t.uzvards, t.parole, t.programmas_kods, COUNT(pz.problemas_id) problemu_sk FROM testetaji t LEFT JOIN problemu_zinojumi pz ON (t.testetaja_id = pz.testetaja_id) GROUP BY 1, 2, 3, 4, 5 ORDER BY uzvards;", MainForm.sav);
		
		int zara_id;
		
		public darbiniekiem(Form f)
		{
			InitializeComponent();
			
			sakuma_forma = f;
			this.Text = Application.ProductName.ToString();
			
			MainForm.paz_mainit_paroli("darbinieks");
			
			darbinieks_txt.Text = MainForm.id + " - " + MainForm.vards + " " + MainForm.uzvards;
			statuss_txt.Text = MainForm.statusam;
			
			amatiA.Fill(amatiDT);
			atsauksmesA.Fill(atsauksmesDT);
			darbiniekiA.Fill(darbiniekiDT);
			laidieniA.Fill(laidieniDT);
			lemumiA.Fill(lemumiDT);
			problemasA.Fill(problemasDT);
			sadalasA.Fill(sadalasDT);
			stavokliA.Fill(stavokliDT);
			stud_prog_veidiA.Fill(stud_prog_veidiDT);
			stud_progrA.Fill(stud_progDT);
			testetajiA.Fill(testetajiDT);
			
			db.Tables.Add(amatiDT);
			db.Tables.Add(atsauksmesDT);
			db.Tables.Add(darbiniekiDT);
			db.Tables.Add(laidieniDT);
			db.Tables.Add(lemumiDT);
			db.Tables.Add(problemasDT);
			db.Tables.Add(sadalasDT);
			db.Tables.Add(stavokliDT);
			db.Tables.Add(stud_prog_veidiDT);
			db.Tables.Add(stud_progDT);
			db.Tables.Add(testetajiDT);
			
			amatiDT.PrimaryKey = new DataColumn[] {amatiDT.Columns["amata_id"]};
			atsauksmesDT.PrimaryKey = new DataColumn[] {atsauksmesDT.Columns["atsauksmes_id"]};
			darbiniekiDT.PrimaryKey = new DataColumn[] {darbiniekiDT.Columns["darbinieka_id"]};
			laidieniDT.PrimaryKey = new DataColumn[] {laidieniDT.Columns["laidiena_id"]};
			lemumiDT.PrimaryKey = new DataColumn[] {lemumiDT.Columns["lemuma_id"]};
			problemasDT.PrimaryKey = new DataColumn[] {problemasDT.Columns["problemas_id"]};
			sadalasDT.PrimaryKey = new DataColumn[] {sadalasDT.Columns["sadalas_id"]};
			stavokliDT.PrimaryKey = new DataColumn[] {stavokliDT.Columns["stavokla_id"]};
			stud_prog_veidiDT.PrimaryKey = new DataColumn[] {stud_prog_veidiDT.Columns["stud_prog_veida_id"]};
			stud_progDT.PrimaryKey = new DataColumn[] {stud_progDT.Columns["programmas_kods"]};
			testetajiDT.PrimaryKey = new DataColumn[] {testetajiDT.Columns["testetaja_id"]};
			
			amatiDT.Columns["amata_id"].AutoIncrement = true;
			atsauksmesDT.Columns["atsauksmes_id"].AutoIncrement = true;
			laidieniDT.Columns["laidiena_id"].AutoIncrement = true;
			lemumiDT.Columns["lemuma_id"].AutoIncrement = true;
			sadalasDT.Columns["sadalas_id"].AutoIncrement = true;
			stavokliDT.Columns["stavokla_id"].AutoIncrement = true;
			stud_prog_veidiDT.Columns["stud_prog_veida_id"].AutoIncrement = true;
			
			amatiDT.Columns["amata_id"].AutoIncrementStep = 1;
			atsauksmesDT.Columns["atsauksmes_id"].AutoIncrementStep = 1;
			laidieniDT.Columns["laidiena_id"].AutoIncrementStep = 1;
			lemumiDT.Columns["lemuma_id"].AutoIncrementStep = 1;
			sadalasDT.Columns["sadalas_id"].AutoIncrementStep = 1;
			stavokliDT.Columns["stavokla_id"].AutoIncrementStep = 1;
			stud_prog_veidiDT.Columns["stud_prog_veida_id"].AutoIncrementStep = 1;
			
			if (amatiDT.Rows.Count > 0) {
				amatiDT.Columns["amata_id"].AutoIncrementSeed = (int)amatiDT.Compute("MAX(amata_id)", String.Empty) + 1;
			} else {
				amatiDT.Columns["amata_id"].AutoIncrementSeed = 1;
			}
			
			if (atsauksmesDT.Rows.Count > 0) {
				atsauksmesDT.Columns["atsauksmes_id"].AutoIncrementSeed = (int)atsauksmesDT.Compute("MAX(atsauksmes_id)", String.Empty) + 1;
			} else {
				atsauksmesDT.Columns["atsauksmes_id"].AutoIncrementSeed = 1;
			}
			
			if (laidieniDT.Rows.Count > 0) {
				laidieniDT.Columns["laidiena_id"].AutoIncrementSeed = (int)laidieniDT.Compute("MAX(laidiena_id)", String.Empty) + 1;
			} else {
				laidieniDT.Columns["laidiena_id"].AutoIncrementSeed = 1;
			}
			
			if (lemumiDT.Rows.Count > 0) {
				lemumiDT.Columns["lemuma_id"].AutoIncrementSeed = (int)lemumiDT.Compute("MAX(lemuma_id)", String.Empty) + 1;
			} else {
				lemumiDT.Columns["lemuma_id"].AutoIncrementSeed = 1;
			}
			
			if (sadalasDT.Rows.Count > 0) {
				sadalasDT.Columns["sadalas_id"].AutoIncrementSeed = (int)sadalasDT.Compute("MAX(sadalas_id)", String.Empty) + 1;
			} else {
				sadalasDT.Columns["sadalas_id"].AutoIncrementSeed = 1;
			}
			
			if (stavokliDT.Rows.Count > 0) {
				stavokliDT.Columns["stavokla_id"].AutoIncrementSeed = (int)stavokliDT.Compute("MAX(stavokla_id)", String.Empty) + 1;
			} else {
				stavokliDT.Columns["stavokla_id"].AutoIncrementSeed = 1;
			}
			
			if (stud_prog_veidiDT.Rows.Count > 0) {
				stud_prog_veidiDT.Columns["stud_prog_veida_id"].AutoIncrementSeed = (int)stud_prog_veidiDT.Compute("MAX(stud_prog_veida_id)", String.Empty) + 1;
			} else {
				stud_prog_veidiDT.Columns["stud_prog_veida_id"].AutoIncrementSeed = 1;
			}
			
			db.Relations.Add("amati-darbinieki", amatiDT.Columns["amata_id"], darbiniekiDT.Columns["amata_id"]);
			db.Relations.Add("problemas-atsauksmes", problemasDT.Columns["problemas_id"], atsauksmesDT.Columns["problemas_id"]);
			db.Relations.Add("stud_progr_v-stud_progr", stud_prog_veidiDT.Columns["stud_prog_veida_id"], stud_progDT.Columns["stud_prog_veida_id"]);
			db.Relations.Add("stud_progr-test", stud_progDT.Columns["programmas_kods"], testetajiDT.Columns["programmas_kods"]);
			
			laid_kop_DT = laidieniDT.Copy();
			sad_kop_DT = sadalasDT.Copy();
			stav_kop_DT = stavokliDT.Copy();
			
			amati_skats.DataSource = amatiDT;
			amati_skats.Columns["nosaukums"].HeaderText = "Amata nosaukums";
			
			atsauksmes_skats.DataSource = atsauksmesDT;
			atsauksmes_skats.DataSource = problemasDT;
			atsauksmes_skats.DataMember = "problemas-atsauksmes";
			atsauksmes_skats.Columns["datums"].ReadOnly = true;
			atsauksmes_skats.Columns["komentars"].HeaderText = "Atsauksme";
			atsauksmes_skats.Columns["datums"].HeaderText = "Atsauksmes datums [#]";
			DataGridViewComboBoxColumn cb_d_id = new DataGridViewComboBoxColumn();
			cb_d_id.DataSource = darbiniekiDT;
			cb_d_id.DataPropertyName = cb_d_id.ValueMember = "darbinieka_id";
			cb_d_id.DisplayMember = "v_uzvards";
			cb_d_id.HeaderText = "Darbinieks";
			atsauksmes_skats.Columns.Remove(atsauksmes_skats.Columns["darbinieka_id"]);
			atsauksmes_skats.Columns.Insert(0, cb_d_id);
			DataGridViewComboBoxColumn cb_l_id = new DataGridViewComboBoxColumn();
			cb_l_id.DataSource = lemumiDT;
			cb_l_id.DataPropertyName = cb_l_id.ValueMember = "lemuma_id";
			cb_l_id.DisplayMember = "nosaukums";
			cb_l_id.HeaderText = "Problēmas stāvoklis";
			atsauksmes_skats.Columns.Remove(atsauksmes_skats.Columns["lemuma_id"]);
			atsauksmes_skats.Columns.Insert(5, cb_l_id);
			DataGridViewComboBoxColumn cb_iz_id = new DataGridViewComboBoxColumn();
			cb_iz_id.DataSource = darbiniekiDT;
			cb_iz_id.DisplayMember = "v_uzvards";
			cb_iz_id.ValueMember = "darbinieka_id";
			cb_iz_id.DataPropertyName = "izpilditaja_id";
			cb_iz_id.HeaderText = "Izpildītājs";
			atsauksmes_skats.Columns.Remove(atsauksmes_skats.Columns["izpilditaja_id"]);
			atsauksmes_skats.Columns.Insert(6, cb_iz_id);
			
			darbinieki_skats.DataSource = darbiniekiDT;
			darbinieki_skats.DataSource = amatiDT;
			darbinieki_skats.DataMember = "amati-darbinieki";
			sagatavot_darbinieku_skatu();
			
			laidieni_skats.DataSource = laidieniDT;
			laidieni_skats.Columns["nosaukums"].HeaderText = "Nosaukums/versija";
			laidieni_skats.Columns["apraksts"].HeaderText = "Apraksts, veiktās izmaiņas";
			laidieni_skats.Columns["publ_datums"].HeaderText = "Laidiena publicēšanas datums";
			
			lemumi_skats.DataSource = lemumiDT;
			lemumi_skats.Columns["nosaukums"].HeaderText = "Problēmas stāvoklis";
			lemumi_skats.Columns["apraksts"].HeaderText = "Problēmas stāvokļa raksturojums";
			
			problemas_skats.DataSource = problemasDT;
			problemas_skats.Columns["problemas_id"].ReadOnly = problemas_skats.Columns["atkl_datums"].ReadOnly = problemas_skats.Columns["atsauksmju_sk"].ReadOnly = true;
			problemas_skats.Columns["problemas_id"].HeaderText = "Problēmas ID [#]";
			problemas_skats.Columns["no_admin_konta"].HeaderText = "No administratora konta";
			problemas_skats.Columns["iss_apraksts"].HeaderText = "Problēmas nosaukums";
			problemas_skats.Columns["apraksts"].HeaderText = "Problēmas apraksts";
			problemas_skats.Columns["atkl_datums"].HeaderText = "Problēmas atklāšanas datums [#]";
			problemas_skats.Columns["piezimes"].HeaderText = "Piezīmes";
			problemas_skats.Columns["atsauksmju_sk"].HeaderText = "Atsauksmju skaits [#]";
			DataGridViewComboBoxColumn cb_sad_id = new DataGridViewComboBoxColumn();
			cb_sad_id.DataSource = sad_kop_DT;
			cb_sad_id.DataPropertyName = cb_sad_id.ValueMember = "sadalas_id";
			cb_sad_id.DisplayMember = "nosaukums";
			cb_sad_id.HeaderText = "SLODZES sadaļa";
			problemas_skats.Columns.Remove(problemas_skats.Columns["sadalas_id"]);
			problemas_skats.Columns.Insert(3, cb_sad_id);
			DataGridViewComboBoxColumn cb_laid_id = new DataGridViewComboBoxColumn();
			cb_laid_id.DataSource = laidieniDT;
			cb_laid_id.DataPropertyName = cb_laid_id.ValueMember = "laidiena_id";
			cb_laid_id.DisplayMember = "nosaukums";
			cb_laid_id.HeaderText = "SLODZES laidiens";
			problemas_skats.Columns.Remove(problemas_skats.Columns["laidiena_id"]);
			problemas_skats.Columns.Insert(7, cb_laid_id);
			DataGridViewComboBoxColumn cb_stav_id = new DataGridViewComboBoxColumn();
			cb_stav_id.DataSource = stavokliDT;
			cb_stav_id.DataPropertyName = cb_stav_id.ValueMember = "stavokla_id";
			cb_stav_id.DisplayMember = "nosaukums";
			cb_stav_id.HeaderText = "Kļūdas veids";
			problemas_skats.Columns.Remove(problemas_skats.Columns["stavokla_id"]);
			problemas_skats.Columns.Insert(8, cb_stav_id);
			
			sadalas_skats.DataSource = sadalasDT;
			sadalas_skats.Columns["nosaukums"].HeaderText = "Sadaļas nosaukums";
			sadalas_skats.Columns["url"].HeaderText = "Sadaļas adrese";
			sadalas_skats.Columns["tikai_admin"].HeaderText = "Tikai administratora kontā";
			
			stavokli_skats.DataSource = stavokliDT;
			stavokli_skats.Columns["nosaukums"].HeaderText = "Kļūdas veids";
			stavokli_skats.Columns["raksturojums"].HeaderText = "Kļūdas veida raksturojums";
			
			stud_progr_skats.DataSource = stud_progDT;
			stud_progr_skats.Columns["programmas_kods"].HeaderText = "Programmas kods";
			stud_progr_skats.Columns["nosaukums"].HeaderText = "Programmas nosaukums";
			DataGridViewComboBoxColumn cb_sp_veids = new DataGridViewComboBoxColumn();
			cb_sp_veids.DataSource = stud_prog_veidiDT;
			cb_sp_veids.DataPropertyName = cb_sp_veids.ValueMember = "stud_prog_veida_id";
			cb_sp_veids.DisplayMember = "veids";
			cb_sp_veids.HeaderText = "Programmas veids";
			stud_progr_skats.Columns.Remove(stud_progr_skats.Columns["stud_prog_veida_id"]);
			stud_progr_skats.Columns.Add(cb_sp_veids);
			
			testetaji_skats.DataSource = testetajiDT;
			testetaji_skats.DataSource = stud_progDT;
			testetaji_skats.DataMember = "stud_progr-test";
			sagatavot_testetaju_skatu();
			
			laidieni_cb.DataSource = laid_kop_DT;
			laidieni_cb.DisplayMember = "nosaukums";
			laidieni_cb.ValueMember = "laidiena_id";
			
			stavokli_cb.DataSource = stav_kop_DT;
			stavokli_cb.DisplayMember = "nosaukums";
			stavokli_cb.ValueMember = "stavokla_id";
			
			strukturet_koku(0, null);
			sadalas_koks.SelectedNode = sadalas_koks.Nodes[0];
			
			if (!File.Exists(DateTime.Now.ToShortDateString() + "_" + MainForm.id + "_backup.xml")) {
				db.WriteXml(DateTime.Now.ToShortDateString() + "_" + MainForm.id + "_backup.xml", XmlWriteMode.WriteSchema);
			}
		}
		
		void CilnesEnter(object sender, EventArgs e)
		{
			amati_skats.Columns["amata_id"].Visible = atsauksmes_skats.Columns["atsauksmes_id"].Visible = atsauksmes_skats.Columns["problemas_id"].Visible = darbinieki_skats.Columns["amata_id"].Visible = darbinieki_skats.Columns["v_uzvards"].Visible = laidieni_skats.Columns["laidiena_id"].Visible = lemumi_skats.Columns["lemuma_id"].Visible = problemas_skats.Columns["testetaja_id"].Visible = sadalas_skats.Columns["sadalas_id"].Visible = sadalas_skats.Columns["galv_sadalas_id"].Visible = stavokli_skats.Columns["stavokla_id"].Visible = testetaji_skats.Columns["programmas_kods"].Visible = false;
		}
		
		void sagatavot_testetaju_skatu() {
			testetaji_skats.Columns["testetaja_id"].ReadOnly = testetaji_skats.Columns["problemu_sk"].ReadOnly = true;
			testetaji_skats.Columns["testetaja_id"].HeaderText = "Testētāja ID [#]";
			testetaji_skats.Columns["vards"].HeaderText = "Vārds";
			testetaji_skats.Columns["uzvards"].HeaderText = "Uzvārds";
			testetaji_skats.Columns["parole"].HeaderText = "Parole";
			testetaji_skats.Columns["problemu_sk"].HeaderText = "Problēmu ziņojumu sk. [#]";
		}
		
		void sagatavot_darbinieku_skatu() {
			darbinieki_skats.Columns["darbinieka_id"].ReadOnly = true;
			darbinieki_skats.Columns["darbinieka_id"].HeaderText = "Darbinieka ID [#]";
			darbinieki_skats.Columns["vards"].HeaderText = "Vārds";
			darbinieki_skats.Columns["uzvards"].HeaderText = "Uzvārds";
			darbinieki_skats.Columns["parole"].HeaderText = "Parole";
		}
		
		void jauns_zars(DataRow[] ieraksti, TreeNodeCollection zari) {
			foreach (DataRow dr in ieraksti) {
				TreeNode jauns_zars = new TreeNode();
				
				jauns_zars.Text = dr["nosaukums"].ToString();
				jauns_zars.Name = dr["sadalas_id"].ToString();
				jauns_zars.Tag = dr["url"].ToString();
				zari.Add(jauns_zars);
				strukturet_koku(Convert.ToInt32(jauns_zars.Name), jauns_zars);
			}
		}
		
		void strukturet_koku(int id, TreeNode vecaka_zars) {
			ieraksti = sadalasDT.Select("galv_sadalas_id = " + id);
			
			if (id == 0) {
				jauns_zars(ieraksti, sadalas_koks.Nodes);
			} else {
				jauns_zars(ieraksti, vecaka_zars.Nodes);
			}
		}
		
		void DarbiniekiemFormClosed(object sender, FormClosedEventArgs e)
		{
			db = new DataSet();
			
			MainForm.id = MainForm.vards = MainForm.uzvards = MainForm.statusam = MainForm.md5 = MainForm.parole = "";
			sakuma_forma.Visible = true;
		}
		
		void IzietToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void MainītParoliToolStripMenuItemClick(object sender, EventArgs e)
		{
			paroles_maina p_m = new paroles_maina("darbinieks");
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
			no_admin_konta.Checked = true;
			pec_sadalas_poga.Text = "Pē&c sadaļas..";
			laidieni_cb.SelectedIndex = 0;
			stavokli_cb.SelectedIndex = 0;
			
			try {
				problemasDT.DefaultView.RowFilter = string.Format("problemas_id LIKE '%{0}%' OR iss_apraksts LIKE '%{0}%' OR apraksts LIKE '%{0}%' OR piezimes LIKE '%{0}%'", probl_filtrs_iev.Text);
			} catch (Exception) {
			}
		}
		
		void No_admin_kontaCheckedChanged(object sender, EventArgs e)
		{
			pec_sadalas_poga.Text = "Pē&c sadaļas..";
			problemasDT.DefaultView.RowFilter = "no_admin_konta = " + no_admin_konta.Checked;
			laidieni_cb.SelectedIndex = 0;
			stavokli_cb.SelectedIndex = 0;
		}
		
		void Pec_sadalas_pogaClick(object sender, EventArgs e)
		{
			laidieni_cb.SelectedIndex  = 0;
			stavokli_cb.SelectedIndex  = 0;
			
			sadalas f = new sadalas(no_admin_konta.Checked, sad_kop_DT);
			
			if (f.ShowDialog() == DialogResult.OK) {
				problemasDT.DefaultView.RowFilter = "sadalas_id = " + f.sad_id + " AND no_admin_konta = " + no_admin_konta.Checked;
				pec_sadalas_poga.Text = f.sad_nosauk;
			}
		}
		
		void Laidieni_cbSelectedIndexChanged(object sender, EventArgs e)
		{
			no_admin_konta.Checked = true;
			pec_sadalas_poga.Text = "Pē&c sadaļas..";
			stavokli_cb.SelectedIndex  = 0;
			
			problemasDT.DefaultView.RowFilter = "laidiena_id = " + laidieni_cb.SelectedValue;
		}
		
		void Stavokli_cbSelectedIndexChanged(object sender, EventArgs e)
		{
			no_admin_konta.Checked = true;
			pec_sadalas_poga.Text = "Pē&c sadaļas..";
			laidieni_cb.SelectedIndex = 0;
			
			problemasDT.DefaultView.RowFilter = "stavokla_id = " + stavokli_cb.SelectedValue;
		}
		
		void Atiestatit_pogaClick(object sender, EventArgs e)
		{
			probl_filtrs_iev.Text = "";
			no_admin_konta.Checked = true;
			pec_sadalas_poga.Text = "Pē&c sadaļas..";
			laidieni_cb.SelectedIndex = 0;
			stavokli_cb.SelectedIndex = 0;
			
			problemasDT.DefaultView.RowFilter = "";
		}
		
		void Problemas_skatsCellClick(object sender, DataGridViewCellEventArgs e)
		{
			atsauksmes_txt.Text = problemas_skats["problemas_id", e.RowIndex].Value.ToString() + " problēmas ziņojuma atsauksmes:";
		}
		
		void Atsauksmes_skatsUserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			atsauksmes_skats.Rows[e.Row.Index - 1].Cells["datums"].Value = DateTime.Now.ToShortDateString();
		}
		
		void Problemas_skatsDataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			
		}
		
		void Sagl_atsauk_pogaClick(object sender, EventArgs e)
		{
			NpgsqlCommand atj_kom = new NpgsqlCommand("UPDATE problemu_zinojumi SET no_admin_konta = @no_admin_konta, sadalas_id = @sadalas_id, iss_apraksts = @iss_apraksts, apraksts = @apraksts, laidiena_id = @laidiena_id, stavokla_id = @stavokla_id, piezimes = @piezimes WHERE problemas_id = @id;", MainForm.sav);
			atj_kom.Parameters.Add("@no_admin_konta", NpgsqlTypes.NpgsqlDbType.Boolean, 5, "no_admin_konta");
			atj_kom.Parameters.Add("@sadalas_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "sadalas_id");
			atj_kom.Parameters.Add("@iss_apraksts", NpgsqlTypes.NpgsqlDbType.Varchar, 50, "iss_apraksts");
			atj_kom.Parameters.Add("@apraksts", NpgsqlTypes.NpgsqlDbType.Varchar, 500, "apraksts");
			atj_kom.Parameters.Add("@laidiena_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "laidiena_id");
			atj_kom.Parameters.Add("@stavokla_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "stavokla_id");
			atj_kom.Parameters.Add("@piezimes", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "piezimes");
			atj_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 7, "problemas_id");
			NpgsqlCommand dz_kom = new NpgsqlCommand("DELETE FROM problemu_zinojumi WHERE problemas_id = @id;", MainForm.sav);
			dz_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 7, "problemas_id");
			
			NpgsqlCommand iev_kom2 = new NpgsqlCommand("INSERT INTO atsauksmes VALUES(@id, @darbinieka_id, @problemas_id, @komentars, @datums, @lemuma_id, @izpilditaja_id);", MainForm.sav);
			iev_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "atsauksmes_id");
			iev_kom2.Parameters.Add("@darbinieka_id", NpgsqlTypes.NpgsqlDbType.Varchar, 4, "darbinieka_id");
			iev_kom2.Parameters.Add("@problemas_id", NpgsqlTypes.NpgsqlDbType.Varchar, 7, "problemas_id");
			iev_kom2.Parameters.Add("@komentars", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "komentars");
			iev_kom2.Parameters.Add("@datums", NpgsqlTypes.NpgsqlDbType.Date, 255, "datums");
			iev_kom2.Parameters.Add("@lemuma_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "lemuma_id");
			iev_kom2.Parameters.Add("@izpilditaja_id", NpgsqlTypes.NpgsqlDbType.Varchar, 4, "izpilditaja_id");
			NpgsqlCommand atj_kom2 = new NpgsqlCommand("UPDATE atsauksmes SET darbinieka_id = @darbinieka_id, komentars = @komentars, datums = @datums, lemuma_id = @lemuma_id, izpilditaja_id = @izpilditaja_id WHERE atsauksmes_id = @id;", MainForm.sav);
			atj_kom2.Parameters.Add("@darbinieka_id", NpgsqlTypes.NpgsqlDbType.Varchar, 4, "darbinieka_id");
			atj_kom2.Parameters.Add("@komentars", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "komentars");
			atj_kom2.Parameters.Add("@datums", NpgsqlTypes.NpgsqlDbType.Date, 255, "datums");
			atj_kom2.Parameters.Add("@lemuma_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "lemuma_id");
			atj_kom2.Parameters.Add("@izpilditaja_id", NpgsqlTypes.NpgsqlDbType.Varchar, 4, "izpilditaja_id");
			atj_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "atsauksmes_id");
			NpgsqlCommand dz_kom2 = new NpgsqlCommand("DELETE FROM atsauksmes WHERE atsauksmes_id = @id;", MainForm.sav);
			dz_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "atsauksmes_id");
			
			problemasA.UpdateCommand = atj_kom;
			problemasA.DeleteCommand = dz_kom;
			atsauksmesA.InsertCommand = iev_kom2;
			atsauksmesA.UpdateCommand = atj_kom2;
			atsauksmesA.DeleteCommand = dz_kom2;
			
			problemasA.Update(problemasDT);
			atsauksmesA.Update(atsauksmesDT);
			
			problemasDT.AcceptChanges();
			atsauksmesDT.AcceptChanges();
			
			MessageBox.Show("Veiktās izmaiņas veiksmīgi saglabātas.", "Izmaiņas saglabātas", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void Atc_atsauk_pogaClick(object sender, EventArgs e)
		{
			db.RejectChanges();
		}
		
		void Test_filtrs_ievTextChanged(object sender, EventArgs e)
		{
			try {
				if (test_filtrs_iev.Text != "") {
					testetaji_skats.DataSource = testetajiDT;
					testetajiDT.DefaultView.RowFilter = string.Format("testetaja_id LIKE '%{0}%' OR vards LIKE '%{0}%' OR uzvards LIKE '%{0}%'", test_filtrs_iev.Text);
				} else {
					testetaji_skats.DataSource = stud_progDT;
					testetaji_skats.DataMember = "stud_progr-test";
				}
				
				sagatavot_testetaju_skatu();
			} catch (Exception) {
			}
		}
		
		void Testetaji_skatsCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			lietotaju_dati f = new lietotaju_dati(testetaji_skats["vards", e.RowIndex].Value.ToString(), testetaji_skats["uzvards", e.RowIndex].Value.ToString(), true, testetaji_skats["programmas_kods", e.RowIndex].Value.ToString(), testetaji_skats["testetaja_id", e.RowIndex].Value.ToString());
			
			if (f.ShowDialog() == DialogResult.OK) {
				testetaji_skats["testetaja_id", e.RowIndex].Value = f.jaunais_id;
				testetaji_skats["vards", e.RowIndex].Value = f.varda_vert;
				testetaji_skats["uzvards", e.RowIndex].Value = f.uzvarda_vert;
				testetaji_skats["parole", e.RowIndex].Value = f.md5;
				testetaji_skats["programmas_kods", e.RowIndex].Value = f.stavokla_vert;
			}
		}
		
		void Test_atiest_pogaClick(object sender, EventArgs e)
		{
			test_filtrs_iev.Text = "";
			sagatavot_testetaju_skatu();
		}
		
		void Jauns_veids_pogaClick(object sender, EventArgs e)
		{
			stud_progr_veidi f = new stud_progr_veidi();
			f.ShowDialog();
		}
		
		void Sagl_test_pogaClick(object sender, EventArgs e)
		{
			NpgsqlCommand iev_kom = new NpgsqlCommand("INSERT INTO stud_programmas VALUES(@id, @nosaukums, @stud_prog_veida_id);", MainForm.sav);
			iev_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 5, "programmas_kods");
			iev_kom.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 50, "nosaukums");
			iev_kom.Parameters.Add("@stud_prog_veida_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "stud_prog_veida_id");
			NpgsqlCommand atj_kom = new NpgsqlCommand("UPDATE stud_programmas SET nosaukums = @nosaukums, stud_prog_veida_id = @stud_prog_veida_id WHERE programmas_kods = @id;", MainForm.sav);
			atj_kom.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 50, "nosaukums");
			atj_kom.Parameters.Add("@stud_prog_veida_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "stud_prog_veida_id");
			atj_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 5, "programmas_kods");
			NpgsqlCommand dz_kom = new NpgsqlCommand("DELETE FROM stud_programmas WHERE programmas_kods = @id;", MainForm.sav);
			dz_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 5, "programmas_kods");
			
			NpgsqlCommand iev_kom2 = new NpgsqlCommand("INSERT INTO testetaji VALUES(@id, @vards, @uzvards, @parole, @programmas_kods)", MainForm.sav);
			iev_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 3, "testetaja_id");
			iev_kom2.Parameters.Add("@vards", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "vards");
			iev_kom2.Parameters.Add("@uzvards", NpgsqlTypes.NpgsqlDbType.Varchar, 30, "uzvards");
			iev_kom2.Parameters.Add("@parole", NpgsqlTypes.NpgsqlDbType.Varchar, 32, "parole");
			iev_kom2.Parameters.Add("@programmas_kods", NpgsqlTypes.NpgsqlDbType.Varchar, 5, "programmas_kods");
			NpgsqlCommand atj_kom2 = new NpgsqlCommand("UPDATE testetaji SET vards = @vards, uzvards = @uzvards, parole = @parole, programmas_kods = @programmas_kods WHERE testetaja_id = @id;", MainForm.sav);
			atj_kom2.Parameters.Add("@vards", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "vards");
			atj_kom2.Parameters.Add("@uzvards", NpgsqlTypes.NpgsqlDbType.Varchar, 30, "uzvards");
			atj_kom2.Parameters.Add("@parole", NpgsqlTypes.NpgsqlDbType.Varchar, 32, "parole");
			atj_kom2.Parameters.Add("@programmas_kods", NpgsqlTypes.NpgsqlDbType.Varchar, 5, "programmas_kods");
			atj_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 3, "testetaja_id");
			NpgsqlCommand dz_kom2 = new NpgsqlCommand("DELETE FROM testetaji WHERE testetaja_id = @id;", MainForm.sav);
			dz_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 3, "testetaja_id");
			
			stud_progrA.InsertCommand = iev_kom;
			stud_progrA.UpdateCommand = atj_kom;
			stud_progrA.DeleteCommand = dz_kom;
			testetajiA.InsertCommand = iev_kom2;
			testetajiA.UpdateCommand = atj_kom2;
			testetajiA.DeleteCommand = dz_kom2;
			
			stud_progrA.Update(stud_progDT);
			testetajiA.Update(testetajiDT);
			
			stud_progDT.AcceptChanges();
			testetajiDT.AcceptChanges();
			
			MessageBox.Show("Veiktās izmaiņas veiksmīgi saglabātas.", "Izmaiņas saglabātas", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void Atc_test_pogaClick(object sender, EventArgs e)
		{
			db.RejectChanges();
		}
		
		void Darb_filtrs_ievTextChanged(object sender, EventArgs e)
		{
			try {
				if (darb_filtrs_iev.Text != "") {
					darbinieki_skats.DataSource = darbiniekiDT;
					darbiniekiDT.DefaultView.RowFilter = string.Format("darbinieka_id LIKE '%{0}%' OR vards LIKE '%{0}%' OR uzvards LIKE '%{0}%'", darb_filtrs_iev.Text);
				} else {
					darbinieki_skats.DataSource = amatiDT;
					darbinieki_skats.DataMember = "amati-darbinieki";
				}
				
				sagatavot_darbinieku_skatu();
			} catch (Exception) {
			}
		}
		
		void Darbinieki_skatsCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			lietotaju_dati f = new lietotaju_dati(darbinieki_skats["vards", e.RowIndex].Value.ToString(), darbinieki_skats["uzvards", e.RowIndex].Value.ToString(), false, darbinieki_skats["amata_id", e.RowIndex].Value.ToString(), darbinieki_skats["darbinieka_id", e.RowIndex].Value.ToString());
			
			if (f.ShowDialog() == DialogResult.OK) {
				darbinieki_skats["darbinieka_id", e.RowIndex].Value = f.jaunais_id;
				darbinieki_skats["vards", e.RowIndex].Value = f.varda_vert;
				darbinieki_skats["uzvards", e.RowIndex].Value = f.uzvarda_vert;
				darbinieki_skats["parole", e.RowIndex].Value = f.md5;
				darbinieki_skats["amata_id", e.RowIndex].Value = f.stavokla_vert;
			}
		}
		
		void Darb_atiest_pogaClick(object sender, EventArgs e)
		{
			darb_filtrs_iev.Text = "";
			sagatavot_darbinieku_skatu();
		}
		
		void Sagl_darb_pogaClick(object sender, EventArgs e)
		{
			NpgsqlCommand iev_kom = new NpgsqlCommand("INSERT INTO amati VALUES(@id, @nosaukums);", MainForm.sav);
			iev_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "amata_id");
			iev_kom.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 50, "nosaukums");
			NpgsqlCommand atj_kom = new NpgsqlCommand("UPDATE amati SET nosaukums = @nosaukums WHERE amata_id = @id;", MainForm.sav);
			atj_kom.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 50, "nosaukums");
			atj_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "amata_id");
			NpgsqlCommand dz_kom = new NpgsqlCommand("DELETE FROM amati WHERE amata_id = @id;", MainForm.sav);
			dz_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "amata_id");
			
			NpgsqlCommand iev_kom2 = new NpgsqlCommand("INSERT INTO darbinieki VALUES(@id, @vards, @uzvards, @parole, @amata_id);", MainForm.sav);
			iev_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 4, "darbinieka_id");
			iev_kom2.Parameters.Add("@vards", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "vards");
			iev_kom2.Parameters.Add("@uzvards", NpgsqlTypes.NpgsqlDbType.Varchar, 30, "uzvards");
			iev_kom2.Parameters.Add("@parole", NpgsqlTypes.NpgsqlDbType.Varchar, 32, "parole");
			iev_kom2.Parameters.Add("@amata_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "amata_id");
			NpgsqlCommand atj_kom2 = new NpgsqlCommand("UPDATE darbinieki SET vards = @vards, uzvards = @uzvards, parole = @parole, amata_id = @amata_id WHERE darbinieka_id= @id;", MainForm.sav);
			atj_kom2.Parameters.Add("@vards", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "vards");
			atj_kom2.Parameters.Add("@uzvards", NpgsqlTypes.NpgsqlDbType.Varchar, 30, "uzvards");
			atj_kom2.Parameters.Add("@parole", NpgsqlTypes.NpgsqlDbType.Varchar, 32, "parole");
			atj_kom2.Parameters.Add("@amata_id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "amata_id");
			atj_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 4, "darbinieka_id");
			NpgsqlCommand dz_kom2 = new NpgsqlCommand("DELETE FROM darbinieki WHERE darbinieka_id = @id;", MainForm.sav);
			dz_kom2.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 4, "darbinieka_id");
			
			amatiA.InsertCommand = iev_kom;
			amatiA.UpdateCommand = atj_kom;
			amatiA.DeleteCommand = dz_kom;
			darbiniekiA.InsertCommand = iev_kom2;
			darbiniekiA.UpdateCommand = atj_kom2;
			darbiniekiA.DeleteCommand = dz_kom2;
			
			amatiA.Update(amatiDT);
			darbiniekiA.Update(darbiniekiDT);
			
			amatiDT.AcceptChanges();
			darbiniekiDT.AcceptChanges();
			
			MessageBox.Show("Veiktās izmaiņas veiksmīgi saglabātas.", "Izmaiņas saglabātas", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void Atc_darb_pogaClick(object sender, EventArgs e)
		{
			db.RejectChanges();
		}
		
		void Sadalas_koksAfterSelect(object sender, TreeViewEventArgs e)
		{
			sadalasDT.DefaultView.RowFilter = "galv_sadalas_id = " + e.Node.Name;
			zara_id = Convert.ToInt32(e.Node.Name);
		}
		
		void Sadalas_skatsUserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			sadalas_skats.Rows[e.Row.Index - 1].Cells["url"].Value = "http://85.254.247.230:8080/";
			sadalas_skats.Rows[e.Row.Index - 1].Cells["tikai_admin"].Value = false;
			sadalas_skats.Rows[e.Row.Index - 1].Cells["galv_sadalas_id"].Value = zara_id;
		}
		
		void Sagl_slodze_pogaClick(object sender, EventArgs e)
		{
			NpgsqlCommand iev_kom = new NpgsqlCommand("INSERT INTO laidieni VALUES(@id, @nosaukums, @apraksts, @datums);", MainForm.sav);
			iev_kom.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "laidiena_id");
			iev_kom.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "nosaukums");
			iev_kom.Parameters.Add("@apraksts", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "apraksts");
			iev_kom.Parameters.Add("@datums", NpgsqlTypes.NpgsqlDbType.Date, 255, "publ_datums");
			NpgsqlCommand atj_kom = new NpgsqlCommand("UPDATE laidieni SET nosaukums = @nosaukums, apraksts = @apraksts, publ_datums = @datums WHERE laidiena_id = @id;", MainForm.sav);
			atj_kom.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "nosaukums");
			atj_kom.Parameters.Add("@apraksts", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "apraksts");
			atj_kom.Parameters.Add("@datums", NpgsqlTypes.NpgsqlDbType.Date, 255, "publ_datums");
			atj_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "laidiena_id");
			NpgsqlCommand dz_kom = new NpgsqlCommand("DELETE FROM laidieni WHERE laidiena_id = @id;", MainForm.sav);
			dz_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "laidiena_id");
			
			NpgsqlCommand iev_kom2 = new NpgsqlCommand("INSERT INTO sadalas VALUES(@id, @nosaukums, @url, @tikai_admin, @galv_sadalas_id);", MainForm.sav);
			iev_kom2.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "sadalas_id");
			iev_kom2.Parameters.Add("@nosaukums",  NpgsqlTypes.NpgsqlDbType.Varchar, 50, "nosaukums");
			iev_kom2.Parameters.Add("@url",  NpgsqlTypes.NpgsqlDbType.Varchar, 255, "url");
			iev_kom2.Parameters.Add("@tikai_admin",  NpgsqlTypes.NpgsqlDbType.Boolean, 5, "tikai_admin");
			iev_kom2.Parameters.Add("@galv_sadalas_id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "galv_sadalas_id");
			NpgsqlCommand atj_kom2 = new NpgsqlCommand("UPDATE sadalas SET nosaukums = @nosaukums, url = @url, tikai_admin = @tikai_admin, galv_sadalas_id = @galv_sadalas_id WHERE sadalas_id = @id;", MainForm.sav);
			atj_kom2.Parameters.Add("@nosaukums",  NpgsqlTypes.NpgsqlDbType.Varchar, 50, "nosaukums");
			atj_kom2.Parameters.Add("@url",  NpgsqlTypes.NpgsqlDbType.Varchar, 255, "url");
			atj_kom2.Parameters.Add("@tikai_admin",  NpgsqlTypes.NpgsqlDbType.Boolean, 5, "tikai_admin");
			atj_kom2.Parameters.Add("@galv_sadalas_id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "galv_sadalas_id");
			atj_kom2.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "sadalas_id");
			NpgsqlCommand dz_kom2 = new NpgsqlCommand("DELETE FROM sadalas WHERE sadalas_id = @id;", MainForm.sav);
			dz_kom2.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "sadalas_id");
			
			laidieniA.InsertCommand = iev_kom;
			laidieniA.UpdateCommand = atj_kom;
			laidieniA.DeleteCommand = dz_kom;
			sadalasA.InsertCommand = iev_kom2;
			sadalasA.UpdateCommand = atj_kom2;
			sadalasA.DeleteCommand = dz_kom2;
			
			laidieniA.Update(laidieniDT);
			sadalasA.Update(sadalasDT);
			
			laidieniDT.AcceptChanges();
			sad_kop_DT.AcceptChanges();
			
			MessageBox.Show("Veiktās izmaiņas veiksmīgi saglabātas.", "Izmaiņas saglabātas", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			sadalas_koks.Nodes.Clear();
			strukturet_koku(0, null);
			sadalas_koks.SelectedNode = sadalas_koks.Nodes[0];
		}
		
		void Atc_slodze_pogaClick(object sender, EventArgs e)
		{
			db.RejectChanges();
		}
		
		void Sagl_lemumi_pogaClick(object sender, EventArgs e)
		{
			NpgsqlCommand iev_kom = new NpgsqlCommand("INSERT INTO lemumi VALUES(@id, @nosaukums, @apraksts);", MainForm.sav);
			iev_kom.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "lemuma_id");
			iev_kom.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "nosaukums");
			iev_kom.Parameters.Add("@apraksts", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "apraksts");
			NpgsqlCommand atj_kom = new NpgsqlCommand("UPDATE lemumi SET nosaukums = @nosaukums, apraksts = @apraksts WHERE lemuma_id = @id;", MainForm.sav);
			atj_kom.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "nosaukums");
			atj_kom.Parameters.Add("@apraksts", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "apraksts");
			atj_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "lemuma_id");
			NpgsqlCommand dz_kom = new NpgsqlCommand("DELETE FROM lemumi WHERE lemuma_id = @id;", MainForm.sav);
			dz_kom.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "lemuma_id");
			
			NpgsqlCommand iev_kom2 = new NpgsqlCommand("INSERT INTO stavokli VALUES(@id, @nosaukums, @raksturojums);", MainForm.sav);
			iev_kom2.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "stavokla_id");
			iev_kom2.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "nosaukums");
			iev_kom2.Parameters.Add("@raksturojums", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "raksturojums");
			NpgsqlCommand atj_kom2 = new NpgsqlCommand("UPDATE stavokli SET nosaukums = @nosaukums, raksturojums = @raksturojums WHERE stavokla_id = @id;", MainForm.sav);
			atj_kom2.Parameters.Add("@nosaukums", NpgsqlTypes.NpgsqlDbType.Varchar, 20, "nosaukums");
			atj_kom2.Parameters.Add("@raksturojums", NpgsqlTypes.NpgsqlDbType.Varchar, 255, "raksturojums");
			atj_kom2.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "stavokla_id");
			NpgsqlCommand dz_kom2 = new NpgsqlCommand("DELETE FROM stavokli WHERE stavokla_id = @id;", MainForm.sav);
			dz_kom2.Parameters.Add("@id",  NpgsqlTypes.NpgsqlDbType.Integer, 4, "stavokla_id");
			
			lemumiA.InsertCommand = iev_kom;
			lemumiA.UpdateCommand = atj_kom;
			lemumiA.DeleteCommand = dz_kom;
			stavokliA.InsertCommand = iev_kom2;
			stavokliA.UpdateCommand = atj_kom2;
			stavokliA.DeleteCommand = dz_kom2;
			
			lemumiA.Update(lemumiDT);
			stavokliA.Update(stavokliDT);
			
			lemumiDT.AcceptChanges();
			stavokliDT.AcceptChanges();
			
			MessageBox.Show("Veiktās izmaiņas veiksmīgi saglabātas.", "Izmaiņas saglabātas", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void Atc_lemumi_pogaClick(object sender, EventArgs e)
		{
			db.RejectChanges();
		}
		
		void Problemas_skatsCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (problemas_skats.Columns[e.ColumnIndex].Name == "iss_apraksts" || problemas_skats.Columns[e.ColumnIndex].Name == "apraksts") {
				if (String.IsNullOrEmpty(e.FormattedValue.ToString()) && problemas_skats[e.ColumnIndex, e.RowIndex].IsInEditMode) {
					problemas_skats.Rows[e.RowIndex].ErrorText = "Problēmas ziņojuma nosaukuma un apraksta laukiem jābūt obligāti aizpildītiem!";
					e.Cancel = true;
				}
			}
		}
		
		void Problemas_skatsCellLeave(object sender, DataGridViewCellEventArgs e)
		{
			problemas_skats.Rows[e.RowIndex].ErrorText = "";
		}
	}
}