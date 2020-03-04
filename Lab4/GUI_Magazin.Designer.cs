namespace GUI_lab4OOP
{
    partial class GUI_Magazin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.Adresslabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.listMagazin = new System.Windows.Forms.GroupBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.dataMagazin = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.listMagazin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMagazin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AmountBox);
            this.groupBox1.Controls.Add(this.SearchBox);
            this.groupBox1.Controls.Add(this.Addbutton);
            this.groupBox1.Controls.Add(this.Searchbutton);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.IDlabel);
            this.groupBox1.Controls.Add(this.AdressBox);
            this.groupBox1.Controls.Add(this.Adresslabel);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Magazin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(566, 73);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(68, 26);
            this.AmountBox.TabIndex = 9;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(409, 73);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(120, 26);
            this.SearchBox.TabIndex = 8;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(98, 150);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(95, 47);
            this.Addbutton.TabIndex = 7;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbox_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(409, 150);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(95, 47);
            this.Searchbutton.TabIndex = 6;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.searchbox_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(98, 34);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(262, 26);
            this.IDBox.TabIndex = 5;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(66, 40);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(26, 20);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "ID";
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(98, 107);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(262, 26);
            this.AdressBox.TabIndex = 3;
            // 
            // Adresslabel
            // 
            this.Adresslabel.AutoSize = true;
            this.Adresslabel.Location = new System.Drawing.Point(33, 113);
            this.Adresslabel.Name = "Adresslabel";
            this.Adresslabel.Size = new System.Drawing.Size(59, 20);
            this.Adresslabel.TabIndex = 2;
            this.Adresslabel.Text = "Adress";
            // 
            // NameBox
            // 
            this.NameBox.AcceptsReturn = true;
            this.NameBox.Location = new System.Drawing.Point(98, 70);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(262, 26);
            this.NameBox.TabIndex = 1;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(41, 76);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(51, 20);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            // 
            // listMagazin
            // 
            this.listMagazin.Controls.Add(this.ShowButton);
            this.listMagazin.Controls.Add(this.dataMagazin);
            this.listMagazin.Location = new System.Drawing.Point(0, 205);
            this.listMagazin.Name = "listMagazin";
            this.listMagazin.Size = new System.Drawing.Size(703, 379);
            this.listMagazin.TabIndex = 1;
            this.listMagazin.TabStop = false;
            this.listMagazin.Text = "List";
            // 
            // ShowButton
            // 
            this.ShowButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ShowButton.Location = new System.Drawing.Point(542, 331);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(149, 36);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // dataMagazin
            // 
            this.dataMagazin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMagazin.Location = new System.Drawing.Point(0, 21);
            this.dataMagazin.Name = "dataMagazin";
            this.dataMagazin.RowHeadersWidth = 62;
            this.dataMagazin.RowTemplate.Height = 28;
            this.dataMagazin.Size = new System.Drawing.Size(700, 287);
            this.dataMagazin.TabIndex = 0;
            this.dataMagazin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMagazin_CellContentClick);
            // 
            // GUI_Magazin
            // 
            this.ClientSize = new System.Drawing.Size(703, 584);
            this.Controls.Add(this.listMagazin);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "GUI_Magazin";
            this.Text = "Magazin st.Petersburgs";
            this.Load += new System.EventHandler(this.GUI_Magazin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.listMagazin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMagazin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MagazinSaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.GroupBox listMagazin;
        private System.Windows.Forms.DataGridView dataMagazin;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Label Adresslabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AmountBox;
    }
}

