namespace tushuguan
{
    partial class tushu_add
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
            this.lab_num = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_kind = new System.Windows.Forms.Label();
            this.lab_amount = new System.Windows.Forms.Label();
            this.lab_place = new System.Windows.Forms.Label();
            this.txb_num = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_kind = new System.Windows.Forms.TextBox();
            this.txb_amount = new System.Windows.Forms.TextBox();
            this.txb_place = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_num
            // 
            this.lab_num.AutoSize = true;
            this.lab_num.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_num.Location = new System.Drawing.Point(151, 83);
            this.lab_num.Name = "lab_num";
            this.lab_num.Size = new System.Drawing.Size(152, 28);
            this.lab_num.TabIndex = 0;
            this.lab_num.Text = "图书编号：";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_name.Location = new System.Drawing.Point(151, 153);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(152, 28);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "图书名称：";
            this.lab_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_kind
            // 
            this.lab_kind.AutoSize = true;
            this.lab_kind.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_kind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_kind.Location = new System.Drawing.Point(151, 216);
            this.lab_kind.Name = "lab_kind";
            this.lab_kind.Size = new System.Drawing.Size(152, 28);
            this.lab_kind.TabIndex = 2;
            this.lab_kind.Text = "图书种类：";
            // 
            // lab_amount
            // 
            this.lab_amount.AutoSize = true;
            this.lab_amount.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_amount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_amount.Location = new System.Drawing.Point(151, 279);
            this.lab_amount.Name = "lab_amount";
            this.lab_amount.Size = new System.Drawing.Size(152, 28);
            this.lab_amount.TabIndex = 3;
            this.lab_amount.Text = "图书数量：";
            // 
            // lab_place
            // 
            this.lab_place.AutoSize = true;
            this.lab_place.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_place.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_place.Location = new System.Drawing.Point(151, 342);
            this.lab_place.Name = "lab_place";
            this.lab_place.Size = new System.Drawing.Size(152, 28);
            this.lab_place.TabIndex = 4;
            this.lab_place.Text = "存放位置：";
            // 
            // txb_num
            // 
            this.txb_num.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_num.Location = new System.Drawing.Point(344, 80);
            this.txb_num.Name = "txb_num";
            this.txb_num.Size = new System.Drawing.Size(298, 38);
            this.txb_num.TabIndex = 5;
            // 
            // txb_name
            // 
            this.txb_name.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_name.Location = new System.Drawing.Point(344, 148);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(298, 38);
            this.txb_name.TabIndex = 6;
            // 
            // txb_kind
            // 
            this.txb_kind.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_kind.Location = new System.Drawing.Point(344, 211);
            this.txb_kind.Name = "txb_kind";
            this.txb_kind.Size = new System.Drawing.Size(298, 38);
            this.txb_kind.TabIndex = 7;
            // 
            // txb_amount
            // 
            this.txb_amount.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_amount.Location = new System.Drawing.Point(344, 274);
            this.txb_amount.Name = "txb_amount";
            this.txb_amount.Size = new System.Drawing.Size(298, 38);
            this.txb_amount.TabIndex = 8;
            // 
            // txb_place
            // 
            this.txb_place.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_place.Location = new System.Drawing.Point(344, 337);
            this.txb_place.Name = "txb_place";
            this.txb_place.Size = new System.Drawing.Size(298, 38);
            this.txb_place.TabIndex = 9;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ok.Location = new System.Drawing.Point(555, 421);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(139, 53);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tushu_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 565);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txb_place);
            this.Controls.Add(this.txb_amount);
            this.Controls.Add(this.txb_kind);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_num);
            this.Controls.Add(this.lab_place);
            this.Controls.Add(this.lab_amount);
            this.Controls.Add(this.lab_kind);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.lab_num);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "tushu_add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书信息添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_num;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_kind;
        private System.Windows.Forms.Label lab_amount;
        private System.Windows.Forms.Label lab_place;
        private System.Windows.Forms.TextBox txb_num;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_kind;
        private System.Windows.Forms.TextBox txb_amount;
        private System.Windows.Forms.TextBox txb_place;
        private System.Windows.Forms.Button btn_ok;
    }
}