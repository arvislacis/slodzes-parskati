namespace slodzes_parskati
{
	partial class stud_progr_veidi
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.progr_veidu_skats = new System.Windows.Forms.DataGridView();
			this.sagl_veidus_poga = new System.Windows.Forms.Button();
			this.atc_veidus_poga = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.progr_veidu_skats)).BeginInit();
			this.SuspendLayout();
			// 
			// progr_veidu_skats
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			this.progr_veidu_skats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.progr_veidu_skats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.progr_veidu_skats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.progr_veidu_skats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.progr_veidu_skats.BackgroundColor = System.Drawing.SystemColors.Control;
			this.progr_veidu_skats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(138)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.progr_veidu_skats.DefaultCellStyle = dataGridViewCellStyle2;
			this.progr_veidu_skats.GridColor = System.Drawing.SystemColors.Control;
			this.progr_veidu_skats.Location = new System.Drawing.Point(12, 12);
			this.progr_veidu_skats.Name = "progr_veidu_skats";
			this.progr_veidu_skats.Size = new System.Drawing.Size(360, 208);
			this.progr_veidu_skats.TabIndex = 0;
			// 
			// sagl_veidus_poga
			// 
			this.sagl_veidus_poga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.sagl_veidus_poga.Location = new System.Drawing.Point(118, 226);
			this.sagl_veidus_poga.Name = "sagl_veidus_poga";
			this.sagl_veidus_poga.Size = new System.Drawing.Size(254, 23);
			this.sagl_veidus_poga.TabIndex = 2;
			this.sagl_veidus_poga.Text = "&Saglabāt izmaiņas";
			this.sagl_veidus_poga.UseVisualStyleBackColor = true;
			this.sagl_veidus_poga.Click += new System.EventHandler(this.Sagl_veidus_pogaClick);
			// 
			// atc_veidus_poga
			// 
			this.atc_veidus_poga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.atc_veidus_poga.Location = new System.Drawing.Point(12, 226);
			this.atc_veidus_poga.Name = "atc_veidus_poga";
			this.atc_veidus_poga.Size = new System.Drawing.Size(100, 23);
			this.atc_veidus_poga.TabIndex = 1;
			this.atc_veidus_poga.Text = "&Atcelt izmaiņas";
			this.atc_veidus_poga.UseVisualStyleBackColor = true;
			this.atc_veidus_poga.Click += new System.EventHandler(this.Atc_veidus_pogaClick);
			// 
			// stud_progr_veidi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.atc_veidus_poga);
			this.Controls.Add(this.sagl_veidus_poga);
			this.Controls.Add(this.progr_veidu_skats);
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "stud_progr_veidi";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Studiju programmu veidu administrēšana";
			((System.ComponentModel.ISupportInitialize)(this.progr_veidu_skats)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button atc_veidus_poga;
		private System.Windows.Forms.Button sagl_veidus_poga;
		private System.Windows.Forms.DataGridView progr_veidu_skats;
	}
}