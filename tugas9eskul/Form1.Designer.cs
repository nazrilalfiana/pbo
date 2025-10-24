namespace tugas9eskul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            ListPesanan = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtnama = new TextBox();
            comboUkuran = new ComboBox();
            btntambah = new Button();
            btnhapus = new Button();
            btnbatal = new Button();
            radioesteh = new RadioButton();
            radiothai = new RadioButton();
            radiohijau = new RadioButton();
            radiolemon = new RadioButton();
            txtjum = new TextBox();
            label4 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            button2 = new Button();
            label6 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListPesanan);
            groupBox1.Location = new Point(372, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Pesanan";
            // 
            // ListPesanan
            // 
            ListPesanan.FormattingEnabled = true;
            ListPesanan.ItemHeight = 15;
            ListPesanan.Location = new Point(0, 22);
            ListPesanan.Name = "ListPesanan";
            ListPesanan.Size = new Size(290, 304);
            ListPesanan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 71);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama Pembeli";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 178);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Ukuran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 115);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Menu";
            // 
            // txtnama
            // 
            txtnama.Location = new Point(166, 71);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(170, 23);
            txtnama.TabIndex = 11;
            // 
            // comboUkuran
            // 
            comboUkuran.FormattingEnabled = true;
            comboUkuran.Location = new Point(166, 178);
            comboUkuran.Name = "comboUkuran";
            comboUkuran.Size = new Size(170, 23);
            comboUkuran.TabIndex = 12;
            comboUkuran.SelectedIndexChanged += comboUkuran_SelectedIndexChanged;
            // 
            // btntambah
            // 
            btntambah.ForeColor = SystemColors.ActiveCaptionText;
            btntambah.Location = new Point(48, 385);
            btntambah.Name = "btntambah";
            btntambah.Size = new Size(75, 23);
            btntambah.TabIndex = 13;
            btntambah.Text = "Pesan";
            btntambah.UseVisualStyleBackColor = true;
            btntambah.Click += btntambah_Click;
            // 
            // btnhapus
            // 
            btnhapus.ForeColor = SystemColors.ActiveCaptionText;
            btnhapus.Location = new Point(372, 385);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(75, 23);
            btnhapus.TabIndex = 14;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = true;
            btnhapus.Visible = false;
            btnhapus.Click += btnhapus_Click;
            // 
            // btnbatal
            // 
            btnbatal.ForeColor = SystemColors.ActiveCaptionText;
            btnbatal.Location = new Point(166, 385);
            btnbatal.Name = "btnbatal";
            btnbatal.Size = new Size(75, 23);
            btnbatal.TabIndex = 15;
            btnbatal.Text = "Batal";
            btnbatal.UseVisualStyleBackColor = true;
            btnbatal.Click += btnbatal_Click;
            // 
            // radioesteh
            // 
            radioesteh.AutoSize = true;
            radioesteh.Location = new Point(166, 115);
            radioesteh.Name = "radioesteh";
            radioesteh.Size = new Size(56, 19);
            radioesteh.TabIndex = 16;
            radioesteh.TabStop = true;
            radioesteh.Text = "Es teh";
            radioesteh.UseVisualStyleBackColor = true;
            // 
            // radiothai
            // 
            radiothai.AutoSize = true;
            radiothai.Location = new Point(272, 115);
            radiothai.Name = "radiothai";
            radiothai.Size = new Size(69, 19);
            radiothai.TabIndex = 17;
            radiothai.TabStop = true;
            radiothai.Text = "Thai Tea";
            radiothai.UseVisualStyleBackColor = true;
            // 
            // radiohijau
            // 
            radiohijau.AutoSize = true;
            radiohijau.Location = new Point(166, 140);
            radiohijau.Name = "radiohijau";
            radiohijau.Size = new Size(75, 19);
            radiohijau.TabIndex = 18;
            radiohijau.TabStop = true;
            radiohijau.Text = "Teh Hijau";
            radiohijau.UseVisualStyleBackColor = true;
            // 
            // radiolemon
            // 
            radiolemon.AutoSize = true;
            radiolemon.Location = new Point(272, 140);
            radiolemon.Name = "radiolemon";
            radiolemon.Size = new Size(83, 19);
            radiolemon.TabIndex = 19;
            radiolemon.TabStop = true;
            radiolemon.Text = "Lemon Tea";
            radiolemon.UseVisualStyleBackColor = true;
            // 
            // txtjum
            // 
            txtjum.Location = new Point(166, 226);
            txtjum.MaxLength = 3;
            txtjum.Name = "txtjum";
            txtjum.Size = new Size(75, 23);
            txtjum.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 226);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 20;
            label4.Text = "Jumlah";
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(788, 385);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Bayar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Transfer", "Cash" });
            comboBox1.Location = new Point(691, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 24;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(689, 166);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 23;
            label5.Text = "Pilih Metode Bayar";
            label5.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(786, 122);
            textBox2.MaxLength = 0;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 28;
            textBox2.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(689, 125);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 27;
            label7.Text = "Uang Bayar";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Location = new Point(786, 79);
            textBox3.MaxLength = 3;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 30;
            textBox3.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(689, 79);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 29;
            label8.Text = "Total";
            label8.Visible = false;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(587, 385);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 31;
            button2.Text = "Lanjut";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 275);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 32;
            label6.Text = "Topping";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(166, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 19);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Biji Selasih";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(166, 300);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 19);
            checkBox2.TabIndex = 34;
            checkBox2.Text = "Cincau";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(272, 274);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(53, 19);
            checkBox3.TabIndex = 35;
            checkBox3.Text = "Boba";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(895, 517);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtjum);
            Controls.Add(label4);
            Controls.Add(radiolemon);
            Controls.Add(radiohijau);
            Controls.Add(radiothai);
            Controls.Add(radioesteh);
            Controls.Add(btnbatal);
            Controls.Add(btnhapus);
            Controls.Add(btntambah);
            Controls.Add(comboUkuran);
            Controls.Add(txtnama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Kedai Teh";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        //private CheckBox checkfutsal;
        //private CheckBox checkpolsis;
        private TextBox txtnama;
        private ComboBox comboUkuran;
        private Button btntambah;
        private Button btnhapus;
        private Button btnbatal;
        private ListBox ListPesanan;
        private RadioButton radioesteh;
        private RadioButton radiothai;
        private RadioButton radiohijau;
        private RadioButton radiolemon;
        private TextBox txtjum;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private Button button2;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}
