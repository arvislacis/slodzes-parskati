using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Npgsql;

namespace slodzes_parskati
{
	public partial class stud_progr_veidi : Form
	{
		public stud_progr_veidi()
		{
			InitializeComponent();
			
			progr_veidu_skats.DataSource = darbiniekiem.db.Tables[8];
			progr_veidu_skats.Columns["stud_prog_veida_id"].Visible = false;
			progr_veidu_skats.Columns["veids"].HeaderText = "Studiju programmas veids";
		}
		
		void Sagl_veidus_pogaClick(object sender, EventArgs e)
		{
			NpgsqlDataAdapter Ad = darbiniekiem.stud_prog_veidiA;
			
			NpgsqlCommand iev_kom = new NpgsqlCommand("INSERT INTO stud_progr_veidi VALUES(@id, @veids);", MainForm.sav);
			iev_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "stud_prog_veida_id");
			iev_kom.Parameters.Add("@veids", NpgsqlTypes.NpgsqlDbType.Varchar, 50, "veids");
			NpgsqlCommand atj_kom = new NpgsqlCommand("UPDATE stud_progr_veidi SET veids = @veids WHERE stud_prog_veida_id = @id;", MainForm.sav);
			atj_kom.Parameters.Add("@veids", NpgsqlTypes.NpgsqlDbType.Varchar, 50, "veids");
			atj_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "stud_prog_veida_id");
			NpgsqlCommand dz_kom = new NpgsqlCommand("DELETE FROM stud_progr_veidi WHERE stud_prog_veida_id = @id;", MainForm.sav);
			dz_kom.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer, 4, "stud_prog_veida_id");
			
			Ad.InsertCommand = iev_kom;
			Ad.UpdateCommand = atj_kom;
			Ad.DeleteCommand = dz_kom;
			
			Ad.Update(darbiniekiem.db.Tables[8]);
			darbiniekiem.db.Tables[8].AcceptChanges();
			
			MessageBox.Show("Veiktās izmaiņas veiksmīgi saglabātas.", "Izmaiņas saglabātas", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			this.Close();
		}
		
		void Atc_veidus_pogaClick(object sender, EventArgs e)
		{
			darbiniekiem.db.RejectChanges();
		}
	}
}