namespace QLKHOVATLIEU
{
    partial class frmtracuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtracuu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_lsp = new System.Windows.Forms.Label();
            this.lb_sp = new System.Windows.Forms.Label();
            this.lb_kh = new System.Windows.Forms.Label();
            this.lb_nv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(53, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng sản phẩm trong kho : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(53, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng nhân viên : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(53, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng Kho hàng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(53, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng loại sản phẩm : ";
            // 
            // lb_lsp
            // 
            this.lb_lsp.AutoSize = true;
            this.lb_lsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lb_lsp.Location = new System.Drawing.Point(544, 233);
            this.lb_lsp.Name = "lb_lsp";
            this.lb_lsp.Size = new System.Drawing.Size(205, 40);
            this.lb_lsp.TabIndex = 8;
            this.lb_lsp.Text = "THỐNG KÊ";
            // 
            // lb_sp
            // 
            this.lb_sp.AutoSize = true;
            this.lb_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lb_sp.Location = new System.Drawing.Point(544, 117);
            this.lb_sp.Name = "lb_sp";
            this.lb_sp.Size = new System.Drawing.Size(205, 40);
            this.lb_sp.TabIndex = 7;
            this.lb_sp.Text = "THỐNG KÊ";
            // 
            // lb_kh
            // 
            this.lb_kh.AutoSize = true;
            this.lb_kh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lb_kh.Location = new System.Drawing.Point(544, 285);
            this.lb_kh.Name = "lb_kh";
            this.lb_kh.Size = new System.Drawing.Size(205, 40);
            this.lb_kh.TabIndex = 6;
            this.lb_kh.Text = "THỐNG KÊ";
            // 
            // lb_nv
            // 
            this.lb_nv.AutoSize = true;
            this.lb_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lb_nv.Location = new System.Drawing.Point(544, 180);
            this.lb_nv.Name = "lb_nv";
            this.lb_nv.Size = new System.Drawing.Size(205, 40);
            this.lb_nv.TabIndex = 5;
            this.lb_nv.Text = "THỐNG KÊ";
            // 
            // frmtracuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1095, 652);
            this.Controls.Add(this.lb_lsp);
            this.Controls.Add(this.lb_sp);
            this.Controls.Add(this.lb_kh);
            this.Controls.Add(this.lb_nv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmtracuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tracuu";
            this.Load += new System.EventHandler(this.frmtracuu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_lsp;
        private System.Windows.Forms.Label lb_sp;
        private System.Windows.Forms.Label lb_kh;
        private System.Windows.Forms.Label lb_nv;
    }
}