using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameXOX
{
    public partial class frmPlayerVsPlayer : Form
    {
        // Genel Değişkenler / Tanımlamalar
        public string oynayanOyuncu;
        public bool oyunBasladi;
        String[] hamleler = new String[9];
        public int hamleSayisi = 0;
        // ----

        public frmPlayerVsPlayer()
        {
            InitializeComponent();
        }

        private void frmPlayerVsPlayer_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //form yüklendiğinde tuş keypress ozelligi forma atanır
            oyunTahtasiTemizle(); 
            lblOyunDurumu.ForeColor = Color.White; // lblOyundurumu YazıRengi
            btnStart.Enabled = false;  // buton pasiflenir
            oyunBaslat();
        }

        public void hamleKontrol(int hamleYuvasi, string hamleTuru)
        {
            hamleler[hamleYuvasi - 1] = hamleTuru;  // Tüm hamleler oynandığı al hamleler dizisine atanır (Hamleyuvası - 1 şeklinde!)

            if (hamleSayisi == 9)
            {
                lblOyunSirasi.Text = "Tüm Hamleler Tamam!"; // Hamle Sayısı 9 a ulastıgında tüm lbl içeriği güncellenir
            }


            if (hamleSayisi >= 5)
            {
                kazananKontrol(); // ve oyun hamlesi 5 ve fazla ise her hamle sonrası oyun kazananı varmı diye kontrol edilir
            }
        }

        public void kazananKontrol()
        { // Tüm Kazanma Kombinasyonları
            
                if ((hamleler[0] == "X") && (hamleler[1] == "X") && (hamleler[2] == "X"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI X!";
                    pbGameZone1.BackColor = Color.LimeGreen;
                    pbGameZone2.BackColor = Color.LimeGreen;
                    pbGameZone3.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[3] == "X") && (hamleler[4] == "X") && (hamleler[5] == "X"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI X!";
                    pbGameZone4.BackColor = Color.LimeGreen;
                    pbGameZone5.BackColor = Color.LimeGreen;
                    pbGameZone6.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[6] == "X") && (hamleler[7] == "X") && (hamleler[8] == "X"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI X!";
                    pbGameZone7.BackColor = Color.LimeGreen;
                    pbGameZone8.BackColor = Color.LimeGreen;
                    pbGameZone9.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[0] == "X") && (hamleler[3] == "X") && (hamleler[6] == "X"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI X!";
                    pbGameZone1.BackColor = Color.LimeGreen;
                    pbGameZone4.BackColor = Color.LimeGreen;
                    pbGameZone7.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[1] == "X") && (hamleler[4] == "X") && (hamleler[7] == "X"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI X!";
                    pbGameZone2.BackColor = Color.LimeGreen;
                    pbGameZone5.BackColor = Color.LimeGreen;
                    pbGameZone8.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[2] == "X") && (hamleler[5] == "X") && (hamleler[8] == "X"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI X!";
                    pbGameZone3.BackColor = Color.LimeGreen;
                    pbGameZone6.BackColor = Color.LimeGreen;
                    pbGameZone9.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[0] == "X") && (hamleler[4] == "X") && (hamleler[8] == "X"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI X!";
                    pbGameZone1.BackColor = Color.LimeGreen;
                    pbGameZone5.BackColor = Color.LimeGreen;
                    pbGameZone9.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[2] == "X") && (hamleler[4] == "X") && (hamleler[6] == "X"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI X!";
                    pbGameZone3.BackColor = Color.LimeGreen;
                    pbGameZone5.BackColor = Color.LimeGreen;
                    pbGameZone7.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[0] == "O") && (hamleler[1] == "O") && (hamleler[2] == "O"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI O!";
                    pbGameZone1.BackColor = Color.LimeGreen;
                    pbGameZone2.BackColor = Color.LimeGreen;
                    pbGameZone3.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[3] == "O") && (hamleler[4] == "O") && (hamleler[5] == "O"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI O!";
                    pbGameZone4.BackColor = Color.LimeGreen;
                    pbGameZone5.BackColor = Color.LimeGreen;
                    pbGameZone6.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[6] == "O") && (hamleler[7] == "O") && (hamleler[8] == "O"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI O!";
                    pbGameZone7.BackColor = Color.LimeGreen;
                    pbGameZone8.BackColor = Color.LimeGreen;
                    pbGameZone9.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[0] == "O") && (hamleler[3] == "O") && (hamleler[6] == "O"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI O!";
                    pbGameZone1.BackColor = Color.LimeGreen;
                    pbGameZone4.BackColor = Color.LimeGreen;
                    pbGameZone7.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[1] == "O") && (hamleler[4] == "O") && (hamleler[7] == "O"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI O!";
                    pbGameZone2.BackColor = Color.LimeGreen;
                    pbGameZone5.BackColor = Color.LimeGreen;
                    pbGameZone8.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[2] == "O") && (hamleler[5] == "O") && (hamleler[8] == "O"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI O!";
                    pbGameZone3.BackColor = Color.LimeGreen;
                    pbGameZone6.BackColor = Color.LimeGreen;
                    pbGameZone9.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[0] == "O") && (hamleler[4] == "O") && (hamleler[8] == "O"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI O!";
                    pbGameZone1.BackColor = Color.LimeGreen;
                    pbGameZone5.BackColor = Color.LimeGreen;
                    pbGameZone9.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[2] == "O") && (hamleler[4] == "O") && (hamleler[6] == "O"))
                {
                    lblOyunDurumu.Text = "OYUN KAZANANI O!";
                    pbGameZone3.BackColor = Color.LimeGreen;
                    pbGameZone5.BackColor = Color.LimeGreen;
                    pbGameZone7.BackColor = Color.LimeGreen;
                    oyunDurdur();
                }
                else if ((hamleler[0] != null) && (hamleler[1] != null) && (hamleler[2] != null) && (hamleler[3] != null) && (hamleler[4] != null) && (hamleler[5] != null) && (hamleler[6] != null) && (hamleler[7] != null) && (hamleler[8] != null))
                { // Tüm alanlar dolu ve kazanan yoksa süre kontrolüne göre kazananı seçmeye gidilir.
                    timerProgBar.Stop();
                    oyunDurdur();

                    if (tbImlec.Value > 5) // İmlec O ya yakınsa
                    {
                        lblOyunDurumu.Text = "KAZANAN O";
                        MessageBox.Show("Süre avantajı ile O Oyuncusu KAZANDI!");
                    }
                    else if (tbImlec.Value < 5) // imlec x e yakınsa
                    {
                        lblOyunDurumu.Text = "KAZANAN X";
                        MessageBox.Show("Süre avantajı ile X Oyuncusu KAZANDI!");
                    }
                    else // İmleç tam ortadaysa Berabere!!!
                    {
                        DialogResult yenidenBaslat = new DialogResult();
                        yenidenBaslat = MessageBox.Show("Kazanan olmadı! Yeni oyuna başlamak istermisiniz?", "YENİ OYUN!", MessageBoxButtons.YesNo);
                        if (yenidenBaslat == DialogResult.Yes)
                        {
                            oyunTahtasiTemizle();
                            oyunBaslat();
                        }
                    }


                }

            
        }

        public void oyunBaslat()
        {// Oyun baslatma genel ayarlar
            oyunBasladi = true;
            oynayanOyuncu = lblOyunSirasi.Text = "X";
            lblOyunDurumu.Text = "OYUN BAŞLADI!";
            lblOyunDurumu.BackColor = Color.Green;

            tbImlec.Value = 5;
            timerProgBar.Start();
        }

        public void oyunDurdur()
        {// Oyun durdurma genel ayarlar
            oynayanOyuncu = lblOyunSirasi.Text = "--";
            lblOyunDurumu.BackColor = Color.Red;
            oyunBasladi = false;

            timerProgBar.Stop();
            this.KeyPreview = true;

        }

        public void oyunTahtasiTemizle()
        { // PictureBoxların imagelerini siler ve saydam yapar. hamle sayisi sıfırlanır gibi genel ayarlar
            hamleSayisi = 0;
            pbGameZone1.Image = null;
            pbGameZone1.BackColor = Color.Transparent;
            pbGameZone2.Image = null;
            pbGameZone2.BackColor = Color.Transparent;
            pbGameZone3.Image = null;
            pbGameZone3.BackColor = Color.Transparent;
            pbGameZone4.Image = null;
            pbGameZone4.BackColor = Color.Transparent;
            pbGameZone5.Image = null;
            pbGameZone5.BackColor = Color.Transparent;
            pbGameZone6.Image = null;
            pbGameZone6.BackColor = Color.Transparent;
            pbGameZone7.Image = null;
            pbGameZone7.BackColor = Color.Transparent;
            pbGameZone8.Image = null;
            pbGameZone8.BackColor = Color.Transparent;
            pbGameZone9.Image = null;
            pbGameZone9.BackColor = Color.Transparent;

            for (int i = 0; i < hamleler.Length; i++)
            {
                hamleler[i] = null;  //  Hamleler Dizisi temizlenir
            }
        }

        private void frmPlayerVsPlayer_KeyPress(object sender, KeyPressEventArgs e)
        { // Tuş algılandığında!
            if (oyunBasladi) // eğer oyun basladıysa tuslar kontrol edilir.
            {
                switch (e.KeyChar) // ilgili tuşa göre komutlar verilir.
                {
                        case (char)Keys.D1:
                            oyunHamlesi(1);
                            break;
                        case (char)Keys.D2:
                            oyunHamlesi(2);
                            break;
                        case (char)Keys.D3:
                            oyunHamlesi(3);
                            break;
                        case (char)Keys.D4:
                            oyunHamlesi(4);
                            break;
                        case (char)Keys.D5:
                            oyunHamlesi(5);
                            break;
                        case (char)Keys.D6:
                            oyunHamlesi(6);
                            break;
                        case (char)Keys.D7:
                            oyunHamlesi(7);
                            break;
                        case (char)Keys.D8:
                            oyunHamlesi(8);
                            break;
                        case (char)Keys.D9:
                            oyunHamlesi(9);
                            break;
                        case (char)Keys.Escape:
                            oyunDurdur();
                            oyunTahtasiTemizle();
                            lblOyunDurumu.Text = "OYUN DURDURULDU!";
                            break;
                        case (char)Keys.Space:
                                DialogResult oyunSonlandir = new DialogResult();
                                oyunSonlandir = MessageBox.Show("Devam eden oyunu bitirip yeni oyun başlatmak istiyor musunuz?", "OYUN DEVAM EDİYOR!", MessageBoxButtons.YesNo);
                                if (oyunSonlandir == DialogResult.Yes)
                                {
                                    oyunTahtasiTemizle();
                                    oyunBaslat();
                                }
                            break;
                }


            }
            else // eğer oyun baslamadıysa yeni oyun isteği sorulur!
            {
                DialogResult yeniOyun = new DialogResult();
                yeniOyun = MessageBox.Show("Yeni oyun başlatmak istiyor musunuz?", "YENİ OYUN?", MessageBoxButtons.YesNo);
                if (yeniOyun == DialogResult.Yes)
                {
                    oyunTahtasiTemizle();
                    oyunBaslat();
                }
            }
        }

        public void oyunHamlesi(int hamleYuvasi)
        {

            switch (hamleYuvasi) //seçilen hamle yuvasına göre hangi oyuncu oynuyorsa if yapısıyla kontrol edilip onun işareti oyun alanına resim olarak eklenir!
            {
                case 1:
                    if (pbGameZone1.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone1.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone1.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(1, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone1.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone1.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(1, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz..."); // onceden oynanmış bir alan seçilirse!
                    break;
                case 2:
                    if (pbGameZone2.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone2.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone2.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(2, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone2.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone2.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(2, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz...");
                    break;
                case 3:
                    if (pbGameZone3.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone3.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone3.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(3, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone3.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone3.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(3, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz...");
                    break;
                case 4:
                    if (pbGameZone4.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone4.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone4.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(4, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone4.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone4.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(4, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz...");
                    break;
                case 5:
                    if (pbGameZone5.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone5.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone5.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(5, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone5.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone5.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(5, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz...");
                    break;
                case 6:
                    if (pbGameZone6.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone6.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone6.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(6, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone6.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone6.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(6, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz...");
                    break;
                case 7:
                    if (pbGameZone7.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone7.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone7.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(7, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone7.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone7.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(7, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz...");
                    break;
                case 8:
                    if (pbGameZone8.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone8.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone8.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(8, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone8.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone8.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(8, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz...");
                    break;
                case 9:
                    if (pbGameZone9.Image == null)
                    {
                        if (oynayanOyuncu == "X")
                        {
                            pbGameZone9.Image = Image.FromFile(Application.StartupPath + "\\resimX.png");
                            pbGameZone9.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "O";

                            hamleSayisi++;
                            hamleKontrol(9, "X");
                        }
                        else if (oynayanOyuncu == "O")
                        {
                            pbGameZone9.Image = Image.FromFile(Application.StartupPath + "\\resimO.png");
                            pbGameZone9.SizeMode = PictureBoxSizeMode.Zoom;
                            oynayanOyuncu = lblOyunSirasi.Text = "X";

                            hamleSayisi++;
                            hamleKontrol(9, "O");
                        }
                    }
                    else MessageBox.Show("Lütfen boş alan seçiniz...");
                    break;
            }
        }

        private void timerProgBar_Tick(object sender, EventArgs e)
        { // timerin 1 saniye de bir çalışacak kodları
            if (oyunBasladi) //eğer oyun basladıysa
            {
                if (oynayanOyuncu =="X")
                    {
                        if (tbImlec.Value == 10) //imlec 10 oldugunda O kazanır
                        {
                            timerProgBar.Stop();
                            lblOyunDurumu.Text = "KAZANAN O";
                            MessageBox.Show("X Oyuncusunun süresi dolduğu için O Oyuncusu KAZANDI!");
                            oyunDurdur();
                        }
                        else
                        {
                            tbImlec.Value++;
                        }
                    }
                    else if (oynayanOyuncu == "O") 
                    {
                        if (tbImlec.Value == 0) //imlec 0 oldugunda X kazanır
                    {
                            timerProgBar.Stop();
                            lblOyunDurumu.Text = "KAZANAN X";
                            MessageBox.Show("O Oyuncusunun süresi dolduğu için X Oyuncusu KAZANDI!");
                            oyunDurdur();

                        }
                        else
                        {
                            tbImlec.Value--;
                        }
                    }
            }
            else
            {
                timerProgBar.Stop(); // OYUN BASLAMADIYSA TİMER VE OYUN DURDUR
                oyunDurdur();
            }
        }

        private void frmPlayerVsPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerProgBar.Stop(); // FORM KAPANIRKEN TİMER DURDUR
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerProgBar.Start(); 
            btnStop.Enabled = true;     // Buton Start Ayarları
            btnStart.Enabled = false;
            this.KeyPreview = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerProgBar.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;    // Buton Stop Ayarları
            this.KeyPreview = false;
        }

        private void tuslar_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTusBilgileri frmTus = new frmTusBilgileri();
            frmTus.StartPosition = FormStartPosition.CenterParent; //Tus Bilgileri Formu acar.
            frmTus.ShowDialog();
        }
    }
}
