namespace QLCHMayTinh
{
    partial class Frm_HDnhap
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
            this.dgvPhieunhap = new System.Windows.Forms.DataGridView();
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHACUNGCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANVNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.pnNhaphang = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemhd = new System.Windows.Forms.Button();
            this.btnThemCTHD = new System.Windows.Forms.Button();
            this.txtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbbNVnhap = new System.Windows.Forms.ComboBox();
            this.cbbNhacc = new System.Windows.Forms.ComboBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtMapn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCTHDNhap = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhap)).BeginInit();
            this.pnNhaphang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieunhap
            // 
            this.dgvPhieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN,
            this.NGAYNHAP,
            this.NHACUNGCAP,
            this.MANVNHAP,
            this.TONGTIEN});
            this.dgvPhieunhap.Location = new System.Drawing.Point(-5, 301);
            this.dgvPhieunhap.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPhieunhap.Name = "dgvPhieunhap";
            this.dgvPhieunhap.Size = new System.Drawing.Size(1077, 319);
            this.dgvPhieunhap.TabIndex = 0;
            this.dgvPhieunhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieunhap_CellContentClick);
            this.dgvPhieunhap.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieunhap_CellContentClick);
            // 
            // MAPN
            // 
            this.MAPN.DataPropertyName = "MAPN";
            this.MAPN.HeaderText = "Mã phiếu nhập";
            this.MAPN.Name = "MAPN";
            this.MAPN.ReadOnly = true;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.ReadOnly = true;
            // 
            // NHACUNGCAP
            // 
            this.NHACUNGCAP.DataPropertyName = "NHACUNGCAP";
            this.NHACUNGCAP.HeaderText = "Nhà cung cấp";
            this.NHACUNGCAP.Name = "NHACUNGCAP";
            this.NHACUNGCAP.ReadOnly = true;
            // 
            // MANVNHAP
            // 
            this.MANVNHAP.DataPropertyName = "MANVNHAP";
            this.MANVNHAP.HeaderText = "Mã NV nhập";
            this.MANVNHAP.Name = "MANVNHAP";
            this.MANVNHAP.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền nhập";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(4, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(127, 45);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Quay lại";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnNhaphang
            // 
            this.pnNhaphang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNhaphang.Controls.Add(this.btnReset);
            this.pnNhaphang.Controls.Add(this.btnXoa);
            this.pnNhaphang.Controls.Add(this.btnThemhd);
            this.pnNhaphang.Controls.Add(this.btnThemCTHD);
            this.pnNhaphang.Controls.Add(this.txtNgaynhap);
            this.pnNhaphang.Controls.Add(this.cbbNVnhap);
            this.pnNhaphang.Controls.Add(this.cbbNhacc);
            this.pnNhaphang.Controls.Add(this.txtManv);
            this.pnNhaphang.Controls.Add(this.txtMapn);
            this.pnNhaphang.Controls.Add(this.label6);
            this.pnNhaphang.Controls.Add(this.label5);
            this.pnNhaphang.Controls.Add(this.label4);
            this.pnNhaphang.Controls.Add(this.label3);
            this.pnNhaphang.Controls.Add(this.label2);
            this.pnNhaphang.Location = new System.Drawing.Point(4, 55);
            this.pnNhaphang.Name = "pnNhaphang";
            this.pnNhaphang.Size = new System.Drawing.Size(1068, 238);
            this.pnNhaphang.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(702, 178);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(207, 40);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(702, 125);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(207, 42);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemhd
            // 
            this.btnThemhd.Location = new System.Drawing.Point(702, 25);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(207, 42);
            this.btnThemhd.TabIndex = 4;
            this.btnThemhd.Text = "Thêm HĐ nhập";
            this.btnThemhd.UseVisualStyleBackColor = true;
            this.btnThemhd.Click += new System.EventHandler(this.btnThemhd_Click);
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.Location = new System.Drawing.Point(702, 73);
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.Size = new System.Drawing.Size(207, 42);
            this.btnThemCTHD.TabIndex = 4;
            this.btnThemCTHD.Text = "Thêm CTHD Nhập";
            this.btnThemCTHD.UseVisualStyleBackColor = true;
            this.btnThemCTHD.Click += new System.EventHandler(this.btnThemCTHD_Click);
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaynhap.Location = new System.Drawing.Point(162, 62);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(373, 29);
            this.txtNgaynhap.TabIndex = 3;
            // 
            // cbbNVnhap
            // 
            this.cbbNVnhap.FormattingEnabled = true;
            this.cbbNVnhap.Location = new System.Drawing.Point(162, 143);
            this.cbbNVnhap.Name = "cbbNVnhap";
            this.cbbNVnhap.Size = new System.Drawing.Size(373, 29);
            this.cbbNVnhap.TabIndex = 2;
            this.cbbNVnhap.SelectedIndexChanged += new System.EventHandler(this.cbbNVnhap_SelectedIndexChanged);
            // 
            // cbbNhacc
            // 
            this.cbbNhacc.FormattingEnabled = true;
            this.cbbNhacc.Location = new System.Drawing.Point(162, 105);
            this.cbbNhacc.Name = "cbbNhacc";
            this.cbbNhacc.Size = new System.Drawing.Size(373, 29);
            this.cbbNhacc.TabIndex = 2;
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(162, 185);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(373, 29);
            this.txtManv.TabIndex = 1;
            // 
            // txtMapn
            // 
            this.txtMapn.Location = new System.Drawing.Point(162, 22);
            this.txtMapn.Name = "txtMapn";
            this.txtMapn.Size = new System.Drawing.Size(373, 29);
            this.txtMapn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã NV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhân viên nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // pnCTHDNhap
            // 
            this.pnCTHDNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCTHDNhap.Location = new System.Drawing.Point(-5, 4);
            this.pnCTHDNhap.Name = "pnCTHDNhap";
            this.pnCTHDNhap.Size = new System.Drawing.Size(1084, 625);
            this.pnCTHDNhap.TabIndex = 6;
            this.pnCTHDNhap.Visible = false;
            // 
            // Frm_HDnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 624);
            this.Controls.Add(this.pnCTHDNhap);
            this.Controls.Add(this.pnNhaphang);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhieunhap);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_HDnhap";
            this.Text = "Frm_HDnhap";
            this.Load += new System.EventHandler(this.Frm_HDnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhap)).EndInit();
            this.pnNhaphang.ResumeLayout(false);
            this.pnNhaphang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHACUNGCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANVNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel pnNhaphang;
        private System.Windows.Forms.DateTimePicker txtNgaynhap;
        private System.Windows.Forms.ComboBox cbbNVnhap;
        private System.Windows.Forms.ComboBox cbbNhacc;
        private System.Windows.Forms.TextBox txtMapn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemhd;
        private System.Windows.Forms.Button btnThemCTHD;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnCTHDNhap;
    }
}