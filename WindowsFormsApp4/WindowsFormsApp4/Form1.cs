using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4;  // Form1'in olduğu namespace'i ekleyin


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private List<string> sehirler;
        private string secilenSehir;
        private char[] tahminler;
        private int kalanHak;
        private Random random;
        private List<Image> adamAsmacaResimleri; // Resim listesi

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler buraya yazılır.
        }
        public Form1()
        {
            InitializeComponent();
            AdamAsmacaResimleriYukle();
            OyunuBaslat();
            this.Load += new EventHandler(Form1_Load);
        }



        // Adam Asmaca resimlerini yükleyen metod
        private void AdamAsmacaResimleriYukle()
        {
            adamAsmacaResimleri = new List<Image>()
{
    Image.FromFile(@"C:\Users\Nur\Desktop\resim1.png"), // Direk
    Image.FromFile(@"C:\Users\Nur\Desktop\resim2.png"), // Baş
    Image.FromFile(@"C:\Users\Nur\Desktop\resim3.png"), // Gövde
    Image.FromFile(@"C:\Users\Nur\Desktop\resim4.png"), // Bir kol
    Image.FromFile(@"C:\Users\Nur\Desktop\resim5.png"), // Diğer kol
    Image.FromFile(@"C:\Users\Nur\Desktop\resim6.png"), // Bir bacak
    Image.FromFile(@"C:\Users\Nur\Desktop\resim7.png"), // Diğer bacak
};

            


        }

        private void OyunuBaslat()
        {
            // Şehir listesi
            sehirler = new List<string>()
            {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın",
                "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı",
                "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
                "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul",
                "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya",
                "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu",
                "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli",
                "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale",
                "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye",
                "Düzce"

            };

            // Rastgele bir şehir seçimi
            random = new Random();
            secilenSehir = sehirler[random.Next(sehirler.Count)].ToUpper();
            tahminler = new char[secilenSehir.Length];
            for (int i = 0; i < tahminler.Length; i++)
            {
                tahminler[i] = '_';
            }

            // Başlangıç hak sayısı ve ilk resim
            kalanHak = 8;
            lblHak.Text = $"Kalan Hak: {kalanHak}";
            lblKelime.Text = string.Join(" ", tahminler);
            MessageBox.Show("Bir harf tahmin edin:");
            picAdamAsmaca.Image = adamAsmacaResimleri[0]; // İlk resim (Boş direk)
            txtTahmin.Clear();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (txtTahmin.Text.Length == 0) return;

            char tahmin = char.ToUpper(txtTahmin.Text[0]);
            bool dogruTahmin = false;

            for (int i = 0; i < secilenSehir.Length; i++)
            {
                if (secilenSehir[i] == tahmin)
                {
                    tahminler[i] = tahmin;
                    dogruTahmin = true;
                }
            }

            if (!dogruTahmin)
            {
                kalanHak--;
                MessageBox.Show("Yanlış tahmin!");
                picAdamAsmaca.Image = adamAsmacaResimleri[8 - kalanHak]; // Yeni resim göster
            }
            else
            {
                MessageBox.Show("Doğru tahmin!");
            }

            lblKelime.Text = string.Join(" ", tahminler);
            lblHak.Text = $"Kalan Hak: {kalanHak}";

            // Oyunun bitiş kontrolü
            if (!Array.Exists(tahminler, harf => harf == '_'))
            {
                MessageBox.Show($"Tebrikler! Şehri bildiniz: {secilenSehir}");
                btnTahmin.Enabled = false;
            }
            else if (kalanHak <= 0)
            {
                MessageBox.Show($"Maalesef kaybettiniz. Seçilen şehir: {secilenSehir}");
                btnTahmin.Enabled = false;
            }

            txtTahmin.Clear();
        }

       
    }
}
