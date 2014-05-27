using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Npgsql;

namespace slodzes_parskati
{
	public partial class atsauksmes : Form
	{
		public atsauksmes(string pz)
		{
			InitializeComponent();
			
			this.Text = "Ziņojuma " + pz + " atsauksmes";
			
			DataTable atsauksmesDT = new DataTable();
			NpgsqlDataAdapter atsauksmesA = new NpgsqlDataAdapter("SELECT d.vards, d.uzvards, a.komentars, a.datums, l.nosaukums FROM darbinieki d, atsauksmes a, lemumi l WHERE d.darbinieka_id = a.darbinieka_id AND l.lemuma_id = a.lemuma_id AND a.problemas_id = '" + pz + "' ORDER BY a.datums DESC;", MainForm.sav);
			atsauksmesA.Fill(atsauksmesDT);
			
			atsauksmju_skats.DataSource = atsauksmesDT;
			
			atsauksmju_skats.Columns["vards"].HeaderText = "Vārds";
			atsauksmju_skats.Columns["uzvards"].HeaderText = "Uzvārds";
			atsauksmju_skats.Columns["komentars"].HeaderText = "Atsauksme";
			atsauksmju_skats.Columns["datums"].HeaderText = "Atsauksmes iesniegšanas datums";
			atsauksmju_skats.Columns["nosaukums"].HeaderText = "Stāvoklis";
		}
	}
}