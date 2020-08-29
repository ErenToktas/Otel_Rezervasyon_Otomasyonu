using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otel_App.Entity;
using System.Data.Entity;
using DevExpress.XtraEditors;

namespace Otel_App.Urun
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        OtelEntities db = new OtelEntities();
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            lookUpEditBirim.Properties.DataSource = (from x in db.TBLBIRIM
                                                     select new
                                                     {
                                                         x.BIRIMAD,
                                                         x.BIRIMID
                                                     }).ToList();
            lookUpEditGrup.Properties.DataSource = (from x in db.TBLURUNGRUP
                                                    select new
                                                    {
                                                        x.URUNGRUPID,
                                                        x.GRUPADI
                                                    }).ToList();
            lookUpEditParaBirim.Properties.DataSource = (from x in db.TBLKURLAR
                                                         select new
                                                         {
                                                             x.KURAD,
                                                             x.KURID
                                                         }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN k = new TBLURUN();
            try
            {
            if (lookUpEditBirim.Text != "" & lookUpEditGrup.Text != "" & lookUpEditParaBirim.Text != "" &
                txtFiyat.Text != "" & comboBoxEditKdv.Text != "" & txtUrunAd.Text != "")
            {
                k.BIRIM = int.Parse(lookUpEditBirim.EditValue.ToString());
                k.URUNADI = txtUrunAd.Text;
                k.URUNGRUP = int.Parse(lookUpEditGrup.EditValue.ToString());
                k.KDV = byte.Parse(comboBoxEditKdv.Text);
                k.KUR = int.Parse(lookUpEditParaBirim.EditValue.ToString());
                k.FIYAT = int.Parse(txtFiyat.Text);
                k.DURUM = 1;
                db.TBLURUN.Add(k);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün Sisteme Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Boş alan bırakdınız lütfen boş alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Lütfen ilgili alanları kontrol ediniz ve tekrar doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
