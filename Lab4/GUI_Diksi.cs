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
    public partial class GUI_Diksi : Form
    {
        BUS_Magazin busMag = new BUS_Magazin();
        string s = "SELECT * FROM tblDiksi";
        public GUI_Diksi()
        {
            InitializeComponent();
        }

        private void GUI_Diksi_Load(object sender, EventArgs e)
        {
            dataDiksi.DataSource = busMag.getMagazin(s, 3);
            dataDiksi.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (IDBox.Text != "" && NameBox.Text != ""
                && CostBox.Text != "" && StockBox.Text != "")
            {
                DTO_Magazin mag = new DTO_Magazin(IDBox.Text, NameBox.Text, CostBox.Text, Convert.ToInt32(StockBox.Text));
                if (busMag.AddMagazin(mag))
                {
                    MessageBox.Show("was successful!");
                    dataDiksi.DataSource = busMag.getMagazin(s, 3);
                    dataDiksi.Refresh();
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
                    dataDiksi.DataSource = busMag.getMagazin(s, 3);
                    dataDiksi.Refresh();
                }
                else { MessageBox.Show("was't successful"); }
            }
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            string sql = s;
            string dk = "";
            if (MoneyBox.Text.Trim() != "")
            {
                dk += "Cost <= " + MoneyBox.Text;
            }
            if (dk != "") sql += " WHERE " + dk;
            dataDiksi.DataSource = busMag.getMagazin(sql, 3);
            dataDiksi.Refresh();
        }

        private void dataDiksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDBox.Text = dataDiksi[0, e.RowIndex].Value.ToString();
                NameBox.Text = dataDiksi[1, e.RowIndex].Value.ToString();
                CostBox.Text = dataDiksi[2, e.RowIndex].Value.ToString();
                StockBox.Text = dataDiksi[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            { }
        }
    }
}
