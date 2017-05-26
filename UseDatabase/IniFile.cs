using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace UseDatabase
{
    public class IniFile
    {
        string _iniFile;

        public IniFile(string fileName)
        {
            _iniFile = fileName;
        }

        public void WriteSetting(string section, string key, string value)
        {
            if (NativeMethods.WritePrivateProfileString(section, key, value, _iniFile) == false)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
        }
    }
}
