namespace CD
{
    partial class frmManageMember
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
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.tabControMenu = new System.Windows.Forms.TabControl();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIDAdd = new System.Windows.Forms.TextBox();
            this.txtTelAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddressAdd = new System.Windows.Forms.TextBox();
            this.txtLnameAdd = new System.Windows.Forms.TextBox();
            this.txtFnameAdd = new System.Windows.Forms.TextBox();
            this.pictureBoxImgAdd = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdMaleAdd = new System.Windows.Forms.RadioButton();
            this.rdFemaleAdd = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btnImgAdd = new System.Windows.Forms.Button();
            this.tabED = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAddressEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDEdit = new System.Windows.Forms.TextBox();
            this.txtTelEdit = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLnameEdit = new System.Windows.Forms.TextBox();
            this.txtFnameEdit = new System.Windows.Forms.TextBox();
            this.pictureBoxImgEdit = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdMaleEdit = new System.Windows.Forms.RadioButton();
            this.rdFemaleEdit = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.btnImgEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            this.tabControMenu.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgAdd)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabED.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgEdit)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.AllowUserToAddRows = false;
            this.dataGridViewMember.AllowUserToDeleteRows = false;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.ReadOnly = true;
            this.dataGridViewMember.RowHeadersVisible = false;
            this.dataGridViewMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMember.Size = new System.Drawing.Size(343, 384);
            this.dataGridViewMember.TabIndex = 1;
            this.dataGridViewMember.SelectionChanged += new System.EventHandler(this.dataGridViewMember_SelectionChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(71, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(182, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ค้นหาข้อมูล";
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.Filter = "JPEG files (*.jpg)|*jpg|PNG files |*png";
            // 
            // tabControMenu
            // 
            this.tabControMenu.Controls.Add(this.tabAdd);
            this.tabControMenu.Controls.Add(this.tabED);
            this.tabControMenu.Location = new System.Drawing.Point(361, 16);
            this.tabControMenu.Name = "tabControMenu";
            this.tabControMenu.SelectedIndex = 0;
            this.tabControMenu.Size = new System.Drawing.Size(313, 411);
            this.tabControMenu.TabIndex = 17;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.groupBox3);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(305, 385);
            this.tabAdd.TabIndex = 0;
            this.tabAdd.Text = "เพิ่ม";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIDAdd);
            this.groupBox3.Controls.Add(this.txtTelAdd);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtAddressAdd);
            this.groupBox3.Controls.Add(this.txtLnameAdd);
            this.groupBox3.Controls.Add(this.txtFnameAdd);
            this.groupBox3.Controls.Add(this.pictureBoxImgAdd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnImgAdd);
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 358);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลลูกค้า";
            // 
            // txtIDAdd
            // 
            this.txtIDAdd.Location = new System.Drawing.Point(178, 13);
            this.txtIDAdd.Name = "txtIDAdd";
            this.txtIDAdd.Size = new System.Drawing.Size(95, 20);
            this.txtIDAdd.TabIndex = 50;
            // 
            // txtTelAdd
            // 
            this.txtTelAdd.Location = new System.Drawing.Point(178, 155);
            this.txtTelAdd.Name = "txtTelAdd";
            this.txtTelAdd.Size = new System.Drawing.Size(95, 20);
            this.txtTelAdd.TabIndex = 49;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 23);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "เบอร์โทร";
            // 
            // txtAddressAdd
            // 
            this.txtAddressAdd.Location = new System.Drawing.Point(38, 192);
            this.txtAddressAdd.Multiline = true;
            this.txtAddressAdd.Name = "txtAddressAdd";
            this.txtAddressAdd.Size = new System.Drawing.Size(235, 109);
            this.txtAddressAdd.TabIndex = 44;
            // 
            // txtLnameAdd
            // 
            this.txtLnameAdd.Location = new System.Drawing.Point(178, 68);
            this.txtLnameAdd.Name = "txtLnameAdd";
            this.txtLnameAdd.Size = new System.Drawing.Size(95, 20);
            this.txtLnameAdd.TabIndex = 43;
            // 
            // txtFnameAdd
            // 
            this.txtFnameAdd.Location = new System.Drawing.Point(178, 42);
            this.txtFnameAdd.Name = "txtFnameAdd";
            this.txtFnameAdd.Size = new System.Drawing.Size(95, 20);
            this.txtFnameAdd.TabIndex = 42;
            // 
            // pictureBoxImgAdd
            // 
            this.pictureBoxImgAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxImgAdd.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxImgAdd.Name = "pictureBoxImgAdd";
            this.pictureBoxImgAdd.Size = new System.Drawing.Size(100, 128);
            this.pictureBoxImgAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImgAdd.TabIndex = 41;
            this.pictureBoxImgAdd.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "ที่อยู่";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "รหัสลูกค้า";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "สกุล";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdMaleAdd);
            this.groupBox4.Controls.Add(this.rdFemaleAdd);
            this.groupBox4.Location = new System.Drawing.Point(131, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(142, 45);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "เพศ";
            // 
            // rdMaleAdd
            // 
            this.rdMaleAdd.AutoSize = true;
            this.rdMaleAdd.Location = new System.Drawing.Point(19, 19);
            this.rdMaleAdd.Name = "rdMaleAdd";
            this.rdMaleAdd.Size = new System.Drawing.Size(44, 17);
            this.rdMaleAdd.TabIndex = 3;
            this.rdMaleAdd.TabStop = true;
            this.rdMaleAdd.Text = "ชาย";
            this.rdMaleAdd.UseVisualStyleBackColor = true;
            // 
            // rdFemaleAdd
            // 
            this.rdFemaleAdd.AutoSize = true;
            this.rdFemaleAdd.Location = new System.Drawing.Point(93, 19);
            this.rdFemaleAdd.Name = "rdFemaleAdd";
            this.rdFemaleAdd.Size = new System.Drawing.Size(46, 17);
            this.rdFemaleAdd.TabIndex = 4;
            this.rdFemaleAdd.TabStop = true;
            this.rdFemaleAdd.Text = "หญิง";
            this.rdFemaleAdd.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "ขื่อ";
            // 
            // btnImgAdd
            // 
            this.btnImgAdd.Location = new System.Drawing.Point(28, 154);
            this.btnImgAdd.Name = "btnImgAdd";
            this.btnImgAdd.Size = new System.Drawing.Size(55, 23);
            this.btnImgAdd.TabIndex = 35;
            this.btnImgAdd.Text = "เลือกรูป";
            this.btnImgAdd.UseVisualStyleBackColor = true;
            this.btnImgAdd.Click += new System.EventHandler(this.btnImgAdd_Click);
            // 
            // tabED
            // 
            this.tabED.Controls.Add(this.groupBox5);
            this.tabED.Location = new System.Drawing.Point(4, 22);
            this.tabED.Name = "tabED";
            this.tabED.Padding = new System.Windows.Forms.Padding(3);
            this.tabED.Size = new System.Drawing.Size(305, 385);
            this.tabED.TabIndex = 1;
            this.tabED.Text = "แก้ไข/ลบ";
            this.tabED.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAddressEdit);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtIDEdit);
            this.groupBox5.Controls.Add(this.txtTelEdit);
            this.groupBox5.Controls.Add(this.btnDel);
            this.groupBox5.Controls.Add(this.btnEdit);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtLnameEdit);
            this.groupBox5.Controls.Add(this.txtFnameEdit);
            this.groupBox5.Controls.Add(this.pictureBoxImgEdit);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.btnImgEdit);
            this.groupBox5.Location = new System.Drawing.Point(12, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 375);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ข้อมูลลูกค้า";
            // 
            // txtAddressEdit
            // 
            this.txtAddressEdit.Location = new System.Drawing.Point(38, 192);
            this.txtAddressEdit.Multiline = true;
            this.txtAddressEdit.Name = "txtAddressEdit";
            this.txtAddressEdit.Size = new System.Drawing.Size(235, 109);
            this.txtAddressEdit.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "ที่อยู่";
            // 
            // txtIDEdit
            // 
            this.txtIDEdit.Location = new System.Drawing.Point(178, 13);
            this.txtIDEdit.Name = "txtIDEdit";
            this.txtIDEdit.ReadOnly = true;
            this.txtIDEdit.Size = new System.Drawing.Size(95, 20);
            this.txtIDEdit.TabIndex = 50;
            // 
            // txtTelEdit
            // 
            this.txtTelEdit.Location = new System.Drawing.Point(178, 155);
            this.txtTelEdit.Name = "txtTelEdit";
            this.txtTelEdit.Size = new System.Drawing.Size(95, 20);
            this.txtTelEdit.TabIndex = 49;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(96, 317);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(56, 23);
            this.btnDel.TabIndex = 48;
            this.btnDel.Text = "ลบ";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(34, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 23);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "เบอร์โทร";
            // 
            // txtLnameEdit
            // 
            this.txtLnameEdit.Location = new System.Drawing.Point(178, 68);
            this.txtLnameEdit.Name = "txtLnameEdit";
            this.txtLnameEdit.Size = new System.Drawing.Size(95, 20);
            this.txtLnameEdit.TabIndex = 43;
            // 
            // txtFnameEdit
            // 
            this.txtFnameEdit.Location = new System.Drawing.Point(178, 42);
            this.txtFnameEdit.Name = "txtFnameEdit";
            this.txtFnameEdit.Size = new System.Drawing.Size(95, 20);
            this.txtFnameEdit.TabIndex = 42;
            // 
            // pictureBoxImgEdit
            // 
            this.pictureBoxImgEdit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxImgEdit.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxImgEdit.Name = "pictureBoxImgEdit";
            this.pictureBoxImgEdit.Size = new System.Drawing.Size(100, 128);
            this.pictureBoxImgEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImgEdit.TabIndex = 41;
            this.pictureBoxImgEdit.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(121, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "รหัสลูกค้า";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "สกุล";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdMaleEdit);
            this.groupBox6.Controls.Add(this.rdFemaleEdit);
            this.groupBox6.Location = new System.Drawing.Point(131, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(142, 45);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "เพศ";
            // 
            // rdMaleEdit
            // 
            this.rdMaleEdit.AutoSize = true;
            this.rdMaleEdit.Location = new System.Drawing.Point(19, 19);
            this.rdMaleEdit.Name = "rdMaleEdit";
            this.rdMaleEdit.Size = new System.Drawing.Size(44, 17);
            this.rdMaleEdit.TabIndex = 3;
            this.rdMaleEdit.TabStop = true;
            this.rdMaleEdit.Text = "ชาย";
            this.rdMaleEdit.UseVisualStyleBackColor = true;
            // 
            // rdFemaleEdit
            // 
            this.rdFemaleEdit.AutoSize = true;
            this.rdFemaleEdit.Location = new System.Drawing.Point(93, 19);
            this.rdFemaleEdit.Name = "rdFemaleEdit";
            this.rdFemaleEdit.Size = new System.Drawing.Size(46, 17);
            this.rdFemaleEdit.TabIndex = 4;
            this.rdFemaleEdit.TabStop = true;
            this.rdFemaleEdit.Text = "หญิง";
            this.rdFemaleEdit.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(147, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "ขื่อ";
            // 
            // btnImgEdit
            // 
            this.btnImgEdit.Location = new System.Drawing.Point(28, 154);
            this.btnImgEdit.Name = "btnImgEdit";
            this.btnImgEdit.Size = new System.Drawing.Size(55, 23);
            this.btnImgEdit.TabIndex = 35;
            this.btnImgEdit.Text = "เลือกรูป";
            this.btnImgEdit.UseVisualStyleBackColor = true;
            this.btnImgEdit.Click += new System.EventHandler(this.btnImgEdit_Click);
            // 
            // frmManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 439);
            this.ControlBox = false;
            this.Controls.Add(this.tabControMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewMember);
            this.Name = "frmManageMember";
            this.Text = "จัดการข้อมูลลูกค้า";
            this.Load += new System.EventHandler(this.frmManageMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            this.tabControMenu.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgAdd)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabED.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgEdit)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.TabControl tabControMenu;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabED;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIDAdd;
        private System.Windows.Forms.TextBox txtTelAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddressAdd;
        private System.Windows.Forms.TextBox txtLnameAdd;
        private System.Windows.Forms.TextBox txtFnameAdd;
        private System.Windows.Forms.PictureBox pictureBoxImgAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdMaleAdd;
        private System.Windows.Forms.RadioButton rdFemaleAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnImgAdd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtIDEdit;
        private System.Windows.Forms.TextBox txtTelEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLnameEdit;
        private System.Windows.Forms.TextBox txtFnameEdit;
        private System.Windows.Forms.PictureBox pictureBoxImgEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rdMaleEdit;
        private System.Windows.Forms.RadioButton rdFemaleEdit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnImgEdit;
        private System.Windows.Forms.TextBox txtAddressEdit;
        private System.Windows.Forms.Label label1;
    }
}