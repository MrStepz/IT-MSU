using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CD
{
    public partial class frmReportBorrow : Form
    {
        SqlConnection con;
        Query query;
        DataTable dt = new DataTable();
        string sql;
        public frmReportBorrow()
        {
            InitializeComponent();
        }

        private void frmReportBorrow_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            con = db.getDatabase();
            AddItemStatus();
            comboBoxStatus.DataSource = dt;
            comboBoxStatus.DisplayMember = "lbl";
            comboBoxStatus.ValueMember = "val";
        }
        private void AddItemStatus()
        {
            dt = new DataTable();
            dt.Columns.Add("val");
            dt.Columns.Add("lbl");
            dt.Rows.Add("1", "ทั้งหมด");
            dt.Rows.Add("2", "คืนแล้ว");
            dt.Rows.Add("3", "ยังไม่คืน");
        }
        private void txtMemID_TextChanged(object sender, EventArgs e)
        {
            SearchReportBorrow(txtMemID.Text);
        }
        private void SearchReportBorrow(string MemID)
        {
            con.Open();
            query = new Query(con);
            sql = "select m.fname+' '+m.lname ,m.tel ,m.address,m.pic";
            sql += " from member m";
            sql += " where m.mem_id = '" + MemID + "'";
            System.Diagnostics.Debug.WriteLine("member sql =  " + sql);
            //query member 
            SqlDataReader rd = query.QuerySingle(sql);
            if (rd.Read())
            {
                lblMemName.Text = rd.GetString(0).ToString();
                lblTel.Text = rd.GetString(1).ToString();
                // lblAddress.Text = rd.GetString(2).ToString();
                // Img Member
                byte[] img = (byte[])rd.GetValue(3);
                MemoryStream ms = new MemoryStream(img, 0, img.Length);
                ms.Position = 0;
                pictureBoxImgMember.Image = Image.FromStream(ms);
                rd.Close();
                con.Close();

                //query borrow 
                con.Open();
                query = new Query(con);
                string statusBorrow = "case when d.status>0 then 'คืนแล้ว' else 'ยังไม่คืน' end as สถานะ";
                int statusVal = int.Parse(comboBoxStatus.SelectedValue.ToString());
                string statusCondition = "";
                if (statusVal == 1) statusCondition = "";
                if (statusVal == 2) statusCondition = " and d.status = "+1;
                if (statusVal == 3) statusCondition = " and d.status = " + 0;
                sql = "select d.pro_id , p.name,d.use_time,b.date_borrow," + statusBorrow + ",d.all_mulct,e.name , c.cat_name ,p.pic";
                sql += " from product p , borrow b , borrow_detail d  ,employee e ,category c";
                sql += " where p.pro_id=d.pro_id and d.borrow_id = b.borrow_id";
                sql += " and  e.emp_id = b.emp_id and c.cat_id =p.cat_id "+ statusCondition + " order by b.date_borrow asc";
                System.Diagnostics.Debug.WriteLine("borrow sql =  " + sql);
                rd = query.QuerySingle(sql);
                dt = new DataTable();
                dt.Columns.Add("รหัสหนัง");
                dt.Columns.Add("ชื่อ");
                dt.Columns.Add("ระยะเวลา");
                dt.Columns.Add("วันที่ยืม");
                dt.Columns.Add("สถานะ");
                dt.Columns.Add("ค่าปรับ");
                dt.Columns.Add("ผู้บันทึก");
                dt.Columns.Add("ประเภท");
                dt.Columns.Add("รูป", typeof(byte[]));
                while (rd.Read())
                {
                    string date = rd.GetDateTime(3).ToString("dd/MM/yyyy");
                    dt.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetInt32(2), date, rd.GetString(4),
                                rd.GetDouble(5).ToString("0"), rd.GetString(6), rd.GetString(7), (byte[])rd.GetValue(8));
                }
                dataGridViewList.DataSource = dt;
                SetGridViewList();
                int cntRows = dataGridViewList.RowCount;
                lblCntMulct.Text = CountMulct(cntRows).ToString();

                lblCntRows.Text = cntRows.ToString() + " รายการ";
                rd.Close();
                con.Close();
            }
            con.Close();
        }
        private int CountMulct(int rows)
        {
            int sum = 0;
            for (int i= 0;i<rows;i++)
            {
                sum += int.Parse(dataGridViewList.Rows[i].Cells[5].Value.ToString());
            }
            return sum;

        }
        private void SetGridViewList()
        {
            dataGridViewList.Columns[0].Width = 80;
            dataGridViewList.Columns[1].Width = 200;
            dataGridViewList.Columns[2].Width = 80;
            dataGridViewList.Columns[3].Width = 80;
            dataGridViewList.Columns[4].Width = 50;
            dataGridViewList.Columns[5].Width = 50;
            dataGridViewList.Columns[6].Width = 130;
            dataGridViewList.Columns[7].Visible = false;
            dataGridViewList.Columns[8].Visible = false;
        }
        private void dataGridViewList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewList.CurrentCell.RowIndex;
                lblProID.Text = dataGridViewList.Rows[row].Cells[0].Value.ToString();
                lblProName.Text = dataGridViewList.Rows[row].Cells[1].Value.ToString();
                lblUseTime.Text = dataGridViewList.Rows[row].Cells[2].Value.ToString();
                lblProCat.Text = dataGridViewList.Rows[row].Cells[7].Value.ToString();
                byte[] img = (byte[])dataGridViewList.Rows[row].Cells[8].Value;
                MemoryStream ms = new MemoryStream(img, 0, img.Length);
                ms.Position = 0;
                pictureBoxImgProduct.Image = Image.FromStream(ms);
            }
            catch { }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchReportBorrow(txtMemID.Text);
        }
    }
}
