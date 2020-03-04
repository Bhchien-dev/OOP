namespace GUI_lab4OOP
{
    partial class GUI_Diksi
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
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.StockBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataDiksi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDiksi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonMoney);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.CostBox);
            this.groupBox1.Controls.Add(this.StockBox);
            this.groupBox1.Controls.Add(this.MoneyBox);
            this.groupBox1.Controls.Add(this.labelMoney);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.labelCost);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diksi St.Petersburgs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataDiksi);
            this.groupBox2.Location = new System.Drawing.Point(0, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 182);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(398, 59);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(159, 20);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "How many you have?";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(53, 152);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(50, 20);
            this.labelStock.TabIndex = 1;
            this.labelStock.Text = "Stock";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(53, 116);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(42, 20);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "Cost";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(53, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(53, 37);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // MoneyBox
            // 
            this.MoneyBox.Location = new System.Drawing.Point(441, 82);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(100, 26);
            this.MoneyBox.TabIndex = 5;
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(131, 152);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(100, 26);
            this.StockBox.TabIndex = 6;
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(131, 113);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(100, 26);
            this.CostBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(131, 73);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 26);
            this.NameBox.TabIndex = 8;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(131, 37);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 26);
            this.IDBox.TabIndex = 9;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(609, 409);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 29);
            this.buttonBuy.TabIndex = 10;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(583, 85);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(76, 29);
            this.buttonMoney.TabIndex = 11;
            this.buttonMoney.Text = "Search";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(265, 130);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 48);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(265, 46);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 50);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataDiksi
            // 
            this.dataDiksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDiksi.Location = new System.Drawing.Point(3, 22);
            this.dataDiksi.Name = "dataDiksi";
            this.dataDiksi.RowHeadersWidth = 62;
            this.dataDiksi.RowTemplate.Height = 28;
            this.dataDiksi.Size = new System.Drawing.Size(785, 160);
            this.dataDiksi.TabIndex = 0;
            this.dataDiksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDiksi_CellContentClick);
            // 
            // GUI_Diksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBuy);
            this.Name = "GUI_Diksi";
            this.Text = "Magazin Diksi";
            this.Load += new System.EventHandler(this.GUI_Diksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDiksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox StockBox;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataDiksi;
        private System.Windows.Forms.Button buttonBuy;
    }
}