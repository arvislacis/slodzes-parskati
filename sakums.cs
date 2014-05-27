using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using Npgsql;

namespace slodzes_parskati
{	
	public partial class MainForm : Form
	{
		public static NpgsqlConnection sav = new NpgsqlConnection("server=localhost;port=5432;database=slodze;uid=arvis;pwd=lacis;");
		public static string id = "", vards = "", uzvards = "", statusam = "", md5 = "", parole = "";
		
		NpgsqlCommand aut_kom;
		
		void autentificeties() {
			sav.Open();
			NpgsqlDataReader lasitajs = aut_kom.ExecuteReader();
			
			while (lasitajs.Read()) {
				id = lasitajs[0].ToString();
				vards = lasitajs[1].ToString();
				uzvards = lasitajs[2].ToString();
				statusam = lasitajs[3].ToString();
				md5 = lasitajs[4].ToString();
			}
			
			sav.Close();
			
			if (id != "" && vards != "" && uzvards != "" && statusam != "" && md5 != "") {
				parole = parole_iev.Text;
				id_iev.Text = parole_iev.Text = "";
				
				if (id.Length == 3) {
					this.Visible = false;
					
					testetajiem f = new testetajiem(this);
					f.Show();
				} else if (id.Length == 4) {
					this.Visible = false;
					
					darbiniekiem f = new darbiniekiem(this);
					f.Show();
				}
			} else {
				MessageBox.Show("Autentificēšanās sistēmā neizdevās!\nPārbaudiet vai esat ievadījis pareizu identifikatoru un/vai paroli.", "Autentifikācija neizdevās", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		public static void paz_mainit_paroli(string lietotajs) {
			if (id == parole) {
				if (MessageBox.Show("Jūsu pašreizējais lietotāja identifikators sakrīt ar izmantoto paroli.\nSistēmas izmantošana šādā stāvoklī var radīt drošības problēmas.\nVai vēlaties mainīt paroli?", "Vai vēlaties mainīt paroli?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					paroles_maina p_m  = new paroles_maina(lietotajs);
					
					p_m.ShowDialog();
				}
			}
		}
		
		public static void majas_lapa() {
			Process.Start("http://85.254.247.230:8080/ielogoties.aspx");
		}
		
		public static void sutit_atsauksmi() {
			Process.Start("mailto:arvis.lacis@inbox.lv?subject=" + Application.ProductName.ToString() + " " + Application.ProductVersion.ToString());
		}
		
		public static void par() {
			MessageBox.Show(Application.ProductName.ToString() + " " + Application.ProductVersion.ToString() + "\nLietojumprogramma SLODZES sistēmas testēšanas problēmu ziņojumu veidošanai un administrēšanai.\n\nLatvijas Lauksaimniecības universitāte\nInformācijas tehnoloģiju fakultāte\n2. kurss Programmēšana\n\n© 2014 Arvis Lācis", "Par SLODZES testēšanu", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		public MainForm()
		{
			InitializeComponent();
			
			nosaukums.Text = Application.ProductName.ToString();
		}
		
		void Ieiet_pogaClick(object sender, EventArgs e)
		{	
			if (id_iev.TextLength == 3 && parole_iev.TextLength != 0) {
				aut_kom = new NpgsqlCommand("SELECT t.testetaja_id, t.vards, t.uzvards, sp.nosaukums, t.parole FROM testetaji t, stud_programmas sp WHERE  t.testetaja_id = '" + id_iev.Text + "' AND t.parole = md5(t.vards || t.testetaja_id || '" + parole_iev.Text + "' || t.uzvards) AND t.programmas_kods = sp.programmas_kods;", sav);
				
				autentificeties();
			} else if (id_iev.TextLength == 4 && parole_iev.TextLength != 0) {
				aut_kom = new NpgsqlCommand("SELECT d.darbinieka_id, d.vards, d.uzvards, a.nosaukums, d.parole FROM darbinieki d, amati a WHERE  d.darbinieka_id = '" + id_iev.Text + "' AND d.parole = md5(d.vards || d.darbinieka_id || '" + parole_iev.Text + "' || d.uzvards) AND d.amata_id = a.amata_id;", sav);
				
				autentificeties();
			} else {
				MessageBox.Show("Identifikatoram jāsatāv no 3-4 simboliem un paroles laukam jābūt aizpildītam.", "Nederīgi autentifikācija dati", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		
		void Parole_ievKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				Ieiet_pogaClick(sender, e);
			}
		}
		
		void Aizvert_pogaClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}