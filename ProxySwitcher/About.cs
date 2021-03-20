using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcher
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            labelProductName.Text = AssemblyTitle;
            labelVersion.Text = AssemblyVersion;
            richTextBox1.Text = @"This work is created by Charles Sun under GPLv3 license. RegistryMonitor is created by Thomas Freudenberg under The Code Project Open License (CPOL).";
        }

        #region Assembly attributes
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
