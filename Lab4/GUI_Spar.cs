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
    public partial class GUI_Spar : Form
    {
        BUS_Magazin busMag = new BUS_Magazin();
        string s = "SELECT * FROM tblSpar";
        public GUI_Spar()
        {
            InitializeComponent();
        }

        private void GUI_Spar_Load(object sender, EventArgs e)
        {
            dataSpar.DataSource = busMag.getMagazin(s, 1);
            dataSpar.Refresh();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != "" && NameBox.Text != ""
                && CostBox.Text != "" && StockBox.Text != "")
            {
                DTO_Magazin mag = new DTO_Magazin(IDBox.Text, NameBox.Text, CostBox.Text, Convert.ToInt32(StockBox.Text));
                if (busMag.AddMagazin(mag))
                {
                    MessageBox.Show("was successful!");
                    dataSpar.DataSource = busMag.getMagazin(s, 1);
                    dataSpar.Refresh();
                }
                else { MessageBox.Show("was't successful"); }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != "" && NameBox.Text != ""
                && CostBox.Text != "" && StockBox.Text != "")
            {
                DTO_Magazin mag = new DTO_Magazin(IDBox.Text, NameBox.Text, CostBox.Text, Convert.ToInt32(StockBox.Text));
                if (busMag.EditMagazin(mag))
                {
                    MessageBox.Show("was successful!");
                    dataSpar.DataSource = busMag.getMagazin(s, 1);
                    dataSpar.Refresh();
                }
                else { MessageBox.Show("was't successful"); }
            }
        }

        private void MoneyButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblSpar";
            string dk = "";
            if(MoneyBox.Text.Trim() != "")
            {
                dk += "Cost <= " + MoneyBox.Text;
            }
            if (dk != "") sql += " WHERE " + dk;
            dataSpar.DataSource = busMag.getMagazin(sql, 1);
            dataSpar.Refresh();
        }

        private void dataSpar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                IDBox.Text = dataSpar[0, e.RowIndex].Value.ToString();
                NameBox.Text = dataSpar[1, e.RowIndex].Value.ToString();
                CostBox.Text = dataSpar[2, e.RowIndex].Value.ToString();
                StockBox.Text = dataSpar[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            { }
        }
        
    }
}
