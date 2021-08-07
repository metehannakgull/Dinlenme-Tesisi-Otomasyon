
namespace PansiyonOtomasyon
{
    partial class FormStoklar
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAtistirmalik = new System.Windows.Forms.TextBox();
            this.txtIcecekTutari = new System.Windows.Forms.TextBox();
            this.txtGidaTutari = new System.Windows.Forms.TextBox();
            this.lblAtistirmalik = new System.Windows.Forms.Label();
            this.lblIcecekTutari = new System.Windows.Forms.Label();
            this.lblGidaTutari = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.txtInternet = new System.Windows.Forms.TextBox();
            this.txtSu = new System.Windows.Forms.TextBox();
            this.txtElektrik = new System.Windows.Forms.TextBox();
            this.lblInternet = new System.Windows.Forms.Label();
            this.lblSu = new System.Windows.Forms.Label();
            this.lblElektrik = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtAtistirmalik);
            this.groupBox1.Controls.Add(this.txtIcecekTutari);
            this.groupBox1.Controls.Add(this.txtGidaTutari);
            this.groupBox1.Controls.Add(this.lblAtistirmalik);
            this.groupBox1.Controls.Add(this.lblIcecekTutari);
            this.groupBox1.Controls.Add(this.lblGidaTutari);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 328);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 222);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(277, 97);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalık";
            this.columnHeader3.Width = 92;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(185, 169);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(98, 36);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtAtistirmalik
            // 
            this.txtAtistirmalik.Location = new System.Drawing.Point(175, 128);
            this.txtAtistirmalik.Name = "txtAtistirmalik";
            this.txtAtistirmalik.Size = new System.Drawing.Size(129, 20);
            this.txtAtistirmalik.TabIndex = 13;
            // 
            // txtIcecekTutari
            // 
            this.txtIcecekTutari.Location = new System.Drawing.Point(175, 80);
            this.txtIcecekTutari.Name = "txtIcecekTutari";
            this.txtIcecekTutari.Size = new System.Drawing.Size(129, 20);
            this.txtIcecekTutari.TabIndex = 12;
            // 
            // txtGidaTutari
            // 
            this.txtGidaTutari.Location = new System.Drawing.Point(175, 26);
            this.txtGidaTutari.Name = "txtGidaTutari";
            this.txtGidaTutari.Size = new System.Drawing.Size(129, 20);
            this.txtGidaTutari.TabIndex = 11;
            // 
            // lblAtistirmalik
            // 
            this.lblAtistirmalik.AutoSize = true;
            this.lblAtistirmalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAtistirmalik.Location = new System.Drawing.Point(59, 129);
            this.lblAtistirmalik.Name = "lblAtistirmalik";
            this.lblAtistirmalik.Size = new System.Drawing.Size(88, 16);
            this.lblAtistirmalik.TabIndex = 10;
            this.lblAtistirmalik.Text = "Atıştırmalık:";
            // 
            // lblIcecekTutari
            // 
            this.lblIcecekTutari.AutoSize = true;
            this.lblIcecekTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcecekTutari.Location = new System.Drawing.Point(46, 80);
            this.lblIcecekTutari.Name = "lblIcecekTutari";
            this.lblIcecekTutari.Size = new System.Drawing.Size(102, 16);
            this.lblIcecekTutari.TabIndex = 9;
            this.lblIcecekTutari.Text = "İçecek Tutari:";
            // 
            // lblGidaTutari
            // 
            this.lblGidaTutari.AutoSize = true;
            this.lblGidaTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidaTutari.Location = new System.Drawing.Point(59, 26);
            this.lblGidaTutari.Name = "lblGidaTutari";
            this.lblGidaTutari.Size = new System.Drawing.Size(89, 16);
            this.lblGidaTutari.TabIndex = 8;
            this.lblGidaTutari.Text = "Gıda Tutarı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.btnKaydet2);
            this.groupBox2.Controls.Add(this.txtInternet);
            this.groupBox2.Controls.Add(this.txtSu);
            this.groupBox2.Controls.Add(this.txtElektrik);
            this.groupBox2.Controls.Add(this.lblInternet);
            this.groupBox2.Controls.Add(this.lblSu);
            this.groupBox2.Controls.Add(this.lblElektrik);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(377, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 318);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet2.Location = new System.Drawing.Point(162, 163);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(98, 36);
            this.btnKaydet2.TabIndex = 21;
            this.btnKaydet2.Text = "Kaydet";
            this.btnKaydet2.UseVisualStyleBackColor = true;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // txtInternet
            // 
            this.txtInternet.Location = new System.Drawing.Point(152, 122);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(129, 20);
            this.txtInternet.TabIndex = 20;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(152, 74);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(129, 20);
            this.txtSu.TabIndex = 19;
            // 
            // txtElektrik
            // 
            this.txtElektrik.Location = new System.Drawing.Point(152, 20);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(129, 20);
            this.txtElektrik.TabIndex = 18;
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInternet.Location = new System.Drawing.Point(36, 123);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(63, 16);
            this.lblInternet.TabIndex = 17;
            this.lblInternet.Text = "İnternet:";
            // 
            // lblSu
            // 
            this.lblSu.AutoSize = true;
            this.lblSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSu.Location = new System.Drawing.Point(69, 74);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(30, 16);
            this.lblSu.TabIndex = 16;
            this.lblSu.Text = "Su:";
            // 
            // lblElektrik
            // 
            this.lblElektrik.AutoSize = true;
            this.lblElektrik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElektrik.Location = new System.Drawing.Point(36, 20);
            this.lblElektrik.Name = "lblElektrik";
            this.lblElektrik.Size = new System.Drawing.Size(64, 16);
            this.lblElektrik.TabIndex = 15;
            this.lblElektrik.Text = "Elektrik:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(23, 205);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(277, 97);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 92;
            // 
            // FormStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(707, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStoklar";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.FormStoklar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAtistirmalik;
        private System.Windows.Forms.TextBox txtIcecekTutari;
        private System.Windows.Forms.TextBox txtGidaTutari;
        private System.Windows.Forms.Label lblAtistirmalik;
        private System.Windows.Forms.Label lblIcecekTutari;
        private System.Windows.Forms.Label lblGidaTutari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.TextBox txtInternet;
        private System.Windows.Forms.TextBox txtSu;
        private System.Windows.Forms.TextBox txtElektrik;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.Label lblElektrik;
    }
}