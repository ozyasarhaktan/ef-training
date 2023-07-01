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

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrenciAd.Text;
            var sorgu = from item in db.TBL_OGRENCI
                        where item.ogrenciAd.Contains(aranan)
                        select item;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-615L31L\NATKAH;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from TBL_DERSLER", sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource=db.TBL_OGRENCI.ToList();
            //dataGridView1.Columns[3].Visible = false;    Yöntem 1
            //dataGridView1.Columns[4].Visible = false;    Yöntem 1

            var query = from item in db.TBL_OGRENCI
                        select new
                        {
                            item.ogrenciID,
                            item.ogrenciAd,
                            item.ogrenciSoyad
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            //var query = from item in db.TBL_NOTLAR
            //            select new
            //            {
            //                item.notID,
            //                item.ogrenci,
            //                item.ders,
            //                item.sinav1,
            //                item.sinav2,
            //                item.sinav3,
            //                item.ortalama,
            //                item.durum
            //            };

            //yukarıdaki yerine join kullanmadan öğrenciID yerine Öğrenci ad ve soyadı ; dersID yerine ise ders adı getirebiliriz

            var query = from item in db.TBL_NOTLAR
                        select new
                        {
                            item.notID,
                            Ad_Soyad = item.TBL_OGRENCI.ogrenciAd + " " + item.TBL_OGRENCI.ogrenciSoyad,
                            Ders_Adi = item.TBL_DERSLER.dersAd,
                            item.sinav1,
                            item.sinav2,
                            item.sinav3,
                            item.ortalama,
                            item.durum


                        };
            dataGridView1.DataSource = query.ToList();
            //dataGridView1.DataSource = db.TBL_NOTLAR.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBL_OGRENCI tOgr = new TBL_OGRENCI();
            tOgr.ogrenciAd = txtOgrenciAd.Text;
            tOgr.ogrenciSoyad = txtOgrenciSoyad.Text;
            db.TBL_OGRENCI.Add(tOgr);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Listeye Eklenmiştir!");
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            TBL_DERSLER tDers = new TBL_DERSLER();
            tDers.dersAd = txtDersAd.Text;
            db.TBL_DERSLER.Add(tDers);
            db.SaveChanges();
            MessageBox.Show("Ders Listeye Eklenmiştir!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciID.Text);
            var x = db.TBL_OGRENCI.Find(id);
            db.TBL_OGRENCI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Sistemden Silindi!");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciID.Text);
            var x = db.TBL_OGRENCI.Find(id);
            x.ogrenciAd = txtOgrenciAd.Text;
            x.ogrenciSoyad = txtOgrenciSoyad.Text;
            x.ogrenciFotograf = txtOgrenciFotograf.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi!..");

        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.notListesi();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBL_OGRENCI.Where(x => x.ogrenciAd == txtOgrenciAd.Text || x.ogrenciSoyad == txtOgrenciSoyad.Text).ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                // ASC sıralanmış listenin elemanları
                List<TBL_OGRENCI> liste1 = db.TBL_OGRENCI.OrderBy(x => x.ogrenciAd).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked == true)
            {
                // DESC sıralanmış listenin elemanları
                List<TBL_OGRENCI> liste2 = db.TBL_OGRENCI.OrderByDescending(x => x.ogrenciAd).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (radioButton3.Checked == true)
            {
                // ASC sıralanmış listenin ilk üç elemanı
                List<TBL_OGRENCI> liste3 = db.TBL_OGRENCI.OrderBy(p => p.ogrenciAd).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if (radioButton4.Checked == true)
            {
                // ID'ye göre veri getirme
                //  .As.Enumerable koymamın sebebi dışarıdaki textten aldığım ifadeyi int'e çevirmemesiydi.
                List<TBL_OGRENCI> liste4 = db.TBL_OGRENCI.AsEnumerable().Where(p => p.ogrenciID == int.Parse(txtOgrenciID.Text)).ToList();
                dataGridView1.DataSource = liste4;
            }
            if (radioButton5.Checked == true)
            {
                // A ile başlayanlar
                List<TBL_OGRENCI> liste5 = db.TBL_OGRENCI.Where(p => p.ogrenciAd.StartsWith("a")).ToList();
                dataGridView1.DataSource = liste5;
            }
            if (radioButton6.Checked == true)
            {
                // A ile bitenler
                List<TBL_OGRENCI> liste6 = db.TBL_OGRENCI.Where(p => p.ogrenciAd.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste6;
            }
            if (radioButton7.Checked == true)
            {
                //DEĞER KONTROLÜ
                bool deger = db.TBL_KULUPLER.Any();
                if (deger == true)
                {
                    MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(deger.ToString(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radioButton8.Checked == true)
            {
                //DEĞER VARSA ÖĞRENCİ SAYISI
                bool deger = db.TBL_OGRENCI.Any();
                int sayi = 0;
                if (deger == true)
                {
                    sayi = db.TBL_OGRENCI.Count();
                    MessageBox.Show(sayi + " öğrenci var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(0 + " öğrenci var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (radioButton9.Checked == true)
            {
                //TOPLAM SINAV 1 puanı
                //int toplam = db.TBL_NOTLAR.Sum(p => p.sinav1).Value;
                //MessageBox.Show("Toplam Sınav1 puanı : " + toplam);
                //onun yerine aşağıdaki gibi yapılabilir :
                var toplam = db.TBL_NOTLAR.Sum(p => p.sinav1);
                MessageBox.Show("Toplam Sınav1 puanı : " + toplam.ToString());
            }
            if (radioButton10.Checked == true)
            {
                //ortalama SINAV 1 puanı
                double ortalama = db.TBL_NOTLAR.Average(p => p.sinav1).Value;
                MessageBox.Show("Ortalama Sınav1 puanı : " + ortalama);

                //onun yerine aşağıdaki gibi yapılabilir :

                //var toplam = db.TBL_NOTLAR.Average(p => p.sinav1);
                //MessageBox.Show("Ortalama Sınav1 puanı : " + toplam.ToString());
            }
            if (radioButton11.Checked == true)
            {
                //sınav1 notu ortalamasından yüksek olan verileri getir 
                double ortalama = db.TBL_NOTLAR.Average(p => p.sinav1).Value;
                List<TBL_NOTLAR> liste6 = db.TBL_NOTLAR.Where(p => p.sinav1 > ortalama).ToList();
                dataGridView1.DataSource = liste6;
                MessageBox.Show("Ortalama Sınav1 puanı : " + ortalama);
            }
            if (radioButton12.Checked == true)
            {
                //sınav1 notu en yüksek olan sınav1 i getir
                int enYuksek = db.TBL_NOTLAR.Max(p => p.sinav1).Value;
                //dataGridView1.DataSource = db.TBL_NOTLAR.Where(p=> p.sinav1 == enYuksek).ToList();

                //yukarıdaki yerine ağaşıdaki de yapılabilir

                var query = from item in db.TBL_NOTLAR
                            where item.sinav1 == enYuksek
                            select new
                            {
                                item.TBL_OGRENCI.ogrenciAd,
                                item.sinav1
                            };
                dataGridView1.DataSource = query.ToList();
            }
            if (radioButton13.Checked == true)
            {
                //sınav1 notu en düşük olan sınav1 i getir
                int enDusuk = db.TBL_NOTLAR.Min(p => p.sinav1).Value;
                //dataGridView1.DataSource = db.TBL_NOTLAR.Where(p=> p.sinav1 == enDusuk).ToList();

                //yukarıdaki yerine ağaşıdaki de yapılabilir

                var query = from item in db.TBL_NOTLAR
                            where item.sinav1 == enDusuk
                            select new
                            {
                                item.TBL_OGRENCI.ogrenciAd,
                                item.sinav1
                            };
                dataGridView1.DataSource = query.ToList();
            }

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBL_NOTLAR
                        join d2 in db.TBL_OGRENCI
                        on d1.ogrenci equals d2.ogrenciID
                        join d3 in db.TBL_DERSLER
                        on d1.ders equals d3.dersID
                        where d1.sinav2.HasValue
                        select new
                        {
                            ÖĞRENCİ = d2.ogrenciAd + " " + d2.ogrenciSoyad,
                            d3.dersAd,
                            Sınav_1 = d1.sinav1,
                            Sınav_2 = d1.sinav2,
                            Sınav_3 = d1.sinav3,
                            Ortalama = d1.ortalama
                        };
            yukarıda sınav2 boş olmayan değerleri yazdırdım
            dataGridView1.DataSource = sorgu.ToList();

        }
    }
}
