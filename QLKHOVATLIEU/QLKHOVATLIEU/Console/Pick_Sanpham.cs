using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHOVATLIEU.Console
{
    public partial class Pick_Sanpham : Form
    {
        public Pick_Sanpham()
        {
            InitializeComponent();
        }

        private void Pick_Sanpham_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "MASP";
            comboBox1.DisplayMember = "TENSP";
            comboBox1.DataSource = Class.Csdl_sys.ex_data("select MaSP , TenSP from sanpham");

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
           
            
          
        }
        int gt = 0;
        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
           
          if (int.TryParse(txt_soluong.Text, out gt) == false)
            {
                Class.Setting_sys.mess("vui lòng nhập số !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QLKHOVATLIEU.frmhoadon.ls_ma_sp.IndexOf(comboBox1.SelectedValue.ToString().Trim()) < 0)
            {
                if (gt != 0)
                {
                    QLKHOVATLIEU.frmhoadon.id_sp = comboBox1.SelectedValue.ToString().Trim();
                    QLKHOVATLIEU.frmhoadon.soluong = gt;
                    this.Close();
                }
                else
                {
                    Class.Setting_sys.mess("Số lượng không được bỏ trống !");
                }
            }
            else
            {
                Class.Setting_sys.mess("Sản phẩm đã có trong hoá đơn vui lòng chọn sản phẩm khác!");
            }
           
        }
    }
}
