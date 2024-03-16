namespace QLCHMayTinh
{
    partial class Frm_Thongke
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
            this.btnTongSLDaban = new System.Windows.Forms.Button();
            this.btnSLHang = new System.Windows.Forms.Button();
            this.btnDoanhsoNV = new System.Windows.Forms.Button();
            this.btnPhantramDSSP = new System.Windows.Forms.Button();
            this.PhanTramdoanhsoKH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTongSLDaban
            // 
            this.btnTongSLDaban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTongSLDaban.Location = new System.Drawing.Point(154, 32);
            this.btnTongSLDaban.Name = "btnTongSLDaban";
            this.btnTongSLDaban.Size = new System.Drawing.Size(261, 59);
            this.btnTongSLDaban.TabIndex = 0;
            this.btnTongSLDaban.Text = "Lợi nhuận trên số SP bán ra";
            this.btnTongSLDaban.UseVisualStyleBackColor = true;
            this.btnTongSLDaban.Click += new System.EventHandler(this.btnTongSLDaban_Click);
            // 
            // btnSLHang
            // 
            this.btnSLHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSLHang.Location = new System.Drawing.Point(154, 108);
            this.btnSLHang.Name = "btnSLHang";
            this.btnSLHang.Size = new System.Drawing.Size(261, 59);
            this.btnSLHang.TabIndex = 0;
            this.btnSLHang.Text = "SL hàng hóa của mỗi danh mục";
            this.btnSLHang.UseVisualStyleBackColor = true;
            this.btnSLHang.Click += new System.EventHandler(this.btnSLHang_Click);
            // 
            // btnDoanhsoNV
            // 
            this.btnDoanhsoNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDoanhsoNV.Location = new System.Drawing.Point(154, 183);
            this.btnDoanhsoNV.Name = "btnDoanhsoNV";
            this.btnDoanhsoNV.Size = new System.Drawing.Size(261, 59);
            this.btnDoanhsoNV.TabIndex = 0;
            this.btnDoanhsoNV.Text = "Thống kê doanh số NV";
            this.btnDoanhsoNV.UseVisualStyleBackColor = true;
            this.btnDoanhsoNV.Click += new System.EventHandler(this.btnDoanhsoNV_Click);
            // 
            // btnPhantramDSSP
            // 
            this.btnPhantramDSSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPhantramDSSP.Location = new System.Drawing.Point(154, 261);
            this.btnPhantramDSSP.Name = "btnPhantramDSSP";
            this.btnPhantramDSSP.Size = new System.Drawing.Size(261, 59);
            this.btnPhantramDSSP.TabIndex = 0;
            this.btnPhantramDSSP.Text = "Thống kê % doanh số theo SP";
            this.btnPhantramDSSP.UseVisualStyleBackColor = true;
            this.btnPhantramDSSP.Click += new System.EventHandler(this.btnPhantramDSSP_Click);
            // 
            // PhanTramdoanhsoKH
            // 
            this.PhanTramdoanhsoKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhanTramdoanhsoKH.Location = new System.Drawing.Point(154, 343);
            this.PhanTramdoanhsoKH.Name = "PhanTramdoanhsoKH";
            this.PhanTramdoanhsoKH.Size = new System.Drawing.Size(261, 59);
            this.PhanTramdoanhsoKH.TabIndex = 0;
            this.PhanTramdoanhsoKH.Text = "Thống kê % doanh số theo tỉnh";
            this.PhanTramdoanhsoKH.UseVisualStyleBackColor = true;
            this.PhanTramdoanhsoKH.Click += new System.EventHandler(this.PhanTramdoanhsoKH_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 461);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // Frm_Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PhanTramdoanhsoKH);
            this.Controls.Add(this.btnPhantramDSSP);
            this.Controls.Add(this.btnDoanhsoNV);
            this.Controls.Add(this.btnSLHang);
            this.Controls.Add(this.btnTongSLDaban);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Thongke";
            this.Text = "Frm_Thongke";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTongSLDaban;
        private System.Windows.Forms.Button btnSLHang;
        private System.Windows.Forms.Button btnDoanhsoNV;
        private System.Windows.Forms.Button btnPhantramDSSP;
        private System.Windows.Forms.Button PhanTramdoanhsoKH;
        private System.Windows.Forms.Panel panel1;
    }
}