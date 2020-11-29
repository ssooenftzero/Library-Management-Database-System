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
            this.lab_giv_date = new System.Windows.Forms.Label();
            this.btn_giv_ok = new System.Windows.Forms.Button();
            this.lab_giv_sno = new System.Windows.Forms.Label();
            this.lab_giv_bno = new System.Windows.Forms.Label();
            this.txt_giv_bno = new System.Windows.Forms.TextBox();
            this.txt_giv_sno = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lab_giv_date
            // 
            this.lab_giv_date.AutoSize = true;
            this.lab_giv_date.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_giv_date.Location = new System.Drawing.Point(90, 226);
            this.lab_giv_date.Name = "lab_giv_date";
            this.lab_giv_date.Size = new System.Drawing.Size(152, 28);
            this.lab_giv_date.TabIndex = 0;
            this.lab_giv_date.Text = "还书日期：";
            // 
            // btn_giv_ok
            // 
            this.btn_giv_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_giv_ok.Location = new System.Drawing.Point(546, 329);
            this.btn_giv_ok.Name = "btn_giv_ok";
            this.btn_giv_ok.Size = new System.Drawing.Size(120, 58);
            this.btn_giv_ok.TabIndex = 2;
            this.btn_giv_ok.Text = "更新";
            this.btn_giv_ok.UseVisualStyleBackColor = true;
            this.btn_giv_ok.Click += new System.EventHandler(this.btn_giv_ok_Click);
            // 
            // lab_giv_sno
            // 
            this.lab_giv_sno.AutoSize = true;
            this.lab_giv_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_giv_sno.Location = new System.Drawing.Point(90, 63);
            this.lab_giv_sno.Name = "lab_giv_sno";
            this.lab_giv_sno.Size = new System.Drawing.Size(152, 28);
            this.lab_giv_sno.TabIndex = 3;
            this.lab_giv_sno.Text = "学    号：";
            // 
            // lab_giv_bno
            // 
            this.lab_giv_bno.AutoSize = true;
            this.lab_giv_bno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_giv_bno.Location = new System.Drawing.Point(90, 135);
            this.lab_giv_bno.Name = "lab_giv_bno";
            this.lab_giv_bno.Size = new System.Drawing.Size(152, 28);
            this.lab_giv_bno.TabIndex = 4;
            this.lab_giv_bno.Text = "书    号：";
            // 
            // txt_giv_bno
            // 
            this.txt_giv_bno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_giv_bno.Location = new System.Drawing.Point(254, 135);
            this.txt_giv_bno.Name = "txt_giv_bno";
            this.txt_giv_bno.Size = new System.Drawing.Size(412, 38);
            this.txt_giv_bno.TabIndex = 8;
            // 
            // txt_giv_sno
            // 
            this.txt_giv_sno.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_giv_sno.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_giv_sno.Location = new System.Drawing.Point(254, 60);
            this.txt_giv_sno.Name = "txt_giv_sno";
            this.txt_giv_sno.Size = new System.Drawing.Size(412, 38);
            this.txt_giv_sno.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(412, 25);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tushu_give
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_giv_sno);
            this.Controls.Add(this.txt_giv_bno);
            this.Controls.Add(this.lab_giv_bno);
            this.Controls.Add(this.lab_giv_sno);
            this.Controls.Add(this.btn_giv_ok);
            this.Controls.Add(this.lab_giv_date);
            this.Name = "tushu_give";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书归还";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_giv_date;
        private System.Windows.Forms.Button btn_giv_ok;
        private System.Windows.Forms.Label lab_giv_sno;
        private System.Windows.Forms.Label lab_giv_bno;
        private System.Windows.Forms.TextBox txt_giv_bno;
        private System.Windows.Forms.TextBox txt_giv_sno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}