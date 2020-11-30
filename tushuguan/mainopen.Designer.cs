namespace tushuguan
{
    partial class mainopen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainopen));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsl_add = new System.Windows.Forms.ToolStripLabel();
            this.tsb_lend = new System.Windows.Forms.ToolStripButton();
            this.tsl_lend = new System.Windows.Forms.ToolStripLabel();
            this.tsb_give = new System.Windows.Forms.ToolStripButton();
            this.tsl_give = new System.Windows.Forms.ToolStripLabel();
            this.tsb_search = new System.Windows.Forms.ToolStripButton();
            this.tsl_search = new System.Windows.Forms.ToolStripLabel();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tsl_delete = new System.Windows.Forms.ToolStripLabel();
            this.tsb_apply = new System.Windows.Forms.ToolStripButton();
            this.tsl_apply = new System.Windows.Forms.ToolStripLabel();
            this.tsb_alter = new System.Windows.Forms.ToolStripButton();
            this.tsl_alter = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsl_add,
            this.tsb_lend,
            this.tsl_lend,
            this.tsb_give,
            this.tsl_give,
            this.tsb_search,
            this.tsl_search,
            this.tsb_delete,
            this.toolStripLabel4,
            this.tsl_delete,
            this.tsb_apply,
            this.tsl_apply,
            this.tsb_alter,
            this.tsl_alter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(29, 24);
            this.tsb_add.Text = "图书信息添加";
            // 
            // tsl_add
            // 
            this.tsl_add.Name = "tsl_add";
            this.tsl_add.Size = new System.Drawing.Size(99, 24);
            this.tsl_add.Text = "图书信息添加";
            this.tsl_add.Click += new System.EventHandler(this.tsl_add_Click);
            // 
            // tsb_lend
            // 
            this.tsb_lend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_lend.Image = ((System.Drawing.Image)(resources.GetObject("tsb_lend.Image")));
            this.tsb_lend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_lend.Name = "tsb_lend";
            this.tsb_lend.Size = new System.Drawing.Size(29, 24);
            this.tsb_lend.Text = "图书借阅";
            // 
            // tsl_lend
            // 
            this.tsl_lend.Name = "tsl_lend";
            this.tsl_lend.Size = new System.Drawing.Size(69, 24);
            this.tsl_lend.Text = "图书借阅";
            this.tsl_lend.Click += new System.EventHandler(this.tsl_lend_Click);
            // 
            // tsb_give
            // 
            this.tsb_give.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_give.Image = ((System.Drawing.Image)(resources.GetObject("tsb_give.Image")));
            this.tsb_give.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_give.Name = "tsb_give";
            this.tsb_give.Size = new System.Drawing.Size(29, 24);
            this.tsb_give.Text = "图书归还";
            // 
            // tsl_give
            // 
            this.tsl_give.Name = "tsl_give";
            this.tsl_give.Size = new System.Drawing.Size(69, 24);
            this.tsl_give.Text = "图书归还";
            this.tsl_give.Click += new System.EventHandler(this.tsl_give_Click);
            // 
            // tsb_search
            // 
            this.tsb_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_search.Image = ((System.Drawing.Image)(resources.GetObject("tsb_search.Image")));
            this.tsb_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_search.Name = "tsb_search";
            this.tsb_search.Size = new System.Drawing.Size(29, 24);
            this.tsb_search.Text = "图书查询";
            // 
            // tsl_search
            // 
            this.tsl_search.Name = "tsl_search";
            this.tsl_search.Size = new System.Drawing.Size(69, 24);
            this.tsl_search.Text = "图书查询";
            this.tsl_search.Click += new System.EventHandler(this.tsl_search_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(29, 24);
            this.tsb_delete.Text = "用户注销";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(0, 24);
            // 
            // tsl_delete
            // 
            this.tsl_delete.Name = "tsl_delete";
            this.tsl_delete.Size = new System.Drawing.Size(69, 24);
            this.tsl_delete.Text = "用户注销";
            this.tsl_delete.Click += new System.EventHandler(this.tsl_delete_Click);
            // 
            // tsb_apply
            // 
            this.tsb_apply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_apply.Image = ((System.Drawing.Image)(resources.GetObject("tsb_apply.Image")));
            this.tsb_apply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_apply.Name = "tsb_apply";
            this.tsb_apply.Size = new System.Drawing.Size(29, 24);
            this.tsb_apply.Text = "用户注册";
            // 
            // tsl_apply
            // 
            this.tsl_apply.Name = "tsl_apply";
            this.tsl_apply.Size = new System.Drawing.Size(69, 24);
            this.tsl_apply.Text = "用户注册";
            this.tsl_apply.Click += new System.EventHandler(this.tsl_apply_Click);
            // 
            // tsb_alter
            // 
            this.tsb_alter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_alter.Image = ((System.Drawing.Image)(resources.GetObject("tsb_alter.Image")));
            this.tsb_alter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_alter.Name = "tsb_alter";
            this.tsb_alter.Size = new System.Drawing.Size(29, 24);
            this.tsb_alter.Text = "用户信息修改";
            // 
            // tsl_alter
            // 
            this.tsl_alter.Name = "tsl_alter";
            this.tsl_alter.Size = new System.Drawing.Size(99, 24);
            this.tsl_alter.Text = "用户信息修改";
            this.tsl_alter.Click += new System.EventHandler(this.tsl_alter_Click);
            // 
            // mainopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 568);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "mainopen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书馆管理信息系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripLabel tsl_add;
        private System.Windows.Forms.ToolStripButton tsb_lend;
        private System.Windows.Forms.ToolStripLabel tsl_lend;
        private System.Windows.Forms.ToolStripButton tsb_give;
        private System.Windows.Forms.ToolStripLabel tsl_give;
        private System.Windows.Forms.ToolStripButton tsb_search;
        private System.Windows.Forms.ToolStripLabel tsl_search;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel tsl_delete;
        private System.Windows.Forms.ToolStripButton tsb_apply;
        private System.Windows.Forms.ToolStripLabel tsl_apply;
        private System.Windows.Forms.ToolStripButton tsb_alter;
        private System.Windows.Forms.ToolStripLabel tsl_alter;
    }
}