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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.txt_sea_bname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sea_bname.Name = "txt_sea_bname";
            this.txt_sea_bname.Size = new System.Drawing.Size(409, 38);
            this.txt_sea_bname.TabIndex = 1;
            // 
            // btn_sea_ok
            // 
            this.btn_sea_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sea_ok.Location = new System.Drawing.Point(605, 41);
            this.btn_sea_ok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sea_ok.Name = "btn_sea_ok";
            this.btn_sea_ok.Size = new System.Drawing.Size(111, 38);
            this.btn_sea_ok.TabIndex = 2;
            this.btn_sea_ok.Text = "查询";
            this.btn_sea_ok.UseVisualStyleBackColor = true;
            this.btn_sea_ok.Click += new System.EventHandler(this.btn_sea_ok_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(169, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(409, 227);
            this.dataGridView1.TabIndex = 3;
            // 
            // tushu_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sea_ok);
            this.Controls.Add(this.txt_sea_bname);
            this.Controls.Add(this.lab_sea_bname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "tushu_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_sea_bname;
        private System.Windows.Forms.TextBox txt_sea_bname;
        private System.Windows.Forms.Button btn_sea_ok;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}