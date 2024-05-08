namespace SkyGeGe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            info_box = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            關閉程式ToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            ts_menu_item_monitor_status = new ToolStripMenuItem();
            ts_item_setList = new ToolStripMenuItem();
            btn_startBot = new Button();
            browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)browser).BeginInit();
            SuspendLayout();
            // 
            // info_box
            // 
            info_box.Location = new Point(0, 28);
            info_box.Multiline = true;
            info_box.Name = "info_box";
            info_box.ScrollBars = ScrollBars.Vertical;
            info_box.Size = new Size(358, 501);
            info_box.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(813, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { 關閉程式ToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(44, 22);
            toolStripDropDownButton1.Text = "檔案";
            // 
            // 關閉程式ToolStripMenuItem
            // 
            關閉程式ToolStripMenuItem.Name = "關閉程式ToolStripMenuItem";
            關閉程式ToolStripMenuItem.Size = new Size(122, 22);
            關閉程式ToolStripMenuItem.Text = "關閉程式";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { ts_menu_item_monitor_status, ts_item_setList });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(44, 22);
            toolStripDropDownButton2.Text = "設定";
            // 
            // ts_menu_item_monitor_status
            // 
            ts_menu_item_monitor_status.Checked = true;
            ts_menu_item_monitor_status.CheckState = CheckState.Checked;
            ts_menu_item_monitor_status.Name = "ts_menu_item_monitor_status";
            ts_menu_item_monitor_status.Size = new Size(146, 22);
            ts_menu_item_monitor_status.Text = "監控狀態";
            // 
            // ts_item_setList
            // 
            ts_item_setList.Name = "ts_item_setList";
            ts_item_setList.Size = new Size(146, 22);
            ts_item_setList.Text = "設定監控名單";
            ts_item_setList.Click += ts_item_setList_Click;
            // 
            // btn_startBot
            // 
            btn_startBot.Location = new Point(364, 28);
            btn_startBot.Name = "btn_startBot";
            btn_startBot.Size = new Size(75, 23);
            btn_startBot.TabIndex = 2;
            btn_startBot.Text = "啟動程式";
            btn_startBot.UseVisualStyleBackColor = true;
            btn_startBot.Click += btn_startBot_Click;
            // 
            // browser
            // 
            browser.AllowExternalDrop = true;
            browser.CreationProperties = null;
            browser.DefaultBackgroundColor = Color.White;
            browser.Location = new Point(364, 57);
            browser.Name = "browser";
            browser.Size = new Size(437, 472);
            browser.Source = new Uri("about:blank", UriKind.Absolute);
            browser.TabIndex = 0;
            browser.Visible = false;
            browser.ZoomFactor = 1D;
            browser.NavigationCompleted += webView21_NavigationCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 527);
            Controls.Add(btn_startBot);
            Controls.Add(toolStrip1);
            Controls.Add(browser);
            Controls.Add(info_box);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SkyGeGe Monitor";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)browser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox info_box;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem 關閉程式ToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem ts_menu_item_monitor_status;
        private ToolStripMenuItem ts_item_setList;
        private Button btn_startBot;
        private Microsoft.Web.WebView2.WinForms.WebView2 browser;
    }
}
