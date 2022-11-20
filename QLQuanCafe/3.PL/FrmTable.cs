using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL
{
    public partial class FrmTableManger : Form
    {
        public FrmTableManger()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcountProfile frmAcountProfile = new FrmAcountProfile();
            frmAcountProfile.ShowDialog();


        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.ShowDialog();
        }
    }
}
