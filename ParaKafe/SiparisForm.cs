using ParaKafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaKafe
{
    public partial class SiparisForm : Form
    {
        private readonly Siparis siparis;
        private readonly KafeVeri db;

        // Adım 41
        public event EventHandler<MasaTasindiEventArgs> MasaTasindi;

        // Adım 07
        // dgv e atmak ve devamlı güncellemek zorunda kalmamak için BL oluşturduk
        private readonly BindingList<SiparisDetay> blDetaylar;

        // Adım 04
        // ctor'dan veriyi almış olduk
        public SiparisForm(Siparis siparis, KafeVeri db)
        {
            this.siparis = siparis;
            this.db = db;

            // Adım 08
            // Oluşturduğumuz BL listesini new liyerek siparisimizin SiparisDetay listesini tutan SiparisDetaylar prop unu atadık
            blDetaylar = new BindingList<SiparisDetay>(siparis.SiparisDetaylar);

            // Adım 13
            // Liste değişince event tetiklensin
            blDetaylar.ListChanged += BlDetaylar_ListChanged;
            InitializeComponent();
            // Adım 18
            // dgv'de sütun adları atılan BindingList deki nesne nin property lerine göre otomatik gelir
            // Fakat property isimlerimiz ingilizce karakter ve birleşik yazıldığı için çirkin duruyor
            // Bunun için Form a gidip dgv ayarlarından edit Columns ile 4 tane ekledik
            // $# Daha sonra bu Column ları property lerle eşlemek için dgv ayarlarından EditColumns dedikten sonra "DataPropertyName" lerine bağlamak istediğimiz property adını yazdık
            // BirimFiyat sütununda gösterim şeklinde yanına ₺ koymamıştık hesaplamada kullanmak için, Burda listede gösterirken koymak için yine dgv Edit Column ayarlarından ayarlamak istediğimiz sütunu seçerek DefaultCellStyle dan Format kısmını #,###.00₺ 
            dgvSiparisDetaylar.AutoGenerateColumns = false;

            // Adım 09
            //dgv oluştuktan sonra blDetayları dgv nin Datasourcuna bağladık
            dgvSiparisDetaylar.DataSource = blDetaylar;

            UrunleriListele();
            MasaNoyuGuncelle();
            OdemeTutariniGuncelle();
        }

        private void BlDetaylar_ListChanged(object sender, ListChangedEventArgs e)
        {
            // Adım 13.a
            // Bu event tetiklenince tutar güncellensin
            // dgv içinden silindiğinde de güncellensin diye bu eventi kullandık (dgv ayarlarından MultiSelect=false ve SelectionMode=FullRowSelect)
            // dgv 'den silinince bağlı olduğu listeden de silinir böylece siparisten de silinir
            OdemeTutariniGuncelle();
        }

        private void OdemeTutariniGuncelle()
        {
            // Adım 12
            // ilk açılışta siparisin eski ToplamTutarı gelsin diye
            lblOdemeTutari.Text = siparis.ToplamTutarTL;
        }

        private void MasaNoyuGuncelle()
        {
            // Adım 05
            // Formun Text ini ve forma gösterdiğimiz büyük label ın textini siparisin MasaNo sundan aldık
            Text = $"Masa {siparis.MasaNo}  (Açılış: {siparis.AcilisZamani})";
            lblMasaNo.Text = siparis.MasaNo.ToString("00");

            // Adım 37
            // Masa taşıyabilmek için boş masaNo ları cboMasano ya ekledik
            // Bos masaNoları alabilmek için aktif siparislerdeki masaNo ları bir diziye atıp sonrasında, Enumerable Range ile 1'den toplam masa adeti kadar numara içinden bu dizide olmayanları yani bos olanları çektik
            int[] doluMasalar = db.AktifSiparisler.Select(x => x.MasaNo).ToArray();
            cboMasaNo.DataSource = Enumerable
                .Range(1, db.MasaAdet)
                .Where(x=> !doluMasalar.Contains(x))
                .ToList();

        }

        private void UrunleriListele()
        {
            // Adım 06
            // KafeVeri db de bulunan Urunler listesini combobox ta gösterdik
            cboUrun.DataSource = db.Urunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Adım 10
            // Seçilen ürün ve adedini oluşuturduğumuz siparis.SiparisDetaylar listesine atabilmek için bir SiparisDetay oluşturup ürünü fiyatini ve adetini combobox ve nud'dan çektik
            var sd = new SiparisDetay();
            Urun urun = (Urun)cboUrun.SelectedItem;
            sd.UrunAd = urun.UrunAd;
            sd.BirimFiyat = urun.BirimFiyat;
            sd.Adet = (int)nudAdet.Value;

            // Adım 11
            // sd isimli SiparisDetayi daha önceden siparis.SiparisDetaylar listesini bağladığımız blDetaylara attık(aynı listeye referans ile bağlı olduğu için farketmiyor tek artısı BindingList olduğu için dgv direk güncelleniyor diğer türlü anlık yenileme için ekstra işlem gerekecekti(ne gibi??) gerekecekti)
            blDetaylar.Add(sd);

        }

        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            // Adım 14
            Close();
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            // Adım 15
            SiparisiKapat(SiparisDurum.Iptal, 0);

        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            // Adım 16
            SiparisiKapat(SiparisDurum.Odendi, siparis.ToplamTutar());
        }

        private void SiparisiKapat(SiparisDurum durum,decimal odenenTutar)
        {
            // Adım 15-16
            // Metot haline getirdik benzer kodlar olduğu için
            // Siparisin durumu güncellendi ve db deki yeri değiştirildi
            siparis.Durum = durum;
            siparis.OdenenTutar = odenenTutar;
            siparis.KapanisZamani = DateTime.Now;
            db.AktifSiparisler.Remove(siparis);
            db.GecmisSiparisler.Add(siparis);
            Close();
        }

        private void btnMasaTasi_Click(object sender, EventArgs e)
        {
            // Adım 38
            if (cboMasaNo.SelectedIndex == -1) return;

            // Adım 39
            int eskiMasaNo = siparis.MasaNo;
            int hedefMasaNo = (int)cboMasaNo.SelectedItem;
            siparis.MasaNo = hedefMasaNo;
            MasaNoyuGuncelle();

            // Adım 42
            if (MasaTasindi != null)
                MasaTasindi(this, new MasaTasindiEventArgs(eskiMasaNo, hedefMasaNo));
            
        }
    }
}
