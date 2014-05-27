namespace slodzes_parskati
{
	partial class sadalas
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.sadalas_koks = new System.Windows.Forms.TreeView();
			this.statusa_josla = new System.Windows.Forms.StatusStrip();
			this.url_txt = new System.Windows.Forms.ToolStripStatusLabel();
			this.sadalas_izv_poga = new System.Windows.Forms.Button();
			this.statusa_josla.SuspendLayout();
			this.SuspendLayout();
			// 
			// sadalas_koks
			// 
			this.sadalas_koks.BackColor = System.Drawing.SystemColors.Control;
			this.sadalas_koks.Dock = System.Windows.Forms.DockStyle.Top;
			this.sadalas_koks.Location = new System.Drawing.Point(0, 0);
			this.sadalas_koks.Name = "sadalas_koks";
			this.sadalas_koks.Size = new System.Drawing.Size(494, 220);
			this.sadalas_koks.TabIndex = 0;
			this.sadalas_koks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Sadalas_koksAfterSelect);
			this.sadalas_koks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Sadalas_koksMouseDoubleClick);
			// 
			// statusa_josla
			// 
			this.statusa_josla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.url_txt});
			this.statusa_josla.Location = new System.Drawing.Point(0, 249);
			this.statusa_josla.Name = "statusa_josla";
			this.statusa_josla.Size = new System.Drawing.Size(494, 22);
			this.statusa_josla.TabIndex = 2;
			this.statusa_josla.Text = "statusa_josla";
			// 
			// url_txt
			// 
			this.url_txt.IsLink = true;
			this.url_txt.Name = "url_txt";
			this.url_txt.Size = new System.Drawing.Size(43, 17);
			this.url_txt.Text = "Adrese";
			this.url_txt.Click += new System.EventHandler(this.Url_txtClick);
			// 
			// sadalas_izv_poga
			// 
			this.sadalas_izv_poga.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sadalas_izv_poga.Location = new System.Drawing.Point(0, 226);
			this.sadalas_izv_poga.Name = "sadalas_izv_poga";
			this.sadalas_izv_poga.Size = new System.Drawing.Size(494, 23);
			this.sadalas_izv_poga.TabIndex = 1;
			this.sadalas_izv_poga.Text = "&Izvēlēties sadaļu";
			this.sadalas_izv_poga.UseVisualStyleBackColor = true;
			this.sadalas_izv_poga.Click += new System.EventHandler(this.Sadalas_izv_pogaClick);
			// 
			// sadalas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 271);
			this.Controls.Add(this.sadalas_izv_poga);
			this.Controls.Add(this.statusa_josla);
			this.Controls.Add(this.sadalas_koks);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "sadalas";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SLODZES sadaļas izvēle";
			this.statusa_josla.ResumeLayout(false);
			this.statusa_josla.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button sadalas_izv_poga;
		private System.Windows.Forms.ToolStripStatusLabel url_txt;
		private System.Windows.Forms.StatusStrip statusa_josla;
		private System.Windows.Forms.TreeView sadalas_koks;
	}
}