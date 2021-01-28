using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;

namespace Odev
{
	public partial class Form1 : Form
	{
		
		OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
			+ Application.StartupPath + "\\Database.mdb");

		OleDbCommand komut = new OleDbCommand();

		int selectedValue;

		public Form1()
		{
			InitializeComponent();
		}

		public void BilgilerGetir()
		{
			try
			{
				//Kullanicilar tablosundaki veriler çekiliyor
				baglantim.Open();
				OleDbDataAdapter komut = new OleDbDataAdapter("SELECT k.Kimlik,k.İsim,k.Soyisim,k.Email,k.DogumTarihi,u.UrunAd FROM tbl_kullanici as k INNER JOIN tbl_urunler as u ON k.UrunKimlik = u.Kimlik", baglantim);
				DataTable tablo = new DataTable();
				komut.Fill(tablo);
				dataGridView1.DataSource = tablo;
				baglantim.Close();

				//Combobox'a veriler çekiliyor
				OleDbCommand command = new OleDbCommand("SELECT UrunAd , Kimlik FROM tbl_urunler", baglantim);
				baglantim.Open();
				DataTable tb = new DataTable();
				tb.Load(command.ExecuteReader());
				baglantim.Close();
				comboBoxUrun.DataSource = tb;
				comboBoxUrun.DisplayMember = "UrunAd";
				comboBoxUrun.ValueMember = "Kimlik";
				baglantim.Close();

				//Urunler tablosuna veriler çekiliyor
				baglantim.Open();
				komut = new OleDbDataAdapter("select * from tbl_urunler", baglantim);
				tablo = new DataTable();
				komut.Fill(tablo);
				dataGridView2.DataSource = tablo;
				baglantim.Close();
			}
			catch (Exception aciklama)
			{
				MessageBox.Show(aciklama.Message, "Veri tabanı işlemleri");
				baglantim.Close();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			BilgilerGetir();
		}

		private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			lblUrunId.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
			txtUrunAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
			txtFiyat.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
			txtStok.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
			txtAciklama.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
		}

		private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			lblKullaniciId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
			txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			comboBoxUrun.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sorgu = "INSERT INTO tbl_kullanici(İsim,Soyisim,Email,DogumTarihi,UrunKimlik) values(@ad,@soyad,@email,@dtarih,@urunkimlik)";
			komut = new OleDbCommand(sorgu, baglantim);
			komut.Parameters.AddWithValue("@ad", txtAd.Text);
			komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
			komut.Parameters.AddWithValue("@email", txtEmail.Text);
			komut.Parameters.AddWithValue("@dtarih", dateTimePicker1.Value);
			komut.Parameters.AddWithValue("@urunkimlik", selectedValue);
			baglantim.Open();
			komut.ExecuteNonQuery();
			baglantim.Close();
			BilgilerGetir();
		}

		private void comboBoxUrun_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataRowView dr = (DataRowView) comboBoxUrun.SelectedItem;
			selectedValue = Convert.ToInt32(dr.Row.ItemArray[1]);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string sorgu = "DELETE FROM tbl_kullanici where Kimlik=@kimlik";
			komut = new OleDbCommand(sorgu, baglantim);
			komut.Parameters.AddWithValue("@kimlik", lblKullaniciId.Text);
			baglantim.Open();
			komut.ExecuteNonQuery();
			baglantim.Close();
			BilgilerGetir();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string sorgu = "UPDATE tbl_kullanici SET İsim=@ad , Soyisim=@soyad , Email=@email , DogumTarihi=@dtarih , UrunKimlik=@urunkimlik WHERE Kimlik=@kimlik";
			komut = new OleDbCommand(sorgu, baglantim);
			komut.Parameters.AddWithValue("@ad", txtAd.Text);
			komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
			komut.Parameters.AddWithValue("@email", txtEmail.Text);
			komut.Parameters.AddWithValue("@dtarih", dateTimePicker1.Value);
			komut.Parameters.AddWithValue("@urunkimlik", selectedValue);
			komut.Parameters.AddWithValue("@kimlik", lblKullaniciId.Text);
			baglantim.Open();
			komut.ExecuteNonQuery();
			baglantim.Close();
			BilgilerGetir();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			string sorgu = "INSERT INTO tbl_urunler(UrunAd,Fiyat,Stok,Açıklama) values(@ad,@fiyat,@stok,@aciklama)";
			komut = new OleDbCommand(sorgu, baglantim);
			komut.Parameters.AddWithValue("@ad", txtUrunAd.Text);
			komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
			komut.Parameters.AddWithValue("@stok", txtStok.Text);
			komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
			baglantim.Open();
			komut.ExecuteNonQuery();
			baglantim.Close();
			BilgilerGetir();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string sorgu = "DELETE FROM tbl_urunler where Kimlik=@kimlik";
			komut = new OleDbCommand(sorgu, baglantim);
			komut.Parameters.AddWithValue("@kimlik", lblUrunId.Text);
			baglantim.Open();
			komut.ExecuteNonQuery();
			baglantim.Close();
			BilgilerGetir();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string sorgu = "UPDATE tbl_urunler SET UrunAd=@ad , Fiyat=@fiyat , Stok=@stok , Açıklama=@aciklama WHERE Kimlik=@kimlik";
			komut = new OleDbCommand(sorgu, baglantim);
			komut.Parameters.AddWithValue("@ad", txtUrunAd.Text);
			komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
			komut.Parameters.AddWithValue("@stok", txtStok.Text);
			komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
			komut.Parameters.AddWithValue("@kimlik", lblUrunId.Text);
			baglantim.Open();
			komut.ExecuteNonQuery();
			baglantim.Close();
			BilgilerGetir();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//Kullanıcılar tablosu grafiği oluşturuluyor
			this.chart1.Titles.Add("Kullanıcı Yaş Ortalaması");
			List<string> isimler = new List<string>();
			List<DateTime> tarihler = new List<DateTime>();

			komut = new OleDbCommand("SELECT İsim,DogumTarihi FROM tbl_kullanici;",baglantim);
			baglantim.Open();

			OleDbDataReader reader = komut.ExecuteReader();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					isimler.Add(reader[0].ToString());
					tarihler.Add((DateTime) reader[1]);
				}
			}
			else
			{
				MessageBox.Show("Grafik Oluşturulamadı");
			}
			reader.Close();
			baglantim.Close();

			for (int i = 0; i < isimler.Count; i++)
			{
				Series sutunlar = this.chart1.Series.Add(isimler[i]);
				DateTime d = tarihler[i];
				int yas = (DateTime.Now.Year)- d.Year;
				sutunlar.Points.Add(yas);
			}

			//Ürünler tablosu grafiği oluşturuluyor
			this.chart2.Titles.Add("Ürün Fiyat Ortalaması");
			List<string> urunler = new List<string>();
			List<int> fiyatlar = new List<int>();

			komut = new OleDbCommand("SELECT UrunAd,Fiyat FROM tbl_urunler;", baglantim);
			baglantim.Open();

			OleDbDataReader r = komut.ExecuteReader();

			if (r.HasRows)
			{
				while (r.Read())
				{
					urunler.Add(r[0].ToString());
					fiyatlar.Add((int)r[1]);
				}
			}
			else
			{
				MessageBox.Show("Grafik Oluşturulamadı");
			}
			r.Close();
			baglantim.Close();

			for (int i = 0; i < urunler.Count; i++)
			{
				Series sutunlar2 = this.chart2.Series.Add(urunler[i]);
				sutunlar2.Points.Add(fiyatlar[i]);
			}
		}
	}
}
