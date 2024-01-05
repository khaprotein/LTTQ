
namespace ontap
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXT_PC = new System.Windows.Forms.TextBox();
            this.LB_PC = new System.Windows.Forms.Label();
            this.date_NVL = new System.Windows.Forms.DateTimePicker();
            this.TXT_DT = new System.Windows.Forms.TextBox();
            this.TXT_DS = new System.Windows.Forms.TextBox();
            this.TXT_HT = new System.Windows.Forms.TextBox();
            this.TXT_MNV = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton_GH = new System.Windows.Forms.RadioButton();
            this.radioButton_BH = new System.Windows.Forms.RadioButton();
            this.LB_DS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton_NU = new System.Windows.Forms.RadioButton();
            this.radioButton_NAM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_THONGKE = new System.Windows.Forms.Button();
            this.button_SAPXEP = new System.Windows.Forms.Button();
            this.button_SUA = new System.Windows.Forms.Button();
            this.button_XOA = new System.Windows.Forms.Button();
            this.button_LUU = new System.Windows.Forms.Button();
            this.button_THEM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MANV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HOTEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GIOITINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIENTHOAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NGAYVL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOANHSO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PCNL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 152);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MANV,
            this.HOTEN,
            this.GIOITINH,
            this.DIENTHOAI,
            this.NGAYVL,
            this.DOANHSO,
            this.PCNL});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(750, 144);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TXT_PC);
            this.panel2.Controls.Add(this.LB_PC);
            this.panel2.Controls.Add(this.date_NVL);
            this.panel2.Controls.Add(this.TXT_DT);
            this.panel2.Controls.Add(this.TXT_DS);
            this.panel2.Controls.Add(this.TXT_HT);
            this.panel2.Controls.Add(this.TXT_MNV);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.LB_DS);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 430);
            this.panel2.TabIndex = 2;
            // 
            // TXT_PC
            // 
            this.TXT_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TXT_PC.Location = new System.Drawing.Point(164, 346);
            this.TXT_PC.Name = "TXT_PC";
            this.TXT_PC.Size = new System.Drawing.Size(299, 30);
            this.TXT_PC.TabIndex = 23;
            this.TXT_PC.Visible = false;
            // 
            // LB_PC
            // 
            this.LB_PC.AutoSize = true;
            this.LB_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_PC.Location = new System.Drawing.Point(16, 349);
            this.LB_PC.Name = "LB_PC";
            this.LB_PC.Size = new System.Drawing.Size(128, 25);
            this.LB_PC.TabIndex = 27;
            this.LB_PC.Text = "PC nhiên liệu";
            this.LB_PC.Visible = false;
            this.LB_PC.Click += new System.EventHandler(this.LB_PC_Click);
            // 
            // date_NVL
            // 
            this.date_NVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_NVL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NVL.Location = new System.Drawing.Point(169, 220);
            this.date_NVL.Name = "date_NVL";
            this.date_NVL.Size = new System.Drawing.Size(299, 30);
            this.date_NVL.TabIndex = 26;
            this.date_NVL.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TXT_DT
            // 
            this.TXT_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TXT_DT.Location = new System.Drawing.Point(169, 176);
            this.TXT_DT.Name = "TXT_DT";
            this.TXT_DT.Size = new System.Drawing.Size(299, 30);
            this.TXT_DT.TabIndex = 25;
            // 
            // TXT_DS
            // 
            this.TXT_DS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TXT_DS.Location = new System.Drawing.Point(164, 344);
            this.TXT_DS.Name = "TXT_DS";
            this.TXT_DS.Size = new System.Drawing.Size(299, 30);
            this.TXT_DS.TabIndex = 24;
            // 
            // TXT_HT
            // 
            this.TXT_HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TXT_HT.Location = new System.Drawing.Point(164, 60);
            this.TXT_HT.Name = "TXT_HT";
            this.TXT_HT.Size = new System.Drawing.Size(299, 30);
            this.TXT_HT.TabIndex = 23;
            // 
            // TXT_MNV
            // 
            this.TXT_MNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TXT_MNV.Location = new System.Drawing.Point(164, 19);
            this.TXT_MNV.Name = "TXT_MNV";
            this.TXT_MNV.Size = new System.Drawing.Size(299, 30);
            this.TXT_MNV.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton_GH);
            this.panel5.Controls.Add(this.radioButton_BH);
            this.panel5.Location = new System.Drawing.Point(169, 280);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 47);
            this.panel5.TabIndex = 16;
            // 
            // radioButton_GH
            // 
            this.radioButton_GH.AutoSize = true;
            this.radioButton_GH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_GH.Location = new System.Drawing.Point(140, 12);
            this.radioButton_GH.Name = "radioButton_GH";
            this.radioButton_GH.Size = new System.Drawing.Size(123, 29);
            this.radioButton_GH.TabIndex = 1;
            this.radioButton_GH.TabStop = true;
            this.radioButton_GH.Text = "Giao nhận";
            this.radioButton_GH.UseVisualStyleBackColor = true;
            this.radioButton_GH.CheckedChanged += new System.EventHandler(this.radioButton_GH_CheckedChanged);
            // 
            // radioButton_BH
            // 
            this.radioButton_BH.AutoSize = true;
            this.radioButton_BH.Checked = true;
            this.radioButton_BH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_BH.Location = new System.Drawing.Point(14, 12);
            this.radioButton_BH.Name = "radioButton_BH";
            this.radioButton_BH.Size = new System.Drawing.Size(117, 29);
            this.radioButton_BH.TabIndex = 0;
            this.radioButton_BH.TabStop = true;
            this.radioButton_BH.Text = "Bán hàng";
            this.radioButton_BH.UseVisualStyleBackColor = true;
            this.radioButton_BH.CheckedChanged += new System.EventHandler(this.radioButton_BH_CheckedChanged);
            // 
            // LB_DS
            // 
            this.LB_DS.AutoSize = true;
            this.LB_DS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LB_DS.Location = new System.Drawing.Point(16, 349);
            this.LB_DS.Name = "LB_DS";
            this.LB_DS.Size = new System.Drawing.Size(96, 25);
            this.LB_DS.TabIndex = 21;
            this.LB_DS.Text = "Doanh số";
            this.LB_DS.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(16, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Loại NV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(16, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày vào làm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(16, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(16, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã số NV";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton_NU);
            this.panel4.Controls.Add(this.radioButton_NAM);
            this.panel4.Location = new System.Drawing.Point(164, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 47);
            this.panel4.TabIndex = 15;
            // 
            // radioButton_NU
            // 
            this.radioButton_NU.AutoSize = true;
            this.radioButton_NU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_NU.Location = new System.Drawing.Point(140, 12);
            this.radioButton_NU.Name = "radioButton_NU";
            this.radioButton_NU.Size = new System.Drawing.Size(58, 29);
            this.radioButton_NU.TabIndex = 1;
            this.radioButton_NU.TabStop = true;
            this.radioButton_NU.Text = "Nữ";
            this.radioButton_NU.UseVisualStyleBackColor = true;
            // 
            // radioButton_NAM
            // 
            this.radioButton_NAM.AutoSize = true;
            this.radioButton_NAM.Checked = true;
            this.radioButton_NAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton_NAM.Location = new System.Drawing.Point(14, 12);
            this.radioButton_NAM.Name = "radioButton_NAM";
            this.radioButton_NAM.Size = new System.Drawing.Size(74, 29);
            this.radioButton_NAM.TabIndex = 0;
            this.radioButton_NAM.TabStop = true;
            this.radioButton_NAM.Text = "Nam";
            this.radioButton_NAM.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(16, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_THONGKE);
            this.panel3.Controls.Add(this.button_SAPXEP);
            this.panel3.Controls.Add(this.button_SUA);
            this.panel3.Controls.Add(this.button_XOA);
            this.panel3.Controls.Add(this.button_LUU);
            this.panel3.Controls.Add(this.button_THEM);
            this.panel3.Location = new System.Drawing.Point(622, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 430);
            this.panel3.TabIndex = 1;
            // 
            // button_THONGKE
            // 
            this.button_THONGKE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_THONGKE.Location = new System.Drawing.Point(14, 349);
            this.button_THONGKE.Name = "button_THONGKE";
            this.button_THONGKE.Size = new System.Drawing.Size(116, 43);
            this.button_THONGKE.TabIndex = 5;
            this.button_THONGKE.Text = "Thống kê";
            this.button_THONGKE.UseVisualStyleBackColor = true;
            this.button_THONGKE.Click += new System.EventHandler(this.button_THONGKE_Click);
            // 
            // button_SAPXEP
            // 
            this.button_SAPXEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_SAPXEP.Location = new System.Drawing.Point(17, 283);
            this.button_SAPXEP.Name = "button_SAPXEP";
            this.button_SAPXEP.Size = new System.Drawing.Size(116, 43);
            this.button_SAPXEP.TabIndex = 4;
            this.button_SAPXEP.Text = "Sắp xếp";
            this.button_SAPXEP.UseVisualStyleBackColor = true;
            this.button_SAPXEP.Click += new System.EventHandler(this.button_SAPXEP_Click);
            // 
            // button_SUA
            // 
            this.button_SUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_SUA.Location = new System.Drawing.Point(17, 217);
            this.button_SUA.Name = "button_SUA";
            this.button_SUA.Size = new System.Drawing.Size(116, 43);
            this.button_SUA.TabIndex = 3;
            this.button_SUA.Text = "Sửa";
            this.button_SUA.UseVisualStyleBackColor = true;
            this.button_SUA.Click += new System.EventHandler(this.button_SUA_Click);
            // 
            // button_XOA
            // 
            this.button_XOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_XOA.Location = new System.Drawing.Point(14, 151);
            this.button_XOA.Name = "button_XOA";
            this.button_XOA.Size = new System.Drawing.Size(116, 43);
            this.button_XOA.TabIndex = 2;
            this.button_XOA.Text = "Xoá";
            this.button_XOA.UseVisualStyleBackColor = true;
            this.button_XOA.Click += new System.EventHandler(this.button_XOA_Click);
            // 
            // button_LUU
            // 
            this.button_LUU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_LUU.Location = new System.Drawing.Point(14, 85);
            this.button_LUU.Name = "button_LUU";
            this.button_LUU.Size = new System.Drawing.Size(116, 43);
            this.button_LUU.TabIndex = 1;
            this.button_LUU.Text = "Lưu";
            this.button_LUU.UseVisualStyleBackColor = true;
            this.button_LUU.Click += new System.EventHandler(this.button_LUU_Click);
            // 
            // button_THEM
            // 
            this.button_THEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_THEM.Location = new System.Drawing.Point(14, 19);
            this.button_THEM.Name = "button_THEM";
            this.button_THEM.Size = new System.Drawing.Size(116, 43);
            this.button_THEM.TabIndex = 0;
            this.button_THEM.Text = "Thêm";
            this.button_THEM.UseVisualStyleBackColor = true;
            this.button_THEM.Click += new System.EventHandler(this.button_THEM_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(140, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chương trình quản lý nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(626, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tác vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(16, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Danh sách nhân viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MANV
            // 
            this.MANV.Text = "Mã NV";
            this.MANV.Width = 150;
            // 
            // HOTEN
            // 
            this.HOTEN.Text = "Họ tên";
            this.HOTEN.Width = 150;
            // 
            // GIOITINH
            // 
            this.GIOITINH.Text = "Giới tính";
            this.GIOITINH.Width = 100;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.Text = "Điện thoại";
            this.DIENTHOAI.Width = 150;
            // 
            // NGAYVL
            // 
            this.NGAYVL.Text = "Ngày vào làm";
            this.NGAYVL.Width = 200;
            // 
            // DOANHSO
            // 
            this.DOANHSO.Text = "Doanh số";
            this.DOANHSO.Width = 200;
            // 
            // PCNL
            // 
            this.PCNL.Text = "Phụ cấp nhiên liệu";
            this.PCNL.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 703);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker date_NVL;
        private System.Windows.Forms.TextBox TXT_DT;
        private System.Windows.Forms.TextBox TXT_PC;
        private System.Windows.Forms.TextBox TXT_DS;
        private System.Windows.Forms.TextBox TXT_HT;
        private System.Windows.Forms.TextBox TXT_MNV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton_GH;
        private System.Windows.Forms.RadioButton radioButton_BH;
        private System.Windows.Forms.Label LB_DS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton_NU;
        private System.Windows.Forms.RadioButton radioButton_NAM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_THONGKE;
        private System.Windows.Forms.Button button_SAPXEP;
        private System.Windows.Forms.Button button_SUA;
        private System.Windows.Forms.Button button_XOA;
        private System.Windows.Forms.Button button_LUU;
        private System.Windows.Forms.Button button_THEM;
        private System.Windows.Forms.Label LB_PC;
        private System.Windows.Forms.ColumnHeader MANV;
        private System.Windows.Forms.ColumnHeader HOTEN;
        private System.Windows.Forms.ColumnHeader GIOITINH;
        private System.Windows.Forms.ColumnHeader DIENTHOAI;
        private System.Windows.Forms.ColumnHeader NGAYVL;
        private System.Windows.Forms.ColumnHeader DOANHSO;
        private System.Windows.Forms.ColumnHeader PCNL;
    }
}

