using System;
using System.Drawing;
using System.Windows.Forms;

using Npgsql;

namespace slodzes_parskati
{
	public partial class paroles_maina : Form
	{
		string lietotajs;
		
		NpgsqlCommand mainas_kom;
		
		void pp_kluda() {
			if (pp_ievade.Text != MainForm.parole) {
				kludas.SetError(pp_ievade, "Ievadītā parole nesakrīt ar pašreizējo lietotāja paroli!");
			} else {
				kludas.SetError(pp_ievade, "");
			}
		}
		
		void jp_kluda() {
			if (jp_ievade.Text == MainForm.parole) {
				kludas.SetError(jp_ievade, "Jaunā parole sakrīt ar pašreizējo paroli!");
			} else if (jp_ievade.Text == "") {
				kludas.SetError(jp_ievade, "Jaunās paroles laukam jābūt obligāti aizpildītam!");
			} else {
				kludas.SetError(jp_ievade, "");
			}
		}
		
		void jpv_kluda() {
			if (jpv_ievade.Text != jp_ievade.Text) {
				kludas.SetError(jpv_ievade, "Jaunās un atkārtoti ievadītās paroles vērtības nesakrīt!");
			} else {
				kludas.SetError(jpv_ievade, "");
			}
		}
		
		public paroles_maina(string l)
		{
			InitializeComponent();
			
			lietotajs = l;
		}
		
		void Pp_ievadeValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			pp_kluda();
		}
		
		void Jp_ievadeValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			jp_kluda();
		}
		
		void Jpv_ievadeValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			jpv_kluda();
		}
		
		void Jpv_ievadeKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				Mainit_pogaClick(sender, e);
			}
		}
		
		void Mainit_pogaClick(object sender, EventArgs e)
		{	
			if (pp_ievade.Text == MainForm.parole && jp_ievade.Text != MainForm.parole && jp_ievade.Text != "" && jpv_ievade.Text == jp_ievade.Text) {
				if (lietotajs == "testetajs") {
					mainas_kom = new NpgsqlCommand("UPDATE testetaji SET parole = md5('" + MainForm.vards + MainForm.id + jp_ievade.Text + MainForm.uzvards + "') WHERE testetaji.testetaja_id = '" + MainForm.id + "';", MainForm.sav);
				} else if (lietotajs == "darbinieks") {
					mainas_kom = new NpgsqlCommand("UPDATE darbinieki SET parole = md5('" + MainForm.vards + MainForm.id + jp_ievade.Text + MainForm.uzvards + "') WHERE darbinieki.darbinieka_id = '" + MainForm.id + "';", MainForm.sav);
				}
				
				MainForm.sav.Open();
				int ieraksti = mainas_kom.ExecuteNonQuery();
				MainForm.sav.Close();
				
				if (ieraksti == 1) {
					MessageBox.Show("Lietotāja parole ir veiksmīgi nomainīta.", "Parole nomainīta", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
					this.Close();
				} else {
					MessageBox.Show("Paroles maiņas laikā radās neparedzēta kļūda.\nMēģiniet atkārtot paroles maiņu vēlāk.", "Neparedzēta kļūda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			} else {
				pp_kluda();
				jp_kluda();
				jpv_kluda();
				
				MessageBox.Show("Paroli nevar nomainīt, jo nav novērstas visas kļūdas.\nSkatiet kļūdas paziņojumus blakus ievadlaukiem.", "Paroli nevar nomainīt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		void Atcelt_pogaClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}