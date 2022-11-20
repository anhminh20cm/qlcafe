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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            loadAcountList();
        }

        void loadAcountList()
        {
            dgrid_account.ColumnCount= 4;
            dgrid_account.Columns[0].Name = "stt";
            dgrid_account.Columns[1].Name = "tên đăng nhập";
            dgrid_account.Columns[2].Name = "tên hiển thị";
            dgrid_account.Columns[3].Name = "mật khẩu";
            dgrid_account.Columns[0].Name = "loại";
            dgrid_account.Rows.Clear();
            foreach(var x in dgrid_account.Rows ) { }
        }
    }
}
