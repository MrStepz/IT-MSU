using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CD
{
    public partial class frmReportCirculation : Form
    {
        SqlConnection con;
        Database db;
        DataTable dt;
        string sql;
        string dateFrom, dateTo;
        public frmReportCirculation()
        {
            InitializeComponent();
        }
        private void frmCirculation_Load(object sender, EventArgs e)
        {
            db = new Database();
            con = db.getDatabase();
            dateTimeFrom.Value = DateTime.Now.AddDays(0);
            dateTimeFrom.Value = DateTime.Now.AddMonths(0);
            dateTimeFrom.Value = DateTime.Now.AddYears(0);

            dateTimeTo.Value = DateTime.Now.AddDays(0);
            dateTimeTo.Value = DateTime.Now.AddMonths(0);
            dateTimeTo.Value = DateTime.Now.AddYears(0);

            dateTimeFrom.Format = DateTimePickerFormat.Custom;
            dateTimeFrom.CustomFormat = "dd/MM/yyyy";
            dateTimeTo.Format = DateTimePickerFormat.Custom;
            dateTimeTo.CustomFormat = "dd/MM/yyyy";
            LoadDataCirculation();
        }
        private void LoadDataCirculation()
        {
            dateFrom =  DateConvert.dmyToymd(dateTimeFrom.Text);
            dateTo = DateConvert.dmyToymd(dateTimeTo.Text);
            dataGridViewCirculation.DataSource = QueryDataCirculation(dateFrom, dateTo);
            lblCntRows.Text = dataGridViewCirculation.Rows.Count.ToString();
            lblCntPrice.Text = CountPrice().ToString()+" บาท";
            SetGridViewCirculation();
            
        }
        private DataTable QueryDataCirculation(string dateFrom, string dateTo)
        {
            con.Open();
            Query query = new Query(con);
            sql = "select p.pro_id, p.name ";
            sql += ",d.pro_price,b.date_borrow, b.time_borrow ,e.name";
            sql += " from product p,borrow_detail d ,borrow b ,employee e";
            sql += " where d.pro_id = p.pro_id and b.borrow_id = d.borrow_id";
            sql += " and b.date_borrow between '" + dateFrom + "' and '" + dateTo + "' ";
            sql += " and b.emp_id = e.emp_id order by p.pro_id asc";
            System.Diagnostics.Debug.WriteLine("LoadDataCirculation = " + sql);
            SqlDataReader rd = query.QuerySingle(sql);
            dt = new DataTable();
            dt.Columns.Add("รหัสหนัง");
            dt.Columns.Add("ชื่อหนัง");
            dt.Columns.Add("ราคา");
            dt.Columns.Add("วันที่บันทึก");
            dt.Columns.Add("เวลา");
            dt.Columns.Add("พนักงานขาย");
            while (rd.Read())
            {
                string date = DateConvert.ymdTodmy(rd.GetDateTime(3).ToShortDateString());
                dt.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetDouble(2), date, rd.GetString(4), rd.GetString(5));
            }
            rd.Close();
            con.Close();
            return dt;
        }
        private int  CountPrice()
        {
            int cntRows = dataGridViewCirculation.Rows.Count;
            int sum = 0;
            for (int i=0;i<cntRows;i++)
            {
                sum += int.Parse(dataGridViewCirculation.Rows[i].Cells[2].Value.ToString());
            }
            return sum;
        }
        private void SetGridViewCirculation()
        {
            dataGridViewCirculation.Columns[0].Width = 100;
            dataGridViewCirculation.Columns[1].Width = 200;
            dataGridViewCirculation.Columns[2].Width = 50;
            dataGridViewCirculation.Columns[3].Width = 80;
            dataGridViewCirculation.Columns[4].Width = 80;
            dataGridViewCirculation.Columns[5].Width = 130;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadDataCirculation();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewCirculation.DataSource != null)
            {
                printPreviewCirculation.Document = printDocumentCirculation;
                printPreviewCirculation.ShowDialog();
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูล", "ไม่สามารภพิมพ์ได้");
            }
        }

        private void printDocumentCirculation_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //set font
            int x = 50, y = 45;
            Font fontHead = new Font("Arial", 20, FontStyle.Bold);
            Font fontTile = new Font("Arial", 13, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10, FontStyle.Regular);
            e.Graphics.DrawString("รายงานยอดขาย", fontHead, Brushes.Black,
                new Point(320, 20));
            string to = DateConvert.ymdTodmy(dateFrom);
            string from = DateConvert.ymdTodmy(dateTo);
            e.Graphics.DrawString("วันที่ "+ to +" ถึง "+ from, fontTile, Brushes.Black,
               new Point(300, 60));
            e.Graphics.DrawLine(new Pen(Brushes.Black),
                new Point(5, 80), new Point(838, 80));
            y += 100;
           // x += 45;
            e.Graphics.DrawString("รหัสหนัง", fontNormal, Brushes.Black,
                new Point(x, y));
            x += 160;
            e.Graphics.DrawString("ชื่อหนัง", fontNormal, Brushes.Black,
               new Point(x, y));
            x += 160;
            e.Graphics.DrawString("ราคา", fontNormal, Brushes.Black,
             new Point(x, y));
            x += 130;
            e.Graphics.DrawString("วันที่บันทึก / เวลา", fontNormal, Brushes.Black,
           new Point(x, y));
            x += 200;
            e.Graphics.DrawString("พนักงานขาย", fontNormal, Brushes.Black,
             new Point(x, y));
            //query 
            con.Open();
            Query query = new Query(con);
            sql = "select p.pro_id, p.name ";
            sql += ",d.pro_price,b.date_borrow, b.time_borrow ,e.name";
            sql += " from product p,borrow_detail d ,borrow b ,employee e";
            sql += " where d.pro_id = p.pro_id and b.borrow_id = d.borrow_id";
            sql += " and b.date_borrow between '" + dateFrom + "' and '" + dateTo + "' ";
            sql += " and b.emp_id = e.emp_id order by p.pro_id asc";
            SqlDataReader rd = query.QuerySingle(sql);

            //loop  rd
            y += 45;
            x = 50;
            while (rd.Read())
            {  
                e.Graphics.DrawString(rd[0].ToString(), fontNormal, Brushes.Black,
                new Point(x, y));
                x += 100;
               
                e.Graphics.DrawString(rd[1].ToString(),fontNormal, Brushes.Black,
                new Point(x, y));
                x += 220;

                e.Graphics.DrawString(rd[2].ToString(), fontNormal, Brushes.Black,
              new Point(x, y));
                x += 130;
                string date = rd.GetDateTime(3).ToString("dd/MM/yyyy");
                string time = rd.GetString(4).ToString();
                e.Graphics.DrawString(date+ " | "+ time, fontNormal, Brushes.Black,
               new Point(x, y));
                x += 200;

                e.Graphics.DrawString(rd[5].ToString(),fontNormal, Brushes.Black,
                new Point(x, y));

                x = 50;
                y += 30;
            }
            y += 30;
            e.Graphics.DrawLine(new Pen(Brushes.Black),
             new Point(5, y), new Point(838, y));
            y += 30;
            int totalList= dataGridViewCirculation.Rows.Count;
            int SumPrice = CountPrice();
            e.Graphics.DrawString("ทั้งหมด " + totalList + " รายการ", fontNormal, Brushes.Black,
           new Point(x, y));
            e.Graphics.DrawString("รวม " + SumPrice + " บาท", fontNormal, Brushes.Black,
           new Point(x+=150, y));
            y += 30;
            e.Graphics.DrawLine(new Pen(Brushes.Black),
            new Point(5, y), new Point(838, y));
            con.Close();
            rd.Close();
        }
    }
}
