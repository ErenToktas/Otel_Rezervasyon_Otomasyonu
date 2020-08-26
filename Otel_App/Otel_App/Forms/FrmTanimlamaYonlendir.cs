using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_App.Forms
{
    public partial class FrmTanimlamaYonlendir : Form
    {
        public FrmTanimlamaYonlendir()
        {
            InitializeComponent();
        }

        private void FrmTanimlamaYonlendir_Load(object sender, EventArgs e)
        {

        }

        private void panelTelefonNo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelTelefonNo_Click(object sender, EventArgs e)
        {
            FrmTelefon frm = new FrmTelefon();
            frm.Show();
        }

        private void panelDurum_Click(object sender, EventArgs e)
        {
            FrmDurum frm = new FrmDurum();
            frm.Show();
        }

        private void panelKur_Click(object sender, EventArgs e)
        {
            FrmKurlar frm = new FrmKurlar();
            frm.Show();
        }

        private void panelKasa_Click(object sender, EventArgs e)
        {
            FrmKasalar frm = new FrmKasalar();
            frm.Show();
        }

        private void panelDepartman_Click(object sender, EventArgs e)
        {
            FrmDepartman frm = new FrmDepartman();
            frm.Show();
        }

        private void panelBankalar_Click(object sender, EventArgs e)
        {
            FrmBankalar frm = new FrmBankalar();
            frm.Show();
        }

        private void panelGorev_Click(object sender, EventArgs e)
        {
            FrmGorev frm = new FrmGorev();
            frm.Show();
        }

        private void panelIslem_Click(object sender, EventArgs e)
        {
            Frmislemler frm = new Frmislemler();
            frm.Show();
        }

        private void panelUrunGruplar_Click(object sender, EventArgs e)
        {
            FrmUrunGrup frm = new FrmUrunGrup();
            frm.Show();
        }

        private void panelBırım_Click(object sender, EventArgs e)
        {
            FrmBirim frm = new FrmBirim();
            frm.Show();
        }

        private void panelOda_Click(object sender, EventArgs e)
        {
            FrmOdalar frm = new FrmOdalar();
            frm.Show();
        }

        private void panelCarıTur_Click(object sender, EventArgs e)
        {
            FrmCariTurleri frm = new FrmCariTurleri();
            frm.Show();
        }
    }
}
