using kontor.HizliService;
using System;
using System.Drawing;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
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


        public string username = "";
        public string password = "";
        public static string apikey = "";
        public static string secret = "";
        string firmaadi = "BULUNAMADI";
        string hashliuser = "";
        string hashlipass = "";
        string token = "";
        private async void kontoryuklebtn_Click(object sender, EventArgs e)
        {
            kayitsayilbl.Visible = false;
            kayitsayilbl.Refresh();
            firmaisimtxt.Visible = false;
            firmaisimtxt.Refresh();
            this.Size = new Size(801, 168);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if (tokenAlindi == false)
            {
                await tokenAl();
            }
            try
            {
                HizliServiceClient hizliServiceClient3 = new HizliServiceClient();
                using (new OperationContextScope(hizliServiceClient3.InnerChannel))
                {
                    var prop = new HttpRequestMessageProperty();
                    prop.Headers.Add("Authorization", "Bearer " + token);
                    OperationContext context = OperationContext.Current;
                    context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;
                    musteriOutput musterigetir = await hizliServiceClient3.MusteriGetirAsync(vnotxt.Text.Trim());
                    if (musterigetir.hata == false)
                    {
                        firmaadi = musterigetir.musteri.unvan.Trim().Length > 30 ? musterigetir.musteri.unvan.Substring(0, 20).Trim() + "..." : musterigetir.musteri.unvan.Trim();
                        firmaisimtxt.Text = "Firma Adı: " + musterigetir.musteri.unvan;
                        firmaisimtxt.Visible = true;
                        firmaisimtxt.Refresh();
                    }
                    //else
                    //{
                    //    foreach (var item in musterigetir.hataMesaji)
                    //    {
                    //        MessageBox.Show(item);
                    //    }
                    //}

                }
            }
            catch
            {
                DialogResult dr2 = MessageBox.Show($"{vnotxt.Text} nolu vergi numarası geçersiz olabilir, yükleme işlemine devam etmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (dr2 == DialogResult.Yes)
                {
                    await kontoryukle();
                    return;
                }
                else if (dr2 == DialogResult.No)
                {
                    return;
                }
            }
            await kontoryukle();
        }

        private async Task kontoryukle()
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
                dataGridView1.Columns.Add("Aciklama", "Açıklama");
                dataGridView1.Columns.Add("KontorId", "KontorId");
                HizliServiceClient hizliServiceClient = new HizliServiceClient();
                using (new OperationContextScope(hizliServiceClient.InnerChannel))
                {
                    var prop = new HttpRequestMessageProperty();
                    prop.Headers.Add("Authorization", "Bearer " + token);
                    OperationContext context = OperationContext.Current;
                    context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;
                    KontorYukleModel modal = new KontorYukleModel()
                    {
                        vkn_tckn = vnotxt.Text.Trim(),
                        birimTuru = 0,
                        islemTuru = 0,
                        krediTuru = new KrediTuru()
                        {
                            baslangicTarihi = DateTime.Now.ToString("dd-MM-yyyy"),
                            odemeTuru = OdemeTuru.Pesin,
                            birimFiyat = 0.1m,
                            birimMiktari = Convert.ToInt32(kontorsayitxt.Text.Trim()),
                            faturaNo = null,
                            taksitSayisi = 0,
                            aciklama = DateTime.Now.ToString("dd-MM-yyyy") + $" tarihinde yetkili tarafından yüklenmiştir."
                        }
                    };
                    ResponseMessage response = await hizliServiceClient.KontorYukleAsync(modal);
                    if (response.IsSucceeded)
                    {
                        this.Size = new Size(801, 752);
                        kayitsayilbl.Visible = true;
                        HizliServiceClient hizliServiceClient2 = new HizliServiceClient();
                        using (new OperationContextScope(hizliServiceClient2.InnerChannel))
                        {
                            var prop2 = new HttpRequestMessageProperty();
                            prop2.Headers.Add("Authorization", "Bearer " + token);
                            OperationContext context2 = OperationContext.Current;
                            context2.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop2;
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
                                        krediRapor.Aciklama,
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

        private async Task tokenAl()
        {
            label3.Visible = false;
            try
            {
                HizliServiceClient hizliServiceClient3 = new HizliServiceClient();
                using (new OperationContextScope(hizliServiceClient3.InnerChannel))
                {

                    LoginUtil modal2 = new LoginUtil
                    {
                        password = password,
                        secretKey = secret,
                        username = username
                    };

                    LoginOut loginResponse = await hizliServiceClient3.UtilEncryptAsync(modal2);
                    hashliuser = loginResponse.username.ToString();
                    hashlipass = loginResponse.password.ToString();
                }
                HizliServiceClient hizliServiceClient4 = new HizliServiceClient();
                using (new OperationContextScope(hizliServiceClient4.InnerChannel))
                {
                    LoginInput modal = new LoginInput
                    {
                        username = hashliuser,
                        password = hashlipass,
                        apiKey = apikey
                    };

                    LoginOutput[] loginResponse = await hizliServiceClient4.LoginAsync(modal);
                    foreach (var item in loginResponse)
                    {
                        token = item.Token;
                        tokenAlindi = true;
                        label3.Visible = true;
                    }
                }
            }
            catch
            {
                tokenAlindi = false;
                label3.Visible = false;
            }
        }


        bool tokenAlindi = false;
        private async void Form1_Load(object sender, EventArgs e)
        {
            await tokenAl();
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
