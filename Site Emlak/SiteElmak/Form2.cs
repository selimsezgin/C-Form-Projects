using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiteElmak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source= -- ;Initial Catalog=siteler;Integrated Security=True"); // -- yerine server adı yazılmalıdır kullanılması gereken database dosyada mevcuttur

        private void verileriGoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Goster", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSite.Text == "Akbey Sitesi")
            {
                btnAkbey.BackColor = Color.Lime;
                btnCakir.BackColor = Color.Gray;
                btnKarahan.BackColor = Color.Gray;
                btnKilic.BackColor = Color.Gray;
            }
            
            else if (comboBoxSite.Text == "Çakır Sitesi")
            {
                btnAkbey.BackColor = Color.Gray;
                btnCakir.BackColor = Color.Lime;
                btnKarahan.BackColor = Color.Gray;
                btnKilic.BackColor = Color.Gray;
            }
            
            else if (comboBoxSite.Text == "Karahan Sitesi")
            {
                btnAkbey.BackColor = Color.Gray;
                btnCakir.BackColor = Color.Gray;
                btnKarahan.BackColor = Color.Lime;
                btnKilic.BackColor = Color.Gray;
            }
            
            else if (comboBoxSite.Text == "Kılıç Sitesi")
            {
                btnAkbey.BackColor = Color.Gray;
                btnCakir.BackColor = Color.Gray;
                btnKarahan.BackColor = Color.Gray;
                btnKilic.BackColor = Color.Lime;
            }
        }

        private void comboBoxBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBlok.Text == "A")
            {
                btn_A.BackColor = Color.Lime;
                btn_B.BackColor = Color.Gray;
                btn_C.BackColor = Color.Gray;
                btn_D.BackColor = Color.Gray;
            }

            else if (comboBoxBlok.Text == "B")
            {
                btn_A.BackColor = Color.Lime;
                btn_B.BackColor = Color.Gray;
                btn_C.BackColor = Color.Gray;
                btn_D.BackColor = Color.Gray;
            }

            else if (comboBoxBlok.Text == "C")
            {
                btn_A.BackColor = Color.Gray;
                btn_B.BackColor = Color.Gray;
                btn_C.BackColor = Color.Lime;
                btn_D.BackColor = Color.Gray;
            }

            else if (comboBoxBlok.Text == "D")
            {
                btn_A.BackColor = Color.Gray;
                btn_B.BackColor = Color.Gray;
                btn_C.BackColor = Color.Gray;
                btn_D.BackColor = Color.Lime;
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verileriGoster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("Kaydet", baglan);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("id", txtBoxId.Text); 
            komut.Parameters.AddWithValue("site", comboBoxSite.Text.ToString());
            komut.Parameters.AddWithValue("satkira", comboBoxSatKira.Text.ToString());
            komut.Parameters.AddWithValue("oda", comboBoxOda.Text.ToString());
            komut.Parameters.AddWithValue("metre", txtBoxMetre.Text.ToString());
            komut.Parameters.AddWithValue("fiyat", txtBoxFiyat.Text.ToString());
            komut.Parameters.AddWithValue("blok", comboBoxBlok.Text.ToString());
            komut.Parameters.AddWithValue("no", txtBoxNo.Text.ToString());
            komut.Parameters.AddWithValue("adsoyad", txtBoxAdSoyad.Text.ToString());
            komut.Parameters.AddWithValue("telefon", txtBoxTelefon.Text.ToString());
            komut.Parameters.AddWithValue("notlar", txtBoxNotlar.Text.ToString());

            komut.ExecuteNonQuery();
            baglan.Close();

            listView1.Items.Clear();
            verileriGoster();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Sil", baglan);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("id", txtBoxId.Text);

            komut.ExecuteNonQuery();
            baglan.Close();

            listView1.Items.Clear();
            verileriGoster();
        }

        int id = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtBoxId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBoxSite.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBoxSatKira.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxOda.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtBoxMetre.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtBoxFiyat.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBoxBlok.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtBoxNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtBoxAdSoyad.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtBoxTelefon.Text = listView1.SelectedItems[0].SubItems[9].Text;
            txtBoxNotlar.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtBoxId.Clear();
            comboBoxSite.ResetText();
            comboBoxSatKira.ResetText();
            comboBoxOda.ResetText();
            txtBoxMetre.Clear();
            txtBoxFiyat.Clear();
            comboBoxBlok.ResetText();
            txtBoxNo.Clear();
            txtBoxAdSoyad.Clear();
            txtBoxTelefon.Clear();
            txtBoxNotlar.Clear();

            btnAkbey.BackColor = Color.Gray;
            btnCakir.BackColor = Color.Gray;
            btnKarahan.BackColor = Color.Gray;
            btnKilic.BackColor = Color.Gray;

            btn_A.BackColor = Color.Gray;
            btn_B.BackColor = Color.Gray;
            btn_C.BackColor = Color.Gray;
            btn_D.BackColor = Color.Gray;
        }

    }
}
