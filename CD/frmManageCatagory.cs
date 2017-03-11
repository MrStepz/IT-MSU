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

namespace CD
{
    public partial class frmManageCatagory : Form
    {
        SqlConnection con;
        Database db;
        string sql;
        public frmManageCatagory()
        {
            InitializeComponent();
        }

        private void frmManageCatagory_Load(object sender, EventArgs e)
        {
            LoadDataCat();
        }

        private void dataGridViewCat_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewCat.CurrentCell.RowIndex;
                txtIDEdit.Text = dataGridViewCat.Rows[row].Cells[0].Value.ToString();
                txtNameEdit.Text = dataGridViewCat.Rows[row].Cells[1].Value.ToString();
            }
            catch { }
        }

        public void LoadDataCat()
        {
            db = new Database();
            con = db.getDatabase();
            con.Open();
            Query query = new Query(con);
            sql = "select cat_id as 'รหัสประเภท', cat_name as 'ชื่อประเภทหนัง' from category";
            dataGridViewCat.DataSource = query.QueryList(sql);
            con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db = new Database();
            con = db.getDatabase();
            con.Open();
            Query query = new Query(con);
            sql = "update category set cat_name='" + txtNameEdit.Text + "' where cat_id='" + txtIDEdit.Text + "'";
            int result = query.Edit(sql);
            if (result > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
            }
            con.Close();
            LoadDataCat();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db = new Database();
            con = db.getDatabase();
            con.Open();
            Query query = new Query(con);
            sql = "delete category where cat_id='" + txtIDAdd.Text + "'";
            int result = query.Remove(sql);
            if (result > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
            }
            con.Close();
            LoadDataCat();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db = new Database();
            con = db.getDatabase();
            con.Open();
            Query query = new Query(con);
            sql = "insert into category(cat_id,cat_name) values('" + txtIDAdd.Text + "','" + txtNameAdd.Text + "')";
            int result = query.Add(sql);
            if (result > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
            }
            con.Close();
            LoadDataCat();
        }
    }
}
