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

namespace Otel_App.Forms
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }
        OtelEntities db = new OtelEntities();
        private void FrmDurum_Load(object sender, EventArgs e)
        {
            db.TBLDURUM.Load();
            bindingSource1.DataSource = db.TBLDURUM.Local;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
