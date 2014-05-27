namespace slodzes_parskati
{
	partial class testetajiem
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testetajiem));
			this.statusa_josla = new System.Windows.Forms.StatusStrip();
			this.testetajs_txt = new System.Windows.Forms.ToolStripStatusLabel();
			this.statuss_txt = new System.Windows.Forms.ToolStripStatusLabel();
			this.izvelne = new System.Windows.Forms.MenuStrip();
			this.datneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.izietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rīkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainītParoliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.palīdzībaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resursiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SLODZESmājasLapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sūtītAtsauksmiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.parToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cilnes = new System.Windows.Forms.TabControl();
			this.jauns_zinojums_tab = new System.Windows.Forms.TabPage();
			this.piezimes_txt = new System.Windows.Forms.Label();
			this.pievienot_poga = new System.Windows.Forms.Button();
			this.piezimju_iev = new System.Windows.Forms.TextBox();
			this.kludas_veids_txt = new System.Windows.Forms.Label();
			this.probl_apraksta_iev = new System.Windows.Forms.TextBox();
			this.probl_apraksts_txt = new System.Windows.Forms.Label();
			this.sadalas_koks = new System.Windows.Forms.Button();
			this.probl_vieta_txt = new System.Windows.Forms.Label();
			this.laidiens_txt = new System.Windows.Forms.Label();
			this.probl_nosauk_iev = new System.Windows.Forms.TextBox();
			this.probl_nosauk_txt = new System.Windows.Forms.Label();
			this.no_admin_konta = new System.Windows.Forms.CheckBox();
			this.probl_id_txt = new System.Windows.Forms.Label();
			this.probl_id_iev = new System.Windows.Forms.TextBox();
			this.stavokli_cb = new System.Windows.Forms.ComboBox();
			this.laidieni_cb = new System.Windows.Forms.ComboBox();
			this.ieprieksejie_tab = new System.Windows.Forms.TabPage();
			this.filtresana = new System.Windows.Forms.GroupBox();
			this.txt_filtrs_iev = new System.Windows.Forms.TextBox();
			this.pec_teksta_txt = new System.Windows.Forms.Label();
			this.probl_zin_skats = new System.Windows.Forms.DataGridView();
			this.kludas = new System.Windows.Forms.ErrorProvider(this.components);
			this.statusa_josla.SuspendLayout();
			this.izvelne.SuspendLayout();
			this.cilnes.SuspendLayout();
			this.jauns_zinojums_tab.SuspendLayout();
			this.ieprieksejie_tab.SuspendLayout();
			this.filtresana.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.probl_zin_skats)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kludas)).BeginInit();
			this.SuspendLayout();
			// 
			// statusa_josla
			// 
			this.statusa_josla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.testetajs_txt,
									this.statuss_txt});
			this.statusa_josla.Location = new System.Drawing.Point(0, 329);
			this.statusa_josla.Name = "statusa_josla";
			this.statusa_josla.Size = new System.Drawing.Size(449, 22);
			this.statusa_josla.TabIndex = 2;
			this.statusa_josla.Text = "statusa_josla";
			// 
			// testetajs_txt
			// 
			this.testetajs_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.testetajs_txt.Name = "testetajs_txt";
			this.testetajs_txt.Size = new System.Drawing.Size(56, 17);
			this.testetajs_txt.Text = "Testētājs";
			// 
			// statuss_txt
			// 
			this.statuss_txt.Name = "statuss_txt";
			this.statuss_txt.Size = new System.Drawing.Size(44, 17);
			this.statuss_txt.Text = "Statuss";
			// 
			// izvelne
			// 
			this.izvelne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.datneToolStripMenuItem,
									this.rīkiToolStripMenuItem,
									this.palīdzībaToolStripMenuItem});
			this.izvelne.Location = new System.Drawing.Point(0, 0);
			this.izvelne.Name = "izvelne";
			this.izvelne.Size = new System.Drawing.Size(449, 24);
			this.izvelne.TabIndex = 0;
			this.izvelne.Text = "izvelne";
			// 
			// datneToolStripMenuItem
			// 
			this.datneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.izietToolStripMenuItem});
			this.datneToolStripMenuItem.Name = "datneToolStripMenuItem";
			this.datneToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.datneToolStripMenuItem.Text = "&Datne";
			// 
			// izietToolStripMenuItem
			// 
			this.izietToolStripMenuItem.Name = "izietToolStripMenuItem";
			this.izietToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.izietToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.izietToolStripMenuItem.Text = "I&ziet";
			this.izietToolStripMenuItem.Click += new System.EventHandler(this.IzietToolStripMenuItemClick);
			// 
			// rīkiToolStripMenuItem
			// 
			this.rīkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mainītParoliToolStripMenuItem});
			this.rīkiToolStripMenuItem.Name = "rīkiToolStripMenuItem";
			this.rīkiToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.rīkiToolStripMenuItem.Text = "&Rīki";
			// 
			// mainītParoliToolStripMenuItem
			// 
			this.mainītParoliToolStripMenuItem.Name = "mainītParoliToolStripMenuItem";
			this.mainītParoliToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.mainītParoliToolStripMenuItem.Text = "&Mainīt paroli...";
			this.mainītParoliToolStripMenuItem.Click += new System.EventHandler(this.MainītParoliToolStripMenuItemClick);
			// 
			// palīdzībaToolStripMenuItem
			// 
			this.palīdzībaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.resursiToolStripMenuItem,
									this.toolStripSeparator1,
									this.parToolStripMenuItem});
			this.palīdzībaToolStripMenuItem.Name = "palīdzībaToolStripMenuItem";
			this.palīdzībaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.palīdzībaToolStripMenuItem.Text = "&Palīdzība";
			// 
			// resursiToolStripMenuItem
			// 
			this.resursiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.SLODZESmājasLapaToolStripMenuItem,
									this.sūtītAtsauksmiToolStripMenuItem});
			this.resursiToolStripMenuItem.Name = "resursiToolStripMenuItem";
			this.resursiToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.resursiToolStripMenuItem.Text = "&Resursi";
			// 
			// SLODZESmājasLapaToolStripMenuItem
			// 
			this.SLODZESmājasLapaToolStripMenuItem.Name = "SLODZESmājasLapaToolStripMenuItem";
			this.SLODZESmājasLapaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.SLODZESmājasLapaToolStripMenuItem.Text = "SLODZES &mājas lapa";
			this.SLODZESmājasLapaToolStripMenuItem.Click += new System.EventHandler(this.SLODZESmājasLapaToolStripMenuItemClick);
			// 
			// sūtītAtsauksmiToolStripMenuItem
			// 
			this.sūtītAtsauksmiToolStripMenuItem.Name = "sūtītAtsauksmiToolStripMenuItem";
			this.sūtītAtsauksmiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.sūtītAtsauksmiToolStripMenuItem.Text = "&Sūtīt atsauksmi";
			this.sūtītAtsauksmiToolStripMenuItem.Click += new System.EventHandler(this.SūtītAtsauksmiToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
			// 
			// parToolStripMenuItem
			// 
			this.parToolStripMenuItem.Name = "parToolStripMenuItem";
			this.parToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.parToolStripMenuItem.Text = "P&ar...";
			this.parToolStripMenuItem.Click += new System.EventHandler(this.ParToolStripMenuItemClick);
			// 
			// cilnes
			// 
			this.cilnes.Controls.Add(this.jauns_zinojums_tab);
			this.cilnes.Controls.Add(this.ieprieksejie_tab);
			this.cilnes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cilnes.Location = new System.Drawing.Point(0, 24);
			this.cilnes.Name = "cilnes";
			this.cilnes.SelectedIndex = 0;
			this.cilnes.Size = new System.Drawing.Size(449, 305);
			this.cilnes.TabIndex = 1;
			// 
			// jauns_zinojums_tab
			// 
			this.jauns_zinojums_tab.BackColor = System.Drawing.SystemColors.Control;
			this.jauns_zinojums_tab.Controls.Add(this.piezimes_txt);
			this.jauns_zinojums_tab.Controls.Add(this.pievienot_poga);
			this.jauns_zinojums_tab.Controls.Add(this.piezimju_iev);
			this.jauns_zinojums_tab.Controls.Add(this.kludas_veids_txt);
			this.jauns_zinojums_tab.Controls.Add(this.probl_apraksta_iev);
			this.jauns_zinojums_tab.Controls.Add(this.probl_apraksts_txt);
			this.jauns_zinojums_tab.Controls.Add(this.sadalas_koks);
			this.jauns_zinojums_tab.Controls.Add(this.probl_vieta_txt);
			this.jauns_zinojums_tab.Controls.Add(this.laidiens_txt);
			this.jauns_zinojums_tab.Controls.Add(this.probl_nosauk_iev);
			this.jauns_zinojums_tab.Controls.Add(this.probl_nosauk_txt);
			this.jauns_zinojums_tab.Controls.Add(this.no_admin_konta);
			this.jauns_zinojums_tab.Controls.Add(this.probl_id_txt);
			this.jauns_zinojums_tab.Controls.Add(this.probl_id_iev);
			this.jauns_zinojums_tab.Controls.Add(this.stavokli_cb);
			this.jauns_zinojums_tab.Controls.Add(this.laidieni_cb);
			this.jauns_zinojums_tab.Location = new System.Drawing.Point(4, 22);
			this.jauns_zinojums_tab.Name = "jauns_zinojums_tab";
			this.jauns_zinojums_tab.Padding = new System.Windows.Forms.Padding(3);
			this.jauns_zinojums_tab.Size = new System.Drawing.Size(441, 279);
			this.jauns_zinojums_tab.TabIndex = 0;
			this.jauns_zinojums_tab.Text = "Jauns problēmas ziņojums";
			// 
			// piezimes_txt
			// 
			this.piezimes_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.piezimes_txt.BackColor = System.Drawing.Color.Transparent;
			this.piezimes_txt.Location = new System.Drawing.Point(6, 194);
			this.piezimes_txt.Name = "piezimes_txt";
			this.piezimes_txt.Size = new System.Drawing.Size(115, 45);
			this.piezimes_txt.TabIndex = 13;
			this.piezimes_txt.Text = "Papildu piezīmes:";
			// 
			// pievienot_poga
			// 
			this.pievienot_poga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pievienot_poga.Location = new System.Drawing.Point(6, 242);
			this.pievienot_poga.Name = "pievienot_poga";
			this.pievienot_poga.Size = new System.Drawing.Size(418, 23);
			this.pievienot_poga.TabIndex = 15;
			this.pievienot_poga.Text = "Pievienot problēmas ziņojumu";
			this.pievienot_poga.UseVisualStyleBackColor = true;
			this.pievienot_poga.Click += new System.EventHandler(this.Pievienot_pogaClick);
			// 
			// piezimju_iev
			// 
			this.piezimju_iev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.piezimju_iev.Location = new System.Drawing.Point(127, 194);
			this.piezimju_iev.MaxLength = 255;
			this.piezimju_iev.Multiline = true;
			this.piezimju_iev.Name = "piezimju_iev";
			this.piezimju_iev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.piezimju_iev.Size = new System.Drawing.Size(297, 42);
			this.piezimju_iev.TabIndex = 14;
			// 
			// kludas_veids_txt
			// 
			this.kludas_veids_txt.BackColor = System.Drawing.Color.Transparent;
			this.kludas_veids_txt.Location = new System.Drawing.Point(6, 75);
			this.kludas_veids_txt.Name = "kludas_veids_txt";
			this.kludas_veids_txt.Size = new System.Drawing.Size(115, 23);
			this.kludas_veids_txt.TabIndex = 7;
			this.kludas_veids_txt.Text = "Kļūdas veids:";
			// 
			// probl_apraksta_iev
			// 
			this.probl_apraksta_iev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.probl_apraksta_iev.Location = new System.Drawing.Point(127, 138);
			this.probl_apraksta_iev.MaxLength = 500;
			this.probl_apraksta_iev.Multiline = true;
			this.probl_apraksta_iev.Name = "probl_apraksta_iev";
			this.probl_apraksta_iev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.probl_apraksta_iev.Size = new System.Drawing.Size(297, 50);
			this.probl_apraksta_iev.TabIndex = 12;
			this.probl_apraksta_iev.Validating += new System.ComponentModel.CancelEventHandler(this.Probl_apraksta_ievValidating);
			// 
			// probl_apraksts_txt
			// 
			this.probl_apraksts_txt.BackColor = System.Drawing.Color.Transparent;
			this.probl_apraksts_txt.Location = new System.Drawing.Point(6, 141);
			this.probl_apraksts_txt.Name = "probl_apraksts_txt";
			this.probl_apraksts_txt.Size = new System.Drawing.Size(115, 57);
			this.probl_apraksts_txt.TabIndex = 11;
			this.probl_apraksts_txt.Text = "Problēmas apraksts:";
			// 
			// sadalas_koks
			// 
			this.sadalas_koks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.sadalas_koks.Location = new System.Drawing.Point(127, 32);
			this.sadalas_koks.Name = "sadalas_koks";
			this.sadalas_koks.Size = new System.Drawing.Size(186, 34);
			this.sadalas_koks.TabIndex = 5;
			this.sadalas_koks.Text = "&Izvēlēties sadaļu...";
			this.sadalas_koks.UseVisualStyleBackColor = true;
			this.sadalas_koks.Click += new System.EventHandler(this.Sadalas_koksClick);
			// 
			// probl_vieta_txt
			// 
			this.probl_vieta_txt.BackColor = System.Drawing.Color.Transparent;
			this.probl_vieta_txt.Location = new System.Drawing.Point(6, 32);
			this.probl_vieta_txt.Name = "probl_vieta_txt";
			this.probl_vieta_txt.Size = new System.Drawing.Size(115, 34);
			this.probl_vieta_txt.TabIndex = 4;
			this.probl_vieta_txt.Text = "Problēmas atrašanās vieta:";
			// 
			// laidiens_txt
			// 
			this.laidiens_txt.BackColor = System.Drawing.Color.Transparent;
			this.laidiens_txt.Location = new System.Drawing.Point(212, 9);
			this.laidiens_txt.Name = "laidiens_txt";
			this.laidiens_txt.Size = new System.Drawing.Size(100, 23);
			this.laidiens_txt.TabIndex = 2;
			this.laidiens_txt.Text = "SLODZES laidiens:";
			// 
			// probl_nosauk_iev
			// 
			this.probl_nosauk_iev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.probl_nosauk_iev.Location = new System.Drawing.Point(127, 99);
			this.probl_nosauk_iev.MaxLength = 50;
			this.probl_nosauk_iev.Multiline = true;
			this.probl_nosauk_iev.Name = "probl_nosauk_iev";
			this.probl_nosauk_iev.Size = new System.Drawing.Size(297, 33);
			this.probl_nosauk_iev.TabIndex = 10;
			this.probl_nosauk_iev.Validating += new System.ComponentModel.CancelEventHandler(this.Probl_nosauk_ievValidating);
			// 
			// probl_nosauk_txt
			// 
			this.probl_nosauk_txt.BackColor = System.Drawing.Color.Transparent;
			this.probl_nosauk_txt.Location = new System.Drawing.Point(6, 99);
			this.probl_nosauk_txt.Name = "probl_nosauk_txt";
			this.probl_nosauk_txt.Size = new System.Drawing.Size(115, 33);
			this.probl_nosauk_txt.TabIndex = 9;
			this.probl_nosauk_txt.Text = "Problēmas nosaukums (īss raksturojums):";
			// 
			// no_admin_konta
			// 
			this.no_admin_konta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.no_admin_konta.BackColor = System.Drawing.Color.Transparent;
			this.no_admin_konta.Checked = true;
			this.no_admin_konta.CheckState = System.Windows.Forms.CheckState.Checked;
			this.no_admin_konta.Location = new System.Drawing.Point(330, 32);
			this.no_admin_konta.Name = "no_admin_konta";
			this.no_admin_konta.Size = new System.Drawing.Size(94, 34);
			this.no_admin_konta.TabIndex = 6;
			this.no_admin_konta.Text = "Administratora kontā";
			this.no_admin_konta.UseVisualStyleBackColor = false;
			// 
			// probl_id_txt
			// 
			this.probl_id_txt.BackColor = System.Drawing.Color.Transparent;
			this.probl_id_txt.Location = new System.Drawing.Point(6, 9);
			this.probl_id_txt.Name = "probl_id_txt";
			this.probl_id_txt.Size = new System.Drawing.Size(115, 23);
			this.probl_id_txt.TabIndex = 0;
			this.probl_id_txt.Text = "Problēmas ID:";
			// 
			// probl_id_iev
			// 
			this.probl_id_iev.Location = new System.Drawing.Point(127, 6);
			this.probl_id_iev.MaxLength = 7;
			this.probl_id_iev.Name = "probl_id_iev";
			this.probl_id_iev.ReadOnly = true;
			this.probl_id_iev.Size = new System.Drawing.Size(80, 20);
			this.probl_id_iev.TabIndex = 1;
			this.probl_id_iev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// stavokli_cb
			// 
			this.stavokli_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.stavokli_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stavokli_cb.FormattingEnabled = true;
			this.stavokli_cb.Location = new System.Drawing.Point(127, 72);
			this.stavokli_cb.Name = "stavokli_cb";
			this.stavokli_cb.Size = new System.Drawing.Size(297, 21);
			this.stavokli_cb.TabIndex = 8;
			// 
			// laidieni_cb
			// 
			this.laidieni_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.laidieni_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.laidieni_cb.FormattingEnabled = true;
			this.laidieni_cb.Location = new System.Drawing.Point(318, 6);
			this.laidieni_cb.Name = "laidieni_cb";
			this.laidieni_cb.Size = new System.Drawing.Size(106, 21);
			this.laidieni_cb.TabIndex = 3;
			// 
			// ieprieksejie_tab
			// 
			this.ieprieksejie_tab.BackColor = System.Drawing.SystemColors.Control;
			this.ieprieksejie_tab.Controls.Add(this.filtresana);
			this.ieprieksejie_tab.Controls.Add(this.probl_zin_skats);
			this.ieprieksejie_tab.Location = new System.Drawing.Point(4, 22);
			this.ieprieksejie_tab.Name = "ieprieksejie_tab";
			this.ieprieksejie_tab.Padding = new System.Windows.Forms.Padding(3);
			this.ieprieksejie_tab.Size = new System.Drawing.Size(441, 279);
			this.ieprieksejie_tab.TabIndex = 1;
			this.ieprieksejie_tab.Text = "Iepriekšējie ziņojumi";
			// 
			// filtresana
			// 
			this.filtresana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.filtresana.Controls.Add(this.txt_filtrs_iev);
			this.filtresana.Controls.Add(this.pec_teksta_txt);
			this.filtresana.Location = new System.Drawing.Point(6, 6);
			this.filtresana.Name = "filtresana";
			this.filtresana.Size = new System.Drawing.Size(429, 64);
			this.filtresana.TabIndex = 0;
			this.filtresana.TabStop = false;
			this.filtresana.Text = "Filtrēt problēmu ziņojumus";
			// 
			// txt_filtrs_iev
			// 
			this.txt_filtrs_iev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_filtrs_iev.Location = new System.Drawing.Point(119, 21);
			this.txt_filtrs_iev.MaxLength = 500;
			this.txt_filtrs_iev.Multiline = true;
			this.txt_filtrs_iev.Name = "txt_filtrs_iev";
			this.txt_filtrs_iev.Size = new System.Drawing.Size(310, 37);
			this.txt_filtrs_iev.TabIndex = 1;
			this.txt_filtrs_iev.TextChanged += new System.EventHandler(this.Txt_filtrs_ievTextChanged);
			// 
			// pec_teksta_txt
			// 
			this.pec_teksta_txt.Location = new System.Drawing.Point(6, 21);
			this.pec_teksta_txt.Name = "pec_teksta_txt";
			this.pec_teksta_txt.Size = new System.Drawing.Size(100, 37);
			this.pec_teksta_txt.TabIndex = 0;
			this.pec_teksta_txt.Text = "Pēc teksta:";
			// 
			// probl_zin_skats
			// 
			this.probl_zin_skats.AllowUserToAddRows = false;
			this.probl_zin_skats.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			this.probl_zin_skats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.probl_zin_skats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.probl_zin_skats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.probl_zin_skats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.probl_zin_skats.BackgroundColor = System.Drawing.SystemColors.Control;
			this.probl_zin_skats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(138)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.probl_zin_skats.DefaultCellStyle = dataGridViewCellStyle2;
			this.probl_zin_skats.GridColor = System.Drawing.SystemColors.Control;
			this.probl_zin_skats.Location = new System.Drawing.Point(3, 73);
			this.probl_zin_skats.Name = "probl_zin_skats";
			this.probl_zin_skats.Size = new System.Drawing.Size(435, 200);
			this.probl_zin_skats.TabIndex = 1;
			this.probl_zin_skats.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Probl_zin_skatsCellDoubleClick);
			this.probl_zin_skats.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.Probl_zin_skatsCellLeave);
			this.probl_zin_skats.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Probl_zin_skatsCellValidating);
			// 
			// kludas
			// 
			this.kludas.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.kludas.ContainerControl = this;
			// 
			// testetajiem
			// 
			this.ClientSize = new System.Drawing.Size(449, 351);
			this.Controls.Add(this.cilnes);
			this.Controls.Add(this.statusa_josla);
			this.Controls.Add(this.izvelne);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.izvelne;
			this.MinimumSize = new System.Drawing.Size(465, 390);
			this.Name = "testetajiem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SLODZES testēšana";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestetajiemFormClosed);
			this.statusa_josla.ResumeLayout(false);
			this.statusa_josla.PerformLayout();
			this.izvelne.ResumeLayout(false);
			this.izvelne.PerformLayout();
			this.cilnes.ResumeLayout(false);
			this.jauns_zinojums_tab.ResumeLayout(false);
			this.jauns_zinojums_tab.PerformLayout();
			this.ieprieksejie_tab.ResumeLayout(false);
			this.filtresana.ResumeLayout(false);
			this.filtresana.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.probl_zin_skats)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kludas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txt_filtrs_iev;
		private System.Windows.Forms.Label pec_teksta_txt;
		private System.Windows.Forms.GroupBox filtresana;
		private System.Windows.Forms.DataGridView probl_zin_skats;
		private System.Windows.Forms.TabPage ieprieksejie_tab;
		private System.Windows.Forms.ErrorProvider kludas;
		private System.Windows.Forms.Label piezimes_txt;
		private System.Windows.Forms.Button pievienot_poga;
		private System.Windows.Forms.TextBox piezimju_iev;
		private System.Windows.Forms.Label kludas_veids_txt;
		private System.Windows.Forms.TextBox probl_apraksta_iev;
		private System.Windows.Forms.Label probl_apraksts_txt;
		private System.Windows.Forms.Button sadalas_koks;
		private System.Windows.Forms.Label probl_vieta_txt;
		private System.Windows.Forms.Label laidiens_txt;
		private System.Windows.Forms.TextBox probl_nosauk_iev;
		private System.Windows.Forms.Label probl_nosauk_txt;
		private System.Windows.Forms.CheckBox no_admin_konta;
		private System.Windows.Forms.Label probl_id_txt;
		private System.Windows.Forms.TextBox probl_id_iev;
		private System.Windows.Forms.ComboBox stavokli_cb;
		private System.Windows.Forms.ComboBox laidieni_cb;
		private System.Windows.Forms.TabPage jauns_zinojums_tab;
		private System.Windows.Forms.TabControl cilnes;
		private System.Windows.Forms.ToolStripStatusLabel statuss_txt;
		private System.Windows.Forms.ToolStripStatusLabel testetajs_txt;
		private System.Windows.Forms.ToolStripMenuItem sūtītAtsauksmiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SLODZESmājasLapaToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem resursiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem parToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mainītParoliToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem palīdzībaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rīkiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem izietToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem datneToolStripMenuItem;
		private System.Windows.Forms.MenuStrip izvelne;
		private System.Windows.Forms.StatusStrip statusa_josla;
	}
}