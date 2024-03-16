namespace QLCHMayTinh
{
    partial class Frm_Khohang
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
            this.dgvKhohang = new System.Windows.Forms.DataGridView();
            this.MADMUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTONKHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANHACC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTimkiem = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiamax = new System.Windows.Forms.TextBox();
            this.txtGiamin = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDanhmucsp = new System.Windows.Forms.ComboBox();
            this.cbbHangsx = new System.Windows.Forms.ComboBox();
            this.lblTimkiemsp = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNhaphang = new System.Windows.Forms.Button();
            this.pnPhieunhap = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhohang)).BeginInit();
            this.pnTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(754, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHO HÀNG";
            // 
            // dgvKhohang
            // 
            this.dgvKhohang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhohang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADMUC,
            this.MASP,
            this.TENSP,
            this.DVT,
            this.GIA,
            this.SLTONKHO,
            this.MANHACC});
            this.dgvKhohang.Location = new System.Drawing.Point(5, 146);
            this.dgvKhohang.Margin = new System.Windows.Forms.Padding(5);
            this.dgvKhohang.Name = "dgvKhohang";
            this.dgvKhohang.Size = new System.Drawing.Size(1588, 627);
            this.dgvKhohang.TabIndex = 2;
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
            // SLTONKHO
            // 
            this.SLTONKHO.DataPropertyName = "SLTONKHO";
            this.SLTONKHO.HeaderText = "Số lượng còn lại";
            this.SLTONKHO.Name = "SLTONKHO";
            this.SLTONKHO.ReadOnly = true;
            // 
            // MANHACC
            // 
            this.MANHACC.DataPropertyName = "MANHACC";
            this.MANHACC.HeaderText = "Mã nhà cung cấp";
            this.MANHACC.Name = "MANHACC";
            this.MANHACC.ReadOnly = true;
            // 
            // pnTimkiem
            // 
            this.pnTimkiem.Controls.Add(this.label6);
            this.pnTimkiem.Controls.Add(this.txtGiamax);
            this.pnTimkiem.Controls.Add(this.txtGiamin);
            this.pnTimkiem.Controls.Add(this.btnReset);
            this.pnTimkiem.Controls.Add(this.btnTimkiem);
            this.pnTimkiem.Controls.Add(this.txtTenSP);
            this.pnTimkiem.Controls.Add(this.label5);
            this.pnTimkiem.Controls.Add(this.label4);
            this.pnTimkiem.Controls.Add(this.label3);
            this.pnTimkiem.Controls.Add(this.label2);
            this.pnTimkiem.Controls.Add(this.cbbDanhmucsp);
            this.pnTimkiem.Controls.Add(this.cbbHangsx);
            this.pnTimkiem.Controls.Add(this.lblTimkiemsp);
            this.pnTimkiem.Location = new System.Drawing.Point(5, 55);
            this.pnTimkiem.Name = "pnTimkiem";
            this.pnTimkiem.Size = new System.Drawing.Size(1232, 83);
            this.pnTimkiem.TabIndex = 3;
            this.pnTimkiem.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "-";
            // 
            // txtGiamax
            // 
            this.txtGiamax.Location = new System.Drawing.Point(581, 34);
            this.txtGiamax.Name = "txtGiamax";
            this.txtGiamax.Size = new System.Drawing.Size(136, 29);
            this.txtGiamax.TabIndex = 5;
            // 
            // txtGiamin
            // 
            this.txtGiamin.Location = new System.Drawing.Point(419, 34);
            this.txtGiamin.Name = "txtGiamin";
            this.txtGiamin.Size = new System.Drawing.Size(136, 29);
            this.txtGiamin.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1086, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(948, 25);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(132, 45);
            this.btnTimkiem.TabIndex = 4;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(733, 34);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(196, 29);
            this.txtTenSP.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh mục SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hãng sản xuất";
            // 
            // cbbDanhmucsp
            // 
            this.cbbDanhmucsp.FormattingEnabled = true;
            this.cbbDanhmucsp.Location = new System.Drawing.Point(266, 35);
            this.cbbDanhmucsp.Name = "cbbDanhmucsp";
            this.cbbDanhmucsp.Size = new System.Drawing.Size(136, 29);
            this.cbbDanhmucsp.TabIndex = 1;
            // 
            // cbbHangsx
            // 
            this.cbbHangsx.FormattingEnabled = true;
            this.cbbHangsx.Location = new System.Drawing.Point(114, 35);
            this.cbbHangsx.Name = "cbbHangsx";
            this.cbbHangsx.Size = new System.Drawing.Size(136, 29);
            this.cbbHangsx.TabIndex = 1;
            // 
            // lblTimkiemsp
            // 
            this.lblTimkiemsp.AutoSize = true;
            this.lblTimkiemsp.Location = new System.Drawing.Point(7, 10);
            this.lblTimkiemsp.Name = "lblTimkiemsp";
            this.lblTimkiemsp.Size = new System.Drawing.Size(82, 21);
            this.lblTimkiemsp.TabIndex = 0;
            this.lblTimkiemsp.Text = "Tìm kiếm";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(5, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhaphang.Location = new System.Drawing.Point(1363, 6);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(229, 49);
            this.btnNhaphang.TabIndex = 5;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.UseVisualStyleBackColor = true;
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // pnPhieunhap
            // 
            this.pnPhieunhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPhieunhap.Location = new System.Drawing.Point(5, 3);
            this.pnPhieunhap.Name = "pnPhieunhap";
            this.pnPhieunhap.Size = new System.Drawing.Size(1606, 770);
            this.pnPhieunhap.TabIndex = 6;
            this.pnPhieunhap.Visible = false;
            // 
            // Frm_Khohang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 779);
            this.Controls.Add(this.pnPhieunhap);
            this.Controls.Add(this.btnNhaphang);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnTimkiem);
            this.Controls.Add(this.dgvKhohang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Khohang";
            this.Text = "Frm_Khohang";
            this.Load += new System.EventHandler(this.Frm_Khohang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhohang)).EndInit();
            this.pnTimkiem.ResumeLayout(false);
            this.pnTimkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhohang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADMUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTONKHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHACC;
        private System.Windows.Forms.Panel pnTimkiem;
        private System.Windows.Forms.Label lblTimkiemsp;
        private System.Windows.Forms.ComboBox cbbDanhmucsp;
        private System.Windows.Forms.ComboBox cbbHangsx;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtGiamax;
        private System.Windows.Forms.TextBox txtGiamin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNhaphang;
        private System.Windows.Forms.Panel pnPhieunhap;
    }
}