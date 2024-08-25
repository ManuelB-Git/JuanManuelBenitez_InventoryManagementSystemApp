namespace JuanManuelBenitez_InventoryManagementSystem
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.searchPartBTB = new System.Windows.Forms.Button();
            this.addPartBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.partsLBL = new System.Windows.Forms.Label();
            this.productsLBL = new System.Windows.Forms.Label();
            this.modifyPartBTN = new System.Windows.Forms.Button();
            this.deletePartBTN = new System.Windows.Forms.Button();
            this.searchProductBTN = new System.Windows.Forms.Button();
            this.addProductBTN = new System.Windows.Forms.Button();
            this.modifyProductBTN = new System.Windows.Forms.Button();
            this.deleteProductBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.partDGV = new System.Windows.Forms.DataGridView();
            this.productDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.partDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPartBTB
            // 
            this.searchPartBTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.searchPartBTB.FlatAppearance.BorderSize = 0;
            this.searchPartBTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.searchPartBTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.searchPartBTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPartBTB.ForeColor = System.Drawing.Color.White;
            this.searchPartBTB.Location = new System.Drawing.Point(181, 237);
            this.searchPartBTB.Name = "searchPartBTB";
            this.searchPartBTB.Size = new System.Drawing.Size(75, 23);
            this.searchPartBTB.TabIndex = 16;
            this.searchPartBTB.Text = "Search";
            this.searchPartBTB.UseVisualStyleBackColor = false;
            this.searchPartBTB.Click += new System.EventHandler(this.searchPartBTB_Click);
            // 
            // addPartBTN
            // 
            this.addPartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.addPartBTN.FlatAppearance.BorderSize = 0;
            this.addPartBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.addPartBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.addPartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPartBTN.ForeColor = System.Drawing.Color.White;
            this.addPartBTN.Location = new System.Drawing.Point(275, 525);
            this.addPartBTN.Name = "addPartBTN";
            this.addPartBTN.Size = new System.Drawing.Size(75, 23);
            this.addPartBTN.TabIndex = 17;
            this.addPartBTN.Text = "Add";
            this.addPartBTN.UseVisualStyleBackColor = false;
            this.addPartBTN.Click += new System.EventHandler(this.addPartBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Inventory Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partsLBL
            // 
            this.partsLBL.AutoSize = true;
            this.partsLBL.BackColor = System.Drawing.Color.Transparent;
            this.partsLBL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.partsLBL.Location = new System.Drawing.Point(7, 237);
            this.partsLBL.Name = "partsLBL";
            this.partsLBL.Size = new System.Drawing.Size(58, 30);
            this.partsLBL.TabIndex = 19;
            this.partsLBL.Text = "Parts";
            this.partsLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.partsLBL.Click += new System.EventHandler(this.label2_Click);
            // 
            // productsLBL
            // 
            this.productsLBL.AutoSize = true;
            this.productsLBL.BackColor = System.Drawing.Color.Transparent;
            this.productsLBL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.productsLBL.Location = new System.Drawing.Point(557, 238);
            this.productsLBL.Name = "productsLBL";
            this.productsLBL.Size = new System.Drawing.Size(94, 30);
            this.productsLBL.TabIndex = 20;
            this.productsLBL.Text = "Products";
            this.productsLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modifyPartBTN
            // 
            this.modifyPartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.modifyPartBTN.FlatAppearance.BorderSize = 0;
            this.modifyPartBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.modifyPartBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.modifyPartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyPartBTN.ForeColor = System.Drawing.Color.White;
            this.modifyPartBTN.Location = new System.Drawing.Point(356, 525);
            this.modifyPartBTN.Name = "modifyPartBTN";
            this.modifyPartBTN.Size = new System.Drawing.Size(75, 23);
            this.modifyPartBTN.TabIndex = 21;
            this.modifyPartBTN.Text = "Modify";
            this.modifyPartBTN.UseVisualStyleBackColor = false;
            this.modifyPartBTN.Click += new System.EventHandler(this.modifyPartBTN_Click);
            // 
            // deletePartBTN
            // 
            this.deletePartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.deletePartBTN.FlatAppearance.BorderSize = 0;
            this.deletePartBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.deletePartBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.deletePartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePartBTN.ForeColor = System.Drawing.Color.White;
            this.deletePartBTN.Location = new System.Drawing.Point(437, 525);
            this.deletePartBTN.Name = "deletePartBTN";
            this.deletePartBTN.Size = new System.Drawing.Size(75, 23);
            this.deletePartBTN.TabIndex = 22;
            this.deletePartBTN.Text = "Delete";
            this.deletePartBTN.UseVisualStyleBackColor = false;
            this.deletePartBTN.Click += new System.EventHandler(this.deletePartBTN_Click);
            // 
            // searchProductBTN
            // 
            this.searchProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.searchProductBTN.FlatAppearance.BorderSize = 0;
            this.searchProductBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.searchProductBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.searchProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProductBTN.ForeColor = System.Drawing.Color.White;
            this.searchProductBTN.Location = new System.Drawing.Point(731, 237);
            this.searchProductBTN.Name = "searchProductBTN";
            this.searchProductBTN.Size = new System.Drawing.Size(75, 23);
            this.searchProductBTN.TabIndex = 23;
            this.searchProductBTN.Text = "Search";
            this.searchProductBTN.UseVisualStyleBackColor = false;
            this.searchProductBTN.Click += new System.EventHandler(this.searchProductBTN_Click);
            // 
            // addProductBTN
            // 
            this.addProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.addProductBTN.FlatAppearance.BorderSize = 0;
            this.addProductBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.addProductBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.addProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBTN.ForeColor = System.Drawing.Color.White;
            this.addProductBTN.Location = new System.Drawing.Point(825, 525);
            this.addProductBTN.Name = "addProductBTN";
            this.addProductBTN.Size = new System.Drawing.Size(75, 23);
            this.addProductBTN.TabIndex = 24;
            this.addProductBTN.Text = "Add";
            this.addProductBTN.UseVisualStyleBackColor = false;
            this.addProductBTN.Click += new System.EventHandler(this.addProductBTN_Click);
            // 
            // modifyProductBTN
            // 
            this.modifyProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.modifyProductBTN.FlatAppearance.BorderSize = 0;
            this.modifyProductBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.modifyProductBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.modifyProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductBTN.ForeColor = System.Drawing.Color.White;
            this.modifyProductBTN.Location = new System.Drawing.Point(906, 525);
            this.modifyProductBTN.Name = "modifyProductBTN";
            this.modifyProductBTN.Size = new System.Drawing.Size(75, 23);
            this.modifyProductBTN.TabIndex = 25;
            this.modifyProductBTN.Text = "Modify";
            this.modifyProductBTN.UseVisualStyleBackColor = false;
            this.modifyProductBTN.Click += new System.EventHandler(this.modifyProductBTN_Click);
            // 
            // deleteProductBTN
            // 
            this.deleteProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.deleteProductBTN.FlatAppearance.BorderSize = 0;
            this.deleteProductBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.deleteProductBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.deleteProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductBTN.ForeColor = System.Drawing.Color.White;
            this.deleteProductBTN.Location = new System.Drawing.Point(987, 525);
            this.deleteProductBTN.Name = "deleteProductBTN";
            this.deleteProductBTN.Size = new System.Drawing.Size(75, 23);
            this.deleteProductBTN.TabIndex = 26;
            this.deleteProductBTN.Text = "Delete";
            this.deleteProductBTN.UseVisualStyleBackColor = false;
            this.deleteProductBTN.Click += new System.EventHandler(this.deleteProductBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.exitBTN.FlatAppearance.BorderSize = 0;
            this.exitBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.exitBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBTN.ForeColor = System.Drawing.Color.White;
            this.exitBTN.Location = new System.Drawing.Point(1008, 789);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 27;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.Location = new System.Drawing.Point(262, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 25);
            this.textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox2.Location = new System.Drawing.Point(812, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 25);
            this.textBox2.TabIndex = 29;
            // 
            // partDGV
            // 
            this.partDGV.AllowUserToAddRows = false;
            this.partDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partDGV.BackgroundColor = System.Drawing.Color.White;
            this.partDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.partDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.partDGV.Location = new System.Drawing.Point(12, 269);
            this.partDGV.Name = "partDGV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.partDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.partDGV.ShowEditingIcon = false;
            this.partDGV.Size = new System.Drawing.Size(500, 250);
            this.partDGV.TabIndex = 30;
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToAddRows = false;
            this.productDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDGV.BackgroundColor = System.Drawing.Color.White;
            this.productDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.productDGV.Location = new System.Drawing.Point(562, 269);
            this.productDGV.Name = "productDGV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.productDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.productDGV.ShowEditingIcon = false;
            this.productDGV.Size = new System.Drawing.Size(500, 250);
            this.productDGV.TabIndex = 31;
            this.productDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellContentClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1095, 824);
            this.Controls.Add(this.productDGV);
            this.Controls.Add(this.partDGV);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.deleteProductBTN);
            this.Controls.Add(this.modifyProductBTN);
            this.Controls.Add(this.addProductBTN);
            this.Controls.Add(this.searchProductBTN);
            this.Controls.Add(this.deletePartBTN);
            this.Controls.Add(this.modifyPartBTN);
            this.Controls.Add(this.productsLBL);
            this.Controls.Add(this.partsLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPartBTN);
            this.Controls.Add(this.searchPartBTB);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1111, 863);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchPartBTB;
        private System.Windows.Forms.Button addPartBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label partsLBL;
        private System.Windows.Forms.Label productsLBL;
        private System.Windows.Forms.Button modifyPartBTN;
        private System.Windows.Forms.Button deletePartBTN;
        private System.Windows.Forms.Button searchProductBTN;
        private System.Windows.Forms.Button addProductBTN;
        private System.Windows.Forms.Button modifyProductBTN;
        private System.Windows.Forms.Button deleteProductBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView partDGV;
        private System.Windows.Forms.DataGridView productDGV;
    }
}

