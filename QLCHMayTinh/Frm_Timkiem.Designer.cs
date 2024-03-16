namespace QLCHMayTinh
{
    partial class Frm_Timkiem
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
            this.panelA = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.btnSanpham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHDnhap = new System.Windows.Forms.Button();
            this.btnHDXUat = new System.Windows.Forms.Button();
            this.panelA.SuspendLayout();
            this.panelB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelA
            // 
            this.panelA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelA.Controls.Add(this.panelB);
            this.panelA.Location = new System.Drawing.Point(4, 2);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(765, 424);
            this.panelA.TabIndex = 0;
            // 
            // panelB
            // 
            this.panelB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelB.Controls.Add(this.btnSanpham);
            this.panelB.Controls.Add(this.btnHDXUat);
            this.panelB.Controls.Add(this.btnHDnhap);
            this.panelB.Controls.Add(this.label1);
            this.panelB.Location = new System.Drawing.Point(0, 0);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(765, 424);
            this.panelB.TabIndex = 7;
            // 
            // btnSanpham
            // 
            this.btnSanpham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSanpham.AutoSize = true;
            this.btnSanpham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanpham.Location = new System.Drawing.Point(275, 93);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(231, 49);
            this.btnSanpham.TabIndex = 3;
            this.btnSanpham.Text = "Tìm kiếm sản phẩm";
            this.btnSanpham.UseVisualStyleBackColor = true;
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnHDnhap
            // 
            this.btnHDnhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHDnhap.AutoSize = true;
            this.btnHDnhap.Enabled = false;
            this.btnHDnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDnhap.Location = new System.Drawing.Point(275, 233);
            this.btnHDnhap.Name = "btnHDnhap";
            this.btnHDnhap.Size = new System.Drawing.Size(231, 49);
            this.btnHDnhap.TabIndex = 6;
            this.btnHDnhap.Text = "Tìm kiếm hóa đơn nhập";
            this.btnHDnhap.UseVisualStyleBackColor = true;
            this.btnHDnhap.Click += new System.EventHandler(this.btnHDnhap_Click);
            // 
            // btnHDXUat
            // 
            this.btnHDXUat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHDXUat.AutoSize = true;
            this.btnHDXUat.Enabled = false;
            this.btnHDXUat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDXUat.Location = new System.Drawing.Point(275, 161);
            this.btnHDXUat.Name = "btnHDXUat";
            this.btnHDXUat.Size = new System.Drawing.Size(231, 49);
            this.btnHDXUat.TabIndex = 5;
            this.btnHDXUat.Text = "Tìm kiếm hóa đơn xuất";
            this.btnHDXUat.UseVisualStyleBackColor = true;
            // 
            // Frm_Timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(771, 428);
            this.Controls.Add(this.panelA);
            this.Name = "Frm_Timkiem";
            this.Text = "Frm_Timkiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Timkiem_Load);
            this.panelA.ResumeLayout(false);
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Button btnSanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHDXUat;
        private System.Windows.Forms.Button btnHDnhap;
    }
}