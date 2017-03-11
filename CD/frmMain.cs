using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            setDetailEmp();
        }
        private void setDetailEmp()
        {
            StatusUserName.Text = EmpDetail.EMPNO;
            StatusEmpName.Text = EmpDetail.EMPNAME;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime day = DateTime.Today;
            StatusDate.Text = day.ToString("dd/MM/yyyy");
            frmBorrow f = new frmBorrow();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void MenuClose_Click(object sender, EventArgs e)
        {
            DialogResult dr =  MessageBox.Show("ต้องการออกจากโปรแกรมหรือไม่ ?", "Logout", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                EmpDetail.EMPID = 0;
                EmpDetail.EMPNAME = "";
                EmpDetail.EMPNO = "";
                frmLogin f = new frmLogin();
                f.Show();
                this.Visible = false;
            }
        }

        private void MenuManageMovie_Click(object sender, EventArgs e)
        {
           frmManageMouvie f = new frmManageMouvie();
           f.MdiParent = this;
           f.WindowState = FormWindowState.Maximized;
           f.Show(); 
        }

        private void MenuManageCatagory_Click(object sender, EventArgs e)
        {
            frmManageCatagory f = new frmManageCatagory();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void MenuManageMember_Click(object sender, EventArgs e)
        {
            frmManageMember f = new frmManageMember();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }


       

        private void MenuFront_Click(object sender, EventArgs e)
        {
            frmBorrow f = new frmBorrow();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void MenuReportCirculation_Click(object sender, EventArgs e)
        {
            frmReportCirculation f = new frmReportCirculation();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void MenuReportBorrow_Click(object sender, EventArgs e)
        {
            frmReportBorrow f = new frmReportBorrow();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }    
    }
}
