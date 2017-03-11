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
    public partial class frmManageMouvie : Form
    {
        SqlConnection con;
        Database db;
        string sql;
        public frmManageMouvie()
        {
            InitializeComponent();
        }
        private void frmManageMouvie_Load(object sender, EventArgs e)
        {
            LoadDataPro("");
            LoadDataCat();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataPro(txtSearch.Text);
        }
        public void LoadDataPro(string keyword)
        {
            db = new Database();
            con = db.getDatabase();
            con.Open();
            Query query = new Query(con);
            sql = "select p.pro_id as 'รหัส' , p.name as'ชื่อ', p.price as 'ราคา' , p.amount  as 'จำนวน',";
            sql += " p.detail ,p.use_time ,p.pic,c.cat_name as 'ประเภท',p.mulct as 'ค่าปรับ' from product p , category c ";
            sql += " where p.cat_id=c.cat_id ";
            if (keyword != "")
            {
                sql += " and( p.pro_id LIKE'%" + keyword + "%' or p.name  LIKE'%" + keyword + "%'";
                sql += " or c.cat_name  LIKE'%" + keyword + "%')";
            }
            System.Diagnostics.Debug.WriteLine("sql = "+sql);
            dataGridViewProduct.DataSource = query.QueryList(sql);
            SetGridViewProduct();
            con.Close();
        }
        public void SetGridViewProduct()
        {
            dataGridViewProduct.Columns[4].Visible = false;
            dataGridViewProduct.Columns[5].Visible = false;
            dataGridViewProduct.Columns[6].Visible = false;
            dataGridViewProduct.Columns[7].Visible = false;
            dataGridViewProduct.Columns[0].Width = 50;
            dataGridViewProduct.Columns[2].Width = 50;
            dataGridViewProduct.Columns[3].Width = 50;
            dataGridViewProduct.Columns[6].Width = 80;
            dataGridViewProduct.Columns[8].Width = 50;
        }
        public void LoadDataCat()
        {
            db = new Database();
            con = db.getDatabase();
            con.Open();
            Query query = new Query(con);
            sql = "select * from category";
            DataTable dt = query.QueryList(sql);
            comboBoxCatAdd.DataSource = dt;
            comboBoxCatAdd.DisplayMember = "cat_name";
            comboBoxCatAdd.ValueMember = "cat_id";
            comboBoxCatEdit.DataSource = dt;
            comboBoxCatEdit.DisplayMember = "cat_name";
            comboBoxCatEdit.ValueMember = "cat_id";
            con.Close();
        }
        private void btnImgAdd_Click(object sender, EventArgs e)
        {
            openFileDialogImg.ShowDialog();
            pictureBoxImgAdd.ImageLocation = openFileDialogImg.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            Query query = new Query(con);
            ImageConverter ic = new ImageConverter();
            byte[] img = null;
            if (pictureBoxImgAdd.Image != null)
            {
                img = (byte[])ic.ConvertTo(pictureBoxImgAdd.Image, typeof(byte[]));
            }
            sql = "insert into product(pro_id,name,price,amount,detail,cat_id,use_time,mulct,pic)";
            sql += " values(@id,@name,@price,@amount,@detail,@cat_id,@use_time,@mulct,@pic)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar);
            cmd.Parameters.Add("@price", SqlDbType.Float);
            cmd.Parameters.Add("@amount", SqlDbType.Int);
            cmd.Parameters.Add("@detail", SqlDbType.NVarChar);
            cmd.Parameters.Add("@cat_id", SqlDbType.NChar);
            cmd.Parameters.Add("@use_time", SqlDbType.Int);
            cmd.Parameters.Add("@mulct", SqlDbType.Float);
            cmd.Parameters.Add("@pic", SqlDbType.Image);

            cmd.Parameters["@id"].Value = txtIDAdd.Text;
            cmd.Parameters["@name"].Value = txtNameAdd.Text;
            cmd.Parameters["@price"].Value = txtPriceAdd.Text;
            cmd.Parameters["@amount"].Value = txtAmountAdd.Text;
            cmd.Parameters["@detail"].Value = txtDetailAdd.Text;
            cmd.Parameters["@cat_id"].Value = comboBoxCatAdd.SelectedValue.ToString();
            cmd.Parameters["@use_time"].Value = txtUseTimeAdd.Text;
            cmd.Parameters["@mulct"].Value = txtMulctAdd.Text;
            cmd.Parameters["@pic"].Value = img;
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
            }
            con.Close();
            LoadDataPro("");
        }

        private void dataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewProduct.CurrentCell.RowIndex;
                txtIDEdit.Text = dataGridViewProduct.Rows[row].Cells[0].Value.ToString();
                txtNameEdit.Text = dataGridViewProduct.Rows[row].Cells[1].Value.ToString();
                txtPriceEdit.Text = dataGridViewProduct.Rows[row].Cells[2].Value.ToString();
                txtAmountEdit.Text = dataGridViewProduct.Rows[row].Cells[3].Value.ToString();
                txtDetailEdit.Text = dataGridViewProduct.Rows[row].Cells[4].Value.ToString();
                txtUseTimeEdit.Text = dataGridViewProduct.Rows[row].Cells[5].Value.ToString();
                comboBoxCatEdit.Text = dataGridViewProduct.Rows[row].Cells[7].Value.ToString();
                txtMulctEdit.Text = dataGridViewProduct.Rows[row].Cells[8].Value.ToString();
                byte[] img = (byte[])dataGridViewProduct.Rows[row].Cells[6].Value;

                MemoryStream ms = new MemoryStream(img, 0, img.Length);
                ms.Position = 0;
                pictureBoxImgEdit.Image = Image.FromStream(ms);
            }
            catch { }
        }

        private void btnImgEdit_Click(object sender, EventArgs e)
        {
            openFileDialogImg.ShowDialog();
            pictureBoxImgEdit.ImageLocation = openFileDialogImg.FileName;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            Query query = new Query(con);
            ImageConverter ic = new ImageConverter();
            byte[] img = null;
            if (pictureBoxImgEdit.Image != null)
            {
                img = (byte[])ic.ConvertTo(pictureBoxImgEdit.Image, typeof(byte[]));
            }
            sql = "update product set name=@name,price=@price,";
            sql += " amount=@amount,detail=@detail,cat_id=@cat_id,use_time=@use_time,mulct=@mulct,pic=@pic";
            sql += " where pro_id=@id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar);
            cmd.Parameters.Add("@price", SqlDbType.Float);
            cmd.Parameters.Add("@amount", SqlDbType.Int);
            cmd.Parameters.Add("@detail", SqlDbType.NVarChar);
            cmd.Parameters.Add("@cat_id", SqlDbType.NChar);
            cmd.Parameters.Add("@use_time", SqlDbType.Int);
            cmd.Parameters.Add("@mulct", SqlDbType.Float);
            cmd.Parameters.Add("@pic", SqlDbType.Image);

            cmd.Parameters["@id"].Value = txtIDEdit.Text;
            cmd.Parameters["@name"].Value = txtNameEdit.Text;
            cmd.Parameters["@price"].Value = txtPriceEdit.Text;
            cmd.Parameters["@amount"].Value = txtAmountEdit.Text;
            cmd.Parameters["@detail"].Value = txtDetailEdit.Text;
            cmd.Parameters["@cat_id"].Value = comboBoxCatEdit.SelectedValue.ToString();
            cmd.Parameters["@use_time"].Value = txtUseTimeEdit.Text;
            cmd.Parameters["@mulct"].Value = txtMulctEdit.Text;
            cmd.Parameters["@pic"].Value = img;
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
            }
            con.Close();
            LoadDataPro("");
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("ต้องการลบข้อมูล " + txtNameEdit.Text + " หรือไม่", "ลบข้อมูล",MessageBoxButtons.YesNo);
            if (dr==DialogResult.Yes) { 
            con.Open();
            sql = "delete product where pro_id = '" + txtIDEdit.Text + "'";
            Query query = new Query(con);
            int result = query.Remove(sql);
            if (result > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
            }
            con.Close();
            LoadDataPro("");
            }
        }
    }
}
