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
            this.lab_sc_bname = new System.Windows.Forms.Label();
            this.txb_sc_bname = new System.Windows.Forms.TextBox();
            this.btn_sc_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_sc_bname
            // 
            this.lab_sc_bname.AutoSize = true;
            this.lab_sc_bname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_sc_bname.Location = new System.Drawing.Point(169, 115);
            this.lab_sc_bname.Name = "lab_sc_bname";
            this.lab_sc_bname.Size = new System.Drawing.Size(96, 28);
            this.lab_sc_bname.TabIndex = 0;
            this.lab_sc_bname.Text = "书名：";
            // 
            // txb_sc_bname
            // 
            this.txb_sc_bname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_sc_bname.Location = new System.Drawing.Point(293, 112);
            this.txb_sc_bname.Name = "txb_sc_bname";
            this.txb_sc_bname.Size = new System.Drawing.Size(328, 38);
            this.txb_sc_bname.TabIndex = 1;
            // 
            // btn_sc_ok
            // 
            this.btn_sc_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sc_ok.Location = new System.Drawing.Point(477, 212);
            this.btn_sc_ok.Name = "btn_sc_ok";
            this.btn_sc_ok.Size = new System.Drawing.Size(144, 41);
            this.btn_sc_ok.TabIndex = 2;
            this.btn_sc_ok.Text = "查询";
            this.btn_sc_ok.UseVisualStyleBackColor = true;
            this.btn_sc_ok.Click += new System.EventHandler(this.btn_sc_ok_Click);
            // 
            // tushu_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.btn_sc_ok);
            this.Controls.Add(this.txb_sc_bname);
            this.Controls.Add(this.lab_sc_bname);
            this.Name = "tushu_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_sc_bname;
        private System.Windows.Forms.TextBox txb_sc_bname;
        private System.Windows.Forms.Button btn_sc_ok;
    }
}