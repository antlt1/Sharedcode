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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                button6.Text = "ẩn";
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                button6.Text = "hiện";
                txt_pass.PasswordChar = '*';
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Class.Csdl_sys.Creater_id("", "", "TK");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("insert into taikhoan values('{0}',{1},{2},{3},{4},{5})");
            try
            {
                Class.Csdl_sys.ex_data(cmd);
                Class.Setting_sys.mess("Thêm nhân thành công !");

            }
            catch (Exception)
            {
                Class.Setting_sys.mess("Thêm nhân viên thất bại !");
            }
               
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
           // DataTable dt = Class.Csdl_sys.ex_data(string.Format(""));
           //for(int  i = 0; i < gv_nhanvien.Columns.Count; i++)
           // {
           //     gv_nhanvien.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           // }
        }

        private void gv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow gv = gv_nhanvien.Rows[e.RowIndex];
            txt_id.Text = gv.Cells[0].Value.ToString();
            txt_name.Text = gv.Cells[1].Value.ToString();
            txt_diachi.Text = gv.Cells[0].Value.ToString();
            txt_email.Text = gv.Cells[0].Value.ToString();
            txt_name.Text = gv.Cells[0].Value.ToString();
            txt_pass.Text = gv.Cells[0].Value.ToString();
            string gioitinh = (gv.Cells[0].Value.ToString() == "nam") ? "nam" : "nữ";
            rbtn_nam.Checked = (gioitinh == "nam") ? true : false;
            rbtn_nu.Checked = (gioitinh == "nữ") ? true : false;
            //if (gioitinh == "nam")
            //{
            //    rbtn_nam.Checked = true;
            //}
            //else
            //{
            //    rbtn_nu.Checked = true;
            //}
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("update taikhoan set  = '{0}', = {1}, = {2}, = {3}, = {4}, = {5})");
            try
            {
                Class.Csdl_sys.ex_data(cmd);
                Class.Setting_sys.mess("Sửa nhân thành công !");

            }
            catch (Exception)
            {
                Class.Setting_sys.mess("Sửa nhân viên thất bại !");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("delete taikhoan  where = '{0}' ",txt_id.Text);
            try
            {
                Class.Csdl_sys.ex_data(cmd);
                Class.Setting_sys.mess("Xoá nhân thành công !");

            }
            catch (Exception)
            {
                Class.Setting_sys.mess("Xoá nhân viên thất bại !");
            }
        }
    }
}
