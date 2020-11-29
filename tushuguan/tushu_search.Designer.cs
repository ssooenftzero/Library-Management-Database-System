namespace tushuguan
{
    partial class tushu_search
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
            this.lab_sea_bname = new System.Windows.Forms.Label();
            this.txt_sea_bname = new System.Windows.Forms.TextBox();
            this.btn_sea_ok = new System.Windows.Forms.Button();
            this.lab_sea_bno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBno = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_sea_bname
            // 
            this.lab_sea_bname.AutoSize = true;
            this.lab_sea_bname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_sea_bname.Location = new System.Drawing.Point(60, 45);
            this.lab_sea_bname.Name = "lab_sea_bname";
            this.lab_sea_bname.Size = new System.Drawing.Size(96, 28);
            this.lab_sea_bname.TabIndex = 0;
            this.lab_sea_bname.Text = "书名：";
            // 
            // txt_sea_bname
            // 
            this.txt_sea_bname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sea_bname.Location = new System.Drawing.Point(169, 40);
            this.txt_sea_bname.Name = "txt_sea_bname";
            this.txt_sea_bname.Size = new System.Drawing.Size(410, 38);
            this.txt_sea_bname.TabIndex = 1;
            // 
            // btn_sea_ok
            // 
            this.btn_sea_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sea_ok.Location = new System.Drawing.Point(605, 41);
            this.btn_sea_ok.Name = "btn_sea_ok";
            this.btn_sea_ok.Size = new System.Drawing.Size(111, 37);
            this.btn_sea_ok.TabIndex = 2;
            this.btn_sea_ok.Text = "查询";
            this.btn_sea_ok.UseVisualStyleBackColor = true;
            this.btn_sea_ok.Click += new System.EventHandler(this.btn_sea_ok_Click);
            // 
            // lab_sea_bno
            // 
            this.lab_sea_bno.AutoSize = true;
            this.lab_sea_bno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_sea_bno.Location = new System.Drawing.Point(46, 29);
            this.lab_sea_bno.Name = "lab_sea_bno";
            this.lab_sea_bno.Size = new System.Drawing.Size(87, 25);
            this.lab_sea_bno.TabIndex = 3;
            this.lab_sea_bno.Text = "书号：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtLoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBno);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lab_sea_bno);
            this.panel1.Location = new System.Drawing.Point(65, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 199);
            this.panel1.TabIndex = 7;
            // 
            // txtLoc
            // 
            this.txtLoc.Enabled = false;
            this.txtLoc.Location = new System.Drawing.Point(426, 111);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(156, 25);
            this.txtLoc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(292, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "存放位置：";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(426, 29);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(156, 25);
            this.txtType.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(342, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "种类：";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(124, 111);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(156, 25);
            this.txtNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(46, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "数量：";
            // 
            // txtBno
            // 
            this.txtBno.Enabled = false;
            this.txtBno.Location = new System.Drawing.Point(124, 29);
            this.txtBno.Name = "txtBno";
            this.txtBno.Size = new System.Drawing.Size(156, 25);
            this.txtBno.TabIndex = 4;
            this.txtBno.TextChanged += new System.EventHandler(this.txtBno_TextChanged);
            // 
            // tushu_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sea_ok);
            this.Controls.Add(this.txt_sea_bname);
            this.Controls.Add(this.lab_sea_bname);
            this.Name = "tushu_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书查询";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_sea_bname;
        private System.Windows.Forms.TextBox txt_sea_bname;
        private System.Windows.Forms.Button btn_sea_ok;
        private System.Windows.Forms.Label lab_sea_bno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBno;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
    }
}