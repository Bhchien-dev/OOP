using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Data;

namespace lab5_OOP
{
    class Program
    {
        static void print(Triangle triangle)
        {
            Console.WriteLine($"Type Triangle : {triangle.Type}\n" +
                              $"Point number one: P1({triangle.Point_one.x},{triangle.Point_one.y})\n" +
                              $"Point number two: P2({triangle.Point_two.x},{triangle.Point_two.y})\n" +
                              $"Point number three: P3({triangle.Point_three.x},{triangle.Point_three.y})");
        }
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle("Right Triangle", 
                                                new Points(0, 0), 
                                                new Points(1, 0), 
                                                new Points(0, 1));
            using (var filestream = File.OpenWrite("Triangle.xml"))
            {
                var serializer = new XmlSerializer(typeof(Triangle));
                serializer.Serialize(filestream, triangle);
            }
            Triangle _triangle;
            using (var filestream = File.OpenRead("Triangle.xml"))
            {
                var serializer = new XmlSerializer(typeof(Triangle));
                _triangle = serializer.Deserialize(filestream) as Triangle;
            }
            Console.WriteLine("Deserialized:");
            print(_triangle);
            using(var filestream = File.OpenWrite("Traingle.bin"))
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(filestream, triangle);
            }
            using(var filestream = File.OpenRead("Traingle.bin"))
            {
                var binaryFormatter = new BinaryFormatter();
                _triangle = binaryFormatter.Deserialize(filestream) as Triangle;
            }
            Console.WriteLine("Deserialized:");
            print(_triangle);
            Console.ReadLine();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS 2019\lab2_OOP\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection;
            SqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            string sql = null;
            connection = new SqlConnection(connectionString);
            sql = "SELECT * FROM tblSongs";
            connection.Open();
            adapter = new SqlDataAdapter(sql, connection);
            adapter.Fill(dataSet);
            connection.Close();
            dataSet.WriteXml("TriangleDB.xml");
            return;
        }
    }
}
