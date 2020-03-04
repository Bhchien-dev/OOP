using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_lab4OOP;
using BUS_lab4OOP;

namespace GUI_lab4OOP
{
    public partial class GUI_Magazin : Form
    {
        BUS_Magazin busMag = new BUS_Magazin();
        string s = "SELECT * FROM tblMagazin";
        public GUI_Magazin()
        {
            InitializeComponent();
        }
        private void GUI_Magazin_Load(object sender, EventArgs e)
        {
            dataMagazin.DataSource = busMag.getMagazin(s, 0);
            dataMagazin.Refresh();
        }

        private void Addbox_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != "" && NameBox.Text != "" && AdressBox.Text != "")
            {
                DTO_Magazin mag = new DTO_Magazin(IDBox.Text, NameBox.Text, AdressBox.Text);
                if (busMag.AddMagazin(mag))
                {
                    MessageBox.Show("was successful!");
                    dataMagazin.DataSource = busMag.getMagazin(s, 0);
                    dataMagazin.Refresh();
                }
                else { MessageBox.Show("was't successful"); }
            }
        }

        private void dataMagazin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDBox.Text = dataMagazin[0, e.RowIndex].Value.ToString();
                NameBox.Text = dataMagazin[1, e.RowIndex].Value.ToString();
                AdressBox.Text = dataMagazin[2, e.RowIndex].Value.ToString();
            }
            catch ( Exception ex )
            { }
            
        }

        private void searchbox_Click(object sender, EventArgs e)
        {
            string sql = "SELECT S.Magazin, S.cost, P.Magazin, P.cost, D.Magazin, D.cost FROM tblSpar S" +
                         " INNER JOIN (tblDiksi D INNER JOIN tblPere P ON D.Name = P.Name)" +
                         " ON S.Name = D.Name ";
            string dk = "";
            if (SearchBox.Text.Trim() != "" && AmountBox.Text.Trim() != "")
            {
                dk += " D.Name LIKE '%" + SearchBox.Text + "%'";                
                dk += " AND D.Stock >= " + AmountBox.Text;
                dk += " AND S.Stock >= " + AmountBox.Text;
                dk += " AND P.Stock >= " + AmountBox.Text;
                
            }
            if (dk != "") 
            { 
                sql += " WHERE" + dk;
            }
            dataMagazin.DataSource = busMag.getMagazin(sql, 0);
            dataMagazin.Refresh();
        }
        
        private void ShowButton_Click(object sender, EventArgs e)
        {
            
                if(NameBox.Text.Trim() == "Spar") 
                { 
                    GUI_Spar SparForm = new GUI_Spar();
                    SparForm.ShowDialog();
                }
                if (NameBox.Text.Trim() == "Perekrestok")
                {
                    GUI_Perekrestok PereForm = new GUI_Perekrestok();
                    PereForm.ShowDialog();
                }
                if (NameBox.Text.Trim() == "Diksi")
                {
                    GUI_Diksi DiksiForm = new GUI_Diksi();
                    DiksiForm.ShowDialog();
                }
            
            
        }

        
    }
}
