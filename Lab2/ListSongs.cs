using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab2_OOP
{
    public partial class ListSongs : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataSet ds;
        public ListSongs()
        {
            InitializeComponent();
        }
        private void ListSongs_Load(object sender, EventArgs e)
        {
            this.tblSongsTableAdapter.Fill(this.database1DataSet.tblSongs);
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VS 2019\lab2_OOP\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            LoadData("SELECT * FROM tblSongs");
            Delete.Enabled = false;
            Edit.Enabled = false;
            ShowDetail(false);
        }
        private void LoadData(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            Result.DataSource = ds.Tables[0];
            Result.Refresh();
        }
        private void ShowDetail(Boolean show)
        {
            DetailIDBox.Enabled = show;
            DetailSongBox.Enabled = show;
            DetailArtistBox.Enabled = show;
            DetailAlbumBox.Enabled = show;
            DetailGerneBox.Enabled = show;
            DetailClose.Enabled = show;
            DetailSave.Enabled = show;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Search Songs";
            Delete.Enabled = false;
            Edit.Enabled = false;
            String sql = "SELECT * FROM tblSongs";
            String dk = "";
            if (textBox1.Text.Trim() != "")
            {
                dk += " Song LIKE '%" + textBox1.Text + "%'"
                   + " OR Artist LIKE '%" + textBox1.Text + "%'"
                   + " OR Album LIKE '%" + textBox1.Text + "%'"
                   + " OR ID LIKE '%" + textBox1.Text + "%'"
                   + " OR Gerne LIKE '%" + textBox1.Text + "%'";
            }
            if (dk != "") sql += " WHERE" + dk;
            LoadData(sql);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Add Songs";
            DeleteDetail();
            Edit.Enabled = false;
            Delete.Enabled = false;
            ShowDetail(true);
        }
        private void DeleteDetail()
        {
            DetailSongBox.Clear();
            DetailArtistBox.Clear();
            DetailAlbumBox.Clear();
            DetailGerneBox.Clear();
            DetailIDBox.Clear();
        }
        private void Result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit.Enabled = true;
            Delete.Enabled = true;
            Add.Enabled = false;
            try
            {
                DetailIDBox.Text = Result[0, e.RowIndex].Value.ToString();
                DetailSongBox.Text = Result[1, e.RowIndex].Value.ToString();
                DetailArtistBox.Text = Result[2, e.RowIndex].Value.ToString();
                DetailAlbumBox.Text = Result[3, e.RowIndex].Value.ToString();
                DetailGerneBox.Text = Result[4, e.RowIndex].Value.ToString();
            }
            catch(Exception ex)
            { }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Update Song...";
            Add.Enabled = false;
            Delete.Enabled = false;
            ShowDetail(true);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sue want to detele? ", "Delete" + 
                                DetailID, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblTitle.Text = "Delete Song";
                Add.Enabled = false;
                Edit.Enabled = false;
                ShowDetail(true);
            }

        }

        private void DetailSave_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (con.State != ConnectionState.Open) con.Open();
            if (Add.Enabled)
            {
                sql = "SELECT Count(*) FROM tblSongs WHERE ID ='" + DetailIDBox.Text + "'";
                cmd = new SqlCommand(sql, con);
                sql = "INSERT INTO tblSongs(ID,Song,Artist,Album,Gerne)VALUES (";
                sql += "N'" + DetailIDBox.Text + "',N'" + DetailSongBox.Text + "',N'" +
                        DetailArtistBox.Text + "',N'" + DetailAlbumBox.Text + "',N'" +
                        DetailGerneBox.Text + "')";
            }
            if(Edit.Enabled)
            {
                sql = "UPDATE tblSongs SET ";
                sql += "Song = N'" + DetailSongBox.Text + "',";
                sql += "Artist = N'" + DetailSongBox.Text + "',";
                sql += "Gerne = N'" + DetailGerneBox.Text + "',";
                sql += "Album = N'" + DetailAlbumBox.Text + "' ";
                sql += "WHERE ID = N" + DetailIDBox.Text + "'";
            }
            if(Delete.Enabled)
                sql = "DELETE FROM tblSongs WHERE ID =N'" + DetailIDBox + "' ";
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            sql = "SELECT * FROM tblSongs";
            LoadData(sql);
            con.Close();
            ShowDetail(false);
            Edit.Enabled = false;
            Delete.Enabled = false;
        }

        private void DetailClose_Click(object sender, EventArgs e)
        {
            Delete.Enabled = false;
            Edit.Enabled = false;
            Add.Enabled = true;
            DeleteDetail();
            ShowDetail(false);
        }
    }
}
