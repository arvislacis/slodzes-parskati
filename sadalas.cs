using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using Npgsql;

namespace slodzes_parskati
{
	public partial class sadalas : Form
	{
		public int sad_id;
		public string sad_nosauk;
		
		bool no_admin_konta;
		
		DataTable tabula = new DataTable();
		DataRow[] ieraksti;
		
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
			if (no_admin_konta) {
				ieraksti = tabula.Select("galv_sadalas_id = " + id);
			} else {
				ieraksti = tabula.Select("galv_sadalas_id = " + id + " AND tikai_admin = false");
			}
			
			if (id == 0) {
				jauns_zars(ieraksti, sadalas_koks.Nodes);
			} else {
				jauns_zars(ieraksti, vecaka_zars.Nodes);
			}
		}
		
		public sadalas(bool a, DataTable dt)
		{
			InitializeComponent();
			
			no_admin_konta = a;
			tabula = dt;
			
			strukturet_koku(0, null);
		}
		
		void Sadalas_koksAfterSelect(object sender, TreeViewEventArgs e)
		{
			url_txt.Text = e.Node.Tag.ToString();
		}
		
		void Sadalas_izv_pogaClick(object sender, EventArgs e)
		{
			this.sad_id = Convert.ToInt32(sadalas_koks.SelectedNode.Name);
			this.sad_nosauk = sadalas_koks.SelectedNode.Text;
			
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		void Sadalas_koksMouseDoubleClick(object sender, MouseEventArgs e)
		{
			Sadalas_izv_pogaClick(sender, e);
		}
		
		void Url_txtClick(object sender, EventArgs e)
		{
			Process.Start(url_txt.Text);
		}
	}
}