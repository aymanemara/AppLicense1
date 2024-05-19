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

namespace SoftwareLocker
{
    public partial class frmDialog : DevExpress.XtraEditors.XtraForm
    {
        private string _Pass;

        public frmDialog(string BaseString,
            string Password, int DaysToEnd, int Runed, string info)
        {
            InitializeComponent();
            sebBaseString.Text = BaseString;
            _Pass = Password;
            lbldays.Text = DaysToEnd.ToString();
            //lblTimes.Text = Runed.ToString() + " Time(s)";
            //lblText.Text = info;
            if (DaysToEnd <= 0 /*|| Runed <= 0*/)
            {
                lbldays.Text = "انتهت";
                //lblTimes.Text = "Finished";
                btnTrial.Enabled = false;
            }

            sebPassword.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_Pass == sebPassword.Text)
            {
                MessageBox.Show("تم التفعيل", "تأكيد",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("خطأ في التفعيل", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnTrial_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }
    }
}