namespace tushuguan
{
    partial class tushu_lend
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
            this.lab_ld_sno = new System.Windows.Forms.Label();
            this.lab_ld_datel = new System.Windows.Forms.Label();
            this.lab_ld_bno = new System.Windows.Forms.Label();
            this.txb_ld_sno = new System.Windows.Forms.TextBox();
            this.txb_ld_datel = new System.Windows.Forms.TextBox();
            this.txb_ld_bno = new System.Windows.Forms.TextBox();
            this.btn_ld_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_ld_sno
            // 
            this.lab_ld_sno.AutoSize = true;
            this.lab_ld_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ld_sno.Location = new System.Drawing.Point(130, 117);
            this.lab_ld_sno.Name = "lab_ld_sno";
            this.lab_ld_sno.Size = new System.Drawing.Size(138, 28);
            this.lab_ld_sno.TabIndex = 0;
            this.lab_ld_sno.Text = "学   号：";
            // 
            // lab_ld_datel
            // 
            this.lab_ld_datel.AutoSize = true;
            this.lab_ld_datel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ld_datel.Location = new System.Drawing.Point(130, 264);
            this.lab_ld_datel.Name = "lab_ld_datel";
            this.lab_ld_datel.Size = new System.Drawing.Size(152, 28);
            this.lab_ld_datel.TabIndex = 1;
            this.lab_ld_datel.Text = "借书日期：";
            // 
            // lab_ld_bno
            // 
            this.lab_ld_bno.AutoSize = true;
            this.lab_ld_bno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_ld_bno.Location = new System.Drawing.Point(130, 188);
            this.lab_ld_bno.Name = "lab_ld_bno";
            this.lab_ld_bno.Size = new System.Drawing.Size(138, 28);
            this.lab_ld_bno.TabIndex = 2;
            this.lab_ld_bno.Text = "书   号：";
            // 
            // txb_ld_sno
            // 
            this.txb_ld_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_ld_sno.Location = new System.Drawing.Point(295, 114);
            this.txb_ld_sno.Name = "txb_ld_sno";
            this.txb_ld_sno.Size = new System.Drawing.Size(391, 38);
            this.txb_ld_sno.TabIndex = 3;
            // 
            // txb_ld_datel
            // 
            this.txb_ld_datel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_ld_datel.Location = new System.Drawing.Point(295, 264);
            this.txb_ld_datel.Name = "txb_ld_datel";
            this.txb_ld_datel.Size = new System.Drawing.Size(391, 38);
            this.txb_ld_datel.TabIndex = 4;
            // 
            // txb_ld_bno
            // 
            this.txb_ld_bno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_ld_bno.Location = new System.Drawing.Point(295, 185);
            this.txb_ld_bno.Name = "txb_ld_bno";
            this.txb_ld_bno.Size = new System.Drawing.Size(391, 38);
            this.txb_ld_bno.TabIndex = 5;
            // 
            // btn_ld_ok
            // 
            this.btn_ld_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ld_ok.Location = new System.Drawing.Point(507, 377);
            this.btn_ld_ok.Name = "btn_ld_ok";
            this.btn_ld_ok.Size = new System.Drawing.Size(149, 54);
            this.btn_ld_ok.TabIndex = 6;
            this.btn_ld_ok.Text = "确定";
            this.btn_ld_ok.UseVisualStyleBackColor = true;
            this.btn_ld_ok.Click += new System.EventHandler(this.btn_ld_ok_Click);
            // 
            // tushu_lend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.btn_ld_ok);
            this.Controls.Add(this.txb_ld_bno);
            this.Controls.Add(this.txb_ld_datel);
            this.Controls.Add(this.txb_ld_sno);
            this.Controls.Add(this.lab_ld_bno);
            this.Controls.Add(this.lab_ld_datel);
            this.Controls.Add(this.lab_ld_sno);
            this.Name = "tushu_lend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_ld_sno;
        private System.Windows.Forms.Label lab_ld_datel;
        private System.Windows.Forms.Label lab_ld_bno;
        private System.Windows.Forms.TextBox txb_ld_sno;
        private System.Windows.Forms.TextBox txb_ld_datel;
        private System.Windows.Forms.TextBox txb_ld_bno;
        private System.Windows.Forms.Button btn_ld_ok;
    }
}