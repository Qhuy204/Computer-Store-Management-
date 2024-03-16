namespace QLCHMayTinh
{
    partial class Frm_CTHDXuat
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
            this.components = new System.ComponentModel.Container();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtmactpx = new System.Windows.Forms.TextBox();
            this.cbbTensp = new System.Windows.Forms.ComboBox();
            this.cbbMapx = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvCthdx = new System.Windows.Forms.DataGridView();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.MACTPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLCT_MAYTINHDataSet4 = new QLCHMayTinh.QLCT_MAYTINHDataSet4();
            this.pHIEUXUATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUXUATTableAdapter = new QLCHMayTinh.QLCT_MAYTINHDataSet4TableAdapters.PHIEUXUATTableAdapter();
            this.qLCT_MAYTINHDataSet5 = new QLCHMayTinh.QLCT_MAYTINHDataSet5();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new QLCHMayTinh.QLCT_MAYTINHDataSet5TableAdapters.SANPHAMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCthdx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCT_MAYTINHDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCT_MAYTINHDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMasp
            // 
            this.txtMasp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Location = new System.Drawing.Point(513, 81);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.ReadOnly = true;
            this.txtMasp.Size = new System.Drawing.Size(123, 29);
            this.txtMasp.TabIndex = 24;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(513, 139);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(123, 29);
            this.txtSoluong.TabIndex = 22;
            // 
            // txtmactpx
            // 
            this.txtmactpx.Location = new System.Drawing.Point(192, 136);
            this.txtmactpx.Name = "txtmactpx";
            this.txtmactpx.Size = new System.Drawing.Size(195, 29);
            this.txtmactpx.TabIndex = 21;
            // 
            // cbbTensp
            // 
            this.cbbTensp.DataSource = this.sANPHAMBindingSource;
            this.cbbTensp.DisplayMember = "TENSP";
            this.cbbTensp.FormattingEnabled = true;
            this.cbbTensp.Location = new System.Drawing.Point(192, 188);
            this.cbbTensp.Name = "cbbTensp";
            this.cbbTensp.Size = new System.Drawing.Size(195, 29);
            this.cbbTensp.TabIndex = 20;
            this.cbbTensp.ValueMember = "TENSP";
            this.cbbTensp.SelectedIndexChanged += new System.EventHandler(this.cbbTensp_SelectedIndexChanged);
            // 
            // cbbMapx
            // 
            this.cbbMapx.FormattingEnabled = true;
            this.cbbMapx.Location = new System.Drawing.Point(192, 83);
            this.cbbMapx.Name = "cbbMapx";
            this.cbbMapx.Size = new System.Drawing.Size(195, 29);
            this.cbbMapx.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(677, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 35);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(677, 159);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 35);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(677, 118);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(168, 35);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(677, 77);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(168, 35);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã CT phiếu xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã phiếu xuất";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN BÁN HÀNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giá bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã sản phẩm";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 35);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvCthdx
            // 
            this.dgvCthdx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCthdx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCthdx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCthdx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACTPX,
            this.MAPX,
            this.MASP,
            this.SL,
            this.GIABAN});
            this.dgvCthdx.Location = new System.Drawing.Point(3, 263);
            this.dgvCthdx.Name = "dgvCthdx";
            this.dgvCthdx.Size = new System.Drawing.Size(910, 261);
            this.dgvCthdx.TabIndex = 6;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaban.Location = new System.Drawing.Point(513, 188);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.ReadOnly = true;
            this.txtgiaban.Size = new System.Drawing.Size(123, 29);
            this.txtgiaban.TabIndex = 25;
            // 
            // MACTPX
            // 
            this.MACTPX.DataPropertyName = "MACTPX";
            this.MACTPX.HeaderText = "Mã CT phiếu xuất";
            this.MACTPX.Name = "MACTPX";
            this.MACTPX.ReadOnly = true;
            // 
            // MAPX
            // 
            this.MAPX.DataPropertyName = "MAPX";
            this.MAPX.HeaderText = "Mã phiếu xuất";
            this.MAPX.Name = "MAPX";
            this.MAPX.ReadOnly = true;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.ReadOnly = true;
            // 
            // qLCT_MAYTINHDataSet4
            // 
            this.qLCT_MAYTINHDataSet4.DataSetName = "QLCT_MAYTINHDataSet4";
            this.qLCT_MAYTINHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUXUATBindingSource
            // 
            this.pHIEUXUATBindingSource.DataMember = "PHIEUXUAT";
            this.pHIEUXUATBindingSource.DataSource = this.qLCT_MAYTINHDataSet4;
            // 
            // pHIEUXUATTableAdapter
            // 
            this.pHIEUXUATTableAdapter.ClearBeforeFill = true;
            // 
            // qLCT_MAYTINHDataSet5
            // 
            this.qLCT_MAYTINHDataSet5.DataSetName = "QLCT_MAYTINHDataSet5";
            this.qLCT_MAYTINHDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.qLCT_MAYTINHDataSet5;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_CTHDXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 528);
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.txtMasp);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtmactpx);
            this.Controls.Add(this.cbbTensp);
            this.Controls.Add(this.cbbMapx);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvCthdx);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_CTHDXuat";
            this.Text = "Frm_CTHDXuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_CTHDXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCthdx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCT_MAYTINHDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCT_MAYTINHDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtmactpx;
        private System.Windows.Forms.ComboBox cbbTensp;
        private System.Windows.Forms.ComboBox cbbMapx;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCthdx;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACTPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private QLCT_MAYTINHDataSet4 qLCT_MAYTINHDataSet4;
        private System.Windows.Forms.BindingSource pHIEUXUATBindingSource;
        private QLCT_MAYTINHDataSet4TableAdapters.PHIEUXUATTableAdapter pHIEUXUATTableAdapter;
        private QLCT_MAYTINHDataSet5 qLCT_MAYTINHDataSet5;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private QLCT_MAYTINHDataSet5TableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
    }
}