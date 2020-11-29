namespace tushuguan
{
    partial class denglu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.sno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sno = new System.Windows.Forms.TextBox();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.but_denglu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sno
            // 
            this.sno.AutoSize = true;
            this.sno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sno.Location = new System.Drawing.Point(53, 75);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(87, 25);
            this.sno.TabIndex = 0;
            this.sno.Text = "学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(53, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // txt_sno
            // 
            this.txt_sno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sno.Location = new System.Drawing.Point(136, 69);
            this.txt_sno.Name = "txt_sno";
            this.txt_sno.Size = new System.Drawing.Size(229, 36);
            this.txt_sno.TabIndex = 2;
            // 
            // txt_sname
            // 
            this.txt_sname.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sname.Location = new System.Drawing.Point(136, 131);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(229, 36);
            this.txt_sname.TabIndex = 3;
            // 
            // but_denglu
            // 
            this.but_denglu.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_denglu.Location = new System.Drawing.Point(146, 206);
            this.but_denglu.Name = "but_denglu";
            this.but_denglu.Size = new System.Drawing.Size(120, 49);
            this.but_denglu.TabIndex = 4;
            this.but_denglu.Text = "登录";
            this.but_denglu.UseVisualStyleBackColor = true;
            this.but_denglu.Click += new System.EventHandler(this.but_denglu_Click);
            // 
            // denglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 288);
            this.Controls.Add(this.but_denglu);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.txt_sno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sno);
            this.Name = "denglu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sno;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.Button but_denglu;
    }
}

