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
    public partial class frmhoadon : Form
    {
        public frmhoadon()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataTable hoadon(string id , string name,int sl)
        {          
            DataRow dr = dt.NewRow();        
            dr["Mã sản phẩm"] = id;
            dr["Tên sản phẩm"] = name;
            dr["Số lượng"] = sl;
            dt.Rows.Add(dr);
            return dt;
        }
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            button1_Click(sender,e);
            dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm", typeof(String));
            dt.Columns.Add("Tên sản phẩm", typeof(String));
            dt.Columns.Add("Số lượng", typeof(int));
            txt_diachi.Text = "";
            gv_cthd.DataSource = Class.Csdl_sys.ex_data("select h.MaHD as 'Mã hoá đơn' , s.masp as 'Mã sản phẩm' , s.TenSP 'Tên sản phẩm' , c.SoLuong as 'Số lượng' , c.ThanhTien as 'Tiền' , t.TenTK as 'Người lập phiếu' , h.SDT_KH as 'SĐT khách' , h.Ngay_GH as 'Ngày giao' , h.DiaChi_GH as 'Địa chỉ giao hàng'   from ChiTietHoaDon c , HoaDon h , TaiKhoan t , SanPham s where h.MaNV = t.MaTK and s.MaSP = c.MaSP");
            for(int i = 0; i < gv_cthd.Columns.Count; i++)
            {
                gv_cthd.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
         //   gv_cthd.Columns[1].Visible = false;
        }
        public static string id_sp , ma_sp;
        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            timer1.Start();
            var frm = new Console.Pick_Sanpham() ;
            frm.Show();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           
            if ( txt_diachi.Text != "" && txt_id.Text != "" && txt_sdt.Text != "")
            {
                string masp, tensp, sll, matk = QLKHOVATLIEU.frmMain.id_user_name, sdt = txt_sdt.Text, ngayhd = dt_pick.Value.ToShortDateString(), diachi = txt_diachi.Text;
                try
                {
                    Class.Csdl_sys.ex_cmd(string.Format("insert into HoaDon values ('{0}','{1}',{2},'{3}','{4}')", txt_id.Text, matk.Trim(), sdt, ngayhd, diachi));
                }
                catch (Exception)
                {
                    Class.Setting_sys.mess("Thêm hoá đơn thất bại !");
                }
                foreach (DataRow dr in dt.Rows)
                {
                    masp = dr["Mã sản phẩm"].ToString();
                    sll = dr["Số lượng"].ToString();
                    int tien = int.Parse(Class.Csdl_sys.ex_data_tring(string.Format("select DonGia from sanpham where masp = '{0}'", masp))) * 
                        int.Parse(sll);
                    Class.Csdl_sys.ex_cmd(string.Format("insert into ChiTietHoaDon values('{0}','{1}',{2},{3})", txt_id.Text,masp,sll,tien));
                }

                Class.Setting_sys.mess("Lập hoá đơn thành công !");
                frmhoadon_Load(sender,e);
            }
            else
            {
                Class.Setting_sys.mess("Không được bỏ trông thông tin hoá đơn.Vui lòng xem kỹ các thông tin nhập !");
            }
        }
        public static List<string> ls_ma_sp = new List<string>();
        public static int soluong;

        private void button1_Click(object sender, EventArgs e)
        {
            txt_id.Text = Class.Csdl_sys.Creater_id("hoadon", "mahd", "MH");
        }
        int term_txt_senderl = 0;
        private void txt_tien_TextChanged(object sender, EventArgs e)
        {
            //TextBox txt = sender as TextBox;
            //if(txt.Text.Length > 0)
            //{
            //    term_txt_senderl = 1;
            //}
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string masp_term;
        private void gv_cthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = gv_cthd.Rows[e.RowIndex];
            masp_term = rows.Cells[1].Value.ToString().Trim();
            lb_sp.Text = rows.Cells[2].Value.ToString().Trim();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("delete ChiTietHoaDon  where masp = '{0}' ", masp_term);
            try
            {
                if (MessageBox.Show("Bạn có chắc chấn muốn xoá hoá đơn  này ?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Class.Csdl_sys.ex_data(cmd);
                    Class.Setting_sys.mess("Xoá hoá đơn thành công !");
                    frmhoadon_Load(sender, e);
                }
            }
            catch (Exception)
            {
                Class.Setting_sys.mess("Xoá hoá đơn viên thất bại !");
            }
            txt_diachi.Text = cmd;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(id_sp != null)
            {
                if (ls_ma_sp.IndexOf(id_sp) < 0)
                {
                    gv_hoadon.DataSource = hoadon(id_sp, Class.Csdl_sys.ex_data_tring(string.Format("select tensp from sanpham where masp = '{0}'", id_sp)), soluong);
                    ls_ma_sp.Add(id_sp);
                }
            }
        }
    }
}
