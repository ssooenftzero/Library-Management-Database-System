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
            this.view = new System.Windows.Forms.DataGridView();
            this.lab_sea_bname = new System.Windows.Forms.Label();
            this.txt_sea_bname = new System.Windows.Forms.TextBox();
            this.btn_sea_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Location = new System.Drawing.Point(31, 112);
            this.view.Name = "view";
            this.view.RowHeadersWidth = 51;
            this.view.RowTemplate.Height = 27;
            this.view.Size = new System.Drawing.Size(793, 307);
            this.view.TabIndex = 0;
            // 
            // lab_sea_bname
            // 
            this.lab_sea_bname.AutoSize = true;
            this.lab_sea_bname.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_sea_bname.Location = new System.Drawing.Point(96, 35);
            this.lab_sea_bname.Name = "lab_sea_bname";
            this.lab_sea_bname.Size = new System.Drawing.Size(82, 24);
            this.lab_sea_bname.TabIndex = 1;
            this.lab_sea_bname.Text = "书名：";
            // 
            // txt_sea_bname
            // 
            this.txt_sea_bname.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sea_bname.Location = new System.Drawing.Point(205, 32);
            this.txt_sea_bname.Name = "txt_sea_bname";
            this.txt_sea_bname.Size = new System.Drawing.Size(400, 34);
            this.txt_sea_bname.TabIndex = 2;
            // 
            // btn_sea_ok
            // 
            this.btn_sea_ok.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sea_ok.Location = new System.Drawing.Point(647, 29);
            this.btn_sea_ok.Name = "btn_sea_ok";
            this.btn_sea_ok.Size = new System.Drawing.Size(92, 39);
            this.btn_sea_ok.TabIndex = 3;
            this.btn_sea_ok.Text = "查询";
            this.btn_sea_ok.UseVisualStyleBackColor = true;
            this.btn_sea_ok.Click += new System.EventHandler(this.btn_sea_ok_Click);
            // 
            // tushu_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 482);
            this.Controls.Add(this.btn_sea_ok);
            this.Controls.Add(this.txt_sea_bname);
            this.Controls.Add(this.lab_sea_bname);
            this.Controls.Add(this.view);
            this.Name = "tushu_search";
            this.ShowIcon = false;
            this.Text = "图书查询";
            this.Load += new System.EventHandler(this.tushu_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.Label lab_sea_bname;
        private System.Windows.Forms.TextBox txt_sea_bname;
        private System.Windows.Forms.Button btn_sea_ok;
    }
}