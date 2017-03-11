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
using System.Globalization;
using System.IO;
using CrystalDecisions.Shared;
using System.Drawing.Printing;

namespace CD
{
    public partial class frmBorrow : Form
    {
        SqlConnection con;
        Database db;
        DataTable dt;
        string sql;
        public frmBorrow()
        {
            InitializeComponent();
        }
        private void frmBorrow_Load(object sender, EventArgs e)
        {
            db = new Database();
            con = db.getDatabase();
            dateTimeSaveBorrow.Format = DateTimePickerFormat.Custom;
            dateTimeSaveBorrow.Value = DateTime.Now.AddDays(0);
            dateTimeSaveBorrow.Value = DateTime.Now.AddMonths(0);
            dateTimeSaveBorrow.Value = DateTime.Now.AddYears(0);
            dateTimeSaveBorrow.CustomFormat = "dd/MM/yyyy";
        }
        private void btnImgAdd_Click(object sender, EventArgs e)
        {
            List<string> listID = BorrowList.View();
            string id = txtProID.Text;
            if (!listID.Contains(id))
            {
                BorrowList.AddItem(id);
                LoadList(listID);
            }
            else
            {
                MessageBox.Show("มีรายการนี้อยู่แล้ว");
            }
        }
        private void LoadList(List<string> listID)
        {
            dt = new DataTable();
            dt.Columns.Add("รหัส");
            dt.Columns.Add("ชื่อ");
            dt.Columns.Add("ราคา");
            dt.Columns.Add("ระยะเวลาเช่า");
            dt.Columns.Add("ประเภท");
            dt.Columns.Add("ค่าปรับ");
            dt.Columns.Add("รูป", typeof(byte[]));
            foreach (string item in listID)
            {
                con.Open();
                Query query = new Query(con);
                sql = "select p.pro_id , p.name, p.price,";
                sql += "p.use_time,c.cat_name ,p.mulct,";
                sql += "p.pic from product p , category c ";
                sql += " where p.cat_id=c.cat_id and p.pro_id = '" + item + "'";
                System.Diagnostics.Debug.WriteLine("sql = " + sql);
                SqlDataReader rd = query.QuerySingle(sql);
                while (rd.Read())
                {
                    dt.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetDouble(2), rd.GetInt32(3),
                                rd.GetString(4),rd.GetDouble(5), (byte[])rd.GetValue(6));
                }
                rd.Close();
                con.Close();
            }
            dataGridViewList.DataSource = dt;
            SetColDataGrideList();
            CountPrice();
        }
        private void SetColDataGrideList()
        {
            dataGridViewList.Columns[0].Width = 50;
            dataGridViewList.Columns[1].Width = 130;
            dataGridViewList.Columns[2].Width = 50;
            dataGridViewList.Columns[3].Width = 100;
            dataGridViewList.Columns[6].Visible = false;
        }
        private void CountPrice()
        {
            int countRows = dataGridViewList.RowCount;
            float sum = 0;
            for (int i = 0; i < countRows; i++)
            {
                string val = dataGridViewList.Rows[i].Cells[2].Value.ToString();
                sum += float.Parse(val);
            }
            txtSumBorrow.Text = sum.ToString();
        }
        private void txtMemID_TextChanged(object sender, EventArgs e)
        {
            SearchMember();
        }
        private void SearchMember()
        {
            con.Open();
            try
            {
                Query query = new Query(con);
                sql = "select fname+lname, tel ,address   from member where mem_id = '" + txtMemID.Text + "'";
                SqlDataReader rd = query.QuerySingle(sql);
                if (rd.Read())
                {
                    lblMemNameBorrow.Text = rd.GetString(0).ToString();
                    lblTelBorrow.Text = rd.GetString(1).ToString();
                    lblAddressBorrow.Text = rd.GetString(2).ToString();
                    txtProID.Visible = true;
                }
                else
                {
                    lblMemNameBorrow.Text = "??????";
                    lblTelBorrow.Text = "??????";
                    lblAddressBorrow.Text = "??????";
                    txtProID.Visible = false;
                }
            }
            catch { }
            con.Close();
        }
        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                Query query = new Query(con);
                sql = "select p.pro_id, p.name ,p.price,p.use_time,c.cat_name,p.mulct ,p.pic,p.amount";
                sql += " from product p,category c where p.cat_id = c.cat_id";
                sql += " and p.pro_id = '" + txtProID.Text + "'";
                System.Diagnostics.Debug.WriteLine("sql = " + sql);
                SqlDataReader rd = query.QuerySingle(sql);
                if (rd.Read())
                {
                    if (int.Parse(rd.GetInt32(7).ToString()) > 0)
                    {
                        
                    btnAdd.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("สินค้าหมด");
                    btnAdd.Visible = false;
                    }
                    lblProNameBorrow.Text = rd.GetString(1).ToString();
                    lblPriceBorrow.Text = rd.GetDouble(2).ToString("0");
                    lblUseTimeBorrow.Text = rd.GetInt32(3).ToString();
                    lblProCatBorrow.Text = rd.GetString(4).ToString();
                    lblMulct.Text = rd.GetDouble(5).ToString("0");
                    byte[] img = (byte[])rd.GetValue(6);
                    MemoryStream ms = new MemoryStream(img, 0, img.Length);
                    ms.Position = 0;
                    pictureBoxImgBorrow.Image = Image.FromStream(ms);
                }
                else
                {
                    lblProNameBorrow.Text = "??????";
                    lblPriceBorrow.Text = "??????";
                    lblUseTimeBorrow.Text = "??????";
                    lblProCatBorrow.Text = "??????";
                    lblMulct.Text = "???";
            }
        }
            catch { }
            con.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            BorrowList.RemoveItem(txtProID.Text);
            List<string> listID = BorrowList.View();
            LoadList(listID);
        }
        private void dataGridViewList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewList.CurrentCell.RowIndex;
                txtProID.Text = dataGridViewList.Rows[row].Cells[0].Value.ToString();
                lblProNameBorrow.Text = dataGridViewList.Rows[row].Cells[1].Value.ToString();
                lblPriceBorrow.Text = dataGridViewList.Rows[row].Cells[2].Value.ToString();
                lblUseTimeBorrow.Text = dataGridViewList.Rows[row].Cells[3].Value.ToString();
                lblProCatBorrow.Text = dataGridViewList.Rows[row].Cells[4].Value.ToString();
                lblMulct.Text = dataGridViewList.Rows[row].Cells[5].Value.ToString();
                byte[] img = (byte[])dataGridViewList.Rows[row].Cells[6].Value;
                MemoryStream ms = new MemoryStream(img, 0, img.Length);
                ms.Position = 0;
                pictureBoxImgBorrow.Image = Image.FromStream(ms);
            }
            catch { }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearGridViewList();
        }
        private void ClearGridViewList()
        {
            BorrowList.RemoveAll();
            List<string> listID = BorrowList.View();
            LoadList(listID);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int cntGridList = dataGridViewList.RowCount;
            //PrintBorrow();
            if (cntGridList > 0 && lblMemNameBorrow.Text != "")
            {
                con.Open();
                Query query = new Query(con);
                string borrorID = DateTime.UtcNow.ToString("yyMdHmsf", CultureInfo.InvariantCulture);
                string dateSave = DateConvert.dmyToymd(dateTimeSaveBorrow.Text);
                string timeSave = (DateTime.Now).ToShortTimeString();
                int empID = EmpDetail.EMPID;
                //System.Diagnostics.Debug.WriteLine("dateSave  = " + dateSave + "///dateSave  = " + timeSave+" ");
                sql = "insert into borrow(borrow_id,mem_id,date_borrow,time_borrow,emp_id) ";
                sql += "values('" + borrorID + "','" + txtMemID.Text + "','" + dateSave + "','" + timeSave + "'," + empID + ")";
                System.Diagnostics.Debug.WriteLine("borrow sql   = " + sql);
                int result = query.Add(sql);
                con.Close();
                if (result > 0)
                {
                    List<string> listID = BorrowList.View();
                    foreach (string item in listID)
                    {
                        con.Open();
                        query = new Query(con);
                        sql = "select * from product where pro_id = '" + item + "'";
                        System.Diagnostics.Debug.WriteLine("select sql   = " + sql);
                        SqlDataReader rd = query.QuerySingle(sql);

                        if (rd.Read())
                        {
                            int amount = int.Parse(rd.GetInt32(3).ToString());
                            string price = rd.GetDouble(2).ToString();
                            string useTime = rd.GetInt32(7).ToString();
                            string mulct = rd.GetDouble(8).ToString("0");
                            con.Close();
                            // insert borrow detail
                            con.Open();
                            query = new Query(con);
                            sql = "insert into borrow_detail(borrow_id,pro_id,pro_price,use_time,mulct)";
                            sql += "values('" + borrorID + "','" + item + "'," + price + "," + useTime + "," + mulct + ")";
                            query.Add(sql);
                            con.Close();
                            // update amount on stock
                            con.Open();
                            query = new Query(con);
                            sql = "update product set amount =" + (amount - 1) + "  where pro_id = '" + item + "'";
                            query.Edit(sql);
                            con.Close();
                        }
                        rd.Close();
                        con.Close();
                    }
                    //print
                    //PrintBorrow();
                    ClearGridViewList();
                }
                con.Close();
            }
            MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
        }
        private void PrintBorrow() {
            if (dataGridViewList.DataSource != null)
            {
                printPreviewBorrow.Document = printDocumentBorrow;
                printPreviewBorrow.ShowDialog();
            }
            else
            {
                MessageBox.Show("ไม่มีข้อมูล", "ไม่สามารภพิมพ์ได้");
            }
        }
        private void txtBorrowIDReturn_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                if (dataGridViewListReturn.DataSource != null)
                {
                    dataGridViewListReturn.Columns.Clear();
                }
                string borrowID = txtBorrowIDReturn.Text;
                Query query = new Query(con);
                sql = "select m.fname+' '+m.lname, b.date_borrow,b.time_borrow ,e.name from borrow b ,member m ,employee e ";
                sql += "where b.borrow_id = '" + borrowID + "' and m.mem_id = b.mem_id and e.emp_id = b.emp_id ";
                System.Diagnostics.Debug.WriteLine("sql borrow" + sql);
                SqlDataReader rd = query.QuerySingle(sql);
                if (rd.Read())//query borrow dtail
                {
                    string dateBorrow = rd.GetDateTime(1).ToShortDateString();
                    System.Diagnostics.Debug.WriteLine("dateBorrow" + dateBorrow);
                    lblMemBorrow.Text = rd.GetString(0).ToString();
                    lblDateBorrow.Text = Convert.ToDateTime(dateBorrow).ToString("dd/MM/yyyy");
                    System.Diagnostics.Debug.WriteLine(" Convert = " + Convert.ToDateTime(dateBorrow).ToString("dd/MM/yyyy"));
                    lblTimeBorrow.Text = rd.GetString(2).ToString();
                    lblEmpName.Text = rd.GetString(3).ToString();
                    rd.Close();
                    con.Close();
                    dt = new DataTable();
                    dt = LoadDataDataGridListReturn(dateBorrow , borrowID); // load data
                    AddCheckBoxGridCol(); //add chkbox
                    dataGridViewListReturn.DataSource = dt;
                    con.Close();
                   
                    AddColMulct(dateBorrow); //add Mulct
                    SetCheckCol();//set chkbox              
                    SetColDataGrideListReturn();//set gride
                }
                else
                {
                    ClearDataGridListReturn();
                    con.Close();
                    rd.Close();
                }
                txtMulctReturn.Text = CountMulct().ToString();
        }
           catch { }
           con.Close();
        }
        private DataTable LoadDataDataGridListReturn(string dateBorrow, string borrowID)
        { 
            con.Open();
            Query query = new Query(con);
            sql = "select p.pro_id, p.name,b.use_time";
            sql += " ,DATEADD(dd,b.use_time,'" + dateBorrow + "') as 'กำหนดคืน' ,p.pic ";
            sql += ",c.cat_name,b.detail_id,b.status from borrow_detail b, product p,category c ";
            sql += "where b.borrow_id = '" + borrowID + "' and b.pro_id =p.pro_id ";
            sql += "and c.cat_id = p.cat_id and b.status=0";
            System.Diagnostics.Debug.WriteLine("sql borrowdetail" + sql);
            dt = new DataTable();
            SqlDataReader rd = query.QuerySingle(sql);
            dt.Columns.Add("รหัส");
            dt.Columns.Add("ชื่อหนัง");
            dt.Columns.Add("ระยะเวลาเช่า");
            dt.Columns.Add("กำหนดคืน");
            dt.Columns.Add("รูป", typeof(byte[]));
            dt.Columns.Add("ประเภท");
            dt.Columns.Add("รหัสดีเทล");
            dt.Columns.Add("สถานะ");
            while (rd.Read())
            {
                string date = DateConvert.ymdTodmy(rd.GetDateTime(3).ToShortDateString());
                dt.Rows.Add(rd.GetString(0), rd.GetString(1), rd.GetInt32(2), date,
                            (byte[])rd.GetValue(4), rd.GetString(5), rd.GetInt32(6), rd.GetInt32(7));
            }
            return dt;
        }
        private void ClearDataGridListReturn()
        {
            lblMemNameBorrow.Text = "??????";
            lblDateBorrow.Text = "??????";
            lblTimeBorrow.Text = "??????";
            lblMemBorrow.Text = "??????";
            dataGridViewListReturn.DataSource = null;
            dataGridViewListReturn.Columns.Clear();
           
        }
        private void SetColDataGrideListReturn()
        {
            dataGridViewListReturn.Columns[1].Width = 50;
            dataGridViewListReturn.Columns[2].Width = 150;
            dataGridViewListReturn.Columns[3].Width = 100;
            dataGridViewListReturn.Columns[4].Width = 80;
            dataGridViewListReturn.Columns[9].Width = 80;
            dataGridViewListReturn.Columns[5].Visible = false;
            dataGridViewListReturn.Columns[6].Visible = false;
            dataGridViewListReturn.Columns[7].Visible = false;
            dataGridViewListReturn.Columns[8].Visible = false;
        }
        private double DateDiff(string borrowDetailID,string dateBorrow)
        {
            double result = 0;
            try
            {
                sql = "SELECT CASE WHEN DATEADD(dd, b.use_time,'" + dateBorrow + "') < getdate()";
                sql += " THEN p.mulct* DATEDIFF(day,DATEADD(dd, b.use_time,'"+dateBorrow+"'),getdate())";
                sql += " ELSE 0 END as 'ค่าปรับ' FROM product p ,borrow_detail b";
                sql += " where p.pro_id = b.pro_id and b.detail_id = '" + borrowDetailID + "'";
                System.Diagnostics.Debug.WriteLine("sql DateDiff" + sql);
                con.Open();
                Query query = new Query(con);
                SqlDataReader rd = query.QuerySingle(sql);
               
                if (rd.Read())
                {
                    result = Convert.ToDouble(rd.GetDouble(0).ToString());
                }
                rd.Close();
                con.Close();
            }
            catch { }
            return result;
        }
        private void AddColMulct(string dateBorrow)
        {
            DataGridViewColumn col = new DataGridViewColumn();
            col.HeaderText = "ค่าปรับ";
            col.Width = 30;
            dataGridViewListReturn.Columns.Add("col","ค่าปรับ");
            //add value
            int cntRow = dataGridViewListReturn.RowCount;
            for (int i = 0; i < cntRow; i++)
            {
                string borrowDetailID = dataGridViewListReturn.Rows[i].Cells[7].Value.ToString();
                double mulct = DateDiff(borrowDetailID, dateBorrow);// ค่าปรับ 
                dataGridViewListReturn.Rows[i].Cells[9].Value = mulct.ToString();

                //int status = int.Parse(dataGridViewListReturn.Rows[i].Cells[8].Value.ToString());
                //if (status == 0)
                //{
               
                //}
                //else
                //{
                //    dataGridViewListReturn.Rows[i].Cells[9].Value = 0.ToString();
                //}
            }
        }
        private void AddCheckBoxGridCol()
        {
            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            checkBox.HeaderText = "คืน";
            checkBox.Name = "chkBox";
            checkBox.Width = 30;
            dataGridViewListReturn.Columns.Insert(0, checkBox); 
        }
        private void SetCheckCol()
        {
            for (int i = 0; i < dataGridViewListReturn.Rows.Count; i++)
            {
                dataGridViewListReturn.Rows[i].Cells[0].Value = true;
            }
        }
        private void dataGridViewListReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
          
            object row = dataGridViewListReturn.Rows[index].Cells[0].Value;
            if ((bool)row == true)
            {
                dataGridViewListReturn.Rows[index].Cells[0].Value = false;
            }
            else
            {
                dataGridViewListReturn.Rows[index].Cells[0].Value = true;
            }
            txtMulctReturn.Text= CountMulct().ToString();
        }
        private void dataGridViewListReturn_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewListReturn.CurrentCell.RowIndex;
                lblProIDReturn.Text = dataGridViewListReturn.Rows[row].Cells[1].Value.ToString();
                lblProNameReturn.Text = dataGridViewListReturn.Rows[row].Cells[2].Value.ToString();
                lblUseTimeReturn.Text = dataGridViewListReturn.Rows[row].Cells[3].Value.ToString();
                string dateReturn = dataGridViewListReturn.Rows[row].Cells[4].Value.ToString();
                lblDateReturn.Text = Convert.ToDateTime(DateConvert.dmyToymd(dateReturn)).ToString("dd/MM/yyyy") ;
                lblCatNameReturn.Text = dataGridViewListReturn.Rows[row].Cells[6].Value.ToString();
                byte[] img = (byte[])dataGridViewListReturn.Rows[row].Cells[5].Value;
                MemoryStream ms = new MemoryStream(img, 0, img.Length);
                ms.Position = 0;
                pictureBoxImgReturn.Image = Image.FromStream(ms);
            }
            catch { }
        }
        private void btnSaveReturn_Click(object sender, EventArgs e)
        {
            int i =0;
            Query query = new Query(con);
            foreach (DataGridViewRow row in dataGridViewListReturn.Rows)
            {
                DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();
                chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if ((bool)chk.Value == true)
                {
                    //update borror
                    int detailID = int.Parse(dataGridViewListReturn.Rows[i].Cells[7].Value.ToString());
                    string val = dataGridViewListReturn.Rows[i].Cells[9].Value.ToString();
                    double mulct = Convert.ToDouble(val.ToString());
                    sql = "update borrow_detail set all_mulct="+ mulct + " ,status = '1'";
                    sql += " where detail_id = " + detailID + "";
                    con.Open();
                    query = new Query(con);
                    int result = query.Edit(sql);
                    con.Close();
                    // update select product
                    con.Open();
                    SqlDataReader rd = LoadProductByDetailID(con, detailID);
                    string pro_id = "";
                    int amount = 0;
                    if (rd.Read())
                    {
                        pro_id = rd.GetString(0).ToString();
                        amount = int.Parse(rd.GetInt32(1).ToString());
                        con.Close();
                        // update amount product
                        con.Open();
                        query = new Query(con);
                        sql = "update product set amount=" + (amount+1) + "";
                        sql += " where pro_id = '" + pro_id + "'";
                        result = query.Edit(sql);
                        con.Close();
                    }
                }
                ++i;
            }
            MessageBox.Show("บันทึกข้อมูลสำเร็จ");
            dataGridViewListReturn.DataSource = null;
            dataGridViewListReturn.Columns.Clear();
            lblProIDReturn.Text = "??????";
            lblProNameReturn.Text = "??????";
            lblCatNameReturn.Text = "??????";
            lblDateReturn.Text = "??????";
            lblUseTimeReturn.Text = "??????";
            pictureBoxImgReturn.Image = null;


        }
        private SqlDataReader LoadProductByDetailID(SqlConnection con,int detailID)
        {
            sql = "select p.pro_id,p.amount from product p , borrow_detail b where p.pro_id = b.pro_id";
            sql += " and b.detail_id="+ detailID;
            System.Diagnostics.Debug.WriteLine("LoadProductByDetailID = " + sql);
            Query query = new Query(con);
            SqlDataReader rd =  query.QuerySingle(sql);

            return rd;
        }
        private double CountMulct()
        {
            int cntRow = dataGridViewListReturn.RowCount;
            double mulct = 0;
          

            for (int i = 0; i < cntRow; i++)
            {
                object row = dataGridViewListReturn.Rows[i].Cells[0].Value;
                if ((bool)row == true)
                {
                    string val = dataGridViewListReturn.Rows[i].Cells[9].Value.ToString();
                    mulct += Convert.ToDouble(val.ToString());
                }
            }
            return mulct;
        }
        private void printDocumentBorrow_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //set font
            int x = 50, y = 45;
            Font fontHead = new Font("Arial", 20, FontStyle.Bold);
            Font fontTile = new Font("Arial", 13, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 10, FontStyle.Regular);
            e.PageSettings.PaperSize.RawKind = 45; //PaperKind.Standard10x11
            e.Graphics.DrawString("รายงานยอดขาย", fontHead, Brushes.Black,
                new Point(1, 1));
        }
    }
}

