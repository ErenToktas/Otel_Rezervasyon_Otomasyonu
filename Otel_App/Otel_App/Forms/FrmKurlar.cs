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
using System.Xml;

namespace Otel_App.Forms
{
    public partial class FrmKurlar : Form
    {
        public FrmKurlar()
        {
            InitializeComponent();
        }
        OtelEntities db = new OtelEntities();
        private void FrmKurlar_Load(object sender, EventArgs e)
        {
            db.TBLKURLAR.Load();
            bindingSource1.DataSource = db.TBLKURLAR.Local;
            //Güncel döviz verileri
            //string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            //var xmldoc = new XmlDocument();
            //xmldoc.Load(bugun);
            //DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            //string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            //labelControl1.Text = string.Format("Tarih {0} USD; {1}",tarih.ToShortDateString(), USD);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Hata oluştu tekrar deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
