namespace GUI_lab4OOP
{
    partial class GUI_Spar
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.MoneyButton = new System.Windows.Forms.Button();
            this.StockBox = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonBuy = new System.Windows.Forms.Button();
            this.dataSpar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSpar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.EditButton);
            this.groupBox1.Controls.Add(this.MoneyButton);
            this.groupBox1.Controls.Add(this.StockBox);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.MoneyBox);
            this.groupBox1.Controls.Add(this.labelMoney);
            this.groupBox1.Controls.Add(this.CostBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.labelCost);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spar St.Petersburgs";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(257, 120);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 42);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AllowDrop = true;
            this.EditButton.Location = new System.Drawing.Point(257, 51);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 46);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.UseWaitCursor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // MoneyButton
            // 
            this.MoneyButton.Location = new System.Drawing.Point(626, 101);
            this.MoneyButton.Name = "MoneyButton";
            this.MoneyButton.Size = new System.Drawing.Size(79, 25);
            this.MoneyButton.TabIndex = 10;
            this.MoneyButton.Text = "Search";
            this.MoneyButton.UseVisualStyleBackColor = true;
            this.MoneyButton.Click += new System.EventHandler(this.MoneyButton_Click);
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(111, 136);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(100, 26);
            this.StockBox.TabIndex = 9;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(32, 142);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 20);
            this.labelStock.TabIndex = 8;
            this.labelStock.Text = "Stock";
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(474, 100);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(134, 26);
            this.MoneyBox.TabIndex = 7;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(372, 66);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(159, 20);
            this.labelMoney.TabIndex = 6;
            this.labelMoney.Text = "How many you have?";
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(111, 100);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(100, 26);
            this.CostBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(111, 60);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 26);
            this.NameBox.TabIndex = 4;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(111, 27);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 26);
            this.IDBox.TabIndex = 3;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(41, 106);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(42, 20);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Cost";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(57, 33);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonBuy);
            this.groupBox2.Controls.Add(this.dataSpar);
            this.groupBox2.Location = new System.Drawing.Point(0, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 249);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // ButtonBuy
            // 
            this.ButtonBuy.Location = new System.Drawing.Point(692, 211);
            this.ButtonBuy.Name = "ButtonBuy";
            this.ButtonBuy.Size = new System.Drawing.Size(77, 38);
            this.ButtonBuy.TabIndex = 13;
            this.ButtonBuy.Text = "Buy";
            this.ButtonBuy.UseVisualStyleBackColor = true;
            //this.ButtonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // dataSpar
            // 
            this.dataSpar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSpar.Location = new System.Drawing.Point(0, 25);
            this.dataSpar.Name = "dataSpar";
            this.dataSpar.RowHeadersWidth = 62;
            this.dataSpar.RowTemplate.Height = 28;
            this.dataSpar.Size = new System.Drawing.Size(801, 180);
            this.dataSpar.TabIndex = 0;
            this.dataSpar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSpar_CellContentClick);
            // 
            // GUI_Spar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_Spar";
            this.Text = "Magazin Spar";
            this.Load += new System.EventHandler(this.GUI_Spar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSpar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button MoneyButton;
        private System.Windows.Forms.TextBox StockBox;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonBuy;
        private System.Windows.Forms.DataGridView dataSpar;
    }
}