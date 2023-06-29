namespace EntityOrnek
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciFotograf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnProc = new System.Windows.Forms.Button();
            this.btnNotGuncelle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDersListesi = new System.Windows.Forms.Button();
            this.btnNotListesi = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(14, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciListele.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOgrenciListele.Location = new System.Drawing.Point(14, 312);
            this.btnOgrenciListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(204, 59);
            this.btnOgrenciListele.TabIndex = 1;
            this.btnOgrenciListele.Text = "Öğrenci Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnKaydet.Location = new System.Drawing.Point(14, 377);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(204, 57);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(14, 443);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(204, 57);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Coral;
            this.btnGuncelle.Location = new System.Drawing.Point(14, 507);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(204, 57);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBul.Location = new System.Drawing.Point(14, 572);
            this.btnBul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(204, 57);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.Location = new System.Drawing.Point(67, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(50, 28);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID :";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Location = new System.Drawing.Point(103, 41);
            this.txtOgrenciID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(162, 30);
            this.txtOgrenciID.TabIndex = 7;
            this.txtOgrenciID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(103, 86);
            this.txtOgrenciAd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(162, 30);
            this.txtOgrenciAd.TabIndex = 9;
            this.txtOgrenciAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "AD :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(103, 135);
            this.txtOgrenciSoyad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(162, 30);
            this.txtOgrenciSoyad.TabIndex = 11;
            this.txtOgrenciSoyad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "SOYAD :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOgrenciFotograf
            // 
            this.txtOgrenciFotograf.Location = new System.Drawing.Point(103, 184);
            this.txtOgrenciFotograf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOgrenciFotograf.Name = "txtOgrenciFotograf";
            this.txtOgrenciFotograf.Size = new System.Drawing.Size(162, 30);
            this.txtOgrenciFotograf.TabIndex = 13;
            this.txtOgrenciFotograf.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "FOTOGRAF :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.txtOgrenciFotograf);
            this.groupBox1.Controls.Add(this.txtOgrenciID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox1.Controls.Add(this.txtOgrenciAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(243, 315);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(276, 249);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDersEkle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDersID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDersAd);
            this.groupBox2.Location = new System.Drawing.Point(567, 315);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(276, 249);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders";
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDersEkle.Location = new System.Drawing.Point(48, 152);
            this.btnDersEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(204, 57);
            this.btnDersEkle.TabIndex = 19;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID :";
            // 
            // txtDersID
            // 
            this.txtDersID.Location = new System.Drawing.Point(103, 41);
            this.txtDersID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(162, 30);
            this.txtDersID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(60, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "AD :";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(103, 86);
            this.txtDersAd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(162, 30);
            this.txtDersAd.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnProc);
            this.groupBox3.Controls.Add(this.btnNotGuncelle);
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.txtDurum);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtOrtalama);
            this.groupBox3.Controls.Add(this.txtSinav1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSinav3);
            this.groupBox3.Controls.Add(this.txtSinav2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(235, 532);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(623, 292);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Not";
            // 
            // btnProc
            // 
            this.btnProc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProc.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnProc.Location = new System.Drawing.Point(15, 178);
            this.btnProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(204, 43);
            this.btnProc.TabIndex = 19;
            this.btnProc.Text = "Prodecure";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotGuncelle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnNotGuncelle.Location = new System.Drawing.Point(454, 151);
            this.btnNotGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(130, 59);
            this.btnNotGuncelle.TabIndex = 20;
            this.btnNotGuncelle.Text = "Sınav Notu Güncelle";
            this.btnNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnHesapla.Location = new System.Drawing.Point(307, 151);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(137, 59);
            this.btnHesapla.TabIndex = 19;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(422, 109);
            this.txtDurum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(162, 30);
            this.txtDurum.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(344, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "DURUM :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "SINAV 1 :";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(422, 66);
            this.txtOrtalama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(162, 30);
            this.txtOrtalama.TabIndex = 13;
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(103, 41);
            this.txtSinav1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(162, 30);
            this.txtSinav1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(287, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "ORTALAMA :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "SINAV 2 :";
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(103, 131);
            this.txtSinav3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(162, 30);
            this.txtSinav3.TabIndex = 11;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(103, 86);
            this.txtSinav2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(162, 30);
            this.txtSinav2.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "SINAV 3 :";
            // 
            // btnDersListesi
            // 
            this.btnDersListesi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersListesi.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnDersListesi.Location = new System.Drawing.Point(14, 641);
            this.btnDersListesi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDersListesi.Name = "btnDersListesi";
            this.btnDersListesi.Size = new System.Drawing.Size(204, 59);
            this.btnDersListesi.TabIndex = 17;
            this.btnDersListesi.Text = "Ders Listesi";
            this.btnDersListesi.UseVisualStyleBackColor = true;
            this.btnDersListesi.Click += new System.EventHandler(this.btnDersListesi_Click);
            // 
            // btnNotListesi
            // 
            this.btnNotListesi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotListesi.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnNotListesi.Location = new System.Drawing.Point(14, 710);
            this.btnNotListesi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNotListesi.Name = "btnNotListesi";
            this.btnNotListesi.Size = new System.Drawing.Size(204, 59);
            this.btnNotListesi.TabIndex = 18;
            this.btnNotListesi.Text = "Not Listesi";
            this.btnNotListesi.UseVisualStyleBackColor = true;
            this.btnNotListesi.Click += new System.EventHandler(this.btnNotListesi_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(893, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(239, 25);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala [a--> z]";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(906, 555);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(226, 74);
            this.btnLinqEntity.TabIndex = 20;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(893, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(239, 25);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala [z--> a]";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(893, 168);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 25);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk 3 kAYIT";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(893, 232);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(247, 30);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ID\'ye göre veri getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 772);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnNotListesi);
            this.Controls.Add(this.btnDersListesi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciFotograf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDersListesi;
        private System.Windows.Forms.Button btnNotListesi;
        private System.Windows.Forms.Button btnNotGuncelle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

