using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace tugas9eskul
{
    public partial class Form1 : Form
    {
        private List<string> daftarmenu = new List<string>();
        int sub = 0;
        private int tot = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboUkuran.Items.Add("Kecil");
            comboUkuran.Items.Add("Sedang");
            comboUkuran.Items.Add("Besar");
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            List<string> menudipilih = new List<string>();
            int harga = 0;
            int jumlah = int.Parse(txtjum.Text);
            string nama = txtnama.Text;
            if (radioesteh.Checked)
            {
                menudipilih.Add("Es Teh");
                harga = 5000;
                //textBox1.Text = harga.ToString();
            }
            else if (radiohijau.Checked)
            {
                menudipilih.Add("Teh Hijau");
                harga = 7000;
            }
            else if (radiolemon.Checked)
            {
                menudipilih.Add("Lemon Tea");
                harga = 6000;
            }
            else if (radiothai.Checked)
            {
                menudipilih.Add("Thai Tea");
                harga = 6500;
            }

            if (menudipilih.Count != 0 && comboUkuran.SelectedIndex == 0)
            {
                harga += 0;
            }
            else if (comboUkuran.SelectedIndex == 1)
            {
                harga += 1000;
            }
            else if (comboUkuran.SelectedIndex == 2)
            {
                harga += 2000;
            }

            if (menudipilih.Count == 0)
            {
                MessageBox.Show("Pilih Minimal 1 Menu!", "Peringatan");
                return;
            }
            if (string.IsNullOrEmpty(txtjum.Text))
            {
                jumlah = 1;
            }
            if (string.IsNullOrEmpty(txtnama.Text))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan");
                return;
            }

            string toping = "";
            sub = harga * jumlah;
            if (checkBox1.Checked)
            {
                toping += "Biji Selasih, ";
                sub += 500;
            }
            if (checkBox2.Checked)
            {
                toping += "Cincau, ";
                sub += 500;
            }
            if (checkBox3.Checked)
            {
                toping += "Boba, ";
                sub += 500;
            }
            if (toping.EndsWith(", "))
            {
                toping = toping.Substring(0, toping.Length - 2);
            }
            string data =
                $"{string.Join(",", menudipilih)} {string.Join(",", toping)}, " +
                $"{comboUkuran.Text} | Rp.{sub.ToString()}";
            ListPesanan.Items.Add(data);
            daftarmenu.Add(data);
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            tot += sub;

            if (ListPesanan.Items.Count != 0)
            {
                btnhapus.Visible = true;
                //button1.Visible = true;
                button2.Visible = true;
            }

            if (string.IsNullOrEmpty(nama)) 
            {
                MessageBox.Show("Nama Harus Diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnama.Focus();
            }
            if (comboUkuran.SelectedIndex == -1)
            {
                MessageBox.Show("Ukuran Harus Diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboUkuran.Focus();
            }
            if (!int.TryParse(txtjum.Text.Trim(), out jumlah))
            {
                MessageBox.Show("Jumlah Harus Angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtjum.Focus();
            }else if (string.IsNullOrEmpty(txtjum.Text))
            {
                jumlah = 1;
            }
            //rset input
            txtnama.ReadOnly = true;
            txtjum.Clear();
            radioesteh.Checked = false;
            radiohijau.Checked = false;
            radiolemon.Checked = false;
            radiothai.Checked = false;
            comboUkuran.SelectedIndex = -1;
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (ListPesanan.SelectedIndex != -1)
            {
                daftarmenu.RemoveAt(ListPesanan.SelectedIndex);
                ListPesanan.Items.RemoveAt(ListPesanan.SelectedIndex);

            }
            else
            {
                MessageBox.Show("Pilih Yang Akan Di Hapus!");
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            txtnama.Clear();
            radiothai.Checked = false;
            radiolemon.Checked = false;
            radiohijau.Checked = false;
            radioesteh.Checked = false;
            comboUkuran.SelectedIndex = -1;
            ListPesanan.Items.Clear();
            daftarmenu.Clear();

        }

        private void comboUkuran_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            btntambah.Text = "Kembali";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            textBox2.Focus();
            textBox3.Visible = true;
            label5.Visible = true;
            comboBox1.Visible = true;
            btnbatal.Visible = true;
            //int tot =+ sub;
            if (tot >= 100000)
            {
                MessageBox.Show(
                    "Karena total pembelian lebih dari Rp.100,000\n" +
                    "Maka anda mendapat diskon 10% !", "Pemberitahuan",
                    MessageBoxButtons.OK);
                tot -= (int)(tot * 0.1);
                textBox3.Text = tot.ToString();
            }
            else
            {
                textBox3.Text = tot.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}