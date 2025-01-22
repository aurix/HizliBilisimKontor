using kontor.HizliService;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(801, 168);
            kayitsayilbl.Visible = false;
        }

        MySqlConnection baglanti = new MySqlConnection("Server='46.2.245.103';Port=3306;Database='kontor';Uid='satis';Pwd='!1919+';SSL Mode = None;convert zero datetime=True");

        public string username = "";
        public string password = "";
        string firmaadi = "BULUNAMADI";
        private void kontoryuklebtn_Click(object sender, EventArgs e)
        {
            kayitsayilbl.Visible = false;
            kayitsayilbl.Refresh();
            firmaisimtxt.Visible = false;
            firmaisimtxt.Refresh();
            this.Size = new Size(801, 168);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            try
            {
                HizliServiceClient hizliServiceClient3 = new HizliServiceClient();
                using (new OperationContextScope(hizliServiceClient3.InnerChannel))
                {
                    HttpRequestMessageProperty httpRequestMessageProperty = new HttpRequestMessageProperty();
                    httpRequestMessageProperty.Headers.Add("username", username);
                    httpRequestMessageProperty.Headers.Add("password", password);
                    OperationContext current = OperationContext.Current;
                    current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestMessageProperty;
                    musteriOutput loginResponse = hizliServiceClient3.MusteriGetir(vnotxt.Text);
                    if (loginResponse.hata == false)
                    {
                        firmaadi = loginResponse.musteri.unvan.Trim().Length > 30 ? loginResponse.musteri.unvan.Substring(0, 20).Trim() + "..." : loginResponse.musteri.unvan.Trim();
                        firmaisimtxt.Text = "Firma Adı: " + loginResponse.musteri.unvan;
                        firmaisimtxt.Visible = true;
                        firmaisimtxt.Refresh();
                    }
                }
            }
            catch
            {
                DialogResult dr2 = MessageBox.Show($"{vnotxt.Text} nolu vergi numarası geçersiz olabilir, yükleme işlemine devam etmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    kontoryukle();
                    return;
                }
                else if (dr2 == DialogResult.No)
                {
                    return;
                }
            }
            kontoryukle();
        }

        private void kontoryukle()
        {
            DialogResult dr;
            if (firmaadi == "BULUNAMADI")
            {
                dr = MessageBox.Show($"{vnotxt.Text} vergi numarasına {kontorsayitxt.Text} kontör yüklemek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
            }
            else
            {
                dr = MessageBox.Show($"{firmaadi} ünvanlı {vnotxt.Text} vergi numarasına {kontorsayitxt.Text} kontör yüklemek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
            }
            if (dr == DialogResult.Yes)
            {
                dataGridView1.Columns.Add("VknTckn", "VKN/TCKN");
                dataGridView1.Columns.Add("BirimMiktari", "Kontör Sayısı");
                dataGridView1.Columns.Add("SatinAlmaTarihi", "Satın Alma Tarihi");
                dataGridView1.Columns.Add("KullanimBaslangicTarihi", "Kullanım Başlangıç Tarihi");
                dataGridView1.Columns.Add("BirimTuru", "Birim Türü");
                dataGridView1.Columns.Add("IslemTuru", "İşlem Türü");
                dataGridView1.Columns.Add("KontorId", "KontorId");
                HizliServiceClient hizliServiceClient = new HizliServiceClient();
                using (new OperationContextScope(hizliServiceClient.InnerChannel))
                {
                    HttpRequestMessageProperty httpRequestMessageProperty = new HttpRequestMessageProperty();
                    httpRequestMessageProperty.Headers.Add("username", username);
                    httpRequestMessageProperty.Headers.Add("password", password);
                    OperationContext current = OperationContext.Current;
                    current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestMessageProperty;
                    KontorYukleModel modal = new KontorYukleModel()
                    {
                        vkn_tckn = vnotxt.Text,
                        birimTuru = 0,
                        islemTuru = 0,
                        krediTuru = new KrediTuru()
                        {
                            baslangicTarihi = DateTime.Now.ToString("dd-MM-yyyy"),
                            odemeTuru = OdemeTuru.Pesin,
                            birimFiyat = 0.1m,
                            birimMiktari = Convert.ToInt32(kontorsayitxt.Text),
                            faturaNo = null,
                            taksitSayisi = 0
                        }
                    };
                    ResponseMessage response = hizliServiceClient.KontorYukle(modal);
                    if (response.IsSucceeded)
                    {
                        this.Size = new Size(801, 752);
                        kayitsayilbl.Visible = true;
                        HizliServiceClient hizliServiceClient2 = new HizliServiceClient();
                        using (new OperationContextScope(hizliServiceClient2.InnerChannel))
                        {
                            HttpRequestMessageProperty httpRequestMessageProperty2 = new HttpRequestMessageProperty();
                            httpRequestMessageProperty2.Headers.Add("username", username);
                            httpRequestMessageProperty2.Headers.Add("password", password);
                            OperationContext current2 = OperationContext.Current;
                            current2.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestMessageProperty2;
                            KrediRaporOutput response2 = hizliServiceClient2.KontorHareketleriVknTckn(vnotxt.Text);
                            if (response2.IsSucceeded)
                            {
                                foreach (KrediRapor krediRapor in response2.krediRaporList)
                                {
                                    dataGridView1.Rows.Add(
                                        krediRapor.VknTckn,
                                        krediRapor.BirimMiktari,
                                        krediRapor.SatinAlmaTarihi,
                                        krediRapor.KullanimBaslangicTarihi,
                                        krediRapor.BirimTuru,
                                        krediRapor.IslemTuru,
                                        krediRapor.KontorId
                                    );
                                }
                            }
                        };
                        int sayi = dataGridView1.Rows.Count - 1;
                        kayitsayilbl.Text = "KAYIT SAYISI: " + sayi;
                        MessageBox.Show($"{kontorsayitxt.Text} kontör yüklendi!", "BAŞARILI", MessageBoxButtons.OK);
                    }
                    else
                    {
                        this.Size = new Size(801, 168);
                        kayitsayilbl.Visible = false;
                        MessageBox.Show($"KONTÖR YÜKLENEMEDİ, HATA: " + response.Message, "HATALI", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void yuzkontorchk_CheckedChanged(object sender, EventArgs e)
        {
            kontorsayitxt.Text = "";
            label2.Visible = false;
            kontorsayitxt.Visible = false;
            if (yuzkontorchk.Checked == true)
            {
                kontorsayitxt.Text = "100";
            }
            else if (ıkıyuzellichk.Checked == true)
            {
                kontorsayitxt.Text = "250";
            }
            else if (besyuzchk.Checked == true)
            {
                kontorsayitxt.Text = "500";
            }
            else if (binchk.Checked == true)
            {
                kontorsayitxt.Text = "1000";
            }
            else if (ikibinchk.Checked == true)
            {
                kontorsayitxt.Text = "2000";
            }
            else if (ucbinchk.Checked == true)
            {
                kontorsayitxt.Text = "3000";
            }
            else if (besbinchk.Checked == true)
            {
                kontorsayitxt.Text = "5000";
            }
            else if (onbinchk.Checked == true)
            {
                kontorsayitxt.Text = "10000";
            }
            else if (digerchk.Checked == true)
            {
                kontorsayitxt.Text = "";
                label2.Visible = true;
                kontorsayitxt.Visible = true;
                kontorsayitxt.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            olus();
            if (kullanici == "BİLİNMEYEN KULLANICI")
            {
                Application.Exit();
            }
            if (Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString() == "192.168.1.250")
            {
                baglanti.ConnectionString = "Server=localhost;Port=3306;Database='kontor';Uid='root';Pwd='1';SSL Mode = None;convert zero datetime=True";
            }
            else
            {
                baglanti.ConnectionString = "Server=192.168.1.250;Port=3306;Database='kontor';Uid='satis';Pwd='!1919+';SSL Mode = None;convert zero datetime=True";
            }
        }

        public string kullanici = "BİLİNMEYEN KULLANICI";
        private void olus()
        {
            if (Dns.GetHostName() == "WIN-0LVN6SLHK43")
            {
                kullanici = "Şahin SEREN";
                this.Text = "Kontör Yükleme - Yetkili " + kullanici;
            }
            else if (Dns.GetHostName() == "BaranPC")
            {
                kullanici = "Baran OVACIK";
                this.Text = "Kontör Yükleme - Yetkili " + kullanici;
            }
            else if (Dns.GetHostName() == "DESKTOP-HN2OH3T")
            {
                kullanici = "Alper COŞKUN";
                this.Text = "Kontör Yükleme - Yetkili " + kullanici;
            }
            else if (Dns.GetHostName() == "DESKTOP-O8BEUS0")
            {
                kullanici = "Efe AZSIZAN";
                this.Text = "Kontör Yükleme - Yetkili " + kullanici;
            }
            else
            {
                kullanici = "BİLİNMEYEN KULLANICI";
                this.Text = "Kontör Yükleme - Yetkili " + kullanici;
            }
        }

        private void vnotxt_TextChanged(object sender, EventArgs e)
        {
            if (vnotxt.Text == "" || vnotxt.Text.Length <= 9)
            {
                kontorsayitxt.Enabled = false;
                kontoryuklebtn.Enabled = false;
            }
            else
            {
                kontorsayitxt.Enabled = true;
                kontoryuklebtn.Enabled = false;
            }
            if (kontorsayitxt.Text == "")
            {
                kontoryuklebtn.Enabled = false;
            }
            else
            {
                kontoryuklebtn.Enabled = true;
            }
        }

        private void vnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void kontorsayitxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (vnotxt.Text == "" && vnotxt.Text.Length <= 9)
                {
                    vnotxt.Focus();
                }
                else
                {
                    kontorsayitxt.Focus();
                }
                if (kontorsayitxt.Text == "")
                {
                    kontorsayitxt.Focus();
                }
                else
                {
                    kontoryuklebtn.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (kontoryuklebtn.Focused == true)
                {
                    kontorsayitxt.Focus();
                }
                else if (kontorsayitxt.Focused == true)
                {
                    vnotxt.Focus();
                }
            }
        }
    }
}
