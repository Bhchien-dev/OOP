using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace lab3_OOP
{
    class INIfile
    {
        string PATH;
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int WritePrivateProfileString(string section, string key, 
                                                    string value, string pathfile);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string section, string key, 
                                                  string defa, StringBuilder val, 
                                                  int size, string filepath);
        public INIfile(string inipath = null)
        {
            PATH = new FileInfo(inipath).FullName.ToString();
            if (inipath == null || !File.Exists(inipath))
            {
                throw new FileNotFoundException("ERROR! File was not found.");
            }
        }
        public string Read(string key, string section = null)
        {
            var x = new StringBuilder(225);
            GetPrivateProfileString(section, key, "", x, 255, PATH);
            return x.ToString();
        }
        public void Write(string key, string value, string section = null)
        {
            WritePrivateProfileString(section, key, value, PATH);
        }
        public void ChangeValue(string key, string changvalue,string section = null)
        {
            if (!KeyExit(key, section))
            {
                throw new KeyNotFoundException("ERROR! SECTION PARAMETER was not found.");
            }
            Write(key, changvalue, section);
        }
        public bool KeyExit(string key, string section = null)
        {
            return Read(key, section).Length > 0;
        }
    }
}
