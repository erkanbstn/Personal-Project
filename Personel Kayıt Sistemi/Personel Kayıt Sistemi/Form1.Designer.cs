
namespace Personel_Kayıt_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbe = new System.Windows.Forms.RadioButton();
            this.rdev = new System.Windows.Forms.RadioButton();
            this.cmbseh = new System.Windows.Forms.ComboBox();
            this.mskdmaas = new System.Windows.Forms.MaskedTextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textmes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textsad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngraf = new System.Windows.Forms.Button();
            this.btngün = new System.Windows.Forms.Button();
            this.btntem = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkay = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.rdbe);
            this.groupBox1.Controls.Add(this.rdev);
            this.groupBox1.Controls.Add(this.cmbseh);
            this.groupBox1.Controls.Add(this.mskdmaas);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textmes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textsad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 388);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt ";
            // 
            // rdbe
            // 
            this.rdbe.AutoSize = true;
            this.rdbe.Location = new System.Drawing.Point(312, 264);
            this.rdbe.Name = "rdbe";
            this.rdbe.Size = new System.Drawing.Size(120, 35);
            this.rdbe.TabIndex = 7;
            this.rdbe.TabStop = true;
            this.rdbe.Text = "Bekar";
            this.rdbe.UseVisualStyleBackColor = true;
            this.rdbe.CheckedChanged += new System.EventHandler(this.rdbe_CheckedChanged);
            // 
            // rdev
            // 
            this.rdev.AutoSize = true;
            this.rdev.Location = new System.Drawing.Point(216, 264);
            this.rdev.Name = "rdev";
            this.rdev.Size = new System.Drawing.Size(103, 35);
            this.rdev.TabIndex = 6;
            this.rdev.TabStop = true;
            this.rdev.Text = "Evli";
            this.rdev.UseVisualStyleBackColor = true;
            this.rdev.CheckedChanged += new System.EventHandler(this.rdev_CheckedChanged);
            // 
            // cmbseh
            // 
            this.cmbseh.FormattingEnabled = true;
            this.cmbseh.Location = new System.Drawing.Point(216, 178);
            this.cmbseh.Name = "cmbseh";
            this.cmbseh.Size = new System.Drawing.Size(199, 38);
            this.cmbseh.TabIndex = 4;
            // 
            // mskdmaas
            // 
            this.mskdmaas.Location = new System.Drawing.Point(216, 217);
            this.mskdmaas.Mask = "0000";
            this.mskdmaas.Name = "mskdmaas";
            this.mskdmaas.Size = new System.Drawing.Size(199, 38);
            this.mskdmaas.TabIndex = 5;
            this.mskdmaas.ValidatingType = typeof(int);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(495, 540);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 38);
            this.textBox10.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "PerMeslek :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "PerDurum :";
            // 
            // textmes
            // 
            this.textmes.Location = new System.Drawing.Point(216, 297);
            this.textmes.Name = "textmes";
            this.textmes.Size = new System.Drawing.Size(199, 38);
            this.textmes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "PerMaaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "PerŞehir :";
            // 
            // textsad
            // 
            this.textsad.Location = new System.Drawing.Point(216, 138);
            this.textsad.Name = "textsad";
            this.textsad.Size = new System.Drawing.Size(199, 38);
            this.textsad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "PerSoyad :";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(216, 98);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(199, 38);
            this.textad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "PerAd :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(216, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(199, 38);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cyan;
            this.groupBox2.Controls.Add(this.btngraf);
            this.groupBox2.Controls.Add(this.btngün);
            this.groupBox2.Controls.Add(this.btntem);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkay);
            this.groupBox2.Location = new System.Drawing.Point(506, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 388);
            this.groupBox2.TabIndex = 257;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btngraf
            // 
            this.btngraf.BackColor = System.Drawing.Color.Teal;
            this.btngraf.ForeColor = System.Drawing.Color.FloralWhite;
            this.btngraf.Location = new System.Drawing.Point(61, 280);
            this.btngraf.Name = "btngraf";
            this.btngraf.Size = new System.Drawing.Size(209, 42);
            this.btngraf.TabIndex = 27;
            this.btngraf.Text = "Grafikler";
            this.btngraf.UseVisualStyleBackColor = false;
            this.btngraf.Click += new System.EventHandler(this.btngraf_Click);
            // 
            // btngün
            // 
            this.btngün.BackColor = System.Drawing.Color.Teal;
            this.btngün.ForeColor = System.Drawing.Color.FloralWhite;
            this.btngün.Location = new System.Drawing.Point(61, 232);
            this.btngün.Name = "btngün";
            this.btngün.Size = new System.Drawing.Size(209, 42);
            this.btngün.TabIndex = 26;
            this.btngün.Text = "Güncelle";
            this.btngün.UseVisualStyleBackColor = false;
            this.btngün.Click += new System.EventHandler(this.btngün_Click);
            // 
            // btntem
            // 
            this.btntem.BackColor = System.Drawing.Color.Teal;
            this.btntem.ForeColor = System.Drawing.Color.FloralWhite;
            this.btntem.Location = new System.Drawing.Point(61, 184);
            this.btntem.Name = "btntem";
            this.btntem.Size = new System.Drawing.Size(209, 42);
            this.btntem.TabIndex = 24;
            this.btntem.Text = "Temizle";
            this.btntem.UseVisualStyleBackColor = false;
            this.btntem.Click += new System.EventHandler(this.btntem_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Teal;
            this.btnsil.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnsil.Location = new System.Drawing.Point(61, 131);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(209, 42);
            this.btnsil.TabIndex = 23;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkay
            // 
            this.btnkay.BackColor = System.Drawing.Color.Teal;
            this.btnkay.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnkay.Location = new System.Drawing.Point(61, 83);
            this.btnkay.Name = "btnkay";
            this.btnkay.Size = new System.Drawing.Size(209, 42);
            this.btnkay.TabIndex = 22;
            this.btnkay.Text = "Kaydet";
            this.btnkay.UseVisualStyleBackColor = false;
            this.btnkay.Click += new System.EventHandler(this.btnkay_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1029, 255);
            this.groupBox3.TabIndex = 265;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(864, -17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(836, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 266;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1053, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbe;
        private System.Windows.Forms.RadioButton rdev;
        private System.Windows.Forms.ComboBox cmbseh;
        private System.Windows.Forms.MaskedTextBox mskdmaas;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textmes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textsad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngraf;
        private System.Windows.Forms.Button btngün;
        private System.Windows.Forms.Button btntem;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

