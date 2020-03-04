using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class GUI_Perekrestok : Form
    {
        BUS_Magazin busMag = new BUS_Magazin();
        string s = "SELECT * FROM tblPere";
        public GUI_Perekrestok()
        {
            InitializeComponent();
        }
        private void GUI_Perekrestok_Load(object sender, EventArgs e) 
        {
            dataPere.DataSource = busMag.getMagazin(s, 2);
            dataPere.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != "" && NameBox.Text != ""
                && CostBox.Text != "" && StockBox.Text != "")
            {
                DTO_Magazin mag = new DTO_Magazin(IDBox.Text, NameBox.Text, CostBox.Text, Convert.ToInt32(StockBox.Text));
                if (!busMag.AddMagazin(mag))
                {
                    MessageBox.Show("was successful!");
                    dataPere.DataSource = busMag.getMagazin(s, 2);
                    dataPere.Refresh();
                }
                else { MessageBox.Show("was't successful"); }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != "" && NameBox.Text != ""
                && CostBox.Text != "" && StockBox.Text != "")
            {
                DTO_Magazin mag = new DTO_Magazin(IDBox.Text, NameBox.Text, CostBox.Text, Convert.ToInt32(StockBox.Text));
                if (busMag.EditMagazin(mag))
                {
                    MessageBox.Show("was successful!");
                    dataPere.DataSource = busMag.getMagazin(s, 2);
                    dataPere.Refresh();
                }
                else { MessageBox.Show("was't successful"); }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string sql = s;
            string dk = "";
            if (MoneyBox.Text.Trim() != "")
            {
                dk += "Cost <= " + MoneyBox.Text;
            }
            if (dk != "") sql += " WHERE " + dk;
            dataPere.DataSource = busMag.getMagazin(sql, 2);
            dataPere.Refresh();
        }

        private void dataPere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDBox.Text = dataPere[0, e.RowIndex].Value.ToString();
                NameBox.Text = dataPere[1, e.RowIndex].Value.ToString();
                CostBox.Text = dataPere[2, e.RowIndex].Value.ToString();
                StockBox.Text = dataPere[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            { }
        }
    }
}
