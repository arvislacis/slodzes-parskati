namespace slodzes_parskati
{
	partial class paroles_maina
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
			this.pp_ievade = new System.Windows.Forms.TextBox();
			this.kludas = new System.Windows.Forms.ErrorProvider(this.components);
			this.jp_ievade = new System.Windows.Forms.TextBox();
			this.jpv_ievade = new System.Windows.Forms.TextBox();
			this.mainit_poga = new System.Windows.Forms.Button();
			this.pp_txt = new System.Windows.Forms.Label();
			this.jp_txt = new System.Windows.Forms.Label();
			this.jpv_txt = new System.Windows.Forms.Label();
			this.atcelt_poga = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.kludas)).BeginInit();
			this.SuspendLayout();
			// 
			// pp_ievade
			// 
			this.pp_ievade.Location = new System.Drawing.Point(128, 12);
			this.pp_ievade.MaxLength = 32;
			this.pp_ievade.Name = "pp_ievade";
			this.pp_ievade.Size = new System.Drawing.Size(154, 20);
			this.pp_ievade.TabIndex = 1;
			this.pp_ievade.UseSystemPasswordChar = true;
			this.pp_ievade.Validating += new System.ComponentModel.CancelEventHandler(this.Pp_ievadeValidating);
			// 
			// kludas
			// 
			this.kludas.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.kludas.ContainerControl = this;
			// 
			// jp_ievade
			// 
			this.jp_ievade.Location = new System.Drawing.Point(128, 38);
			this.jp_ievade.MaxLength = 32;
			this.jp_ievade.Name = "jp_ievade";
			this.jp_ievade.Size = new System.Drawing.Size(154, 20);
			this.jp_ievade.TabIndex = 3;
			this.jp_ievade.UseSystemPasswordChar = true;
			this.jp_ievade.Validating += new System.ComponentModel.CancelEventHandler(this.Jp_ievadeValidating);
			// 
			// jpv_ievade
			// 
			this.jpv_ievade.Location = new System.Drawing.Point(128, 64);
			this.jpv_ievade.MaxLength = 32;
			this.jpv_ievade.Name = "jpv_ievade";
			this.jpv_ievade.Size = new System.Drawing.Size(154, 20);
			this.jpv_ievade.TabIndex = 5;
			this.jpv_ievade.UseSystemPasswordChar = true;
			this.jpv_ievade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Jpv_ievadeKeyDown);
			this.jpv_ievade.Validating += new System.ComponentModel.CancelEventHandler(this.Jpv_ievadeValidating);
			// 
			// mainit_poga
			// 
			this.mainit_poga.Location = new System.Drawing.Point(101, 90);
			this.mainit_poga.Name = "mainit_poga";
			this.mainit_poga.Size = new System.Drawing.Size(181, 22);
			this.mainit_poga.TabIndex = 7;
			this.mainit_poga.Text = "&Mainīt paroli";
			this.mainit_poga.UseVisualStyleBackColor = true;
			this.mainit_poga.Click += new System.EventHandler(this.Mainit_pogaClick);
			// 
			// pp_txt
			// 
			this.pp_txt.Location = new System.Drawing.Point(12, 15);
			this.pp_txt.Name = "pp_txt";
			this.pp_txt.Size = new System.Drawing.Size(110, 22);
			this.pp_txt.TabIndex = 0;
			this.pp_txt.Text = "Pašreizējā parole:";
			// 
			// jp_txt
			// 
			this.jp_txt.Location = new System.Drawing.Point(12, 41);
			this.jp_txt.Name = "jp_txt";
			this.jp_txt.Size = new System.Drawing.Size(110, 22);
			this.jp_txt.TabIndex = 2;
			this.jp_txt.Text = "Jaunā parole:";
			// 
			// jpv_txt
			// 
			this.jpv_txt.Location = new System.Drawing.Point(12, 67);
			this.jpv_txt.Name = "jpv_txt";
			this.jpv_txt.Size = new System.Drawing.Size(110, 22);
			this.jpv_txt.TabIndex = 4;
			this.jpv_txt.Text = "Jaunā parole vēlreiz:";
			// 
			// atcelt_poga
			// 
			this.atcelt_poga.Location = new System.Drawing.Point(12, 90);
			this.atcelt_poga.Name = "atcelt_poga";
			this.atcelt_poga.Size = new System.Drawing.Size(83, 22);
			this.atcelt_poga.TabIndex = 6;
			this.atcelt_poga.Text = "&Atcelt";
			this.atcelt_poga.UseVisualStyleBackColor = true;
			this.atcelt_poga.Click += new System.EventHandler(this.Atcelt_pogaClick);
			// 
			// paroles_maina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 121);
			this.Controls.Add(this.atcelt_poga);
			this.Controls.Add(this.jpv_txt);
			this.Controls.Add(this.jp_txt);
			this.Controls.Add(this.pp_txt);
			this.Controls.Add(this.mainit_poga);
			this.Controls.Add(this.jpv_ievade);
			this.Controls.Add(this.jp_ievade);
			this.Controls.Add(this.pp_ievade);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "paroles_maina";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Paroles maiņa";
			((System.ComponentModel.ISupportInitialize)(this.kludas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button atcelt_poga;
		private System.Windows.Forms.Label jpv_txt;
		private System.Windows.Forms.Label jp_txt;
		private System.Windows.Forms.Label pp_txt;
		private System.Windows.Forms.Button mainit_poga;
		private System.Windows.Forms.TextBox jp_ievade;
		private System.Windows.Forms.TextBox jpv_ievade;
		private System.Windows.Forms.ErrorProvider kludas;
		private System.Windows.Forms.TextBox pp_ievade;
	}
}