using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace slodzes_parskati
{
	public partial class lietotaju_dati : Form
	{
		public string jaunais_id, varda_vert, uzvarda_vert, md5, stavokla_vert;
		string vards, uzvards, ar_atslega, id_vert;
		bool testetajs;
		
		string iegut_test_id(string v, string u) {
			for (int i = 0; i < v.Length; i++) {
				for (int j = 1; j < u.Length; j++) {
					string virkne = (v.Substring(i, 1) + u.Substring(0, 1) + u.Substring(j, 1)).ToUpper();
					virkne = virkne.Replace("Ā", "A");
					virkne = virkne.Replace("Č", "C");
					virkne = virkne.Replace("Ē", "E");
					virkne = virkne.Replace("Ģ", "G");
					virkne = virkne.Replace("Ī", "I");
					virkne = virkne.Replace("Ķ", "K");
					virkne = virkne.Replace("Ļ", "L");
					virkne = virkne.Replace("Ņ", "N");
					virkne = virkne.Replace("Š", "S");
					virkne = virkne.Replace("Ū", "U");
					virkne = virkne.Replace("Ž", "Z");
					
					if (!darbiniekiem.db.Tables[10].Rows.Contains(virkne)) {
						return virkne;
					}
				}
			}
			
			return "";
		}
		
		string iegut_darb_id(string v, string u) {
			for (int i = 1; i < v.Length; i++) {
				for (int j = 1; j < u.Length; j++) {
					string virkne = (v.Substring(0, 1) +v.Substring(i, 1) + u.Substring(0, 1) + u.Substring(j, 1)).ToUpper();
					virkne = virkne.Replace("Ā", "A");
					virkne = virkne.Replace("Č", "C");
					virkne = virkne.Replace("Ē", "E");
					virkne = virkne.Replace("Ģ", "G");
					virkne = virkne.Replace("Ī", "I");
					virkne = virkne.Replace("Ķ", "K");
					virkne = virkne.Replace("Ļ", "L");
					virkne = virkne.Replace("Ņ", "N");
					virkne = virkne.Replace("Š", "S");
					virkne = virkne.Replace("Ū", "U");
					virkne = virkne.Replace("Ž", "Z");
					
					if (!darbiniekiem.db.Tables[2].Rows.Contains(virkne)) {
						return virkne;
					}
				}
			}
			
			return "";
		}
		
		public lietotaju_dati(string v, string u, bool t, string ar_ats, string id)
		{
			InitializeComponent();
			
			vards = v;
			uzvards = u;
			testetajs = t;
			ar_atslega = ar_ats;
			id_vert = id;
			
			if (v == "" && u == "") {
				if (t) {
					this.Text = "Pievienot testētāju";
				} else {
					this.Text = "Pievienot darbinieku";
				}
				
				pievienot_poga.Text = "&Pievienot";
			} else {
				if (t) {
					this.Text = "Labot testētāja datus";
				} else {
					this.Text = "Labot darbinieka datus";
				}
				
				pievienot_poga.Text = "&Labot";
				
				vards_iev.Text = v;
				uzvards_iev.Text = u;
			}
			
			if (t) {
				stavoklis_cb.DataSource = darbiniekiem.db.Tables[9];
				stavoklis_cb.DisplayMember = "nosaukums";
				stavoklis_cb.ValueMember = "programmas_kods";
				stavoklis_cb.SelectedValue = ar_ats;
			} else {
				stavoklis_cb.DataSource = darbiniekiem.db.Tables[0];
				stavoklis_cb.DisplayMember = "nosaukums";
				stavoklis_cb.ValueMember = "amata_id";
				stavoklis_cb.SelectedValue = Convert.ToInt32(ar_ats);
			}
		}
		
		void Vards_ievValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (vards_iev.Text == "") {
				kludas.SetError(vards_iev, "Vārda ievades laukam jābūt obligāti aizpildītam!");
			} else {
				kludas.SetError(vards_iev, "");
			}
		}
		
		void Uzvards_ievValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (uzvards_iev.Text == "") {
				kludas.SetError(uzvards_iev, "Uzvārda ievades laukam jābūt obligāti aizpildītam!");
			} else {
				kludas.SetError(uzvards_iev, "");
			}
		}
		
		void Pievienot_pogaClick(object sender, EventArgs e)
		{
			string id;
			NpgsqlCommand paroles_kom = new NpgsqlCommand();
			
			if (vards_iev.Text != "" && uzvards_iev.Text != "") {
				if (vards != "" && uzvards != "") {
					id = id_vert;
				} else {
					if (testetajs) {
						id = iegut_test_id(vards_iev.Text, uzvards_iev.Text);
					} else {
						id = iegut_darb_id(vards_iev.Text, uzvards_iev.Text);
					}
				}
				
				if (parole_iev.Text != "") {
					paroles_kom = new NpgsqlCommand("SELECT md5('" + vards_iev.Text + id + parole_iev.Text + uzvards_iev.Text + "')", MainForm.sav);
				} else {
					paroles_kom = new NpgsqlCommand("SELECT md5('" + vards_iev.Text + id + id + uzvards_iev.Text + "')", MainForm.sav);
				}
				
				MainForm.sav.Open();
				this.md5 = paroles_kom.ExecuteScalar().ToString();
				MainForm.sav.Close();
				
				this.jaunais_id = id;
				this.varda_vert = vards_iev.Text.Normalize();
				this.uzvarda_vert = uzvards_iev.Text.Normalize();
				this.stavokla_vert = stavoklis_cb.SelectedValue.ToString();
				this.DialogResult = DialogResult.OK;
				this.Close();
			} else {
				MessageBox.Show("Datus nevar salabāt, jo nav novērstas visas kļūdas.\nSkatiet kļūdas paziņojumus blakus ievadlaukiem.", "Datus nevar saglabāt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}