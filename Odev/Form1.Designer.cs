
namespace Odev
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblKullaniciId = new System.Windows.Forms.Label();
			this.comboBoxUrun = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblUrunId = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.txtAciklama = new System.Windows.Forms.TextBox();
			this.txtFiyat = new System.Windows.Forms.TextBox();
			this.txtStok = new System.Windows.Forms.TextBox();
			this.txtUrunAd = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.button7 = new System.Windows.Forms.Button();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(9, 210);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(372, 150);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(105, 181);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Kullanıcılar Tablosu";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblKullaniciId);
			this.panel1.Controls.Add(this.comboBoxUrun);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.txtSoyad);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.txtAd);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(9, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(372, 163);
			this.panel1.TabIndex = 12;
			// 
			// lblKullaniciId
			// 
			this.lblKullaniciId.AutoSize = true;
			this.lblKullaniciId.Location = new System.Drawing.Point(4, 4);
			this.lblKullaniciId.Name = "lblKullaniciId";
			this.lblKullaniciId.Size = new System.Drawing.Size(11, 13);
			this.lblKullaniciId.TabIndex = 26;
			this.lblKullaniciId.Text = "*";
			// 
			// comboBoxUrun
			// 
			this.comboBoxUrun.FormattingEnabled = true;
			this.comboBoxUrun.Location = new System.Drawing.Point(129, 104);
			this.comboBoxUrun.Name = "comboBoxUrun";
			this.comboBoxUrun.Size = new System.Drawing.Size(118, 21);
			this.comboBoxUrun.TabIndex = 25;
			this.comboBoxUrun.SelectedIndexChanged += new System.EventHandler(this.comboBoxUrun_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label11.Location = new System.Drawing.Point(4, 101);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 16);
			this.label11.TabIndex = 23;
			this.label11.Text = "Ürün";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(129, 136);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
			this.dateTimePicker1.TabIndex = 22;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(268, 95);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "Güncelle";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(268, 62);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 20;
			this.button2.Text = "Sil";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(268, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(129, 46);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(118, 20);
			this.txtSoyad.TabIndex = 17;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(129, 75);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(118, 20);
			this.txtEmail.TabIndex = 16;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(129, 17);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(118, 20);
			this.txtAd.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(4, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 16);
			this.label6.TabIndex = 14;
			this.label6.Text = "Doğum Tarihi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(4, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(4, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Soyisim";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(4, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "İsim";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblUrunId);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.txtAciklama);
			this.panel2.Controls.Add(this.txtFiyat);
			this.panel2.Controls.Add(this.txtStok);
			this.panel2.Controls.Add(this.txtUrunAd);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Location = new System.Drawing.Point(416, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(372, 163);
			this.panel2.TabIndex = 13;
			// 
			// lblUrunId
			// 
			this.lblUrunId.AutoSize = true;
			this.lblUrunId.Location = new System.Drawing.Point(345, 4);
			this.lblUrunId.Name = "lblUrunId";
			this.lblUrunId.Size = new System.Drawing.Size(11, 13);
			this.lblUrunId.TabIndex = 33;
			this.lblUrunId.Text = "*";
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button4.Location = new System.Drawing.Point(281, 107);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 32;
			this.button4.Text = "Güncelle";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button5.Location = new System.Drawing.Point(281, 67);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 31;
			this.button5.Text = "Sil";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.Location = new System.Drawing.Point(281, 29);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 30;
			this.button6.Text = "Ekle";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// txtAciklama
			// 
			this.txtAciklama.Location = new System.Drawing.Point(142, 125);
			this.txtAciklama.Name = "txtAciklama";
			this.txtAciklama.Size = new System.Drawing.Size(100, 20);
			this.txtAciklama.TabIndex = 29;
			// 
			// txtFiyat
			// 
			this.txtFiyat.Location = new System.Drawing.Point(142, 51);
			this.txtFiyat.Name = "txtFiyat";
			this.txtFiyat.Size = new System.Drawing.Size(100, 20);
			this.txtFiyat.TabIndex = 28;
			// 
			// txtStok
			// 
			this.txtStok.Location = new System.Drawing.Point(142, 89);
			this.txtStok.Name = "txtStok";
			this.txtStok.Size = new System.Drawing.Size(100, 20);
			this.txtStok.TabIndex = 27;
			// 
			// txtUrunAd
			// 
			this.txtUrunAd.Location = new System.Drawing.Point(142, 17);
			this.txtUrunAd.Name = "txtUrunAd";
			this.txtUrunAd.Size = new System.Drawing.Size(100, 20);
			this.txtUrunAd.TabIndex = 26;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(17, 125);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 25;
			this.label7.Text = "Açıklama";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(17, 89);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 16);
			this.label8.TabIndex = 24;
			this.label8.Text = "Stok";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(17, 51);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 16);
			this.label9.TabIndex = 23;
			this.label9.Text = "Fiyat";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(17, 17);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 16);
			this.label10.TabIndex = 22;
			this.label10.Text = "Ürün Adı";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(538, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "Ürünler Tablosu";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(416, 210);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(372, 150);
			this.dataGridView2.TabIndex = 14;
			this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
			// 
			// chart1
			// 
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(9, 385);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(372, 183);
			this.chart1.TabIndex = 34;
			this.chart1.Text = " ";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(362, 580);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 35;
			this.button7.Text = "Grafik";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// chart2
			// 
			chartArea3.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart2.Legends.Add(legend3);
			this.chart2.Location = new System.Drawing.Point(416, 385);
			this.chart2.Name = "chart2";
			this.chart2.Size = new System.Drawing.Size(372, 183);
			this.chart2.TabIndex = 36;
			this.chart2.Text = " ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 615);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox txtAciklama;
		private System.Windows.Forms.TextBox txtFiyat;
		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.TextBox txtUrunAd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.ComboBox comboBoxUrun;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblKullaniciId;
		private System.Windows.Forms.Label lblUrunId;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
	}
}

