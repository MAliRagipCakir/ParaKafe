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
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri db;

        // Adım 26
        // dgv e atmak ve devamlı güncellemek zorunda kalmamak için BL oluşturduk
        private readonly BindingList<Urun> blUrunler;

        // Adım 25
        // ctor'dan veriyi almış olduk
        public UrunlerForm(KafeVeri db)
        {
            this.db = db;

            // Adım 27
            // Oluşturduğumuz BL listesini new liyerek db nin Urunler Listesini atadık
            blUrunler = new BindingList<Urun>(db.Urunler);
            InitializeComponent();

            // Adım 28
            // dgv ayarlarından "AutoSizeColumnMode = Fill,AutoSizeRowsMode = All Cells"  ve Enable Adding özelliğini kaldırdık
            // dgv'nin Datasourcuna oluşturduğumuz db nin Ürünler listesine bağlı olan BL yi atadık
            dgvUrunler.DataSource = blUrunler;


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Adım 29
            // Eklenecek üründe ürün adı boş bırakılamasın diye bunu if ile yakaladık
            string urunAd = txtUrunAd.Text.Trim();

            if (urunAd=="")
            {
                MessageBox.Show("Ürün adını girmediniz.");
            }

            // Adım 30
            // Ürünü form itemlerinden verilen bilgilere göre ürettik ve db.Urunler listesinin referansını bağladığımız BL ye ekledik
            blUrunler.Add(new Urun()
            {
                UrunAd=urunAd,
                BirimFiyat = nudBirimFiyat.Value
            });

            // Adım 31
            // Ekleme işlemi bittikten sonra controllerimizi sıfırladık
            txtUrunAd.Clear();
            nudBirimFiyat.Value = 0;


        }
    }
}
