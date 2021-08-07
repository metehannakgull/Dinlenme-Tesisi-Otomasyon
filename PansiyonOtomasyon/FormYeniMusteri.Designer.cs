
namespace PansiyonOtomasyon
{
    partial class FormYeniMusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGun = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.lblUcret = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dateTPCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTPGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.maskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.lblKimlik = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOda109 = new System.Windows.Forms.Button();
            this.btnOda108 = new System.Windows.Forms.Button();
            this.btnOda107 = new System.Windows.Forms.Button();
            this.btnOda106 = new System.Windows.Forms.Button();
            this.btnOda105 = new System.Windows.Forms.Button();
            this.btnOda104 = new System.Windows.Forms.Button();
            this.btnOda103 = new System.Windows.Forms.Button();
            this.btnOda102 = new System.Windows.Forms.Button();
            this.btnOda101 = new System.Windows.Forms.Button();
            this.btnBosOda = new System.Windows.Forms.Button();
            this.btnDoluOda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGun);
            this.groupBox1.Controls.Add(this.comboBoxCinsiyet);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.lblUcret);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.dateTPCikisTarihi);
            this.groupBox1.Controls.Add(this.dateTPGirisTarihi);
            this.groupBox1.Controls.Add(this.maskTxtTelefon);
            this.groupBox1.Controls.Add(this.txtOdaNo);
            this.groupBox1.Controls.Add(this.txtKimlik);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.lblCikisTarihi);
            this.groupBox1.Controls.Add(this.lblGirisTarihi);
            this.groupBox1.Controls.Add(this.lblOdaNo);
            this.groupBox1.Controls.Add(this.lblKimlik);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblSoyadi);
            this.groupBox1.Controls.Add(this.lblAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.Location = new System.Drawing.Point(294, 382);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(14, 13);
            this.lblGun.TabIndex = 39;
            this.lblGun.Text = "0";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(142, 89);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(193, 21);
            this.comboBoxCinsiyet.TabIndex = 38;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(59, 89);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(76, 22);
            this.lblCinsiyet.TabIndex = 37;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // txtUcret
            // 
            this.txtUcret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUcret.Location = new System.Drawing.Point(140, 264);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(195, 20);
            this.txtUcret.TabIndex = 36;
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.Location = new System.Drawing.Point(70, 261);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(54, 22);
            this.lblUcret.TabIndex = 35;
            this.lblUcret.Text = "Ücret:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(171, 362);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 34);
            this.btnKaydet.TabIndex = 34;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dateTPCikisTarihi
            // 
            this.dateTPCikisTarihi.Location = new System.Drawing.Point(140, 337);
            this.dateTPCikisTarihi.Name = "dateTPCikisTarihi";
            this.dateTPCikisTarihi.Size = new System.Drawing.Size(195, 20);
            this.dateTPCikisTarihi.TabIndex = 33;
            this.dateTPCikisTarihi.ValueChanged += new System.EventHandler(this.dateTPCikisTarihi_ValueChanged);
            // 
            // dateTPGirisTarihi
            // 
            this.dateTPGirisTarihi.Location = new System.Drawing.Point(140, 300);
            this.dateTPGirisTarihi.Name = "dateTPGirisTarihi";
            this.dateTPGirisTarihi.Size = new System.Drawing.Size(195, 20);
            this.dateTPGirisTarihi.TabIndex = 32;
            // 
            // maskTxtTelefon
            // 
            this.maskTxtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskTxtTelefon.Location = new System.Drawing.Point(140, 120);
            this.maskTxtTelefon.Mask = "(999) 000-0000";
            this.maskTxtTelefon.Name = "maskTxtTelefon";
            this.maskTxtTelefon.Size = new System.Drawing.Size(195, 20);
            this.maskTxtTelefon.TabIndex = 31;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtOdaNo.Enabled = false;
            this.txtOdaNo.Location = new System.Drawing.Point(140, 229);
            this.txtOdaNo.MaxLength = 3;
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(195, 20);
            this.txtOdaNo.TabIndex = 30;
            // 
            // txtKimlik
            // 
            this.txtKimlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKimlik.Location = new System.Drawing.Point(140, 193);
            this.txtKimlik.MaxLength = 11;
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Size = new System.Drawing.Size(195, 20);
            this.txtKimlik.TabIndex = 29;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMail.Location = new System.Drawing.Point(140, 157);
            this.txtMail.MaxLength = 30;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(195, 20);
            this.txtMail.TabIndex = 28;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoyadi.Location = new System.Drawing.Point(140, 52);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(195, 20);
            this.txtSoyadi.TabIndex = 27;
            // 
            // txtAdi
            // 
            this.txtAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAdi.Location = new System.Drawing.Point(140, 17);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(195, 20);
            this.txtAdi.TabIndex = 26;
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisTarihi.Location = new System.Drawing.Point(29, 335);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(102, 22);
            this.lblCikisTarihi.TabIndex = 25;
            this.lblCikisTarihi.Text = "Çıkış Tarihi:";
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisTarihi.Location = new System.Drawing.Point(34, 300);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(100, 22);
            this.lblGirisTarihi.TabIndex = 24;
            this.lblGirisTarihi.Text = "Giriş Tarihi:";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNo.Location = new System.Drawing.Point(58, 226);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(71, 22);
            this.lblOdaNo.TabIndex = 23;
            this.lblOdaNo.Text = "Oda No:";
            // 
            // lblKimlik
            // 
            this.lblKimlik.AutoSize = true;
            this.lblKimlik.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKimlik.Location = new System.Drawing.Point(3, 190);
            this.lblKimlik.Name = "lblKimlik";
            this.lblKimlik.Size = new System.Drawing.Size(126, 22);
            this.lblKimlik.TabIndex = 22;
            this.lblKimlik.Text = "T.C. Kimlik No:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(81, 154);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 22);
            this.lblMail.TabIndex = 21;
            this.lblMail.Text = "Mail:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(59, 118);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(70, 22);
            this.lblTelefon.TabIndex = 20;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadi.Location = new System.Drawing.Point(59, 52);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(65, 22);
            this.lblSoyadi.TabIndex = 19;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(81, 16);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(41, 22);
            this.lblAdi.TabIndex = 18;
            this.lblAdi.Text = "Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOda109);
            this.groupBox2.Controls.Add(this.btnOda108);
            this.groupBox2.Controls.Add(this.btnOda107);
            this.groupBox2.Controls.Add(this.btnOda106);
            this.groupBox2.Controls.Add(this.btnOda105);
            this.groupBox2.Controls.Add(this.btnOda104);
            this.groupBox2.Controls.Add(this.btnOda103);
            this.groupBox2.Controls.Add(this.btnOda102);
            this.groupBox2.Controls.Add(this.btnOda101);
            this.groupBox2.Location = new System.Drawing.Point(383, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // btnOda109
            // 
            this.btnOda109.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda109.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda109.Location = new System.Drawing.Point(197, 135);
            this.btnOda109.Name = "btnOda109";
            this.btnOda109.Size = new System.Drawing.Size(84, 61);
            this.btnOda109.TabIndex = 8;
            this.btnOda109.Text = "109";
            this.btnOda109.UseVisualStyleBackColor = false;
            this.btnOda109.Click += new System.EventHandler(this.btnOda109_Click);
            // 
            // btnOda108
            // 
            this.btnOda108.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda108.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda108.Location = new System.Drawing.Point(113, 135);
            this.btnOda108.Name = "btnOda108";
            this.btnOda108.Size = new System.Drawing.Size(84, 61);
            this.btnOda108.TabIndex = 7;
            this.btnOda108.Text = "108";
            this.btnOda108.UseVisualStyleBackColor = false;
            this.btnOda108.Click += new System.EventHandler(this.btnOda108_Click);
            // 
            // btnOda107
            // 
            this.btnOda107.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda107.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda107.Location = new System.Drawing.Point(29, 135);
            this.btnOda107.Name = "btnOda107";
            this.btnOda107.Size = new System.Drawing.Size(84, 61);
            this.btnOda107.TabIndex = 6;
            this.btnOda107.Text = "107";
            this.btnOda107.UseVisualStyleBackColor = false;
            this.btnOda107.Click += new System.EventHandler(this.btnOda107_Click);
            // 
            // btnOda106
            // 
            this.btnOda106.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda106.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda106.Location = new System.Drawing.Point(197, 77);
            this.btnOda106.Name = "btnOda106";
            this.btnOda106.Size = new System.Drawing.Size(84, 61);
            this.btnOda106.TabIndex = 5;
            this.btnOda106.Text = "106";
            this.btnOda106.UseVisualStyleBackColor = false;
            this.btnOda106.Click += new System.EventHandler(this.btnOda106_Click);
            // 
            // btnOda105
            // 
            this.btnOda105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda105.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda105.Location = new System.Drawing.Point(113, 77);
            this.btnOda105.Name = "btnOda105";
            this.btnOda105.Size = new System.Drawing.Size(84, 61);
            this.btnOda105.TabIndex = 4;
            this.btnOda105.Text = "105";
            this.btnOda105.UseVisualStyleBackColor = false;
            this.btnOda105.Click += new System.EventHandler(this.btnOda105_Click);
            // 
            // btnOda104
            // 
            this.btnOda104.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda104.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda104.Location = new System.Drawing.Point(29, 77);
            this.btnOda104.Name = "btnOda104";
            this.btnOda104.Size = new System.Drawing.Size(84, 61);
            this.btnOda104.TabIndex = 3;
            this.btnOda104.Text = "104";
            this.btnOda104.UseVisualStyleBackColor = false;
            this.btnOda104.Click += new System.EventHandler(this.btnOda104_Click);
            // 
            // btnOda103
            // 
            this.btnOda103.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda103.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda103.Location = new System.Drawing.Point(197, 19);
            this.btnOda103.Name = "btnOda103";
            this.btnOda103.Size = new System.Drawing.Size(84, 61);
            this.btnOda103.TabIndex = 2;
            this.btnOda103.Text = "103";
            this.btnOda103.UseVisualStyleBackColor = false;
            this.btnOda103.Click += new System.EventHandler(this.btnOda103_Click);
            // 
            // btnOda102
            // 
            this.btnOda102.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda102.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda102.Location = new System.Drawing.Point(113, 19);
            this.btnOda102.Name = "btnOda102";
            this.btnOda102.Size = new System.Drawing.Size(84, 61);
            this.btnOda102.TabIndex = 1;
            this.btnOda102.Text = "102";
            this.btnOda102.UseVisualStyleBackColor = false;
            this.btnOda102.Click += new System.EventHandler(this.btnOda102_Click);
            // 
            // btnOda101
            // 
            this.btnOda101.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOda101.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOda101.Location = new System.Drawing.Point(29, 19);
            this.btnOda101.Name = "btnOda101";
            this.btnOda101.Size = new System.Drawing.Size(84, 61);
            this.btnOda101.TabIndex = 0;
            this.btnOda101.Text = "101";
            this.btnOda101.UseVisualStyleBackColor = false;
            this.btnOda101.Click += new System.EventHandler(this.btnOda101_Click);
            // 
            // btnBosOda
            // 
            this.btnBosOda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBosOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosOda.Location = new System.Drawing.Point(466, 241);
            this.btnBosOda.Name = "btnBosOda";
            this.btnBosOda.Size = new System.Drawing.Size(56, 33);
            this.btnBosOda.TabIndex = 9;
            this.btnBosOda.Text = "Boş";
            this.btnBosOda.UseVisualStyleBackColor = false;
            this.btnBosOda.Click += new System.EventHandler(this.btnBosOda_Click);
            // 
            // btnDoluOda
            // 
            this.btnDoluOda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDoluOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoluOda.Location = new System.Drawing.Point(546, 241);
            this.btnDoluOda.Name = "btnDoluOda";
            this.btnDoluOda.Size = new System.Drawing.Size(56, 33);
            this.btnDoluOda.TabIndex = 10;
            this.btnDoluOda.Text = "Dolu";
            this.btnDoluOda.UseVisualStyleBackColor = false;
            this.btnDoluOda.Click += new System.EventHandler(this.btnDoluOda_Click);
            // 
            // FormYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(148)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(755, 453);
            this.Controls.Add(this.btnDoluOda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBosOda);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYeniMusteri";
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.FormYeniMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dateTPCikisTarihi;
        private System.Windows.Forms.DateTimePicker dateTPGirisTarihi;
        private System.Windows.Forms.MaskedTextBox maskTxtTelefon;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label lblKimlik;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOda109;
        private System.Windows.Forms.Button btnOda108;
        private System.Windows.Forms.Button btnOda107;
        private System.Windows.Forms.Button btnOda106;
        private System.Windows.Forms.Button btnOda105;
        private System.Windows.Forms.Button btnOda104;
        private System.Windows.Forms.Button btnOda103;
        private System.Windows.Forms.Button btnOda102;
        private System.Windows.Forms.Button btnOda101;
        private System.Windows.Forms.Button btnBosOda;
        private System.Windows.Forms.Button btnDoluOda;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblGun;
    }
}