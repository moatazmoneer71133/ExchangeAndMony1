using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ExchangeAndMony.pages.file
{
    public partial class frm_conFormat : DevExpress.XtraEditors.XtraForm
    {
        public frm_conFormat()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Mode = txt_conn.Text;
            Properties.Settings.Default.Server = txt_server.Text;
            Properties.Settings.Default.DB = txt_db.Text;
            Properties.Settings.Default.user = txt_user.Text;
            Properties.Settings.Default.password = txt_pass.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تمت عملية الحفظ بنجاح");



            btn_new.Enabled = true;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            btn_new.Enabled = false;
        }
    }
}