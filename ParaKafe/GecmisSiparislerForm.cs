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
    public partial class GecmisSiparislerForm : Form
    {
        private readonly KafeVeri db;


        // Adım 20
        // ctor'dan veriyi almış olduk
        public GecmisSiparislerForm(KafeVeri db)
        {
            this.db = db;
            InitializeComponent();

            // Adım 21
            // Bu form daki siparislerin bulunacağı dgv ye geçmiş siparişleri atadık
            // Bu arada Bu form'daki dgv lerin 2 sindede "MultiSelect =false","RowHeaderVisible=false","SelectionMode = FullRowSelect","AutoSizeColumnMode,AutoSizeRowsMode = All Cells"
            // dgv lerin 2 sininde  Enable Adding, Enable Editing ,Enable Deleting özelliklerini kaldırdık
            dgvSiparisler.DataSource = db.GecmisSiparisler;
        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            // Adım 22
            // dgvSiparisler dgv sinin SelectionChanged eventini properties den bulup açtık ve herhangi bir satır seçili olmadığında 2. dgv nin DataSource unu sıfırladık
            if (dgvSiparisler.SelectedRows.Count == 0)
            {
                dgvSiparisDetaylar.DataSource = null;
                return;
            }

            // Adım 23
            // dgvSiparis'deki seçili satırın bağlı olduğu siparisi bir değişkene çektik ve bu siparisin SiparisDetaylar listesini 2.dgv olan dgvSiparisDetaylar a atadık
            Siparis siparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;
            dgvSiparisDetaylar.DataSource = siparis.SiparisDetaylar;
        }
    }
}
