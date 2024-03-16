namespace QLCHMayTinh
{
    partial class Frm_Sanpham
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
            this.dgvDSsanpham = new System.Windows.Forms.DataGridView();
            this.MADMUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANHACC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSanpham = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbNcc = new System.Windows.Forms.ComboBox();
            this.cbbDanhmucSP = new System.Windows.Forms.ComboBox();
            this.txtDVtinh = new System.Windows.Forms.TextBox();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.lblDanhmuc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNhacc = new System.Windows.Forms.Label();
            this.lblGiaban = new System.Windows.Forms.Label();
            this.lblDvt = new System.Windows.Forms.Label();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.lblmasp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSsanpham)).BeginInit();
            this.gbSanpham.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDSsanpham);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 311);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dgvDSsanpham
            // 
            this.dgvDSsanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADMUC,
            this.MASP,
            this.TENSP,
            this.DVT,
            this.GIA,
            this.MANHACC});
            this.dgvDSsanpham.Location = new System.Drawing.Point(0, 28);
            this.dgvDSsanpham.Name = "dgvDSsanpham";
            this.dgvDSsanpham.Size = new System.Drawing.Size(958, 277);
            this.dgvDSsanpham.TabIndex = 0;
            this.dgvDSsanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSsanpham_CellContentClick);
            this.dgvDSsanpham.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSsanpham_CellContentClick);
            // 
            // MADMUC
            // 
            this.MADMUC.DataPropertyName = "MADMUC";
            this.MADMUC.HeaderText = "Mã danh mục";
            this.MADMUC.Name = "MADMUC";
            this.MADMUC.ReadOnly = true;
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "Mã sản phẩm";
            this.MASP.Name = "MASP";
            this.MASP.ReadOnly = true;
            // 
            // TENSP
            // 
            this.TENSP.DataPropertyName = "TENSP";
            this.TENSP.HeaderText = "Tên sản phẩm";
            this.TENSP.Name = "TENSP";
            this.TENSP.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            this.GIA.HeaderText = "Giá bán";
            this.GIA.Name = "GIA";
            this.GIA.ReadOnly = true;
            // 
            // MANHACC
            // 
            this.MANHACC.DataPropertyName = "MANHACC";
            this.MANHACC.HeaderText = "Mã NCC";
            this.MANHACC.Name = "MANHACC";
            this.MANHACC.ReadOnly = true;
            // 
            // gbSanpham
            // 
            this.gbSanpham.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSanpham.AutoSize = true;
            this.gbSanpham.Controls.Add(this.btnReset);
            this.gbSanpham.Controls.Add(this.btnXoa);
            this.gbSanpham.Controls.Add(this.btnSua);
            this.gbSanpham.Controls.Add(this.btnThem);
            this.gbSanpham.Controls.Add(this.cbbNcc);
            this.gbSanpham.Controls.Add(this.cbbDanhmucSP);
            this.gbSanpham.Controls.Add(this.txtDVtinh);
            this.gbSanpham.Controls.Add(this.txtmancc);
            this.gbSanpham.Controls.Add(this.txtGiaban);
            this.gbSanpham.Controls.Add(this.txtTensp);
            this.gbSanpham.Controls.Add(this.txtMasp);
            this.gbSanpham.Controls.Add(this.lblDanhmuc);
            this.gbSanpham.Controls.Add(this.label2);
            this.gbSanpham.Controls.Add(this.lblNhacc);
            this.gbSanpham.Controls.Add(this.lblGiaban);
            this.gbSanpham.Controls.Add(this.lblDvt);
            this.gbSanpham.Controls.Add(this.lblTenSp);
            this.gbSanpham.Controls.Add(this.lblmasp);
            this.gbSanpham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSanpham.Location = new System.Drawing.Point(2, -2);
            this.gbSanpham.Name = "gbSanpham";
            this.gbSanpham.Size = new System.Drawing.Size(959, 231);
            this.gbSanpham.TabIndex = 4;
            this.gbSanpham.TabStop = false;
            this.gbSanpham.Text = "Thông tin sản phẩm";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(798, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 42);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(798, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 42);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(798, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 42);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(798, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 42);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbNcc
            // 
            this.cbbNcc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNcc.FormattingEnabled = true;
            this.cbbNcc.Location = new System.Drawing.Point(192, 54);
            this.cbbNcc.Name = "cbbNcc";
            this.cbbNcc.Size = new System.Drawing.Size(119, 29);
            this.cbbNcc.TabIndex = 2;
            this.cbbNcc.SelectedIndexChanged += new System.EventHandler(this.cbbNcc_SelectedIndexChanged);
            // 
            // cbbDanhmucSP
            // 
            this.cbbDanhmucSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDanhmucSP.FormattingEnabled = true;
            this.cbbDanhmucSP.Location = new System.Drawing.Point(205, 126);
            this.cbbDanhmucSP.Name = "cbbDanhmucSP";
            this.cbbDanhmucSP.Size = new System.Drawing.Size(141, 29);
            this.cbbDanhmucSP.TabIndex = 1;
            // 
            // txtDVtinh
            // 
            this.txtDVtinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVtinh.Location = new System.Drawing.Point(389, 126);
            this.txtDVtinh.Name = "txtDVtinh";
            this.txtDVtinh.Size = new System.Drawing.Size(138, 29);
            this.txtDVtinh.TabIndex = 1;
            // 
            // txtmancc
            // 
            this.txtmancc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmancc.Location = new System.Drawing.Point(371, 53);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.ReadOnly = true;
            this.txtmancc.Size = new System.Drawing.Size(138, 29);
            this.txtmancc.TabIndex = 1;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaban.Location = new System.Drawing.Point(553, 54);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(138, 29);
            this.txtGiaban.TabIndex = 1;
            // 
            // txtTensp
            // 
            this.txtTensp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensp.Location = new System.Drawing.Point(32, 126);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(141, 29);
            this.txtTensp.TabIndex = 1;
            // 
            // txtMasp
            // 
            this.txtMasp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasp.Location = new System.Drawing.Point(32, 54);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(111, 29);
            this.txtMasp.TabIndex = 1;
            // 
            // lblDanhmuc
            // 
            this.lblDanhmuc.AutoSize = true;
            this.lblDanhmuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhmuc.Location = new System.Drawing.Point(201, 101);
            this.lblDanhmuc.Name = "lblDanhmuc";
            this.lblDanhmuc.Size = new System.Drawing.Size(86, 21);
            this.lblDanhmuc.TabIndex = 0;
            this.lblDanhmuc.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // lblNhacc
            // 
            this.lblNhacc.AutoSize = true;
            this.lblNhacc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhacc.Location = new System.Drawing.Point(188, 29);
            this.lblNhacc.Name = "lblNhacc";
            this.lblNhacc.Size = new System.Drawing.Size(113, 21);
            this.lblNhacc.TabIndex = 0;
            this.lblNhacc.Text = "Nhà cung cấp";
            // 
            // lblGiaban
            // 
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaban.Location = new System.Drawing.Point(549, 29);
            this.lblGiaban.Name = "lblGiaban";
            this.lblGiaban.Size = new System.Drawing.Size(68, 21);
            this.lblGiaban.TabIndex = 0;
            this.lblGiaban.Text = "Giá bán";
            // 
            // lblDvt
            // 
            this.lblDvt.AutoSize = true;
            this.lblDvt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDvt.Location = new System.Drawing.Point(385, 101);
            this.lblDvt.Name = "lblDvt";
            this.lblDvt.Size = new System.Drawing.Size(95, 21);
            this.lblDvt.TabIndex = 0;
            this.lblDvt.Text = "Đơn vị tính";
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSp.Location = new System.Drawing.Point(28, 101);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(66, 21);
            this.lblTenSp.TabIndex = 0;
            this.lblTenSp.Text = "Tên SP";
            // 
            // lblmasp
            // 
            this.lblmasp.AutoSize = true;
            this.lblmasp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasp.Location = new System.Drawing.Point(28, 29);
            this.lblmasp.Name = "lblmasp";
            this.lblmasp.Size = new System.Drawing.Size(61, 21);
            this.lblmasp.TabIndex = 0;
            this.lblmasp.Text = "Mã SP";
            // 
            // Frm_Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(964, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSanpham);
            this.Name = "Frm_Sanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Sanpham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Sanpham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSsanpham)).EndInit();
            this.gbSanpham.ResumeLayout(false);
            this.gbSanpham.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbSanpham;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbNcc;
        private System.Windows.Forms.ComboBox cbbDanhmucSP;
        private System.Windows.Forms.TextBox txtDVtinh;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label lblDanhmuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNhacc;
        private System.Windows.Forms.Label lblGiaban;
        private System.Windows.Forms.Label lblDvt;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.Label lblmasp;
        private System.Windows.Forms.DataGridView dgvDSsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADMUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHACC;
    }
}