using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_lab4OOP
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS 2019\DAL_lab4OOP\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlConnection conDiksi = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS 2019\DAL_lab4OOP\dataDiksi.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlConnection conPere = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS 2019\DAL_lab4OOP\dataPere.mdf;Integrated Security=True;Connect Timeout=30");
        protected SqlConnection conSpar = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS 2019\DAL_lab4OOP\dataSpar.mdf;Integrated Security=True;Connect Timeout=30");

    }
}
