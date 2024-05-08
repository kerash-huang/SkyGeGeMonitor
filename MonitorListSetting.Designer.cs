namespace SkyGeGe
{
    partial class MonitorListSetting
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
            splitContainer1 = new SplitContainer();
            btn_delete = new Button();
            txt_mdata = new TextBox();
            btn_add = new Button();
            list_monitor = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btn_delete);
            splitContainer1.Panel1.Controls.Add(txt_mdata);
            splitContainer1.Panel1.Controls.Add(btn_add);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(list_monitor);
            splitContainer1.Size = new Size(402, 489);
            splitContainer1.SplitterDistance = 64;
            splitContainer1.TabIndex = 0;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(270, 9);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(129, 52);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "刪除";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_mdata
            // 
            txt_mdata.Location = new Point(9, 9);
            txt_mdata.Name = "txt_mdata";
            txt_mdata.Size = new Size(231, 23);
            txt_mdata.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(9, 38);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(231, 23);
            btn_add.TabIndex = 0;
            btn_add.Text = "新增名單";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // list_monitor
            // 
            list_monitor.Dock = DockStyle.Fill;
            list_monitor.FormattingEnabled = true;
            list_monitor.ItemHeight = 15;
            list_monitor.Location = new Point(0, 0);
            list_monitor.Name = "list_monitor";
            list_monitor.Size = new Size(402, 421);
            list_monitor.Sorted = true;
            list_monitor.TabIndex = 0;
            // 
            // MonitorListSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 489);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MonitorListSetting";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "監控名單設定";
            Load += MonitorListSetting_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_delete;
        private TextBox txt_mdata;
        private Button btn_add;
        private ListBox list_monitor;
    }
}