namespace ProxySwitcher
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.SwitcherNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SwitcherMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSwitcher = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ProxyEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExceptionsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.ToTrayButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BypassLocalCheckbox = new System.Windows.Forms.CheckBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SwitcherMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SwitcherNotifyIcon
            // 
            this.SwitcherNotifyIcon.BalloonTipText = "Click on the icon to switch on/off the proxy.";
            this.SwitcherNotifyIcon.BalloonTipTitle = "Switch proxy on/off";
            this.SwitcherNotifyIcon.ContextMenuStrip = this.SwitcherMenuStrip;
            this.SwitcherNotifyIcon.Text = "Proxy Switcher";
            this.SwitcherNotifyIcon.Visible = true;
            this.SwitcherNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SwitcherNotifyIcon_MouseClick);
            // 
            // SwitcherMenuStrip
            // 
            this.SwitcherMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSwitcher,
            this.menuConfigure,
            this.menuAbout,
            this.toolStripSeparator1,
            this.menuExit});
            this.SwitcherMenuStrip.Name = "contextMenuStrip1";
            this.SwitcherMenuStrip.Size = new System.Drawing.Size(170, 98);
            // 
            // menuSwitcher
            // 
            this.menuSwitcher.CheckOnClick = true;
            this.menuSwitcher.Name = "menuSwitcher";
            this.menuSwitcher.Size = new System.Drawing.Size(169, 22);
            this.menuSwitcher.Text = "Using Proxy";
            this.menuSwitcher.Click += new System.EventHandler(this.menuSwitcher_Click);
            // 
            // menuConfigure
            // 
            this.menuConfigure.Name = "menuConfigure";
            this.menuConfigure.Size = new System.Drawing.Size(169, 22);
            this.menuConfigure.Text = "Configure Proxy";
            this.menuConfigure.Click += new System.EventHandler(this.menuConfigure_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(169, 22);
            this.menuAbout.Text = "About Swticher";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(169, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // ProxyEnableCheckBox
            // 
            this.ProxyEnableCheckBox.AutoSize = true;
            this.ProxyEnableCheckBox.Location = new System.Drawing.Point(12, 13);
            this.ProxyEnableCheckBox.Name = "ProxyEnableCheckBox";
            this.ProxyEnableCheckBox.Size = new System.Drawing.Size(464, 17);
            this.ProxyEnableCheckBox.TabIndex = 2;
            this.ProxyEnableCheckBox.Text = "Use a proxy server for your LAN (These settings will not apply to dial-up or VPN " +
    "connections).";
            this.ProxyEnableCheckBox.UseVisualStyleBackColor = true;
            this.ProxyEnableCheckBox.CheckedChanged += new System.EventHandler(this.ProxyEnableCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "User semicolons (;) to separate entries.";
            // 
            // ExceptionsTextBox
            // 
            this.ExceptionsTextBox.Location = new System.Drawing.Point(34, 79);
            this.ExceptionsTextBox.Multiline = true;
            this.ExceptionsTextBox.Name = "ExceptionsTextBox";
            this.ExceptionsTextBox.Size = new System.Drawing.Size(560, 56);
            this.ExceptionsTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Do not use proxy server for addresses beginning with:";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(463, 192);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 25);
            this.ApplyButton.TabIndex = 21;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // ToTrayButton
            // 
            this.ToTrayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ToTrayButton.Location = new System.Drawing.Point(544, 192);
            this.ToTrayButton.Name = "ToTrayButton";
            this.ToTrayButton.Size = new System.Drawing.Size(75, 25);
            this.ToTrayButton.TabIndex = 20;
            this.ToTrayButton.Text = "To Tray";
            this.ToTrayButton.UseVisualStyleBackColor = true;
            this.ToTrayButton.Click += new System.EventHandler(this.ToTrayButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.Location = new System.Drawing.Point(12, 192);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 25);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BypassLocalCheckbox
            // 
            this.BypassLocalCheckbox.AutoSize = true;
            this.BypassLocalCheckbox.Location = new System.Drawing.Point(34, 158);
            this.BypassLocalCheckbox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BypassLocalCheckbox.Name = "BypassLocalCheckbox";
            this.BypassLocalCheckbox.Size = new System.Drawing.Size(211, 17);
            this.BypassLocalCheckbox.TabIndex = 18;
            this.BypassLocalCheckbox.Text = "Bypass proxy server for local addresses";
            this.BypassLocalCheckbox.UseVisualStyleBackColor = true;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(519, 37);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(75, 20);
            this.PortTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Port:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(91, 37);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(381, 20);
            this.AddressTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Address:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 230);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExceptionsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ToTrayButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BypassLocalCheckbox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProxyEnableCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy Switcher -  Configuration";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.SwitcherMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon SwitcherNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip SwitcherMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuSwitcher;
        private System.Windows.Forms.ToolStripMenuItem menuConfigure;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.CheckBox ProxyEnableCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExceptionsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button ToTrayButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox BypassLocalCheckbox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label1;
    }
}

