namespace GUI
{
    partial class frmHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOLUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHANHTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetHD = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMathang = new System.Windows.Forms.Button();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboMathang = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnKhongluu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLaphoadon = new System.Windows.Forms.Button();
            this.txtMSHD = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboKhachhang = new System.Windows.Forms.ComboBox();
            this.btKhachhang = new System.Windows.Forms.Button();
            this.btNhanvien = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.cboPhai = new System.Windows.Forms.ComboBox();
            this.cboNhanvien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn";
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.AutoGenerateColumns = false;
            this.dataGridViewCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mSMHDataGridViewTextBoxColumn,
            this.tENMHDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn,
            this.sOLUONGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.tHANHTIENDataGridViewTextBoxColumn});
            this.dataGridViewCTHD.DataMember = "HOADON";
            this.dataGridViewCTHD.DataSource = this.dataSetHD;
            this.dataGridViewCTHD.Location = new System.Drawing.Point(26, 399);
            this.dataGridViewCTHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.RowHeadersWidth = 51;
            this.dataGridViewCTHD.RowTemplate.Height = 24;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(961, 124);
            this.dataGridViewCTHD.TabIndex = 6;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // mSMHDataGridViewTextBoxColumn
            // 
            this.mSMHDataGridViewTextBoxColumn.DataPropertyName = "MSMH";
            this.mSMHDataGridViewTextBoxColumn.HeaderText = "MSMH";
            this.mSMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSMHDataGridViewTextBoxColumn.Name = "mSMHDataGridViewTextBoxColumn";
            // 
            // tENMHDataGridViewTextBoxColumn
            // 
            this.tENMHDataGridViewTextBoxColumn.DataPropertyName = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.HeaderText = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENMHDataGridViewTextBoxColumn.Name = "tENMHDataGridViewTextBoxColumn";
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            // 
            // sOLUONGDataGridViewTextBoxColumn
            // 
            this.sOLUONGDataGridViewTextBoxColumn.DataPropertyName = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.HeaderText = "SOLUONG";
            this.sOLUONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sOLUONGDataGridViewTextBoxColumn.Name = "sOLUONGDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // tHANHTIENDataGridViewTextBoxColumn
            // 
            this.tHANHTIENDataGridViewTextBoxColumn.DataPropertyName = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.HeaderText = "THANHTIEN";
            this.tHANHTIENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tHANHTIENDataGridViewTextBoxColumn.Name = "tHANHTIENDataGridViewTextBoxColumn";
            // 
            // dataSetHD
            // 
            this.dataSetHD.DataSetName = "NewDataSet";
            this.dataSetHD.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dataTable1.TableName = "HOADON";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MSMH";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TENMH";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "DVT";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "SOLUONG";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "DONGIA";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "THANHTIEN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.btMathang);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboMathang);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(26, 254);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(962, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập mặt hàng";
            // 
            // btMathang
            // 
            this.btMathang.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btMathang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMathang.Location = new System.Drawing.Point(360, 57);
            this.btMathang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMathang.Name = "btMathang";
            this.btMathang.Size = new System.Drawing.Size(44, 36);
            this.btMathang.TabIndex = 22;
            this.btMathang.Text = "...";
            this.btMathang.UseVisualStyleBackColor = false;
            this.btMathang.Click += new System.EventHandler(this.btMathang_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(828, 56);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(100, 22);
            this.txtTongtien.TabIndex = 3;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(606, 56);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(100, 22);
            this.txtSoluong.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(436, 57);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 36);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboMathang
            // 
            this.cboMathang.FormattingEnabled = true;
            this.cboMathang.Location = new System.Drawing.Point(156, 56);
            this.cboMathang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMathang.Name = "cboMathang";
            this.cboMathang.Size = new System.Drawing.Size(174, 24);
            this.cboMathang.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(740, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tổng tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(524, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mặt hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.btnKhongluu);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnLaphoadon);
            this.groupBox2.Location = new System.Drawing.Point(26, 528);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(961, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTim.Location = new System.Drawing.Point(526, 38);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(97, 46);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(840, 38);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 46);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIn.Location = new System.Drawing.Point(686, 38);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(95, 46);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            // 
            // btnKhongluu
            // 
            this.btnKhongluu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnKhongluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongluu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhongluu.Location = new System.Drawing.Point(360, 38);
            this.btnKhongluu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKhongluu.Name = "btnKhongluu";
            this.btnKhongluu.Size = new System.Drawing.Size(103, 46);
            this.btnKhongluu.TabIndex = 5;
            this.btnKhongluu.Text = "Hủy";
            this.btnKhongluu.UseVisualStyleBackColor = false;
            this.btnKhongluu.Click += new System.EventHandler(this.btnKhongluu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(200, 38);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 46);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnLaphoadon
            // 
            this.btnLaphoadon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLaphoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaphoadon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLaphoadon.Location = new System.Drawing.Point(25, 38);
            this.btnLaphoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaphoadon.Name = "btnLaphoadon";
            this.btnLaphoadon.Size = new System.Drawing.Size(124, 46);
            this.btnLaphoadon.TabIndex = 7;
            this.btnLaphoadon.Text = "Lập hóa đơn";
            this.btnLaphoadon.UseVisualStyleBackColor = false;
            this.btnLaphoadon.Click += new System.EventHandler(this.btnLaphoadon_Click);
            // 
            // txtMSHD
            // 
            this.txtMSHD.Location = new System.Drawing.Point(881, 44);
            this.txtMSHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMSHD.Name = "txtMSHD";
            this.txtMSHD.Size = new System.Drawing.Size(100, 22);
            this.txtMSHD.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Controls.Add(this.cboKhachhang);
            this.groupBox3.Controls.Add(this.btKhachhang);
            this.groupBox3.Controls.Add(this.btNhanvien);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.txtDiachi);
            this.groupBox3.Controls.Add(this.txtDienthoai);
            this.groupBox3.Controls.Add(this.cboPhai);
            this.groupBox3.Controls.Add(this.cboNhanvien);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(26, 71);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(956, 166);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin Nhân viên - Khách hàng";
            // 
            // cboKhachhang
            // 
            this.cboKhachhang.FormattingEnabled = true;
            this.cboKhachhang.Location = new System.Drawing.Point(156, 81);
            this.cboKhachhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboKhachhang.Name = "cboKhachhang";
            this.cboKhachhang.Size = new System.Drawing.Size(174, 24);
            this.cboKhachhang.TabIndex = 23;
            // 
            // btKhachhang
            // 
            this.btKhachhang.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btKhachhang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btKhachhang.Location = new System.Drawing.Point(360, 84);
            this.btKhachhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btKhachhang.Name = "btKhachhang";
            this.btKhachhang.Size = new System.Drawing.Size(44, 33);
            this.btKhachhang.TabIndex = 22;
            this.btKhachhang.Text = "...";
            this.btKhachhang.UseVisualStyleBackColor = false;
            this.btKhachhang.Click += new System.EventHandler(this.btKhachhang_Click);
            // 
            // btNhanvien
            // 
            this.btNhanvien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btNhanvien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNhanvien.Location = new System.Drawing.Point(360, 34);
            this.btNhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNhanvien.Name = "btNhanvien";
            this.btNhanvien.Size = new System.Drawing.Size(44, 28);
            this.btNhanvien.TabIndex = 22;
            this.btNhanvien.Text = "...";
            this.btNhanvien.UseVisualStyleBackColor = false;
            this.btNhanvien.Click += new System.EventHandler(this.btNhanvien_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(714, 31);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(156, 130);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(174, 22);
            this.txtDiachi.TabIndex = 18;
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(714, 132);
            this.txtDienthoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(224, 22);
            this.txtDienthoai.TabIndex = 19;
            // 
            // cboPhai
            // 
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cboPhai.Location = new System.Drawing.Point(502, 78);
            this.cboPhai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(109, 24);
            this.cboPhai.TabIndex = 15;
            // 
            // cboNhanvien
            // 
            this.cboNhanvien.FormattingEnabled = true;
            this.cboNhanvien.Location = new System.Drawing.Point(156, 36);
            this.cboNhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNhanvien.Name = "cboNhanvien";
            this.cboNhanvien.Size = new System.Drawing.Size(174, 24);
            this.cboNhanvien.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày lập HD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhân viên";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1004, 641);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtMSHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCTHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboMathang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnKhongluu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLaphoadon;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtMSHD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.ComboBox cboPhai;
        private System.Windows.Forms.ComboBox cboNhanvien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Data.DataSet dataSetHD;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOLUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHANHTIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btMathang;
        private System.Windows.Forms.Button btKhachhang;
        private System.Windows.Forms.Button btNhanvien;
        private System.Windows.Forms.ComboBox cboKhachhang;
        private System.Windows.Forms.Button btnTim;
    }
}