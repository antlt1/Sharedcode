using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHOVATLIEU
{
    public partial class frmtracuu : Form
    {
        public frmtracuu()
        {
            InitializeComponent();
        }

        private void frmtracuu_Load(object sender, EventArgs e)
        {
            lb_sp.Text = Class.Csdl_sys.ex_data_tring("select COUNT(*) from SanPham ") ;
            lb_nv.Text = Class.Csdl_sys.ex_data_tring("select COUNT(*) from TaiKhoan where NhanVien = 1");
            lb_lsp.Text = Class.Csdl_sys.ex_data_tring("select COUNT(*) from LoaiSanPham");
            lb_kh.Text = Class.Csdl_sys.ex_data_tring("select COUNT(*) from KhoHang");
        }
    }
}
