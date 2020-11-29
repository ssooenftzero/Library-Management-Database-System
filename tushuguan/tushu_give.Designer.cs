namespace tushuguan
{
    partial class tushu_give
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
            this.lab_gv_sno = new System.Windows.Forms.Label();
            this.lab_gv_bno = new System.Windows.Forms.Label();
            this.lab_gv_dateh = new System.Windows.Forms.Label();
            this.txb_gv_sno = new System.Windows.Forms.TextBox();
            this.txb_gv_bno = new System.Windows.Forms.TextBox();
            this.txb_gv_dateh = new System.Windows.Forms.TextBox();
            this.btn_gv_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_gv_sno
            // 
            this.lab_gv_sno.AutoSize = true;
            this.lab_gv_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gv_sno.Location = new System.Drawing.Point(128, 81);
            this.lab_gv_sno.Name = "lab_gv_sno";
            this.lab_gv_sno.Size = new System.Drawing.Size(96, 28);
            this.lab_gv_sno.TabIndex = 0;
            this.lab_gv_sno.Text = "学号：";
            // 
            // lab_gv_bno
            // 
            this.lab_gv_bno.AutoSize = true;
            this.lab_gv_bno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gv_bno.Location = new System.Drawing.Point(128, 157);
            this.lab_gv_bno.Name = "lab_gv_bno";
            this.lab_gv_bno.Size = new System.Drawing.Size(96, 28);
            this.lab_gv_bno.TabIndex = 1;
            this.lab_gv_bno.Text = "书号：";
            // 
            // lab_gv_dateh
            // 
            this.lab_gv_dateh.AutoSize = true;
            this.lab_gv_dateh.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gv_dateh.Location = new System.Drawing.Point(128, 237);
            this.lab_gv_dateh.Name = "lab_gv_dateh";
            this.lab_gv_dateh.Size = new System.Drawing.Size(152, 28);
            this.lab_gv_dateh.TabIndex = 2;
            this.lab_gv_dateh.Text = "还书日期：";
            // 
            // txb_gv_sno
            // 
            this.txb_gv_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_gv_sno.Location = new System.Drawing.Point(297, 78);
            this.txb_gv_sno.Name = "txb_gv_sno";
            this.txb_gv_sno.Size = new System.Drawing.Size(327, 38);
            this.txb_gv_sno.TabIndex = 3;
            // 
            // txb_gv_bno
            // 
            this.txb_gv_bno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_gv_bno.Location = new System.Drawing.Point(297, 154);
            this.txb_gv_bno.Name = "txb_gv_bno";
            this.txb_gv_bno.Size = new System.Drawing.Size(327, 38);
            this.txb_gv_bno.TabIndex = 4;
            this.txb_gv_bno.TextChanged += new System.EventHandler(this.txb_gv_bno_TextChanged);
            // 
            // txb_gv_dateh
            // 
            this.txb_gv_dateh.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_gv_dateh.Location = new System.Drawing.Point(297, 234);
            this.txb_gv_dateh.Name = "txb_gv_dateh";
            this.txb_gv_dateh.Size = new System.Drawing.Size(327, 38);
            this.txb_gv_dateh.TabIndex = 5;
            // 
            // btn_gv_ok
            // 
            this.btn_gv_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gv_ok.Location = new System.Drawing.Point(529, 327);
            this.btn_gv_ok.Name = "btn_gv_ok";
            this.btn_gv_ok.Size = new System.Drawing.Size(146, 42);
            this.btn_gv_ok.TabIndex = 6;
            this.btn_gv_ok.Text = "确定";
            this.btn_gv_ok.UseVisualStyleBackColor = true;
            this.btn_gv_ok.Click += new System.EventHandler(this.btn_gv_ok_Click);
            // 
            // tushu_give
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.btn_gv_ok);
            this.Controls.Add(this.txb_gv_dateh);
            this.Controls.Add(this.txb_gv_bno);
            this.Controls.Add(this.txb_gv_sno);
            this.Controls.Add(this.lab_gv_dateh);
            this.Controls.Add(this.lab_gv_bno);
            this.Controls.Add(this.lab_gv_sno);
            this.Name = "tushu_give";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书归还";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_gv_sno;
        private System.Windows.Forms.Label lab_gv_bno;
        private System.Windows.Forms.Label lab_gv_dateh;
        private System.Windows.Forms.TextBox txb_gv_sno;
        private System.Windows.Forms.TextBox txb_gv_bno;
        private System.Windows.Forms.TextBox txb_gv_dateh;
        private System.Windows.Forms.Button btn_gv_ok;
    }
}