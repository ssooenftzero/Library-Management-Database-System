namespace tushuguan
{
    partial class user_delete
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
            this.lab_del_sno = new System.Windows.Forms.Label();
            this.lab_del_sname = new System.Windows.Forms.Label();
            this.txt_del_sno = new System.Windows.Forms.TextBox();
            this.txt_del_sname = new System.Windows.Forms.TextBox();
            this.btn_del_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_del_sno
            // 
            this.lab_del_sno.AutoSize = true;
            this.lab_del_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_del_sno.Location = new System.Drawing.Point(113, 156);
            this.lab_del_sno.Name = "lab_del_sno";
            this.lab_del_sno.Size = new System.Drawing.Size(96, 28);
            this.lab_del_sno.TabIndex = 0;
            this.lab_del_sno.Text = "学号：";
            // 
            // lab_del_sname
            // 
            this.lab_del_sname.AutoSize = true;
            this.lab_del_sname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_del_sname.Location = new System.Drawing.Point(113, 220);
            this.lab_del_sname.Name = "lab_del_sname";
            this.lab_del_sname.Size = new System.Drawing.Size(96, 28);
            this.lab_del_sname.TabIndex = 1;
            this.lab_del_sname.Text = "姓名：";
            // 
            // txt_del_sno
            // 
            this.txt_del_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_del_sno.Location = new System.Drawing.Point(202, 151);
            this.txt_del_sno.Name = "txt_del_sno";
            this.txt_del_sno.Size = new System.Drawing.Size(409, 38);
            this.txt_del_sno.TabIndex = 3;
            this.txt_del_sno.TextChanged += new System.EventHandler(this.txt_del_sno_TextChanged);
            // 
            // txt_del_sname
            // 
            this.txt_del_sname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_del_sname.Location = new System.Drawing.Point(202, 215);
            this.txt_del_sname.Name = "txt_del_sname";
            this.txt_del_sname.Size = new System.Drawing.Size(409, 38);
            this.txt_del_sname.TabIndex = 4;
            this.txt_del_sname.TextChanged += new System.EventHandler(this.txt_del_sname_TextChanged);
            // 
            // btn_del_ok
            // 
            this.btn_del_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_del_ok.Location = new System.Drawing.Point(618, 325);
            this.btn_del_ok.Name = "btn_del_ok";
            this.btn_del_ok.Size = new System.Drawing.Size(82, 48);
            this.btn_del_ok.TabIndex = 6;
            this.btn_del_ok.Text = "注销";
            this.btn_del_ok.UseVisualStyleBackColor = true;
            this.btn_del_ok.Click += new System.EventHandler(this.btn_del_ok_Click);
            // 
            // user_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.btn_del_ok);
            this.Controls.Add(this.txt_del_sname);
            this.Controls.Add(this.txt_del_sno);
            this.Controls.Add(this.lab_del_sname);
            this.Controls.Add(this.lab_del_sno);
            this.Name = "user_delete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注销";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_del_sno;
        private System.Windows.Forms.Label lab_del_sname;
        private System.Windows.Forms.TextBox txt_del_sno;
        private System.Windows.Forms.TextBox txt_del_sname;
        private System.Windows.Forms.Button btn_del_ok;
    }
}