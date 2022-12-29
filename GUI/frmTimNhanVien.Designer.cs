namespace GUI
{
    partial class frmTimNhanVien
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetNV = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTenNV);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(677, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(522, 56);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 44);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tra cứu";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(229, 86);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(251, 28);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(229, 121);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(251, 28);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(229, 45);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(251, 28);
            this.txtHoTenNV.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(522, 106);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 43);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ tên nhân viên:";
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.AutoGenerateColumns = false;
            this.dataGridViewNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mSNVDataGridViewTextBoxColumn,
            this.tENNVDataGridViewTextBoxColumn,
            this.pHAIDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.dIENTHOAIDataGridViewTextBoxColumn});
            this.dataGridViewNV.DataMember = "NHANVIEN";
            this.dataGridViewNV.DataSource = this.dataSetNV;
            this.dataGridViewNV.Location = new System.Drawing.Point(14, 204);
            this.dataGridViewNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.RowTemplate.Height = 24;
            this.dataGridViewNV.Size = new System.Drawing.Size(677, 105);
            this.dataGridViewNV.TabIndex = 1;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // mSNVDataGridViewTextBoxColumn
            // 
            this.mSNVDataGridViewTextBoxColumn.DataPropertyName = "MSNV";
            this.mSNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.mSNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSNVDataGridViewTextBoxColumn.Name = "mSNVDataGridViewTextBoxColumn";
            // 
            // tENNVDataGridViewTextBoxColumn
            // 
            this.tENNVDataGridViewTextBoxColumn.DataPropertyName = "TENNV";
            this.tENNVDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.tENNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENNVDataGridViewTextBoxColumn.Name = "tENNVDataGridViewTextBoxColumn";
            // 
            // pHAIDataGridViewTextBoxColumn
            // 
            this.pHAIDataGridViewTextBoxColumn.DataPropertyName = "PHAI";
            this.pHAIDataGridViewTextBoxColumn.HeaderText = "Phái";
            this.pHAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHAIDataGridViewTextBoxColumn.Name = "pHAIDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // dIENTHOAIDataGridViewTextBoxColumn
            // 
            this.dIENTHOAIDataGridViewTextBoxColumn.DataPropertyName = "DIENTHOAI";
            this.dIENTHOAIDataGridViewTextBoxColumn.HeaderText = "Điện thoại";
            this.dIENTHOAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIENTHOAIDataGridViewTextBoxColumn.Name = "dIENTHOAIDataGridViewTextBoxColumn";
            // 
            // dataSetNV
            // 
            this.dataSetNV.DataSetName = "NewDataSet";
            this.dataSetNV.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dataTable1.TableName = "NHANVIEN";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "STT";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "MSNV";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "TENNV";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "PHAI";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "DIACHI";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "DIENTHOAI";
            // 
            // frmTimNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(708, 331);
            this.Controls.Add(this.dataGridViewNV);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTimNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu Nhân Viên";
            this.Load += new System.EventHandler(this.frmTimNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Data.DataSet dataSetNV;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIENTHOAIDataGridViewTextBoxColumn;
    }

}