namespace GUI
{
    partial class frmTimMatHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dataGridViewMH = new System.Windows.Forms.DataGridView();
            this.dataSetMH = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLTONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(169, 45);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(270, 28);
            this.txtMaMH.TabIndex = 3;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(169, 147);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(270, 28);
            this.txtDongia.TabIndex = 3;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(169, 97);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(270, 28);
            this.txtTenMH.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDongia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(662, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mặt hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(502, 127);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 44);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTim.Location = new System.Drawing.Point(502, 63);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(99, 44);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tra cứu";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dataGridViewMH
            // 
            this.dataGridViewMH.AutoGenerateColumns = false;
            this.dataGridViewMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.mSMHDataGridViewTextBoxColumn,
            this.tENMHDataGridViewTextBoxColumn,
            this.sLTONDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn,
            this.dONVITINHDataGridViewTextBoxColumn});
            this.dataGridViewMH.DataMember = "MATHANG";
            this.dataGridViewMH.DataSource = this.dataSetMH;
            this.dataGridViewMH.Location = new System.Drawing.Point(24, 220);
            this.dataGridViewMH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMH.Name = "dataGridViewMH";
            this.dataGridViewMH.RowHeadersWidth = 51;
            this.dataGridViewMH.RowTemplate.Height = 24;
            this.dataGridViewMH.Size = new System.Drawing.Size(662, 147);
            this.dataGridViewMH.TabIndex = 6;
            // 
            // dataSetMH
            // 
            this.dataSetMH.DataSetName = "NewDataSet";
            this.dataSetMH.Tables.AddRange(new System.Data.DataTable[] {
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
            this.dataTable1.TableName = "MATHANG";
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
            this.dataColumn4.ColumnName = "SL_TON";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "DONGIA";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "DONVITINH";
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
            this.mSMHDataGridViewTextBoxColumn.HeaderText = "Mã mặt hàng";
            this.mSMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSMHDataGridViewTextBoxColumn.Name = "mSMHDataGridViewTextBoxColumn";
            // 
            // tENMHDataGridViewTextBoxColumn
            // 
            this.tENMHDataGridViewTextBoxColumn.DataPropertyName = "TENMH";
            this.tENMHDataGridViewTextBoxColumn.HeaderText = "Tên mặt hàng";
            this.tENMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENMHDataGridViewTextBoxColumn.Name = "tENMHDataGridViewTextBoxColumn";
            // 
            // sLTONDataGridViewTextBoxColumn
            // 
            this.sLTONDataGridViewTextBoxColumn.DataPropertyName = "SL_TON";
            this.sLTONDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sLTONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLTONDataGridViewTextBoxColumn.Name = "sLTONDataGridViewTextBoxColumn";
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dONGIADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            // 
            // dONVITINHDataGridViewTextBoxColumn
            // 
            this.dONVITINHDataGridViewTextBoxColumn.DataPropertyName = "DONVITINH";
            this.dONVITINHDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.dONVITINHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dONVITINHDataGridViewTextBoxColumn.Name = "dONVITINHDataGridViewTextBoxColumn";
            // 
            // frmTimMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(706, 385);
            this.Controls.Add(this.dataGridViewMH);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTimMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra cứu mặt hàng";
            this.Load += new System.EventHandler(this.frmTimMatHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMH;
        private System.Data.DataSet dataSetMH;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLTONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONVITINHDataGridViewTextBoxColumn;
    }
}