namespace GUI_lab4OOP
{
    partial class GUI_Perekrestok
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataPere = new System.Windows.Forms.DataGridView();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.StockBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPere)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.MoneyBox);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.CostBox);
            this.groupBox1.Controls.Add(this.StockBox);
            this.groupBox1.Controls.Add(this.labelMoney);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.labelCost);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perekrestok St.Petersburgs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataPere);
            this.groupBox2.Location = new System.Drawing.Point(0, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 189);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dataPere
            // 
            this.dataPere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPere.Location = new System.Drawing.Point(6, 25);
            this.dataPere.Name = "dataPere";
            this.dataPere.RowHeadersWidth = 62;
            this.dataPere.RowTemplate.Height = 28;
            this.dataPere.Size = new System.Drawing.Size(785, 158);
            this.dataPere.TabIndex = 0;
            this.dataPere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPere_CellContentClick);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(41, 150);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 20);
            this.labelStock.TabIndex = 1;
            this.labelStock.Text = "Stock";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(41, 113);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(42, 20);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Cost";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(41, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(41, 34);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(431, 75);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(159, 20);
            this.labelMoney.TabIndex = 5;
            this.labelMoney.Text = "How many you have?";
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(118, 150);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(100, 26);
            this.StockBox.TabIndex = 6;
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(118, 113);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(100, 26);
            this.CostBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(118, 72);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 26);
            this.NameBox.TabIndex = 8;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(118, 31);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 26);
            this.IDBox.TabIndex = 9;
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(482, 98);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(100, 26);
            this.MoneyBox.TabIndex = 10;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(615, 98);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(79, 26);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(263, 116);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(93, 54);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(263, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(93, 50);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(670, 397);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(101, 41);
            this.buttonBuy.TabIndex = 14;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // GUI_Perekrestok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_Perekrestok";
            this.Text = "Magazin Perekrestok";
            this.Load += new System.EventHandler(this.GUI_Perekrestok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataPere;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox StockBox;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonBuy;
    }
}