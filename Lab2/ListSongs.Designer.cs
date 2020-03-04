namespace lab2_OOP
{
    partial class ListSongs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Result = new System.Windows.Forms.DataGridView();
            this.lab3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetailSong = new System.Windows.Forms.GroupBox();
            this.DetailClose = new System.Windows.Forms.Button();
            this.DetailSave = new System.Windows.Forms.Button();
            this.DetailArtistBox = new System.Windows.Forms.TextBox();
            this.DetailAlbumBox = new System.Windows.Forms.TextBox();
            this.DetailGerneBox = new System.Windows.Forms.TextBox();
            this.DetailGerne = new System.Windows.Forms.Label();
            this.DetailAlbum = new System.Windows.Forms.Label();
            this.DetailArtist = new System.Windows.Forms.Label();
            this.DetailSongBox = new System.Windows.Forms.TextBox();
            this.DetailIDBox = new System.Windows.Forms.TextBox();
            this.DetailName = new System.Windows.Forms.Label();
            this.DetailID = new System.Windows.Forms.Label();
            this.database1DataSet = new lab2_OOP.Database1DataSet();
            this.tblSongsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSongsTableAdapter = new lab2_OOP.Database1DataSetTableAdapters.tblSongsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSetBindingSource)).BeginInit();
            this.DetailSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSongsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 0);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song, Artist, Album, ID... :";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 22);
            this.splitter1.MinExtra = 10;
            this.splitter1.MinSize = 10;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(794, 90);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(340, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "List Songs";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.Edit);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Location = new System.Drawing.Point(0, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 84);
            this.panel2.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(442, 27);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(114, 30);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete Songs";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(311, 27);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(97, 30);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit Songs";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(174, 27);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(104, 30);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add Songs";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(22, 27);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(128, 30);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search Songs";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.Result);
            this.groupBox3.Location = new System.Drawing.Point(0, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 260);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // Result
            // 
            this.Result.AutoGenerateColumns = false;
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.songDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.gerneDataGridViewTextBoxColumn});
            this.Result.DataSource = this.tblSongsBindingSource;
            this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result.Location = new System.Drawing.Point(3, 22);
            this.Result.Name = "Result";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Result.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Result.RowHeadersWidth = 62;
            this.Result.RowTemplate.Height = 28;
            this.Result.Size = new System.Drawing.Size(583, 235);
            this.Result.TabIndex = 0;
            this.Result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Result_CellContentClick);
            // 
            // DetailSong
            // 
            this.DetailSong.Controls.Add(this.DetailClose);
            this.DetailSong.Controls.Add(this.DetailSave);
            this.DetailSong.Controls.Add(this.DetailArtistBox);
            this.DetailSong.Controls.Add(this.DetailAlbumBox);
            this.DetailSong.Controls.Add(this.DetailGerneBox);
            this.DetailSong.Controls.Add(this.DetailGerne);
            this.DetailSong.Controls.Add(this.DetailAlbum);
            this.DetailSong.Controls.Add(this.DetailArtist);
            this.DetailSong.Controls.Add(this.DetailSongBox);
            this.DetailSong.Controls.Add(this.DetailIDBox);
            this.DetailSong.Controls.Add(this.DetailName);
            this.DetailSong.Controls.Add(this.DetailID);
            this.DetailSong.Location = new System.Drawing.Point(591, 106);
            this.DetailSong.Name = "DetailSong";
            this.DetailSong.Size = new System.Drawing.Size(209, 335);
            this.DetailSong.TabIndex = 3;
            this.DetailSong.TabStop = false;
            this.DetailSong.Text = "Detail";
            // 
            // DetailClose
            // 
            this.DetailClose.Location = new System.Drawing.Point(115, 287);
            this.DetailClose.Name = "DetailClose";
            this.DetailClose.Size = new System.Drawing.Size(75, 30);
            this.DetailClose.TabIndex = 11;
            this.DetailClose.Text = "Close";
            this.DetailClose.UseVisualStyleBackColor = true;
            this.DetailClose.Click += new System.EventHandler(this.DetailClose_Click);
            // 
            // DetailSave
            // 
            this.DetailSave.Location = new System.Drawing.Point(26, 287);
            this.DetailSave.Name = "DetailSave";
            this.DetailSave.Size = new System.Drawing.Size(76, 30);
            this.DetailSave.TabIndex = 10;
            this.DetailSave.Text = "Save";
            this.DetailSave.UseVisualStyleBackColor = true;
            this.DetailSave.Click += new System.EventHandler(this.DetailSave_Click);
            // 
            // DetailArtistBox
            // 
            this.DetailArtistBox.Location = new System.Drawing.Point(90, 121);
            this.DetailArtistBox.Name = "DetailArtistBox";
            this.DetailArtistBox.Size = new System.Drawing.Size(100, 26);
            this.DetailArtistBox.TabIndex = 9;
            // 
            // DetailAlbumBox
            // 
            this.DetailAlbumBox.Location = new System.Drawing.Point(90, 161);
            this.DetailAlbumBox.Name = "DetailAlbumBox";
            this.DetailAlbumBox.Size = new System.Drawing.Size(100, 26);
            this.DetailAlbumBox.TabIndex = 8;
            // 
            // DetailGerneBox
            // 
            this.DetailGerneBox.Location = new System.Drawing.Point(90, 200);
            this.DetailGerneBox.Name = "DetailGerneBox";
            this.DetailGerneBox.Size = new System.Drawing.Size(100, 26);
            this.DetailGerneBox.TabIndex = 7;
            // 
            // DetailGerne
            // 
            this.DetailGerne.AutoSize = true;
            this.DetailGerne.Location = new System.Drawing.Point(22, 203);
            this.DetailGerne.Name = "DetailGerne";
            this.DetailGerne.Size = new System.Drawing.Size(54, 20);
            this.DetailGerne.TabIndex = 4;
            this.DetailGerne.Text = "Gerne";
            // 
            // DetailAlbum
            // 
            this.DetailAlbum.AutoSize = true;
            this.DetailAlbum.Location = new System.Drawing.Point(22, 167);
            this.DetailAlbum.Name = "DetailAlbum";
            this.DetailAlbum.Size = new System.Drawing.Size(54, 20);
            this.DetailAlbum.TabIndex = 1;
            this.DetailAlbum.Text = "Album";
            // 
            // DetailArtist
            // 
            this.DetailArtist.AutoSize = true;
            this.DetailArtist.Location = new System.Drawing.Point(22, 127);
            this.DetailArtist.Name = "DetailArtist";
            this.DetailArtist.Size = new System.Drawing.Size(46, 20);
            this.DetailArtist.TabIndex = 2;
            this.DetailArtist.Text = "Artist";
            // 
            // DetailSongBox
            // 
            this.DetailSongBox.Location = new System.Drawing.Point(90, 76);
            this.DetailSongBox.Name = "DetailSongBox";
            this.DetailSongBox.Size = new System.Drawing.Size(100, 26);
            this.DetailSongBox.TabIndex = 3;
            // 
            // DetailIDBox
            // 
            this.DetailIDBox.Location = new System.Drawing.Point(90, 38);
            this.DetailIDBox.Name = "DetailIDBox";
            this.DetailIDBox.Size = new System.Drawing.Size(107, 26);
            this.DetailIDBox.TabIndex = 2;
            // 
            // DetailName
            // 
            this.DetailName.AutoSize = true;
            this.DetailName.Location = new System.Drawing.Point(22, 82);
            this.DetailName.Name = "DetailName";
            this.DetailName.Size = new System.Drawing.Size(47, 20);
            this.DetailName.TabIndex = 1;
            this.DetailName.Text = "Song";
            // 
            // DetailID
            // 
            this.DetailID.AutoSize = true;
            this.DetailID.Location = new System.Drawing.Point(25, 44);
            this.DetailID.Name = "DetailID";
            this.DetailID.Size = new System.Drawing.Size(26, 20);
            this.DetailID.TabIndex = 0;
            this.DetailID.Text = "ID";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSongsBindingSource
            // 
            this.tblSongsBindingSource.DataMember = "tblSongs";
            this.tblSongsBindingSource.DataSource = this.database1DataSet;
            // 
            // tblSongsTableAdapter
            // 
            this.tblSongsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // songDataGridViewTextBoxColumn
            // 
            this.songDataGridViewTextBoxColumn.DataPropertyName = "Song";
            this.songDataGridViewTextBoxColumn.HeaderText = "Song";
            this.songDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.songDataGridViewTextBoxColumn.Name = "songDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.Width = 150;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.Width = 150;
            // 
            // gerneDataGridViewTextBoxColumn
            // 
            this.gerneDataGridViewTextBoxColumn.DataPropertyName = "Gerne";
            this.gerneDataGridViewTextBoxColumn.HeaderText = "Gerne";
            this.gerneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gerneDataGridViewTextBoxColumn.Name = "gerneDataGridViewTextBoxColumn";
            this.gerneDataGridViewTextBoxColumn.Width = 80;
            // 
            // ListSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetailSong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ListSongs";
            this.Text = "ListSongs.com";
            this.Load += new System.EventHandler(this.ListSongs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab3DataSetBindingSource)).EndInit();
            this.DetailSong.ResumeLayout(false);
            this.DetailSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSongsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.BindingSource lab3DataSetBindingSource;
        //private lab3DataSet lab3DataSet;
        private System.Windows.Forms.GroupBox DetailSong;
        private System.Windows.Forms.Label DetailID;
        private System.Windows.Forms.TextBox DetailArtistBox;
        private System.Windows.Forms.TextBox DetailAlbumBox;
        private System.Windows.Forms.TextBox DetailGerneBox;
        private System.Windows.Forms.Label DetailGerne;
        private System.Windows.Forms.Label DetailAlbum;
        private System.Windows.Forms.Label DetailArtist;
        private System.Windows.Forms.TextBox DetailSongBox;
        private System.Windows.Forms.TextBox DetailIDBox;
        private System.Windows.Forms.Label DetailName;
        private System.Windows.Forms.Button DetailClose;
        private System.Windows.Forms.Button DetailSave;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tblSongsBindingSource;
        private Database1DataSetTableAdapters.tblSongsTableAdapter tblSongsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gerneDataGridViewTextBoxColumn;
    }
}

