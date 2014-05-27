namespace slodzes_parskati
{
	partial class lietotaju_dati
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
			this.components = new System.ComponentModel.Container();
			this.pievienot_poga = new System.Windows.Forms.Button();
			this.vards_txt = new System.Windows.Forms.Label();
			this.vards_iev = new System.Windows.Forms.TextBox();
			this.kludas = new System.Windows.Forms.ErrorProvider(this.components);
			this.uzvards_txt = new System.Windows.Forms.Label();
			this.uzvards_iev = new System.Windows.Forms.TextBox();
			this.stavoklis_cb = new System.Windows.Forms.ComboBox();
			this.stavoklis_txt = new System.Windows.Forms.Label();
			this.parole_txt = new System.Windows.Forms.Label();
			this.parole_iev = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.kludas)).BeginInit();
			this.SuspendLayout();
			// 
			// pievienot_poga
			// 
			this.pievienot_poga.Location = new System.Drawing.Point(12, 120);
			this.pievienot_poga.Name = "pievienot_poga";
			this.pievienot_poga.Size = new System.Drawing.Size(281, 23);
			this.pievienot_poga.TabIndex = 8;
			this.pievienot_poga.Text = "&Pievienot";
			this.pievienot_poga.UseVisualStyleBackColor = true;
			this.pievienot_poga.Click += new System.EventHandler(this.Pievienot_pogaClick);
			// 
			// vards_txt
			// 
			this.vards_txt.Location = new System.Drawing.Point(12, 15);
			this.vards_txt.Name = "vards_txt";
			this.vards_txt.Size = new System.Drawing.Size(100, 23);
			this.vards_txt.TabIndex = 0;
			this.vards_txt.Text = "Vārds:";
			// 
			// vards_iev
			// 
			this.vards_iev.Location = new System.Drawing.Point(118, 12);
			this.vards_iev.MaxLength = 20;
			this.vards_iev.Name = "vards_iev";
			this.vards_iev.Size = new System.Drawing.Size(175, 20);
			this.vards_iev.TabIndex = 1;
			this.vards_iev.Validating += new System.ComponentModel.CancelEventHandler(this.Vards_ievValidating);
			// 
			// kludas
			// 
			this.kludas.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.kludas.ContainerControl = this;
			// 
			// uzvards_txt
			// 
			this.uzvards_txt.Location = new System.Drawing.Point(12, 41);
			this.uzvards_txt.Name = "uzvards_txt";
			this.uzvards_txt.Size = new System.Drawing.Size(100, 23);
			this.uzvards_txt.TabIndex = 2;
			this.uzvards_txt.Text = "Uzvārds:";
			// 
			// uzvards_iev
			// 
			this.uzvards_iev.Location = new System.Drawing.Point(118, 38);
			this.uzvards_iev.MaxLength = 30;
			this.uzvards_iev.Name = "uzvards_iev";
			this.uzvards_iev.Size = new System.Drawing.Size(175, 20);
			this.uzvards_iev.TabIndex = 3;
			this.uzvards_iev.Validating += new System.ComponentModel.CancelEventHandler(this.Uzvards_ievValidating);
			// 
			// stavoklis_cb
			// 
			this.stavoklis_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stavoklis_cb.FormattingEnabled = true;
			this.stavoklis_cb.Location = new System.Drawing.Point(118, 65);
			this.stavoklis_cb.Name = "stavoklis_cb";
			this.stavoklis_cb.Size = new System.Drawing.Size(175, 21);
			this.stavoklis_cb.TabIndex = 5;
			// 
			// stavoklis_txt
			// 
			this.stavoklis_txt.Location = new System.Drawing.Point(12, 68);
			this.stavoklis_txt.Name = "stavoklis_txt";
			this.stavoklis_txt.Size = new System.Drawing.Size(100, 23);
			this.stavoklis_txt.TabIndex = 4;
			this.stavoklis_txt.Text = "Stāvoklis:";
			// 
			// parole_txt
			// 
			this.parole_txt.Location = new System.Drawing.Point(12, 97);
			this.parole_txt.Name = "parole_txt";
			this.parole_txt.Size = new System.Drawing.Size(100, 23);
			this.parole_txt.TabIndex = 6;
			this.parole_txt.Text = "Parole:";
			// 
			// parole_iev
			// 
			this.parole_iev.Location = new System.Drawing.Point(118, 94);
			this.parole_iev.MaxLength = 32;
			this.parole_iev.Name = "parole_iev";
			this.parole_iev.Size = new System.Drawing.Size(175, 20);
			this.parole_iev.TabIndex = 7;
			this.parole_iev.UseSystemPasswordChar = true;
			// 
			// lietotaju_dati
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 151);
			this.Controls.Add(this.parole_iev);
			this.Controls.Add(this.parole_txt);
			this.Controls.Add(this.stavoklis_txt);
			this.Controls.Add(this.stavoklis_cb);
			this.Controls.Add(this.uzvards_iev);
			this.Controls.Add(this.uzvards_txt);
			this.Controls.Add(this.vards_iev);
			this.Controls.Add(this.vards_txt);
			this.Controls.Add(this.pievienot_poga);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "lietotaju_dati";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Pievienot jaunu";
			((System.ComponentModel.ISupportInitialize)(this.kludas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox parole_iev;
		private System.Windows.Forms.Label parole_txt;
		private System.Windows.Forms.Label stavoklis_txt;
		private System.Windows.Forms.ComboBox stavoklis_cb;
		private System.Windows.Forms.TextBox uzvards_iev;
		private System.Windows.Forms.Label uzvards_txt;
		private System.Windows.Forms.ErrorProvider kludas;
		private System.Windows.Forms.TextBox vards_iev;
		private System.Windows.Forms.Label vards_txt;
		private System.Windows.Forms.Button pievienot_poga;
	}
}