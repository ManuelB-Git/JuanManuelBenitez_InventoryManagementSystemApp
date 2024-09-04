namespace JuanManuelBenitez_InventoryManagementSystem.Forms
{
    partial class ModifyProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProducts));
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partDGV = new System.Windows.Forms.DataGridView();
            this.searchTXT = new System.Windows.Forms.TextBox();
            this.searchPartBTB = new System.Windows.Forms.Button();
            this.minTXT = new System.Windows.Forms.TextBox();
            this.minLBL = new System.Windows.Forms.Label();
            this.maxTXT = new System.Windows.Forms.TextBox();
            this.maxLBL = new System.Windows.Forms.Label();
            this.priceTXT = new System.Windows.Forms.TextBox();
            this.priceLBL = new System.Windows.Forms.Label();
            this.inventoryTXT = new System.Windows.Forms.TextBox();
            this.inventoryLBL = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.nameLBL = new System.Windows.Forms.Label();
            this.idTXT = new System.Windows.Forms.TextBox();
            this.idLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(149, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 37);
            this.label3.TabIndex = 86;
            this.label3.Text = "Modify  Product";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelBTN
            // 
            this.cancelBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.cancelBTN.FlatAppearance.BorderSize = 0;
            this.cancelBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.cancelBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBTN.ForeColor = System.Drawing.Color.White;
            this.cancelBTN.Location = new System.Drawing.Point(962, 675);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 85;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = false;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.saveBTN.FlatAppearance.BorderSize = 0;
            this.saveBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.saveBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.saveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBTN.ForeColor = System.Drawing.Color.White;
            this.saveBTN.Location = new System.Drawing.Point(881, 675);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 84;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.deleteBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.ForeColor = System.Drawing.Color.White;
            this.deleteBTN.Location = new System.Drawing.Point(962, 646);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(75, 23);
            this.deleteBTN.TabIndex = 83;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.addBTN.FlatAppearance.BorderSize = 0;
            this.addBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.addBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.ForeColor = System.Drawing.Color.White;
            this.addBTN.Location = new System.Drawing.Point(962, 348);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(75, 23);
            this.addBTN.TabIndex = 82;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(533, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 81;
            this.label2.Text = "All associated Parts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(533, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "All candidate Parts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(537, 390);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(500, 250);
            this.dataGridView1.TabIndex = 79;
            // 
            // partDGV
            // 
            this.partDGV.AllowUserToAddRows = false;
            this.partDGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.partDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partDGV.BackgroundColor = System.Drawing.Color.White;
            this.partDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.partDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.partDGV.Location = new System.Drawing.Point(537, 92);
            this.partDGV.Name = "partDGV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.partDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.partDGV.Size = new System.Drawing.Size(500, 250);
            this.partDGV.TabIndex = 78;
            // 
            // searchTXT
            // 
            this.searchTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTXT.BackColor = System.Drawing.Color.White;
            this.searchTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.searchTXT.Location = new System.Drawing.Point(787, 61);
            this.searchTXT.Name = "searchTXT";
            this.searchTXT.Size = new System.Drawing.Size(250, 25);
            this.searchTXT.TabIndex = 77;
            // 
            // searchPartBTB
            // 
            this.searchPartBTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchPartBTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.searchPartBTB.FlatAppearance.BorderSize = 0;
            this.searchPartBTB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.searchPartBTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.searchPartBTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPartBTB.ForeColor = System.Drawing.Color.White;
            this.searchPartBTB.Location = new System.Drawing.Point(706, 60);
            this.searchPartBTB.Name = "searchPartBTB";
            this.searchPartBTB.Size = new System.Drawing.Size(75, 23);
            this.searchPartBTB.TabIndex = 76;
            this.searchPartBTB.Text = "Search";
            this.searchPartBTB.UseVisualStyleBackColor = false;
            this.searchPartBTB.Click += new System.EventHandler(this.searchPartBTB_Click);
            // 
            // minTXT
            // 
            this.minTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minTXT.BackColor = System.Drawing.Color.White;
            this.minTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.minTXT.Location = new System.Drawing.Point(375, 463);
            this.minTXT.Name = "minTXT";
            this.minTXT.Size = new System.Drawing.Size(125, 25);
            this.minTXT.TabIndex = 75;
            // 
            // minLBL
            // 
            this.minLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minLBL.AutoSize = true;
            this.minLBL.BackColor = System.Drawing.Color.Transparent;
            this.minLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.minLBL.Location = new System.Drawing.Point(300, 462);
            this.minLBL.Name = "minLBL";
            this.minLBL.Size = new System.Drawing.Size(37, 21);
            this.minLBL.TabIndex = 74;
            this.minLBL.Text = "Min";
            this.minLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxTXT
            // 
            this.maxTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxTXT.BackColor = System.Drawing.Color.White;
            this.maxTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.maxTXT.Location = new System.Drawing.Point(153, 463);
            this.maxTXT.Name = "maxTXT";
            this.maxTXT.Size = new System.Drawing.Size(125, 25);
            this.maxTXT.TabIndex = 73;
            // 
            // maxLBL
            // 
            this.maxLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxLBL.AutoSize = true;
            this.maxLBL.BackColor = System.Drawing.Color.Transparent;
            this.maxLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.maxLBL.Location = new System.Drawing.Point(108, 463);
            this.maxLBL.Name = "maxLBL";
            this.maxLBL.Size = new System.Drawing.Size(39, 21);
            this.maxLBL.TabIndex = 72;
            this.maxLBL.Text = "Max";
            this.maxLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceTXT
            // 
            this.priceTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceTXT.BackColor = System.Drawing.Color.White;
            this.priceTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.priceTXT.Location = new System.Drawing.Point(153, 405);
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(250, 25);
            this.priceTXT.TabIndex = 71;
            // 
            // priceLBL
            // 
            this.priceLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceLBL.AutoSize = true;
            this.priceLBL.BackColor = System.Drawing.Color.Transparent;
            this.priceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.priceLBL.Location = new System.Drawing.Point(58, 405);
            this.priceLBL.Name = "priceLBL";
            this.priceLBL.Size = new System.Drawing.Size(89, 21);
            this.priceLBL.TabIndex = 70;
            this.priceLBL.Text = "Price / Cost";
            this.priceLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inventoryTXT
            // 
            this.inventoryTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryTXT.BackColor = System.Drawing.Color.White;
            this.inventoryTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inventoryTXT.Location = new System.Drawing.Point(153, 348);
            this.inventoryTXT.Name = "inventoryTXT";
            this.inventoryTXT.Size = new System.Drawing.Size(250, 25);
            this.inventoryTXT.TabIndex = 69;
            // 
            // inventoryLBL
            // 
            this.inventoryLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryLBL.AutoSize = true;
            this.inventoryLBL.BackColor = System.Drawing.Color.Transparent;
            this.inventoryLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inventoryLBL.Location = new System.Drawing.Point(71, 348);
            this.inventoryLBL.Name = "inventoryLBL";
            this.inventoryLBL.Size = new System.Drawing.Size(76, 21);
            this.inventoryLBL.TabIndex = 68;
            this.inventoryLBL.Text = "Inventory";
            this.inventoryLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTXT
            // 
            this.nameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTXT.BackColor = System.Drawing.Color.White;
            this.nameTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nameTXT.Location = new System.Drawing.Point(153, 289);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(250, 25);
            this.nameTXT.TabIndex = 67;
            // 
            // nameLBL
            // 
            this.nameLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLBL.AutoSize = true;
            this.nameLBL.BackColor = System.Drawing.Color.Transparent;
            this.nameLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nameLBL.Location = new System.Drawing.Point(95, 288);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(52, 21);
            this.nameLBL.TabIndex = 66;
            this.nameLBL.Text = "Name";
            this.nameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idTXT
            // 
            this.idTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idTXT.BackColor = System.Drawing.Color.White;
            this.idTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTXT.Enabled = false;
            this.idTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.idTXT.Location = new System.Drawing.Point(153, 223);
            this.idTXT.Name = "idTXT";
            this.idTXT.Size = new System.Drawing.Size(250, 25);
            this.idTXT.TabIndex = 65;
            // 
            // idLBL
            // 
            this.idLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idLBL.AutoSize = true;
            this.idLBL.BackColor = System.Drawing.Color.Transparent;
            this.idLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.idLBL.Location = new System.Drawing.Point(122, 223);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(25, 21);
            this.idLBL.TabIndex = 64;
            this.idLBL.Text = "ID";
            this.idLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModifyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1094, 759);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.partDGV);
            this.Controls.Add(this.searchTXT);
            this.Controls.Add(this.searchPartBTB);
            this.Controls.Add(this.minTXT);
            this.Controls.Add(this.minLBL);
            this.Controls.Add(this.maxTXT);
            this.Controls.Add(this.maxLBL);
            this.Controls.Add(this.priceTXT);
            this.Controls.Add(this.priceLBL);
            this.Controls.Add(this.inventoryTXT);
            this.Controls.Add(this.inventoryLBL);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.idTXT);
            this.Controls.Add(this.idLBL);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1110, 760);
            this.Name = "ModifyProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ModifyProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView partDGV;
        private System.Windows.Forms.TextBox searchTXT;
        private System.Windows.Forms.Button searchPartBTB;
        private System.Windows.Forms.TextBox minTXT;
        private System.Windows.Forms.Label minLBL;
        private System.Windows.Forms.TextBox maxTXT;
        private System.Windows.Forms.Label maxLBL;
        private System.Windows.Forms.TextBox priceTXT;
        private System.Windows.Forms.Label priceLBL;
        private System.Windows.Forms.TextBox inventoryTXT;
        private System.Windows.Forms.Label inventoryLBL;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.TextBox idTXT;
        private System.Windows.Forms.Label idLBL;
    }
}