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
    public class Triangle
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        public Points Point_one { get; set; }
        public Points Point_two { get; set; }
        public Points Point_three { get; set; }
        public Triangle() { }
        public Triangle(string type, Points p1, Points p2, Points p3)
        {
            this.Type = type;
            this.Point_one = p1;
            this.Point_two = p2;
            this.Point_three = p3;
        }
    }
}
