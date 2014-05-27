namespace slodzes_parskati
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.nosaukums = new System.Windows.Forms.Label();
			this.autentifikacija = new System.Windows.Forms.GroupBox();
			this.parole_txt = new System.Windows.Forms.Label();
			this.id_txt = new System.Windows.Forms.Label();
			this.aizvert_poga = new System.Windows.Forms.Button();
			this.ieiet_poga = new System.Windows.Forms.Button();
			this.parole_iev = new System.Windows.Forms.TextBox();
			this.id_iev = new System.Windows.Forms.TextBox();
			this.autentifikacija.SuspendLayout();
			this.SuspendLayout();
			// 
			// nosaukums
			// 
			this.nosaukums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.nosaukums.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.nosaukums.ForeColor = System.Drawing.Color.White;
			this.nosaukums.Location = new System.Drawing.Point(12, 9);
			this.nosaukums.Name = "nosaukums";
			this.nosaukums.Size = new System.Drawing.Size(276, 37);
			this.nosaukums.TabIndex = 0;
			this.nosaukums.Text = "SLODZES testēšana";
			this.nosaukums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// autentifikacija
			// 
			this.autentifikacija.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.autentifikacija.Controls.Add(this.parole_txt);
			this.autentifikacija.Controls.Add(this.id_txt);
			this.autentifikacija.Controls.Add(this.aizvert_poga);
			this.autentifikacija.Controls.Add(this.ieiet_poga);
			this.autentifikacija.Controls.Add(this.parole_iev);
			this.autentifikacija.Controls.Add(this.id_iev);
			this.autentifikacija.ForeColor = System.Drawing.Color.White;
			this.autentifikacija.Location = new System.Drawing.Point(12, 49);
			this.autentifikacija.Name = "autentifikacija";
			this.autentifikacija.Size = new System.Drawing.Size(276, 139);
			this.autentifikacija.TabIndex = 1;
			this.autentifikacija.TabStop = false;
			this.autentifikacija.Text = "Autentifikācija sistēmā";
			// 
			// parole_txt
			// 
			this.parole_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.parole_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.parole_txt.Location = new System.Drawing.Point(6, 58);
			this.parole_txt.Name = "parole_txt";
			this.parole_txt.Size = new System.Drawing.Size(100, 23);
			this.parole_txt.TabIndex = 2;
			this.parole_txt.Text = "Parole:";
			// 
			// id_txt
			// 
			this.id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.id_txt.Location = new System.Drawing.Point(6, 32);
			this.id_txt.Name = "id_txt";
			this.id_txt.Size = new System.Drawing.Size(100, 23);
			this.id_txt.TabIndex = 0;
			this.id_txt.Text = "Identifikators:";
			// 
			// aizvert_poga
			// 
			this.aizvert_poga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.aizvert_poga.ForeColor = System.Drawing.SystemColors.ControlText;
			this.aizvert_poga.Location = new System.Drawing.Point(6, 110);
			this.aizvert_poga.Name = "aizvert_poga";
			this.aizvert_poga.Size = new System.Drawing.Size(264, 23);
			this.aizvert_poga.TabIndex = 5;
			this.aizvert_poga.Text = "&Aizvērt";
			this.aizvert_poga.UseVisualStyleBackColor = true;
			this.aizvert_poga.Click += new System.EventHandler(this.Aizvert_pogaClick);
			// 
			// ieiet_poga
			// 
			this.ieiet_poga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.ieiet_poga.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ieiet_poga.Location = new System.Drawing.Point(6, 81);
			this.ieiet_poga.Name = "ieiet_poga";
			this.ieiet_poga.Size = new System.Drawing.Size(264, 23);
			this.ieiet_poga.TabIndex = 4;
			this.ieiet_poga.Text = "&Ieiet";
			this.ieiet_poga.UseVisualStyleBackColor = true;
			this.ieiet_poga.Click += new System.EventHandler(this.Ieiet_pogaClick);
			// 
			// parole_iev
			// 
			this.parole_iev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.parole_iev.Location = new System.Drawing.Point(110, 55);
			this.parole_iev.MaxLength = 32;
			this.parole_iev.Name = "parole_iev";
			this.parole_iev.Size = new System.Drawing.Size(160, 20);
			this.parole_iev.TabIndex = 3;
			this.parole_iev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.parole_iev.UseSystemPasswordChar = true;
			this.parole_iev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Parole_ievKeyDown);
			// 
			// id_iev
			// 
			this.id_iev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.id_iev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.id_iev.Location = new System.Drawing.Point(110, 29);
			this.id_iev.MaxLength = 4;
			this.id_iev.Name = "id_iev";
			this.id_iev.Size = new System.Drawing.Size(160, 20);
			this.id_iev.TabIndex = 1;
			this.id_iev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(138)))), ((int)(((byte)(88)))));
			this.ClientSize = new System.Drawing.Size(300, 200);
			this.ControlBox = false;
			this.Controls.Add(this.autentifikacija);
			this.Controls.Add(this.nosaukums);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lietotāja autentifikācija";
			this.autentifikacija.ResumeLayout(false);
			this.autentifikacija.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label parole_txt;
		private System.Windows.Forms.Label id_txt;
		private System.Windows.Forms.Button aizvert_poga;
		private System.Windows.Forms.Button ieiet_poga;
		private System.Windows.Forms.TextBox id_iev;
		private System.Windows.Forms.TextBox parole_iev;
		private System.Windows.Forms.GroupBox autentifikacija;
		private System.Windows.Forms.Label nosaukums;
	}
}