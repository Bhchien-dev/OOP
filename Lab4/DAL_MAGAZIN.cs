using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_lab4OOP;

namespace DAL_lab4OOP
{
    public class DAL_Magazin : DBConnect
    {
        SqlDataAdapter da;
        DataTable tbldata;
        SqlCommand cmd;
        SqlConnection _conn = new SqlConnection();
        string kindMagazin ;
        
        public DataTable getMagazin(string sql, int i)
        {
            if (i == 0) { _conn = conn; kindMagazin = "tblMagazin"; }
            if (i == 1) { _conn = conSpar;  kindMagazin = "tblSpar"; }
            if (i == 2) { _conn = conPere;  kindMagazin = "tblPere"; }
            if (i == 3) { _conn = conDiksi;  kindMagazin = "tblDiksi"; }
            da = new SqlDataAdapter(sql, _conn);
            tbldata = new DataTable();
            da.Fill(tbldata);
            return tbldata;
        }
        public bool AddMagazin(DTO_Magazin mag)
        {
            try
            {
                _conn.Open();
                string sql = "";
                if (kindMagazin == "tblMagazin")
                {
                    sql = string.Format("INSERT INTO tblMagazin(ID, Name, Adress) VALUES ('{0}', '{1}', '{2}')",
                                          mag.MAGAZIN_ID, mag.MAGAZIN_NAME, mag.MAGAZIN_ADRESS);

                }
                else
                    sql = string.Format("INSERT INTO {0}(ID, Name, Cost, Stock) VALUES ('{1}', '{2}', '{3}', '{4}')",
                                        kindMagazin, mag.ITEM_ID, mag.ITEM_NAME, mag.ITEM_COST, mag.ITEM_STOCK);
                cmd = new SqlCommand(sql, _conn);
               
                if (cmd.ExecuteNonQuery() > 0) return true;

            }
            catch (Exception e) { }
            finally {_conn.Close(); }
            return false;
        }
      
        public bool EditMagazin(DTO_Magazin mag)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("UPDATE {0} SET ID={1}, Name={2}, Cost={3}, Stock={4}",
                                               kindMagazin, mag.ITEM_ID, mag.ITEM_NAME, mag.ITEM_COST, mag.ITEM_STOCK);
                cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch (Exception ex){ }
            finally { _conn.Close(); }
            return false;
        }
        

    }
}
