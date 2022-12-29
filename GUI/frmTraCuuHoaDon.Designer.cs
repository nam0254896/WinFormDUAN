namespace GUI
{
    partial class frmTraCuuHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerHD = new System.Windows.Forms.DateTimePicker();
            this.txtMSHD = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGrid = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGTIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerHD);
            this.groupBox1.Controls.Add(this.txtMSHD);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày nhập hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dateTimePickerHD
            // 
            this.dateTimePickerHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHD.Location = new System.Drawing.Point(233, 94);
            this.dateTimePickerHD.Name = "dateTimePickerHD";
            this.dateTimePickerHD.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerHD.TabIndex = 9;
            // 
            // txtMSHD
            // 
            this.txtMSHD.Location = new System.Drawing.Point(234, 30);
            this.txtMSHD.Name = "txtMSHD";
            this.txtMSHD.Size = new System.Drawing.Size(199, 24);
            this.txtMSHD.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(656, 58);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 48);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTim.Location = new System.Drawing.Point(503, 58);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(106, 48);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tra cứu";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btTraCuu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.DGrid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 233);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // DGrid
            // 
            this.DGrid.AutoGenerateColumns = false;
            this.DGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mSHDDataGridViewTextBoxColumn,
            this.mANVDataGridViewTextBoxColumn,
            this.mSKHDataGridViewTextBoxColumn,
            this.nGAYHDDataGridViewTextBoxColumn,
            this.tONGTIENDataGridViewTextBoxColumn});
            this.DGrid.DataMember = "Table1";
            this.DGrid.DataSource = this.dataSet1;
            this.DGrid.Location = new System.Drawing.Point(21, 33);
            this.DGrid.Name = "DGrid";
            this.DGrid.RowHeadersWidth = 51;
            this.DGrid.RowTemplate.Height = 24;
            this.DGrid.Size = new System.Drawing.Size(793, 175);
            this.DGrid.TabIndex = 0;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // mSHDDataGridViewTextBoxColumn
            // 
            this.mSHDDataGridViewTextBoxColumn.DataPropertyName = "MSHD";
            this.mSHDDataGridViewTextBoxColumn.HeaderText = "MSHD";
            this.mSHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSHDDataGridViewTextBoxColumn.Name = "mSHDDataGridViewTextBoxColumn";
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            // 
            // mSKHDataGridViewTextBoxColumn
            // 
            this.mSKHDataGridViewTextBoxColumn.DataPropertyName = "MSKH";
            this.mSKHDataGridViewTextBoxColumn.HeaderText = "MSKH";
            this.mSKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSKHDataGridViewTextBoxColumn.Name = "mSKHDataGridViewTextBoxColumn";
            // 
            // nGAYHDDataGridViewTextBoxColumn
            // 
            this.nGAYHDDataGridViewTextBoxColumn.DataPropertyName = "NGAYHD";
            this.nGAYHDDataGridViewTextBoxColumn.HeaderText = "NGAYHD";
            this.nGAYHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nGAYHDDataGridViewTextBoxColumn.Name = "nGAYHDDataGridViewTextBoxColumn";
            // 
            // tONGTIENDataGridViewTextBoxColumn
            // 
            this.tONGTIENDataGridViewTextBoxColumn.DataPropertyName = "TONGTIEN";
            this.tONGTIENDataGridViewTextBoxColumn.HeaderText = "TONGTIEN";
            this.tONGTIENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tONGTIENDataGridViewTextBoxColumn.Name = "tONGTIENDataGridViewTextBoxColumn";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
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
            this.dataColumn6});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MSHD";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "MANV";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "MSKH";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "NGAYHD";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "TONGTIEN";
            // 
            // frmTraCuuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTraCuuHoaDon";
            this.Text = "Tra cứu hóa đơn";
            this.Load += new System.EventHandler(this.frmTraCuuHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerHD;
        private System.Windows.Forms.TextBox txtMSHD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGTIENDataGridViewTextBoxColumn;
    }
}