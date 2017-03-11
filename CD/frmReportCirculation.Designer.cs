namespace CD
{
    partial class frmReportCirculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportCirculation));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCntPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCntRows = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCirculation = new System.Windows.Forms.DataGridView();
            this.printDocumentCirculation = new System.Drawing.Printing.PrintDocument();
            this.printPreviewCirculation = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCirculation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.dateTimeTo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.dateTimeFrom);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 70);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "วันที่ค้นหา";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(536, 28);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(85, 23);
            this.btnPrint.TabIndex = 68;
            this.btnPrint.Text = "พิมพ์";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(279, 28);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(130, 20);
            this.dateTimeTo.TabIndex = 67;
            this.dateTimeTo.Value = new System.DateTime(2016, 5, 2, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "ถึง";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(445, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "แสดงข้อมูล";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(95, 28);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(130, 20);
            this.dateTimeFrom.TabIndex = 59;
            this.dateTimeFrom.Value = new System.DateTime(2016, 5, 2, 0, 0, 0, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(47, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "ระหว่าง";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCntPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblCntRows);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewCirculation);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 348);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายงาน";
            // 
            // lblCntPrice
            // 
            this.lblCntPrice.AutoSize = true;
            this.lblCntPrice.Location = new System.Drawing.Point(197, 329);
            this.lblCntPrice.Name = "lblCntPrice";
            this.lblCntPrice.Size = new System.Drawing.Size(13, 13);
            this.lblCntPrice.TabIndex = 74;
            this.lblCntPrice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "รวมเป็นเงิน";
            // 
            // lblCntRows
            // 
            this.lblCntRows.AutoSize = true;
            this.lblCntRows.Location = new System.Drawing.Point(45, 329);
            this.lblCntRows.Name = "lblCntRows";
            this.lblCntRows.Size = new System.Drawing.Size(13, 13);
            this.lblCntRows.TabIndex = 71;
            this.lblCntRows.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "รายการ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "ทั้งหมด";
            // 
            // dataGridViewCirculation
            // 
            this.dataGridViewCirculation.AllowUserToAddRows = false;
            this.dataGridViewCirculation.AllowUserToDeleteRows = false;
            this.dataGridViewCirculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCirculation.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewCirculation.Name = "dataGridViewCirculation";
            this.dataGridViewCirculation.ReadOnly = true;
            this.dataGridViewCirculation.RowHeadersVisible = false;
            this.dataGridViewCirculation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCirculation.Size = new System.Drawing.Size(646, 298);
            this.dataGridViewCirculation.TabIndex = 21;
            // 
            // printDocumentCirculation
            // 
            this.printDocumentCirculation.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCirculation_PrintPage);
            // 
            // printPreviewCirculation
            // 
            this.printPreviewCirculation.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewCirculation.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewCirculation.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewCirculation.Enabled = true;
            this.printPreviewCirculation.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewCirculation.Icon")));
            this.printPreviewCirculation.Name = "printPreviewCirculation";
            this.printPreviewCirculation.Visible = false;
            // 
            // frmCirculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmCirculation";
            this.Text = "รายงานยอดขาย";
            this.Load += new System.EventHandler(this.frmCirculation_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCirculation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewCirculation;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCntRows;
        private System.Windows.Forms.Label lblCntPrice;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocumentCirculation;
        private System.Windows.Forms.PrintPreviewDialog printPreviewCirculation;
    }
}