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

namespace Otel_App.Cariler
{
    public partial class FrmCariKart : Form
    {
        public FrmCariKart()
        {
            InitializeComponent();
        }
        OtelEntities db = new OtelEntities();
        private void FrmCariKart_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.TBLUYRUK
                                                 select new
                                                 {
                                                     x.UYRUKID,
                                                     x.ULKEAD
                                                 }).ToList();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARITUR
                                                 select new
                                                 {
                                                     x.CARITURID,
                                                     x.CARITURAD
                                                 }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            try
            {
                if (txtTCno.Text != "" & txtAdSoyad.Text != "" & txtMail.Text != "" & txtTelefon.Text != "" & txtVergiDaire.Text != ""
                    & txtVergiNo.Text != "" & txtYetkili.Text != "" & lookUpEdit1.Text != "" & lookUpEdit2.Text != ""
                    & rchAdres.Text != "" & rchAciklama.Text != "")
                {
                    t.ACIKLAMA = rchAciklama.Text;
                    t.CARIADRES = rchAdres.Text;
                    t.CARIADSOYAD = txtAdSoyad.Text;
                    t.CARITC = txtTCno.Text;
                    t.CARITUR = int.Parse(lookUpEdit1.EditValue.ToString());
                    t.UYRUK = int.Parse(lookUpEdit1.EditValue.ToString());
                    t.DURUM = 1;
                    t.MAIL = txtMail.Text;
                    t.TELEFON = txtTelefon.Text;
                    t.VERGIDAIRE = txtVergiDaire.Text;
                    t.YETKILI = txtYetkili.Text;
                    t.VERGINO = txtVergiNo.Text;
                    t.YETKILI = txtYetkili.Text;
                    t.KIMLIKFOTO1 = @"D:\Github Dosyalarım\Otel_Rezervasyon_Otomasyonu\Otel_App\pictures\" + txtAdSoyad.Text + "1.jpg" ;
                    t.KIMLIKFOTO2 = @"D:\Github Dosyalarım\Otel_Rezervasyon_Otomasyonu\Otel_App\pictures\" + txtAdSoyad.Text + "2.jpg";
                    db.TBLCARI.Add(t);
                    db.SaveChanges();
                    XtraMessageBox.Show("Bilgiler Sisteme Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
