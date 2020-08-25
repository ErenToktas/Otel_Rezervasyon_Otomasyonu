﻿using System;
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

namespace Otel_App.Forms
{
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }
        OtelEntities db = new OtelEntities();
        private void FrmGorev_Load(object sender, EventArgs e)
        {
            db.TBLGOREV.Load();
            bindingSource1.DataSource = db.TBLGOREV.Local;

            repositoryItemLookUpEdit1.DataSource = (from x in db.TBLDEPARTMAN
                                                    select new
                                                    {
                                                        x.DEPARTMANID,
                                                        x.DEPARTMANAD
                                                    }).ToList();
            repositoryItemLookUpEdit2.DataSource = (from x in db.TBLDURUM
                                                    select new
                                                    {
                                                        x.DURUMID,
                                                        x.DURUMAD
                                                    }).ToList();
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
