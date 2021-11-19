using Newtonsoft.Json;
using ParaKafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaKafe
{
    public partial class AnaForm : Form
    {
        // Adım 01
        KafeVeri db = new KafeVeri();

        public AnaForm()
        {
            InitializeComponent();

            // Adım 35
            // Açılışta kaydetmiş olduğumuz verileri okuttuk 
            VerileriOku();
            MasalariOlustur();
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Ayran", BirimFiyat = 4.50m });
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 5.50m });
        }

        private void MasalariOlustur()
        {
            // Adım 02
            // Masaları koyacağımız listView'e isim/no şeklinde numaralandırdık ve hepsini "bos" ile adlandırdıgımız resmi atadık
            // lvi.Tag ile lvi ları numaralarıyla tag ledik
            // Oluşturduğumuz masa ListViewItem leri lvwMasalar a sırayla ekledik
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem($"Masa {i}");
                lvi.Tag = i;
                lvi.ImageKey = db.AktifSiparisler.Any(x => x.MasaNo == i) ? "dolu" : "bos";
                lvwMasalar.Items.Add(lvi);

                // Adım 36
                // json ile verileri kaydedip çekme işleminde dolu masanın ımageKey i de beraberinde gelsin diye alttaki satırı yukardaki haliyle değiştirdik
                // lvi.ImageKey = "bos"; ===> lvi.ImageKey = db.AktifSiparisler.Any(x => x.MasaNo == i) ? "dolu" : "bos";
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            // Adım 03;
            // Bir masaya çift tıkladığımızda se.ili masayı Tag'inden yakaladık
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            int no = (int)lvi.Tag;

            // Adım 03.1
            // Daha önceden bu masa Numarasına açılan bir sipariş var mı onu kontrol ettik(FirstOrDefault şartı sağlıyanı ilk gördüğünü, hiç yoksa default bu durumda null)
            Siparis siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == no);

            // Adım 03.2
            // siparis'in null olması durumunda yeni bi siparis açıyoruz ve AktifSiparislere bu siparisi ekliyoruz
            // Masanın ImageKey ini de "dolu" olarak adlandırdığımız resim ile değiştirdik
            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = no };
                db.AktifSiparisler.Add(siparis);
                lvi.ImageKey = "dolu";
            }

            // Adım 03.3
            // SiparisForm u açarak, açtığımız siparisi(yada mevcut olan siparisi) ve KafeVeri db imizi yeni forma gönderdik
            SiparisForm sf = new SiparisForm(siparis, db);
            // Adım 42
            sf.MasaTasindi += Sf_MasaTasindi;
            sf.ShowDialog();


            // Adım 17
            // SiparisForm da yapılan ödeme-iptal işlemlerinden biri yapıldıysa siparis durumu değişeceği için artık masa boşalmış olacak
            // bizde bunu sf.ShowDialog() altında yaparak gelen durumu kontrol ettik
            if (siparis.Durum != SiparisDurum.Aktif)
                lvi.ImageKey = "bos";
            

        }

        //Adım 43
        private void Sf_MasaTasindi(object sender, MasaTasindiEventArgs e)
        {
            foreach (ListViewItem lvi in lvwMasalar.Items)
            {
                if ((int)lvi.Tag == e.EskiMasaNo) lvi.ImageKey = "bos";
                if ((int)lvi.Tag == e.YeniMasaNo) lvi.ImageKey = "dolu";
            }
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            // Adım 19
            // GeçmisSiparisForm u açarak, KafeVeri db imizi yeni forma gönderdik
            new GecmisSiparislerForm(db).ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            // Adım 24
            // UrunlerForm u açarak, KafeVeri db imizi yeni forma gönderdik
            new UrunlerForm(db).ShowDialog();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Adım 32
            // Form kapanırken verileri Json ile kaydedebilmek için bu eventi oluşturduk
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            // Adım 33
            // Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution yolundan json ı ParaKafe projemize ekledik
            // tüm listeleri tutan KafeVeri classından oluşturduğumuz db yi json ile bir dosyaya yazdırdık
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }

        private void VerileriOku()
        {
            // Adım 34
            // Dosya hiç oluşturulmamışsa veya bozulmuşsa diye hata almamak için try catch yaptık
            try
            {
                // Adım 34.1
                // Dosya varsa ve okunabiliyorsa KafeVeri türünde açarak db ye atadık
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<KafeVeri>(json);
            }
            catch (Exception)
            {
                // Adım 34.2
                // Dosya bozuksa veya hiç oluşturulmamışsa 0'dan yeni db oluşturarak içinde birkaç örnek ürün oluşturduğumuz metodu çağırdık
                db = new KafeVeri();
                OrnekUrunleriYukle();
            }
        }

    }
}
