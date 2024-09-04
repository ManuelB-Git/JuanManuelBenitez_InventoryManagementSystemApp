namespace JuanManuelBenitez_InventoryManagementSystem.Forms
{
    partial class AddPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPart));
            this.idLBL = new System.Windows.Forms.Label();
            this.idTXT = new System.Windows.Forms.TextBox();
            this.savePartBTN = new System.Windows.Forms.Button();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.nameLBL = new System.Windows.Forms.Label();
            this.inventoryTXT = new System.Windows.Forms.TextBox();
            this.inventoryLBL = new System.Windows.Forms.Label();
            this.priceTXT = new System.Windows.Forms.TextBox();
            this.priceLBL = new System.Windows.Forms.Label();
            this.maxTXT = new System.Windows.Forms.TextBox();
            this.maxLBL = new System.Windows.Forms.Label();
            this.minTXT = new System.Windows.Forms.TextBox();
            this.minLBL = new System.Windows.Forms.Label();
            this.categoryTXT = new System.Windows.Forms.TextBox();
            this.catagoryLBL = new System.Windows.Forms.Label();
            this.cancelPartBTN = new System.Windows.Forms.Button();
            this.titleLBL = new System.Windows.Forms.Label();
            this.inhouseRBTN = new System.Windows.Forms.RadioButton();
            this.outsourcedRBTN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // idLBL
            // 
            this.idLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idLBL.AutoSize = true;
            this.idLBL.BackColor = System.Drawing.Color.Transparent;
            this.idLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.idLBL.Location = new System.Drawing.Point(154, 164);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(25, 21);
            this.idLBL.TabIndex = 20;
            this.idLBL.Text = "ID";
            this.idLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idLBL.Click += new System.EventHandler(this.partsLBL_Click);
            // 
            // idTXT
            // 
            this.idTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idTXT.BackColor = System.Drawing.Color.White;
            this.idTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTXT.Enabled = false;
            this.idTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.idTXT.Location = new System.Drawing.Point(185, 164);
            this.idTXT.Name = "idTXT";
            this.idTXT.Size = new System.Drawing.Size(250, 25);
            this.idTXT.TabIndex = 29;
            // 
            // savePartBTN
            // 
            this.savePartBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.savePartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.savePartBTN.FlatAppearance.BorderSize = 0;
            this.savePartBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.savePartBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.savePartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePartBTN.ForeColor = System.Drawing.Color.White;
            this.savePartBTN.Location = new System.Drawing.Point(464, 502);
            this.savePartBTN.Name = "savePartBTN";
            this.savePartBTN.Size = new System.Drawing.Size(75, 23);
            this.savePartBTN.TabIndex = 30;
            this.savePartBTN.Text = "Save";
            this.savePartBTN.UseVisualStyleBackColor = false;
            this.savePartBTN.Click += new System.EventHandler(this.savePartBTN_Click);
            // 
            // nameTXT
            // 
            this.nameTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTXT.BackColor = System.Drawing.Color.White;
            this.nameTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nameTXT.Location = new System.Drawing.Point(185, 230);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(250, 25);
            this.nameTXT.TabIndex = 32;
            // 
            // nameLBL
            // 
            this.nameLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLBL.AutoSize = true;
            this.nameLBL.BackColor = System.Drawing.Color.Transparent;
            this.nameLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nameLBL.Location = new System.Drawing.Point(127, 229);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(52, 21);
            this.nameLBL.TabIndex = 31;
            this.nameLBL.Text = "Name";
            this.nameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inventoryTXT
            // 
            this.inventoryTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryTXT.BackColor = System.Drawing.Color.White;
            this.inventoryTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inventoryTXT.Location = new System.Drawing.Point(185, 289);
            this.inventoryTXT.Name = "inventoryTXT";
            this.inventoryTXT.Size = new System.Drawing.Size(250, 25);
            this.inventoryTXT.TabIndex = 34;
            // 
            // inventoryLBL
            // 
            this.inventoryLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inventoryLBL.AutoSize = true;
            this.inventoryLBL.BackColor = System.Drawing.Color.Transparent;
            this.inventoryLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inventoryLBL.Location = new System.Drawing.Point(103, 289);
            this.inventoryLBL.Name = "inventoryLBL";
            this.inventoryLBL.Size = new System.Drawing.Size(76, 21);
            this.inventoryLBL.TabIndex = 33;
            this.inventoryLBL.Text = "Inventory";
            this.inventoryLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceTXT
            // 
            this.priceTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceTXT.BackColor = System.Drawing.Color.White;
            this.priceTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.priceTXT.Location = new System.Drawing.Point(185, 346);
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(250, 25);
            this.priceTXT.TabIndex = 36;
            // 
            // priceLBL
            // 
            this.priceLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.priceLBL.AutoSize = true;
            this.priceLBL.BackColor = System.Drawing.Color.Transparent;
            this.priceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.priceLBL.Location = new System.Drawing.Point(90, 346);
            this.priceLBL.Name = "priceLBL";
            this.priceLBL.Size = new System.Drawing.Size(89, 21);
            this.priceLBL.TabIndex = 35;
            this.priceLBL.Text = "Price / Cost";
            this.priceLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxTXT
            // 
            this.maxTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxTXT.BackColor = System.Drawing.Color.White;
            this.maxTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.maxTXT.Location = new System.Drawing.Point(185, 404);
            this.maxTXT.Name = "maxTXT";
            this.maxTXT.Size = new System.Drawing.Size(125, 25);
            this.maxTXT.TabIndex = 38;
            // 
            // maxLBL
            // 
            this.maxLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maxLBL.AutoSize = true;
            this.maxLBL.BackColor = System.Drawing.Color.Transparent;
            this.maxLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.maxLBL.Location = new System.Drawing.Point(140, 404);
            this.maxLBL.Name = "maxLBL";
            this.maxLBL.Size = new System.Drawing.Size(39, 21);
            this.maxLBL.TabIndex = 37;
            this.maxLBL.Text = "Max";
            this.maxLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minTXT
            // 
            this.minTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minTXT.BackColor = System.Drawing.Color.White;
            this.minTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.minTXT.Location = new System.Drawing.Point(375, 404);
            this.minTXT.Name = "minTXT";
            this.minTXT.Size = new System.Drawing.Size(125, 25);
            this.minTXT.TabIndex = 40;
            // 
            // minLBL
            // 
            this.minLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minLBL.AutoSize = true;
            this.minLBL.BackColor = System.Drawing.Color.Transparent;
            this.minLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.minLBL.Location = new System.Drawing.Point(332, 403);
            this.minLBL.Name = "minLBL";
            this.minLBL.Size = new System.Drawing.Size(37, 21);
            this.minLBL.TabIndex = 39;
            this.minLBL.Text = "Min";
            this.minLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryTXT
            // 
            this.categoryTXT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoryTXT.BackColor = System.Drawing.Color.White;
            this.categoryTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.categoryTXT.Location = new System.Drawing.Point(185, 468);
            this.categoryTXT.Name = "categoryTXT";
            this.categoryTXT.Size = new System.Drawing.Size(250, 25);
            this.categoryTXT.TabIndex = 42;
            // 
            // catagoryLBL
            // 
            this.catagoryLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catagoryLBL.AutoSize = true;
            this.catagoryLBL.BackColor = System.Drawing.Color.Transparent;
            this.catagoryLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.catagoryLBL.Location = new System.Drawing.Point(56, 467);
            this.catagoryLBL.MinimumSize = new System.Drawing.Size(123, 21);
            this.catagoryLBL.Name = "catagoryLBL";
            this.catagoryLBL.Size = new System.Drawing.Size(123, 21);
            this.catagoryLBL.TabIndex = 41;
            this.catagoryLBL.Text = "Machine ID";
            this.catagoryLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelPartBTN
            // 
            this.cancelPartBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelPartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.cancelPartBTN.FlatAppearance.BorderSize = 0;
            this.cancelPartBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.cancelPartBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.cancelPartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPartBTN.ForeColor = System.Drawing.Color.White;
            this.cancelPartBTN.Location = new System.Drawing.Point(545, 502);
            this.cancelPartBTN.Name = "cancelPartBTN";
            this.cancelPartBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelPartBTN.TabIndex = 43;
            this.cancelPartBTN.Text = "Cancel";
            this.cancelPartBTN.UseVisualStyleBackColor = false;
            this.cancelPartBTN.Click += new System.EventHandler(this.cancelPartBTN_Click);
            // 
            // titleLBL
            // 
            this.titleLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLBL.AutoSize = true;
            this.titleLBL.BackColor = System.Drawing.Color.Transparent;
            this.titleLBL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.titleLBL.Location = new System.Drawing.Point(226, 9);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(143, 45);
            this.titleLBL.TabIndex = 44;
            this.titleLBL.Text = "Add Part";
            this.titleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inhouseRBTN
            // 
            this.inhouseRBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inhouseRBTN.AutoSize = true;
            this.inhouseRBTN.BackColor = System.Drawing.Color.Transparent;
            this.inhouseRBTN.Checked = true;
            this.inhouseRBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inhouseRBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inhouseRBTN.Location = new System.Drawing.Point(185, 103);
            this.inhouseRBTN.Name = "inhouseRBTN";
            this.inhouseRBTN.Size = new System.Drawing.Size(77, 21);
            this.inhouseRBTN.TabIndex = 47;
            this.inhouseRBTN.TabStop = true;
            this.inhouseRBTN.Text = "In-House";
            this.inhouseRBTN.UseVisualStyleBackColor = false;
            this.inhouseRBTN.CheckedChanged += new System.EventHandler(this.inhouseRBTN_CheckedChanged);
            // 
            // outsourcedRBTN
            // 
            this.outsourcedRBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.outsourcedRBTN.AutoSize = true;
            this.outsourcedRBTN.BackColor = System.Drawing.Color.Transparent;
            this.outsourcedRBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outsourcedRBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.outsourcedRBTN.Location = new System.Drawing.Point(358, 103);
            this.outsourcedRBTN.Name = "outsourcedRBTN";
            this.outsourcedRBTN.Size = new System.Drawing.Size(93, 21);
            this.outsourcedRBTN.TabIndex = 48;
            this.outsourcedRBTN.Text = "Outsourced";
            this.outsourcedRBTN.UseVisualStyleBackColor = false;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(632, 699);
            this.Controls.Add(this.outsourcedRBTN);
            this.Controls.Add(this.inhouseRBTN);
            this.Controls.Add(this.titleLBL);
            this.Controls.Add(this.cancelPartBTN);
            this.Controls.Add(this.categoryTXT);
            this.Controls.Add(this.catagoryLBL);
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
            this.Controls.Add(this.savePartBTN);
            this.Controls.Add(this.idTXT);
            this.Controls.Add(this.idLBL);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(648, 600);
            this.Name = "AddPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLBL;
        private System.Windows.Forms.TextBox idTXT;
        private System.Windows.Forms.Button savePartBTN;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.TextBox inventoryTXT;
        private System.Windows.Forms.Label inventoryLBL;
        private System.Windows.Forms.TextBox priceTXT;
        private System.Windows.Forms.Label priceLBL;
        private System.Windows.Forms.TextBox maxTXT;
        private System.Windows.Forms.Label maxLBL;
        private System.Windows.Forms.TextBox minTXT;
        private System.Windows.Forms.Label minLBL;
        private System.Windows.Forms.TextBox categoryTXT;
        private System.Windows.Forms.Label catagoryLBL;
        private System.Windows.Forms.Button cancelPartBTN;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.RadioButton inhouseRBTN;
        private System.Windows.Forms.RadioButton outsourcedRBTN;
    }
}