namespace CD
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFront = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageMember = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageCatagory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportCirculation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusEmpName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFront,
            this.MenuManage,
            this.MenuReport,
            this.MenuClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFront
            // 
            this.MenuFront.Name = "MenuFront";
            this.MenuFront.Size = new System.Drawing.Size(55, 20);
            this.MenuFront.Text = "หน้าร้าน";
            this.MenuFront.Click += new System.EventHandler(this.MenuFront_Click);
            // 
            // MenuManage
            // 
            this.MenuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuManageMovie,
            this.MenuManageMember,
            this.MenuManageCatagory});
            this.MenuManage.Name = "MenuManage";
            this.MenuManage.Size = new System.Drawing.Size(75, 20);
            this.MenuManage.Text = "จัดการข้อมูล";
            // 
            // MenuManageMovie
            // 
            this.MenuManageMovie.Name = "MenuManageMovie";
            this.MenuManageMovie.Size = new System.Drawing.Size(182, 22);
            this.MenuManageMovie.Text = "จัดการข้อมูลหนัง";
            this.MenuManageMovie.Click += new System.EventHandler(this.MenuManageMovie_Click);
            // 
            // MenuManageMember
            // 
            this.MenuManageMember.Name = "MenuManageMember";
            this.MenuManageMember.Size = new System.Drawing.Size(182, 22);
            this.MenuManageMember.Text = "จัดการข้อมูลลูกค้า";
            this.MenuManageMember.Click += new System.EventHandler(this.MenuManageMember_Click);
            // 
            // MenuManageCatagory
            // 
            this.MenuManageCatagory.Name = "MenuManageCatagory";
            this.MenuManageCatagory.Size = new System.Drawing.Size(182, 22);
            this.MenuManageCatagory.Text = "จัดการข้อมูลประเภทหนัง";
            this.MenuManageCatagory.Click += new System.EventHandler(this.MenuManageCatagory_Click);
            // 
            // MenuReport
            // 
            this.MenuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuReportCirculation,
            this.MenuReportBorrow});
            this.MenuReport.Name = "MenuReport";
            this.MenuReport.Size = new System.Drawing.Size(52, 20);
            this.MenuReport.Text = "รายงาน";
            // 
            // MenuReportCirculation
            // 
            this.MenuReportCirculation.Name = "MenuReportCirculation";
            this.MenuReportCirculation.Size = new System.Drawing.Size(134, 22);
            this.MenuReportCirculation.Text = "ยอดขาย";
            this.MenuReportCirculation.Click += new System.EventHandler(this.MenuReportCirculation_Click);
            // 
            // MenuReportBorrow
            // 
            this.MenuReportBorrow.Name = "MenuReportBorrow";
            this.MenuReportBorrow.Size = new System.Drawing.Size(134, 22);
            this.MenuReportBorrow.Text = "ประวัติการเช่า";
            this.MenuReportBorrow.Click += new System.EventHandler(this.MenuReportBorrow_Click);
            // 
            // MenuClose
            // 
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.Size = new System.Drawing.Size(79, 20);
            this.MenuClose.Text = "ออกจากระบบ";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.StatusUserName,
            this.toolStripStatusLabel4,
            this.StatusEmpName,
            this.toolStripStatusLabel6,
            this.StatusDate});
            this.statusBar.Location = new System.Drawing.Point(0, 501);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(700, 22);
            this.statusBar.TabIndex = 4;
            this.statusBar.Text = "statusBar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel2.Text = "รหัสพนักงาน  : ";
            // 
            // StatusUserName
            // 
            this.StatusUserName.Name = "StatusUserName";
            this.StatusUserName.Size = new System.Drawing.Size(27, 17);
            this.StatusUserName.Text = "xxxx";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel4.Text = "ชื่อพนักงาน : ";
            // 
            // StatusEmpName
            // 
            this.StatusEmpName.Name = "StatusEmpName";
            this.StatusEmpName.Size = new System.Drawing.Size(27, 17);
            this.StatusEmpName.Text = "xxxx";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel6.Text = "วันที่ ";
            // 
            // StatusDate
            // 
            this.StatusDate.Name = "StatusDate";
            this.StatusDate.Size = new System.Drawing.Size(22, 17);
            this.StatusDate.Text = "xxx";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 523);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "โปรแกรมจัดร้านเช่าหนัง";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFront;
        private System.Windows.Forms.ToolStripMenuItem MenuManage;
        private System.Windows.Forms.ToolStripMenuItem MenuReport;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.ToolStripMenuItem MenuManageMovie;
        private System.Windows.Forms.ToolStripMenuItem MenuManageMember;
        private System.Windows.Forms.ToolStripMenuItem MenuManageCatagory;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel StatusUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel StatusEmpName;
        private System.Windows.Forms.ToolStripMenuItem MenuReportCirculation;
        private System.Windows.Forms.ToolStripMenuItem MenuReportBorrow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel StatusDate;
    }
}

