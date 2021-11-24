using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_Sqlite.Class;

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
        Getting_UI G_U = new Getting_UI();
        void BieuDoLine(DateTime dt_start , DateTime dt_finelly) // 12 - 11
        {
            ChartControl lineChart = new ChartControl();

            // Create a line series.
            Series series1 = new Series("Sách mượn đã trả", ViewType.Line);
            Series series2 = new Series("Sách mượn chưa chả", ViewType.Line);
            int result_time = dt_finelly.Month - dt_start.Month;
            for(int i = dt_start.Month; i <= dt_finelly.Month; i++)
            {
                //  MessageBox.Show(i.ToString());
                //    textEdit1.Text = string.Format(
                //"select count(*) from thongtin_muon where month(ngaytra) = {0}", i);
                string cmd1 = G_U.mysqli_ex_data(string.Format(
            "select count(*) as 'time' from thongtin_muon where month(ngaytra) = {0} and trangthai = 'Đả trả'" , i));
                string cmd2 = G_U.mysqli_ex_data(string.Format(
            "select count(*) as 'time' from thongtin_muon where month(ngaytra) = {0} and trangthai != 'Đả trả'", i));
                series1.Points.Add(new SeriesPoint(i,int.Parse(cmd1))); ;
                series2.Points.Add(new SeriesPoint(i, int.Parse(cmd2)));
            }
            lineChart.Series.Add(series1);
            lineChart.Series.Add(series2);
            series1.ArgumentScaleType = ScaleType.Numerical;
            // Access the view-type-specific options of the series.
            ((LineSeriesView)series1.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series1.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.Dash;
            ((LineSeriesView)series2.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series2.View).LineMarkerOptions.Kind = MarkerKind.Triangle;
            ((LineSeriesView)series2.View).LineStyle.DashStyle = DashStyle.Dash;
            // Access the type-specific options of the diagram.
            ((XYDiagram)lineChart.Diagram).EnableAxisXZooming = true;
                
            // Hide the legend (if necessary).
            lineChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add a title to the chart (if necessary).
            lineChart.Titles.Add(new ChartTitle());
            lineChart.Titles[0].Text = "A Line Chart";

            // Add the chart to the form.
            lineChart.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(lineChart);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Parse(dateEdit1.DateTime.ToString("yyyy-MM-dd")), d2 =
            DateTime.Parse(dateEdit2.DateTime.ToString("yyyy-MM-dd"));
            
            BieuDoLine(d1,d2);
        }
    }
}
