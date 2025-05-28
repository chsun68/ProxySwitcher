using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ProxySwitcher
{
    class ProxyRegistry
    {
        private const string REG_KEY_WININET = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings";
        private const string REG_NAME_PROXY_ENABLE = "ProxyEnable";
        private const string REG_NAME_PROXY_SERVER = "ProxyServer";
        private const string REG_NAME_PROXY_OVERRIDE = "ProxyOverride";

        private const int PROXY_ENABLE = 1;
        private const int PROXY_DISABLE = 0;

        // Implementation to enable internet settings immediately.
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        bool settingsReturn, refreshReturn;

        public string Key => REG_KEY_WININET;

        public bool ProxyEnable
        {
            get
            {
                int proxyEnable = Convert.ToInt32(Registry.GetValue(REG_KEY_WININET, REG_NAME_PROXY_ENABLE, PROXY_DISABLE)); //TODO: get wrong reg value?
                return PROXY_ENABLE == proxyEnable;
            }
            set
            {
                Registry.SetValue(REG_KEY_WININET, REG_NAME_PROXY_ENABLE, value? PROXY_ENABLE:PROXY_DISABLE);
            }
        }
        
        public void GetProxyServer(ref string address, ref string port)
        {
            address = "";
            port = "";
            string proxyServer = Convert.ToString(Registry.GetValue(REG_KEY_WININET, REG_NAME_PROXY_SERVER, ""));
            if (!string.IsNullOrEmpty(proxyServer))
            {
                string[] proxyServerContent = proxyServer.Split(':');
                address = proxyServerContent[0] + ':' + proxyServerContent[1];
                port = proxyServerContent[2];
            }
        }

        public void GetProxyOverride(ref string exceptions, ref bool bypassLocal)
        {
            exceptions = "";
            bypassLocal = false;
            string proxyOverride = Convert.ToString(Registry.GetValue(REG_KEY_WININET, REG_NAME_PROXY_OVERRIDE, ""));
            if (!string.IsNullOrEmpty(proxyOverride))
            {
                int position = proxyOverride.IndexOf("<local>");
                if (position > -1)
                {
                    bypassLocal = true;
                    exceptions = proxyOverride.Remove(position, 7);
                    exceptions = exceptions.Replace(";;", ";");
                    if (exceptions.EndsWith(";")) exceptions = exceptions.Substring(0, exceptions.Length - 1);
                    if (exceptions.StartsWith(";")) exceptions = exceptions.Substring(1, exceptions.Length - 1);
                }
            }
        }

        public void SetProxyServer(string address, string port)
        {
            Registry.SetValue(REG_KEY_WININET, REG_NAME_PROXY_SERVER, $"{address}:{port}");
        }

        public void SetProxyOverride(string exceptions, bool bypassLocal)
        {
            string proxyOverride = bypassLocal ? $"{exceptions};<local>" : exceptions;
            Registry.SetValue(REG_KEY_WININET, REG_NAME_PROXY_OVERRIDE, proxyOverride);
        }

        public void ActivateChanges()
        {
            // These lines implement the Interface in the beginning of program
            // They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

    }
}
