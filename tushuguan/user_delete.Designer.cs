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
            this.lab_dlt_sno = new System.Windows.Forms.Label();
            this.lab_dlt_class = new System.Windows.Forms.Label();
            this.btn_dlt_delete = new System.Windows.Forms.Button();
            this.lab_dlt_name = new System.Windows.Forms.Label();
            this.txb_dlt_sno = new System.Windows.Forms.TextBox();
            this.txb_dlt_name = new System.Windows.Forms.TextBox();
            this.txb_dlt_class = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_dlt_sno
            // 
            this.lab_dlt_sno.AutoSize = true;
            this.lab_dlt_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_dlt_sno.Location = new System.Drawing.Point(81, 57);
            this.lab_dlt_sno.Name = "lab_dlt_sno";
            this.lab_dlt_sno.Size = new System.Drawing.Size(138, 28);
            this.lab_dlt_sno.TabIndex = 0;
            this.lab_dlt_sno.Text = "学   号：";
            // 
            // lab_dlt_class
            // 
            this.lab_dlt_class.AutoSize = true;
            this.lab_dlt_class.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_dlt_class.Location = new System.Drawing.Point(81, 217);
            this.lab_dlt_class.Name = "lab_dlt_class";
            this.lab_dlt_class.Size = new System.Drawing.Size(152, 28);
            this.lab_dlt_class.TabIndex = 1;
            this.lab_dlt_class.Text = "专业班级：";
            // 
            // btn_dlt_delete
            // 
            this.btn_dlt_delete.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_dlt_delete.Location = new System.Drawing.Point(541, 329);
            this.btn_dlt_delete.Name = "btn_dlt_delete";
            this.btn_dlt_delete.Size = new System.Drawing.Size(136, 47);
            this.btn_dlt_delete.TabIndex = 3;
            this.btn_dlt_delete.Text = "注销";
            this.btn_dlt_delete.UseVisualStyleBackColor = true;
            this.btn_dlt_delete.Click += new System.EventHandler(this.btn_dlt_delete_Click);
            // 
            // lab_dlt_name
            // 
            this.lab_dlt_name.AutoSize = true;
            this.lab_dlt_name.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_dlt_name.Location = new System.Drawing.Point(81, 136);
            this.lab_dlt_name.Name = "lab_dlt_name";
            this.lab_dlt_name.Size = new System.Drawing.Size(96, 28);
            this.lab_dlt_name.TabIndex = 4;
            this.lab_dlt_name.Text = "姓名：";
            // 
            // txb_dlt_sno
            // 
            this.txb_dlt_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_dlt_sno.Location = new System.Drawing.Point(227, 47);
            this.txb_dlt_sno.Name = "txb_dlt_sno";
            this.txb_dlt_sno.Size = new System.Drawing.Size(336, 38);
            this.txb_dlt_sno.TabIndex = 5;
            // 
            // txb_dlt_name
            // 
            this.txb_dlt_name.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_dlt_name.Location = new System.Drawing.Point(227, 126);
            this.txb_dlt_name.Name = "txb_dlt_name";
            this.txb_dlt_name.Size = new System.Drawing.Size(336, 38);
            this.txb_dlt_name.TabIndex = 6;
            // 
            // txb_dlt_class
            // 
            this.txb_dlt_class.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_dlt_class.Location = new System.Drawing.Point(227, 214);
            this.txb_dlt_class.Name = "txb_dlt_class";
            this.txb_dlt_class.Size = new System.Drawing.Size(336, 38);
            this.txb_dlt_class.TabIndex = 7;
            // 
            // user_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.txb_dlt_class);
            this.Controls.Add(this.txb_dlt_name);
            this.Controls.Add(this.txb_dlt_sno);
            this.Controls.Add(this.lab_dlt_name);
            this.Controls.Add(this.btn_dlt_delete);
            this.Controls.Add(this.lab_dlt_class);
            this.Controls.Add(this.lab_dlt_sno);
            this.Name = "user_delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注销";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_dlt_sno;
        private System.Windows.Forms.Label lab_dlt_class;
        private System.Windows.Forms.Button btn_dlt_delete;
        private System.Windows.Forms.Label lab_dlt_name;
        private System.Windows.Forms.TextBox txb_dlt_sno;
        private System.Windows.Forms.TextBox txb_dlt_name;
        private System.Windows.Forms.TextBox txb_dlt_class;
    }
}