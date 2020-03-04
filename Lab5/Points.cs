using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Net.Http.Headers;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace lab5_OOP
{
    [Serializable]
    public class Points
    {
        public int x { get; set; }
        public int y { get; set; }
        public Points() { }
        public Points(int a, int b) { this.x = a; this.y = b; }
    }
}