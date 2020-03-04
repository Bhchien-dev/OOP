using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_lab4OOP;
using DTO_lab4OOP;
using System.Data;
using System.Data.SqlClient;

namespace BUS_lab4OOP
{
    public class BUS_Magazin
    {
        DAL_Magazin dalMagazin = new DAL_Magazin();
        public DataTable getMagazin(string sql, int i)
        {
            return dalMagazin.getMagazin(sql, i);
        }
        public bool AddMagazin(DTO_Magazin mag)
        {
            return dalMagazin.AddMagazin(mag);
        }
        public bool EditMagazin(DTO_Magazin mag)
        {
            return dalMagazin.EditMagazin(mag);
        }
    }
}
