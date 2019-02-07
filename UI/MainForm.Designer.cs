namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.监控报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入新报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.监控任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加新任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageToday = new System.Windows.Forms.TabPage();
            this.listBoxToday = new System.Windows.Forms.ListBox();
            this.tabPageTomorrow = new System.Windows.Forms.TabPage();
            this.listBoxTomorrow = new System.Windows.Forms.ListBox();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageToday.SuspendLayout();
            this.tabPageTomorrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(721, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.监控报告ToolStripMenuItem,
            this.监控任务ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(721, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 监控报告ToolStripMenuItem
            // 
            this.监控报告ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入新报告ToolStripMenuItem,
            this.修改报告ToolStripMenuItem,
            this.删除报告ToolStripMenuItem});
            this.监控报告ToolStripMenuItem.Name = "监控报告ToolStripMenuItem";
            this.监控报告ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.监控报告ToolStripMenuItem.Text = "监控报告";
            // 
            // 插入新报告ToolStripMenuItem
            // 
            this.插入新报告ToolStripMenuItem.Name = "插入新报告ToolStripMenuItem";
            this.插入新报告ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.插入新报告ToolStripMenuItem.Text = "插入新报告";
            this.插入新报告ToolStripMenuItem.Click += new System.EventHandler(this.插入新报告ToolStripMenuItem_Click);
            // 
            // 修改报告ToolStripMenuItem
            // 
            this.修改报告ToolStripMenuItem.Name = "修改报告ToolStripMenuItem";
            this.修改报告ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改报告ToolStripMenuItem.Text = "修改报告";
            // 
            // 删除报告ToolStripMenuItem
            // 
            this.删除报告ToolStripMenuItem.Name = "删除报告ToolStripMenuItem";
            this.删除报告ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除报告ToolStripMenuItem.Text = "删除报告";
            // 
            // 监控任务ToolStripMenuItem
            // 
            this.监控任务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加新任务ToolStripMenuItem,
            this.删除任务ToolStripMenuItem});
            this.监控任务ToolStripMenuItem.Name = "监控任务ToolStripMenuItem";
            this.监控任务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.监控任务ToolStripMenuItem.Text = "监控任务";
            // 
            // 添加新任务ToolStripMenuItem
            // 
            this.添加新任务ToolStripMenuItem.Name = "添加新任务ToolStripMenuItem";
            this.添加新任务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加新任务ToolStripMenuItem.Text = "添加新任务";
            // 
            // 删除任务ToolStripMenuItem
            // 
            this.删除任务ToolStripMenuItem.Name = "删除任务ToolStripMenuItem";
            this.删除任务ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除任务ToolStripMenuItem.Text = "删除任务";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(721, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 50);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listBoxContent);
            this.splitContainer.Size = new System.Drawing.Size(721, 378);
            this.splitContainer.SplitterDistance = 239;
            this.splitContainer.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageToday);
            this.tabControl.Controls.Add(this.tabPageTomorrow);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(239, 378);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageToday
            // 
            this.tabPageToday.Controls.Add(this.listBoxToday);
            this.tabPageToday.Location = new System.Drawing.Point(4, 22);
            this.tabPageToday.Name = "tabPageToday";
            this.tabPageToday.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageToday.Size = new System.Drawing.Size(231, 352);
            this.tabPageToday.TabIndex = 0;
            this.tabPageToday.Text = "今天需更新报告";
            this.tabPageToday.UseVisualStyleBackColor = true;
            // 
            // listBoxToday
            // 
            this.listBoxToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxToday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxToday.FormattingEnabled = true;
            this.listBoxToday.ItemHeight = 16;
            this.listBoxToday.Location = new System.Drawing.Point(3, 3);
            this.listBoxToday.Name = "listBoxToday";
            this.listBoxToday.Size = new System.Drawing.Size(225, 346);
            this.listBoxToday.TabIndex = 0;
            // 
            // tabPageTomorrow
            // 
            this.tabPageTomorrow.Controls.Add(this.listBoxTomorrow);
            this.tabPageTomorrow.Location = new System.Drawing.Point(4, 22);
            this.tabPageTomorrow.Name = "tabPageTomorrow";
            this.tabPageTomorrow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTomorrow.Size = new System.Drawing.Size(231, 352);
            this.tabPageTomorrow.TabIndex = 1;
            this.tabPageTomorrow.Text = "明天需更新报告";
            this.tabPageTomorrow.UseVisualStyleBackColor = true;
            // 
            // listBoxTomorrow
            // 
            this.listBoxTomorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTomorrow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxTomorrow.FormattingEnabled = true;
            this.listBoxTomorrow.ItemHeight = 16;
            this.listBoxTomorrow.Location = new System.Drawing.Point(3, 3);
            this.listBoxTomorrow.Name = "listBoxTomorrow";
            this.listBoxTomorrow.Size = new System.Drawing.Size(225, 346);
            this.listBoxTomorrow.TabIndex = 0;
            // 
            // listBoxContent
            // 
            this.listBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.ItemHeight = 16;
            this.listBoxContent.Location = new System.Drawing.Point(0, 0);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(478, 378);
            this.listBoxContent.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "监控组信息管理";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageToday.ResumeLayout(false);
            this.tabPageTomorrow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.ToolStripMenuItem 监控报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入新报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 监控任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加新任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除任务ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageToday;
        private System.Windows.Forms.TabPage tabPageTomorrow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox listBoxToday;
        private System.Windows.Forms.ListBox listBoxTomorrow;
    }
}

