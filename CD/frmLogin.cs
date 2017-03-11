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
    public partial class frmLogin : Form
    {
        SqlConnection con;
        Query query;
        string sql;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Database db = new Database();
            con = db.getDatabase();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            con.Open();
            query = new Query(con);
            string sql = "select * from employee where emp_no = '" + txtID.Text+"'";
            SqlDataReader rd = query.QuerySingle(sql);
            if (rd.Read())
            {
                EmpDetail.EMPID = int.Parse(rd[0].ToString());
                EmpDetail.EMPNO = rd[1].ToString();
                EmpDetail.EMPNAME = rd[2].ToString();
                frmMain f = new frmMain();
                f.Show();
                this.Visible = false;
            }
            else
            {
                lblFail.Text = "ไม่มีข้อมูล กรุณาใส่ข้อมูลใหม่";
            }
            rd.Close();
            con.Close();
        }
    }
}
