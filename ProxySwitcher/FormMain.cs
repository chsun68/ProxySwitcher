using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistryUtils;

namespace ProxySwitcher
{
    public partial class FormMain : Form
    {
        private bool isProxyEnable;
        private string proxyAddress;
        private string proxyPort;
        private string proxyExceptions;
        private bool bypassLocal;

        private RegistryMonitor monitor;
        private ProxyRegistry registry;

        private Icon ProxyIcon
        {
            get
            {
                return isProxyEnable ? Properties.Resources.switch_on : Properties.Resources.switch_off;
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            registry = new ProxyRegistry();
            isProxyEnable = registry.ProxyEnable;
            registry.GetProxyServer(ref proxyAddress, ref proxyPort);
            registry.GetProxyOverride(ref proxyExceptions, ref bypassLocal);

            monitor = new RegistryMonitor(registry.Key);
            monitor.RegChanged += Monitor_RegChanged;
            monitor.Start();
        }

        private void Monitor_RegChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler(Monitor_RegChanged), new object[] { sender, e });
            }
            else
            {
                isProxyEnable = registry.ProxyEnable;
                registry.GetProxyServer(ref proxyAddress, ref proxyPort);
                registry.GetProxyOverride(ref proxyExceptions, ref bypassLocal);
                if (FormWindowState.Minimized == WindowState)
                {
                    SetNotifyIconAndMenu();
                }
                else
                {
                    SetFormControlValues();
                }
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                ShowInTaskbar = false;
                SwitcherNotifyIcon.Visible = true;
                SetNotifyIconAndMenu();
                Hide();
            }
            else
            {
                // The form was shown in normal state.
                ShowInTaskbar = true;
                SetFormControlValues();
                ChangeFormControlEnableStatus();
                SwitcherNotifyIcon.Visible = false;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            monitor?.Stop();
            monitor?.Dispose();
        }

        #region Form controls
        private void ProxyEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isProxyEnable = ProxyEnableCheckBox.Checked;
            ChangeFormControlEnableStatus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            proxyAddress = AddressTextBox.Text;
            proxyPort = PortTextBox.Text;
            proxyExceptions = ExceptionsTextBox.Text;
            bypassLocal = BypassLocalCheckbox.Checked;
            registry.SetProxyServer(proxyAddress, proxyPort);
            registry.SetProxyOverride(proxyExceptions, bypassLocal);
            registry.ActivateChanges();
        }

        private void ToTrayButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SetFormControlValues()
        {
            ProxyEnableCheckBox.Checked = isProxyEnable;
            AddressTextBox.Text = proxyAddress;
            PortTextBox.Text = proxyPort;
            ExceptionsTextBox.Text = proxyExceptions;
            BypassLocalCheckbox.Checked = bypassLocal;
        }

        private void ChangeFormControlEnableStatus()
        {
            label1.Enabled = isProxyEnable;
            label2.Enabled = isProxyEnable;
            label3.Enabled = isProxyEnable;
            label4.Enabled = isProxyEnable;
            AddressTextBox.Enabled = isProxyEnable;
            PortTextBox.Enabled = isProxyEnable;
            ExceptionsTextBox.Enabled = isProxyEnable;
            BypassLocalCheckbox.Enabled = isProxyEnable;
        }
        #endregion

        #region Context menu
        private void menuSwitcher_Click(object sender, EventArgs e)
        {
            isProxyEnable = menuSwitcher.Checked;
            registry.ProxyEnable = isProxyEnable;
            registry.ActivateChanges();
        }

        private void menuConfigure_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            string message = @"
License
-------
This work is created by Charles Sun and is licensed under MIT.
This work uses RegistryMonitor, which is created by Thomas Freudenberg under The Code Project Open License (CPOL).

";
            //MessageBox.Show(message, "About");
            //AboutBox about = new AboutBox();
            About about = new About();
            about.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Notify icon
        private void SwitcherNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            {
                isProxyEnable = !isProxyEnable;
                registry.ProxyEnable = isProxyEnable;
                registry.ActivateChanges();
                SetNotifyIconAndMenu();
            }
        }

        private void SetNotifyIconAndMenu()
        {
            SwitcherNotifyIcon.Icon = ProxyIcon;
            menuSwitcher.Checked = isProxyEnable;
        }
        #endregion
    }
}
