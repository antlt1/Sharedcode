using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BieuDoMuaQuat
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable ThongKe()
        {
            DataTable dt = new DataTable();
           // dt.Columns.Add("ThuTu", typeof(String)); // số thứ tự
            dt.Columns.Add("Sach", typeof(String));
            dt.Columns.Add("Tong", typeof(String)); // tổng theo select 
            /// add csdl giả
            /// 
            // data row thông kê
            DataRow dr = null;
            List<string> list_sach = new List<string>();
            list_sach.Add("Sách hư");
            list_sach.Add("Sách đã trả");
            list_sach.Add("Sách đng mượn");
            int count = 0;
            Random rand = new Random();
            foreach (string i in list_sach)
            {
                int tong = rand.Next(100, 10000);
                 //   count++;
                    dr = dt.NewRow();
                //    dr["ThuTu"] = count.ToString() ;
                    dr["Sach"] = i ;
                    dr["Tong"] = tong.ToString() ;
                dt.Rows.Add(dr);
            }
            return dt;
            
        }
        // tạo biểu đồ
        void TaoBieuDo()
        {
            ChartControl ThongKe1 = new ChartControl();
            ThongKe1.Titles.Add( new DevExpress.XtraCharts.ChartTitle() { Text =  "Thống kê sách" });

            Series se1 = new Series("Title thôi",ViewType.Pie); //
           foreach(DataRow dr in ThongKe().Rows)
            {
                se1.Points.Add(new SeriesPoint(dr["Sach"], dr["Tong"]));
               // MessageBox.Show(dr["Sach"].ToString());
            }
            se1.Label.TextPattern = "{A}: {VP:p2}";
            se1.LegendTextPattern = "{A}";
            ((PieSeriesLabel)se1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((PieSeriesLabel)se1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            // view
            PieSeriesView view = (PieSeriesView)se1.View;
            // Data srouce
            se1.ArgumentDataMember = "Sach";
            se1.ValueDataMembers.AddRange(new string[] { "Tong" });
            //document của dev
            ThongKe1.Series.Add(se1);
            // Specify a data filter to explode points.
            view.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_2,
                DataFilterCondition.GreaterThanOrEqual, 9));
            view.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Others"));
            view.ExplodeMode = PieExplodeMode.UseFilters;
            view.ExplodedDistancePercentage = 5;
            view.RuntimeExploding = true;

            // Customize the legend.
            ThongKe1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add the chart to the form.
            ThongKe1.Dock = DockStyle.Fill;
            this.Controls.Add(ThongKe1);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTVDataSet.DOC_GIA' table. You can move, or remove it, as needed.
            //this.dOC_GIATableAdapter.Fill(this.qLTVDataSet.DOC_GIA);
            // gridControl1.DataSource = ThongKe();
            TaoBieuDo();
        }
    }
}
