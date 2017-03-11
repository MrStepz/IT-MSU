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
    public partial class frmManageMember : Form
    {
        SqlConnection con;
        Database db;
        string sql;
        public frmManageMember()
        {
            InitializeComponent();
        }

        private void frmManageMember_Load(object sender, EventArgs e)
        {
            LoadDataMem("");
            
        }
        public void LoadDataMem(string keyword)
        {
            db = new Database();
            con = db.getDatabase();
            con.Open();
            Query query = new Query(con);
            sql = "select mem_id as 'รหัสลูกค้า' , fname as'ชื่อ', lname as 'สกุล' , gender as 'เพศ',";
            sql += " address as 'ที่อยู่', tel as 'เบอรืโทร',pic as 'รูป' from member";
            if (keyword != "")
            {
                sql += " where mem_id LIKE'%"+ keyword + "%' or fname LIKE'%" + keyword + "%'";
                sql += " or lname LIKE'%" + keyword + "%'";
            }
            dataGridViewMember.DataSource = query.QueryList(sql);
            dataGridViewMember.Columns[3].Visible = false;
            dataGridViewMember.Columns[4].Visible = false;
            dataGridViewMember.Columns[5].Visible = false;
            dataGridViewMember.Columns[6].Visible = false;
            con.Close();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataMem(txtSearch.Text);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //db = new Database();
            //con = db.getDatabase();
            con.Open();
            Query query = new Query(con);
            string gender = "";
            if (rdMaleAdd.Checked == true) gender = "ชาย";
            if (rdFemaleAdd.Checked == true) gender = "หญิง";
            ImageConverter ic = new ImageConverter();
            byte[] img=null;
            if (pictureBoxImgAdd.Image != null)
            {
                img = (byte[])ic.ConvertTo(pictureBoxImgAdd.Image, typeof(byte[]));
            }
            sql = "insert into member(mem_id,fname,lname,gender,address,tel,pic)";
            sql += " values(@id,@fname,@lname,@gender,@address,@tel,@pic)";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar);
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar);
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar);
            cmd.Parameters.Add("@gender", SqlDbType.NChar);
            cmd.Parameters.Add("@address", SqlDbType.NVarChar);
            cmd.Parameters.Add("@tel", SqlDbType.NChar);
            cmd.Parameters.Add("@pic", SqlDbType.Image);

            cmd.Parameters["@id"].Value = txtIDAdd.Text;
            cmd.Parameters["@fname"].Value = txtFnameAdd.Text;
            cmd.Parameters["@lname"].Value = txtLnameAdd.Text;
            cmd.Parameters["@gender"].Value = gender;
            cmd.Parameters["@address"].Value = txtAddressAdd.Text;
            cmd.Parameters["@tel"].Value = txtTelAdd.Text;
            cmd.Parameters["@pic"].Value = img;
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
            }
            con.Close();
            LoadDataMem("");
        }

        private void btnImgAdd_Click(object sender, EventArgs e)
        {
           openFileDialogImg.ShowDialog();
           pictureBoxImgAdd.ImageLocation = openFileDialogImg.FileName;
        }

        private void dataGridViewMember_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridViewMember.CurrentCell.RowIndex;
                txtIDEdit.Text = dataGridViewMember.Rows[row].Cells[0].Value.ToString();
                txtFnameEdit.Text = dataGridViewMember.Rows[row].Cells[1].Value.ToString();
                txtLnameEdit.Text = dataGridViewMember.Rows[row].Cells[2].Value.ToString();
                string gender = dataGridViewMember.Rows[row].Cells[3].Value.ToString();
                if (gender == "ชาย") rdMaleEdit.Checked = true;
                if (gender == "หญิง") rdFemaleEdit.Checked = true;
                txtAddressEdit.Text = dataGridViewMember.Rows[row].Cells[4].Value.ToString();
                txtTelEdit.Text = dataGridViewMember.Rows[row].Cells[5].Value.ToString();
                byte[] img = (byte[])dataGridViewMember.Rows[row].Cells[6].Value;
                MemoryStream ms = new MemoryStream(img, 0, img.Length);
                ms.Position = 0;
                pictureBoxImgEdit.Image = Image.FromStream(ms);
            }
            catch { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            Query query = new Query(con);
            string gender = "";
            if (rdMaleEdit.Checked == true) gender = "ชาย";
            if (rdFemaleEdit.Checked == true) gender = "หญิง";
            ImageConverter ic = new ImageConverter();
            byte[] img = null;
            if (pictureBoxImgEdit.Image != null)
            {
                img = (byte[])ic.ConvertTo(pictureBoxImgEdit.Image, typeof(byte[]));
            }
            sql = "update member set fname=@fname,lname=@lname,";
            sql += " gender=@gender,address=@address,tel=@tel,pic=@pic";
            sql += " where mem_id=@id";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar);
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar);
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar);
            cmd.Parameters.Add("@gender", SqlDbType.NChar);
            cmd.Parameters.Add("@address", SqlDbType.NVarChar);
            cmd.Parameters.Add("@tel", SqlDbType.NChar);
            cmd.Parameters.Add("@pic", SqlDbType.Image);

            cmd.Parameters["@id"].Value = txtIDEdit.Text;
            cmd.Parameters["@fname"].Value = txtFnameEdit.Text;
            cmd.Parameters["@lname"].Value = txtLnameEdit.Text;
            cmd.Parameters["@gender"].Value = gender;
            cmd.Parameters["@address"].Value = txtAddressEdit.Text;
            cmd.Parameters["@tel"].Value = txtTelEdit.Text;
            cmd.Parameters["@pic"].Value = img;
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
            }
            con.Close();
            LoadDataMem("");
        }

        private void btnImgEdit_Click(object sender, EventArgs e)
        {
            openFileDialogImg.ShowDialog();
            pictureBoxImgEdit.ImageLocation = openFileDialogImg.FileName;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string name = txtFnameEdit.Text+" "+txtLnameEdit.Text;
            DialogResult dr = MessageBox.Show("ต้องการลบข้อมูล " + name + " หรือไม่", "ลบข้อมูล", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                con.Open();
                sql = "delete member where mem_id = '" + txtIDEdit.Text + "'";
                Query query = new Query(con);
                int result = query.Remove(sql);
                if (result > 0)
                {
                    MessageBox.Show("ลบข้อมูลสำเร็จ");
                }
                con.Close();
                LoadDataMem("");
            }
        }
    }
}
