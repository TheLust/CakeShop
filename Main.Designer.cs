namespace CakeShop
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.colorCB = new System.Windows.Forms.ComboBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.massTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.stockTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.productGB = new System.Windows.Forms.GroupBox();
            this.ingredientGB = new System.Windows.Forms.GroupBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addIngredientBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ingredientCB = new System.Windows.Forms.ComboBox();
            this.tasksBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.productGB.SuspendLayout();
            this.ingredientGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(324, 12);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(464, 426);
            this.productDataGridView.TabIndex = 0;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mass:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock:";
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(86, 63);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(200, 24);
            this.typeCB.TabIndex = 7;
            // 
            // colorCB
            // 
            this.colorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorCB.FormattingEnabled = true;
            this.colorCB.Location = new System.Drawing.Point(86, 130);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(200, 24);
            this.colorCB.TabIndex = 8;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(86, 27);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 22);
            this.nameTB.TabIndex = 9;
            // 
            // massTB
            // 
            this.massTB.Location = new System.Drawing.Point(86, 93);
            this.massTB.Name = "massTB";
            this.massTB.Size = new System.Drawing.Size(200, 22);
            this.massTB.TabIndex = 10;
            this.massTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.massTB_KeyPress);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(86, 160);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(200, 22);
            this.priceTB.TabIndex = 11;
            this.priceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTB_KeyPress);
            // 
            // stockTB
            // 
            this.stockTB.Location = new System.Drawing.Point(86, 190);
            this.stockTB.Name = "stockTB";
            this.stockTB.Size = new System.Drawing.Size(200, 22);
            this.stockTB.TabIndex = 12;
            this.stockTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockTB_KeyPress);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(151, 218);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(135, 39);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(151, 218);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(135, 39);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update Product";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // productGB
            // 
            this.productGB.Controls.Add(this.ingredientGB);
            this.productGB.Controls.Add(this.addBtn);
            this.productGB.Controls.Add(this.updateBtn);
            this.productGB.Controls.Add(this.label1);
            this.productGB.Controls.Add(this.stockTB);
            this.productGB.Controls.Add(this.label2);
            this.productGB.Controls.Add(this.priceTB);
            this.productGB.Controls.Add(this.label3);
            this.productGB.Controls.Add(this.colorCB);
            this.productGB.Controls.Add(this.massTB);
            this.productGB.Controls.Add(this.label4);
            this.productGB.Controls.Add(this.nameTB);
            this.productGB.Controls.Add(this.typeCB);
            this.productGB.Controls.Add(this.label5);
            this.productGB.Controls.Add(this.label6);
            this.productGB.Location = new System.Drawing.Point(12, 89);
            this.productGB.Name = "productGB";
            this.productGB.Size = new System.Drawing.Size(306, 283);
            this.productGB.TabIndex = 15;
            this.productGB.TabStop = false;
            // 
            // ingredientGB
            // 
            this.ingredientGB.Controls.Add(this.doneBtn);
            this.ingredientGB.Controls.Add(this.quantityTB);
            this.ingredientGB.Controls.Add(this.label8);
            this.ingredientGB.Controls.Add(this.addIngredientBtn);
            this.ingredientGB.Controls.Add(this.label7);
            this.ingredientGB.Controls.Add(this.ingredientCB);
            this.ingredientGB.Location = new System.Drawing.Point(0, 0);
            this.ingredientGB.Name = "ingredientGB";
            this.ingredientGB.Size = new System.Drawing.Size(306, 283);
            this.ingredientGB.TabIndex = 15;
            this.ingredientGB.TabStop = false;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(151, 238);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(135, 39);
            this.doneBtn.TabIndex = 17;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // quantityTB
            // 
            this.quantityTB.Location = new System.Drawing.Point(86, 60);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(200, 22);
            this.quantityTB.TabIndex = 16;
            this.quantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTB_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantity:";
            // 
            // addIngredientBtn
            // 
            this.addIngredientBtn.Location = new System.Drawing.Point(151, 93);
            this.addIngredientBtn.Name = "addIngredientBtn";
            this.addIngredientBtn.Size = new System.Drawing.Size(135, 39);
            this.addIngredientBtn.TabIndex = 14;
            this.addIngredientBtn.Text = "Add Ingredient";
            this.addIngredientBtn.UseVisualStyleBackColor = true;
            this.addIngredientBtn.Click += new System.EventHandler(this.addIngredientBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ingredient:";
            // 
            // ingredientCB
            // 
            this.ingredientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ingredientCB.FormattingEnabled = true;
            this.ingredientCB.Location = new System.Drawing.Point(86, 24);
            this.ingredientCB.Name = "ingredientCB";
            this.ingredientCB.Size = new System.Drawing.Size(200, 24);
            this.ingredientCB.TabIndex = 9;
            // 
            // tasksBtn
            // 
            this.tasksBtn.Location = new System.Drawing.Point(12, 12);
            this.tasksBtn.Name = "tasksBtn";
            this.tasksBtn.Size = new System.Drawing.Size(306, 37);
            this.tasksBtn.TabIndex = 16;
            this.tasksBtn.Text = "Tasks";
            this.tasksBtn.UseVisualStyleBackColor = true;
            this.tasksBtn.Click += new System.EventHandler(this.tasksBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tasksBtn);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Cake Shop";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.productGB.ResumeLayout(false);
            this.productGB.PerformLayout();
            this.ingredientGB.ResumeLayout(false);
            this.ingredientGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.ComboBox colorCB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox massTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox stockTB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.GroupBox productGB;
        private System.Windows.Forms.GroupBox ingredientGB;
        private System.Windows.Forms.Button addIngredientBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ingredientCB;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button tasksBtn;
    }
}

