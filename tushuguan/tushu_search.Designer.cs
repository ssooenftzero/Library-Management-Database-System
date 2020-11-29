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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_sea_bname
            // 
            this.lab_sea_bname.AutoSize = true;
            this.lab_sea_bname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_sea_bname.Location = new System.Drawing.Point(45, 36);
            this.lab_sea_bname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_sea_bname.Name = "lab_sea_bname";
            this.lab_sea_bname.Size = new System.Drawing.Size(76, 22);
            this.lab_sea_bname.TabIndex = 0;
            this.lab_sea_bname.Text = "书名：";
            // 
            // txt_sea_bname
            // 
            this.txt_sea_bname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sea_bname.Location = new System.Drawing.Point(127, 32);
            this.txt_sea_bname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sea_bname.Name = "txt_sea_bname";
            this.txt_sea_bname.Size = new System.Drawing.Size(308, 32);
            this.txt_sea_bname.TabIndex = 1;
            // 
            // btn_sea_ok
            // 
            this.btn_sea_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sea_ok.Location = new System.Drawing.Point(454, 33);
            this.btn_sea_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sea_ok.Name = "btn_sea_ok";
            this.btn_sea_ok.Size = new System.Drawing.Size(83, 30);
            this.btn_sea_ok.TabIndex = 2;
            this.btn_sea_ok.Text = "查询";
            this.btn_sea_ok.UseVisualStyleBackColor = true;
            this.btn_sea_ok.Click += new System.EventHandler(this.btn_sea_ok_Click);
            // 
            // lab_sea_bno
            // 
            this.lab_sea_bno.AutoSize = true;
            this.lab_sea_bno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_sea_bno.Location = new System.Drawing.Point(34, 23);
            this.lab_sea_bno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_sea_bno.Name = "lab_sea_bno";
            this.lab_sea_bno.Size = new System.Drawing.Size(69, 20);
            this.lab_sea_bno.TabIndex = 3;
            this.lab_sea_bno.Text = "书号：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtLoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lab_sea_bno);
            this.panel1.Location = new System.Drawing.Point(49, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 160);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(118, 30);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtLoc
            // 
            this.txtLoc.Enabled = false;
            this.txtLoc.Location = new System.Drawing.Point(320, 89);
            this.txtLoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(118, 21);
            this.txtLoc.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(219, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "存放位置：";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(320, 23);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(118, 21);
            this.txtType.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(256, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "种类：";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(93, 89);
            this.txtNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(118, 21);
            this.txtNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "数量：";
            // 
            // tushu_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sea_ok);
            this.Controls.Add(this.txt_sea_bname);
            this.Controls.Add(this.lab_sea_bname);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "tushu_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书查询";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}