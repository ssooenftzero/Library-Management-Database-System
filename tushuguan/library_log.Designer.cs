﻿namespace tushuguan
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
            this.sno.Location = new System.Drawing.Point(101, 95);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(112, 25);
            this.sno.TabIndex = 0;
            this.sno.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(101, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "密  码：";
            // 
            // txt_sno
            // 
            this.txt_sno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sno.ForeColor = System.Drawing.Color.Gray;
            this.txt_sno.Location = new System.Drawing.Point(219, 92);
            this.txt_sno.Name = "txt_sno";
            this.txt_sno.Size = new System.Drawing.Size(219, 36);
            this.txt_sno.TabIndex = 1;
            this.txt_sno.TabStop = false;
            this.txt_sno.Text = "请输入管理员账户";
            this.txt_sno.Enter += new System.EventHandler(this.txt_sno_Enter);
            this.txt_sno.Leave += new System.EventHandler(this.txt_sno_Leave);
            // 
            // txt_sname
            // 
            this.txt_sname.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sname.ForeColor = System.Drawing.Color.Gray;
            this.txt_sname.Location = new System.Drawing.Point(219, 154);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(219, 36);
            this.txt_sname.TabIndex = 2;
            this.txt_sname.TabStop = false;
            this.txt_sname.Text = "请输入管理员密码";
            this.txt_sname.Enter += new System.EventHandler(this.txt_sname_Enter);
            this.txt_sname.Leave += new System.EventHandler(this.txt_sname_Leave);
            // 
            // but_denglu
            // 
            this.but_denglu.BackColor = System.Drawing.SystemColors.Control;
            this.but_denglu.Cursor = System.Windows.Forms.Cursors.Default;
            this.but_denglu.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_denglu.Location = new System.Drawing.Point(106, 239);
            this.but_denglu.Name = "but_denglu";
            this.but_denglu.Size = new System.Drawing.Size(332, 39);
            this.but_denglu.TabIndex = 3;
            this.but_denglu.TabStop = false;
            this.but_denglu.Text = "登 录";
            this.but_denglu.UseVisualStyleBackColor = false;
            this.but_denglu.Click += new System.EventHandler(this.but_denglu_Click);
            // 
            // denglu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 382);
            this.Controls.Add(this.but_denglu);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.txt_sno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sno);
            this.Name = "denglu";
            this.ShowIcon = false;
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

