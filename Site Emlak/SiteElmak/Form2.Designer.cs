
namespace SiteElmak
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSatKira = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxMetre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNotlar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxTelefon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxBlok = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxNo = new System.Windows.Forms.TextBox();
            this.btnAkbey = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCakir = new System.Windows.Forms.Button();
            this.btnKarahan = new System.Windows.Forms.Button();
            this.btnKilic = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gayrimenkul Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F);
            this.label2.Location = new System.Drawing.Point(57, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Items.AddRange(new object[] {
            "Akbey Sitesi",
            "Çakır Sitesi",
            "Karahan Sitesi",
            "Kılıç Sitesi"});
            this.comboBoxSite.Location = new System.Drawing.Point(176, 110);
            this.comboBoxSite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(207, 32);
            this.comboBoxSite.TabIndex = 2;
            this.comboBoxSite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F);
            this.label3.Location = new System.Drawing.Point(57, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sat/Kira";
            // 
            // comboBoxSatKira
            // 
            this.comboBoxSatKira.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxSatKira.FormattingEnabled = true;
            this.comboBoxSatKira.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.comboBoxSatKira.Location = new System.Drawing.Point(176, 148);
            this.comboBoxSatKira.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSatKira.Name = "comboBoxSatKira";
            this.comboBoxSatKira.Size = new System.Drawing.Size(207, 32);
            this.comboBoxSatKira.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11F);
            this.label4.Location = new System.Drawing.Point(57, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oda Sayısı";
            // 
            // comboBoxOda
            // 
            this.comboBoxOda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxOda.FormattingEnabled = true;
            this.comboBoxOda.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
            this.comboBoxOda.Location = new System.Drawing.Point(176, 185);
            this.comboBoxOda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxOda.Name = "comboBoxOda";
            this.comboBoxOda.Size = new System.Drawing.Size(207, 32);
            this.comboBoxOda.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11F);
            this.label5.Location = new System.Drawing.Point(57, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Metrekare";
            // 
            // txtBoxMetre
            // 
            this.txtBoxMetre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxMetre.Location = new System.Drawing.Point(176, 226);
            this.txtBoxMetre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxMetre.Name = "txtBoxMetre";
            this.txtBoxMetre.Size = new System.Drawing.Size(207, 30);
            this.txtBoxMetre.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F);
            this.label6.Location = new System.Drawing.Point(57, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fiyat";
            // 
            // txtBoxFiyat
            // 
            this.txtBoxFiyat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxFiyat.Location = new System.Drawing.Point(176, 263);
            this.txtBoxFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxFiyat.Name = "txtBoxFiyat";
            this.txtBoxFiyat.Size = new System.Drawing.Size(207, 30);
            this.txtBoxFiyat.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11F);
            this.label7.Location = new System.Drawing.Point(452, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notlar";
            // 
            // txtBoxNotlar
            // 
            this.txtBoxNotlar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxNotlar.Location = new System.Drawing.Point(564, 159);
            this.txtBoxNotlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNotlar.Multiline = true;
            this.txtBoxNotlar.Name = "txtBoxNotlar";
            this.txtBoxNotlar.Size = new System.Drawing.Size(227, 107);
            this.txtBoxNotlar.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15F);
            this.label8.Location = new System.Drawing.Point(427, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "İletişim Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11F);
            this.label9.Location = new System.Drawing.Point(452, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ad Soyad";
            // 
            // txtBoxAdSoyad
            // 
            this.txtBoxAdSoyad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxAdSoyad.Location = new System.Drawing.Point(564, 76);
            this.txtBoxAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxAdSoyad.Name = "txtBoxAdSoyad";
            this.txtBoxAdSoyad.Size = new System.Drawing.Size(227, 30);
            this.txtBoxAdSoyad.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F);
            this.label10.Location = new System.Drawing.Point(452, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefon";
            // 
            // txtBoxTelefon
            // 
            this.txtBoxTelefon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxTelefon.Location = new System.Drawing.Point(564, 119);
            this.txtBoxTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxTelefon.Name = "txtBoxTelefon";
            this.txtBoxTelefon.Size = new System.Drawing.Size(227, 30);
            this.txtBoxTelefon.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11F);
            this.label11.Location = new System.Drawing.Point(77, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 22);
            this.label11.TabIndex = 18;
            this.label11.Text = "Blok";
            // 
            // comboBoxBlok
            // 
            this.comboBoxBlok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxBlok.FormattingEnabled = true;
            this.comboBoxBlok.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxBlok.Location = new System.Drawing.Point(131, 319);
            this.comboBoxBlok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBlok.Name = "comboBoxBlok";
            this.comboBoxBlok.Size = new System.Drawing.Size(64, 32);
            this.comboBoxBlok.TabIndex = 19;
            this.comboBoxBlok.SelectedIndexChanged += new System.EventHandler(this.comboBoxBlok_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11F);
            this.label12.Location = new System.Drawing.Point(252, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "No";
            // 
            // txtBoxNo
            // 
            this.txtBoxNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxNo.Location = new System.Drawing.Point(292, 321);
            this.txtBoxNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNo.Name = "txtBoxNo";
            this.txtBoxNo.Size = new System.Drawing.Size(64, 30);
            this.txtBoxNo.TabIndex = 21;
            // 
            // btnAkbey
            // 
            this.btnAkbey.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAkbey.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAkbey.Location = new System.Drawing.Point(929, 33);
            this.btnAkbey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAkbey.Name = "btnAkbey";
            this.btnAkbey.Size = new System.Drawing.Size(117, 54);
            this.btnAkbey.TabIndex = 22;
            this.btnAkbey.Text = "Akbey";
            this.btnAkbey.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F);
            this.label13.Location = new System.Drawing.Point(955, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 27);
            this.label13.TabIndex = 23;
            this.label13.Text = "Site";
            // 
            // btnCakir
            // 
            this.btnCakir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCakir.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnCakir.Location = new System.Drawing.Point(824, 97);
            this.btnCakir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCakir.Name = "btnCakir";
            this.btnCakir.Size = new System.Drawing.Size(109, 54);
            this.btnCakir.TabIndex = 24;
            this.btnCakir.Text = "Çakır";
            this.btnCakir.UseVisualStyleBackColor = false;
            // 
            // btnKarahan
            // 
            this.btnKarahan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKarahan.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnKarahan.Location = new System.Drawing.Point(929, 156);
            this.btnKarahan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKarahan.Name = "btnKarahan";
            this.btnKarahan.Size = new System.Drawing.Size(117, 54);
            this.btnKarahan.TabIndex = 25;
            this.btnKarahan.Text = "Karahan";
            this.btnKarahan.UseVisualStyleBackColor = false;
            // 
            // btnKilic
            // 
            this.btnKilic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKilic.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btnKilic.Location = new System.Drawing.Point(1037, 97);
            this.btnKilic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKilic.Name = "btnKilic";
            this.btnKilic.Size = new System.Drawing.Size(109, 54);
            this.btnKilic.TabIndex = 26;
            this.btnKilic.Text = "Kılıç";
            this.btnKilic.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(52, 446);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1039, 287);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "site";
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "satkira";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "oda";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "metre";
            this.columnHeader5.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "fiyat";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "blok";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "no";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "adsoyad";
            this.columnHeader9.Width = 102;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "telefon";
            this.columnHeader10.Width = 148;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "notlar";
            this.columnHeader11.Width = 84;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(176, 407);
            this.btnGoruntule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(85, 33);
            this.btnGoruntule.TabIndex = 28;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(408, 407);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 33);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(627, 407);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 33);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11F);
            this.label14.Location = new System.Drawing.Point(57, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 22);
            this.label14.TabIndex = 32;
            this.label14.Text = "Id";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtBoxId.Location = new System.Drawing.Point(176, 73);
            this.txtBoxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(207, 30);
            this.txtBoxId.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_A.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_A.Location = new System.Drawing.Point(893, 271);
            this.btn_A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(48, 48);
            this.btn_A.TabIndex = 35;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_B.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_B.Location = new System.Drawing.Point(941, 271);
            this.btn_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(48, 48);
            this.btn_B.TabIndex = 36;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = false;
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_C.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_C.Location = new System.Drawing.Point(989, 271);
            this.btn_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(48, 48);
            this.btn_C.TabIndex = 37;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_D.Font = new System.Drawing.Font("Arial", 13.8F);
            this.btn_D.Location = new System.Drawing.Point(1037, 271);
            this.btn_D.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(48, 48);
            this.btn_D.TabIndex = 38;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15F);
            this.label15.Location = new System.Drawing.Point(955, 239);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 28);
            this.label15.TabIndex = 39;
            this.label15.Text = "Blok";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 757);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnKilic);
            this.Controls.Add(this.btnKarahan);
            this.Controls.Add(this.btnCakir);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAkbey);
            this.Controls.Add(this.txtBoxNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxBlok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBoxTelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxNotlar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxMetre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxOda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSatKira);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSatKira;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxMetre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxNotlar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxTelefon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxBlok;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxNo;
        private System.Windows.Forms.Button btnAkbey;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCakir;
        private System.Windows.Forms.Button btnKarahan;
        private System.Windows.Forms.Button btnKilic;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Label label15;
    }
}