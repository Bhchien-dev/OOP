using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace lab3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var MyINI = new INIfile(@"D:\VS 2019\lab3_OOP\test1.ini");
                Console.WriteLine(MyINI.Read("SampleRate", "NCMD"));
                MyINI.Write("Color", "Blue", "COLOR");
                Console.WriteLine(MyINI.Read("Color", "COLOR"));
                MyINI.ChangeValue("Color", "Black", "COLOR");
                Console.WriteLine(MyINI.Read("Color", "COLOR"));
                try
                {
                    MyINI.ChangeValue("A", "B");
                }
                catch (KeyNotFoundException ke)
                {
                    Console.WriteLine(ke.Message);
                }
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine(fe.Message);
            }
            return;
        }

    }
}
