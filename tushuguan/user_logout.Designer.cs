
namespace tushuguan
{
    partial class user_logout
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_del_sno = new System.Windows.Forms.TextBox();
            this.txt_del_sname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(229, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(229, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号";
            // 
            // txt_del_sno
            // 
            this.txt_del_sno.Location = new System.Drawing.Point(319, 182);
            this.txt_del_sno.Name = "txt_del_sno";
            this.txt_del_sno.Size = new System.Drawing.Size(263, 25);
            this.txt_del_sno.TabIndex = 2;
            this.txt_del_sno.TextChanged += new System.EventHandler(this.txt_del_sno_TextChanged);
            // 
            // txt_del_sname
            // 
            this.txt_del_sname.Location = new System.Drawing.Point(319, 111);
            this.txt_del_sname.Name = "txt_del_sname";
            this.txt_del_sname.Size = new System.Drawing.Size(263, 25);
            this.txt_del_sname.TabIndex = 3;
            this.txt_del_sname.TextChanged += new System.EventHandler(this.txt_del_sname_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(390, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "用户注销";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_del_sname);
            this.Controls.Add(this.txt_del_sno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "user_logout";
            this.Text = "user_logout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_del_sno;
        private System.Windows.Forms.TextBox txt_del_sname;
        private System.Windows.Forms.Button button1;
    }
}