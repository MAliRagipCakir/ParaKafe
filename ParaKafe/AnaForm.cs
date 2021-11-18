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
            MasalariOlustur();

            // Adım 34
            VerileriOku();
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

                // Adım 35
                // json ile verileri kaydedip çekme işleminde dolu masanın ımageKey i de beraberinde gelsin diye alttaki satırı yukardaki haliyle değiştirdik
                // lvi.ImageKey = "bos";
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            // Adım 03;
            // Bir masaya çift tıkladığımızda se.ili masayı Tag'inden yakaladık
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            int no = (int)lvi.Tag;

            // Daha önceden bu masa Numarasına açılan bir sipariş var mı onu kontrol ettik(FirstOrDefault şartı sağlıyanı ilk gördüğünü, hiç yoksa default bu durumda null)
            Siparis siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == no);

            // siparis'in null olması durumunda yeni bi siparis açıyoruz ve AktifSiparislere bu siparisi ekliyoruz
            // Masanın ImageKey ini de "dolu" olarak adlandırdığımız resim ile değiştirdik
            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = no };
                db.AktifSiparisler.Add(siparis);
                lvi.ImageKey = "dolu";
            }

            // SiparisForm u açarak, açtığımız siparisi(yada mevcut olan siparisi) ve KafeVeri db imizi yeni forma gönderdik
            SiparisForm sf = new SiparisForm(siparis, db);
            sf.ShowDialog();


            // Adım 17
            // SiparisForm da yapılan ödeme-iptal işlemlerinden biri yapıldıysa siparis durumu değişeceği için artık masa boşalmış olacak
            // bizde bunu sf.ShowDialog() altında yaparak gelen durumu kontrol ettik
            if (siparis.Durum != SiparisDurum.Aktif)
                lvi.ImageKey = "bos";


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
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            // Adım 33
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }

        private void VerileriOku()
        {
            // Adım 35
            try
            {
                // Adım 35.1
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<KafeVeri>(json);
            }
            catch (Exception)
            {
                // Adım 35.2
                db = new KafeVeri();
                OrnekUrunleriYukle();
            }
        }

    }
}
