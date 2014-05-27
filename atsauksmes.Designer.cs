namespace slodzes_parskati
{
	partial class atsauksmes
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
			this.atsauksmju_skats = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.atsauksmju_skats)).BeginInit();
			this.SuspendLayout();
			// 
			// atsauksmju_skats
			// 
			this.atsauksmju_skats.AllowUserToAddRows = false;
			this.atsauksmju_skats.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			this.atsauksmju_skats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.atsauksmju_skats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.atsauksmju_skats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.atsauksmju_skats.BackgroundColor = System.Drawing.SystemColors.Control;
			this.atsauksmju_skats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(138)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.atsauksmju_skats.DefaultCellStyle = dataGridViewCellStyle2;
			this.atsauksmju_skats.Dock = System.Windows.Forms.DockStyle.Fill;
			this.atsauksmju_skats.GridColor = System.Drawing.SystemColors.Control;
			this.atsauksmju_skats.Location = new System.Drawing.Point(0, 0);
			this.atsauksmju_skats.Name = "atsauksmju_skats";
			this.atsauksmju_skats.ReadOnly = true;
			this.atsauksmju_skats.Size = new System.Drawing.Size(484, 211);
			this.atsauksmju_skats.TabIndex = 0;
			// 
			// atsauksmes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 211);
			this.Controls.Add(this.atsauksmju_skats);
			this.MinimumSize = new System.Drawing.Size(500, 250);
			this.Name = "atsauksmes";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Problēmas ziņojuma atsauksmes";
			((System.ComponentModel.ISupportInitialize)(this.atsauksmju_skats)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView atsauksmju_skats;
	}
}