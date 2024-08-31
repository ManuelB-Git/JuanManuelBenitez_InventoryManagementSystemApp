namespace JuanManuelBenitez_InventoryManagementSystem.Forms
{
    partial class ModifyPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyPart));
            this.outsourcedRBTN = new System.Windows.Forms.RadioButton();
            this.inhouseRBTN = new System.Windows.Forms.RadioButton();
            this.titleLBL = new System.Windows.Forms.Label();
            this.cancelPartBTN = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.catagoryLBL = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.minLBL = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.maxLBL = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.priceLBL = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.inventoryLBL = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameLBL = new System.Windows.Forms.Label();
            this.savePartBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.idLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outsourcedRBTN
            // 
            this.outsourcedRBTN.AutoSize = true;
            this.outsourcedRBTN.BackColor = System.Drawing.Color.Transparent;
            this.outsourcedRBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outsourcedRBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedRBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.outsourcedRBTN.Location = new System.Drawing.Point(358, 103);
            this.outsourcedRBTN.Name = "outsourcedRBTN";
            this.outsourcedRBTN.Size = new System.Drawing.Size(93, 21);
            this.outsourcedRBTN.TabIndex = 67;
            this.outsourcedRBTN.Text = "Outsourced";
            this.outsourcedRBTN.UseVisualStyleBackColor = false;
            // 
            // inhouseRBTN
            // 
            this.inhouseRBTN.AutoSize = true;
            this.inhouseRBTN.BackColor = System.Drawing.Color.Transparent;
            this.inhouseRBTN.Checked = true;
            this.inhouseRBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inhouseRBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inhouseRBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inhouseRBTN.Location = new System.Drawing.Point(185, 103);
            this.inhouseRBTN.Name = "inhouseRBTN";
            this.inhouseRBTN.Size = new System.Drawing.Size(77, 21);
            this.inhouseRBTN.TabIndex = 66;
            this.inhouseRBTN.TabStop = true;
            this.inhouseRBTN.Text = "In-House";
            this.inhouseRBTN.UseVisualStyleBackColor = false;
            this.inhouseRBTN.CheckedChanged += new System.EventHandler(this.inhouseRBTN_CheckedChanged);
            // 
            // titleLBL
            // 
            this.titleLBL.AutoSize = true;
            this.titleLBL.BackColor = System.Drawing.Color.Transparent;
            this.titleLBL.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.titleLBL.Location = new System.Drawing.Point(177, 9);
            this.titleLBL.Name = "titleLBL";
            this.titleLBL.Size = new System.Drawing.Size(184, 45);
            this.titleLBL.TabIndex = 65;
            this.titleLBL.Text = "Modify Part";
            this.titleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelPartBTN
            // 
            this.cancelPartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.cancelPartBTN.FlatAppearance.BorderSize = 0;
            this.cancelPartBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.cancelPartBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.cancelPartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPartBTN.ForeColor = System.Drawing.Color.White;
            this.cancelPartBTN.Location = new System.Drawing.Point(545, 664);
            this.cancelPartBTN.Name = "cancelPartBTN";
            this.cancelPartBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelPartBTN.TabIndex = 64;
            this.cancelPartBTN.Text = "Cancel";
            this.cancelPartBTN.UseVisualStyleBackColor = false;
            this.cancelPartBTN.Click += new System.EventHandler(this.cancelPartBTN_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox7.Location = new System.Drawing.Point(185, 468);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(250, 25);
            this.textBox7.TabIndex = 63;
            // 
            // catagoryLBL
            // 
            this.catagoryLBL.AutoSize = true;
            this.catagoryLBL.BackColor = System.Drawing.Color.Transparent;
            this.catagoryLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catagoryLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.catagoryLBL.Location = new System.Drawing.Point(56, 467);
            this.catagoryLBL.MinimumSize = new System.Drawing.Size(123, 21);
            this.catagoryLBL.Name = "catagoryLBL";
            this.catagoryLBL.Size = new System.Drawing.Size(123, 21);
            this.catagoryLBL.TabIndex = 62;
            this.catagoryLBL.Text = "Machine ID";
            this.catagoryLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox6.Location = new System.Drawing.Point(375, 404);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 25);
            this.textBox6.TabIndex = 61;
            // 
            // minLBL
            // 
            this.minLBL.AutoSize = true;
            this.minLBL.BackColor = System.Drawing.Color.Transparent;
            this.minLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.minLBL.Location = new System.Drawing.Point(332, 403);
            this.minLBL.Name = "minLBL";
            this.minLBL.Size = new System.Drawing.Size(37, 21);
            this.minLBL.TabIndex = 60;
            this.minLBL.Text = "Min";
            this.minLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox5.Location = new System.Drawing.Point(185, 404);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 25);
            this.textBox5.TabIndex = 59;
            // 
            // maxLBL
            // 
            this.maxLBL.AutoSize = true;
            this.maxLBL.BackColor = System.Drawing.Color.Transparent;
            this.maxLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.maxLBL.Location = new System.Drawing.Point(140, 404);
            this.maxLBL.Name = "maxLBL";
            this.maxLBL.Size = new System.Drawing.Size(39, 21);
            this.maxLBL.TabIndex = 58;
            this.maxLBL.Text = "Max";
            this.maxLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox4.Location = new System.Drawing.Point(185, 346);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 25);
            this.textBox4.TabIndex = 57;
            // 
            // priceLBL
            // 
            this.priceLBL.AutoSize = true;
            this.priceLBL.BackColor = System.Drawing.Color.Transparent;
            this.priceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.priceLBL.Location = new System.Drawing.Point(90, 346);
            this.priceLBL.Name = "priceLBL";
            this.priceLBL.Size = new System.Drawing.Size(89, 21);
            this.priceLBL.TabIndex = 56;
            this.priceLBL.Text = "Price / Cost";
            this.priceLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox3.Location = new System.Drawing.Point(185, 289);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 25);
            this.textBox3.TabIndex = 55;
            // 
            // inventoryLBL
            // 
            this.inventoryLBL.AutoSize = true;
            this.inventoryLBL.BackColor = System.Drawing.Color.Transparent;
            this.inventoryLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.inventoryLBL.Location = new System.Drawing.Point(103, 289);
            this.inventoryLBL.Name = "inventoryLBL";
            this.inventoryLBL.Size = new System.Drawing.Size(76, 21);
            this.inventoryLBL.TabIndex = 54;
            this.inventoryLBL.Text = "Inventory";
            this.inventoryLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox2.Location = new System.Drawing.Point(185, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 25);
            this.textBox2.TabIndex = 53;
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.BackColor = System.Drawing.Color.Transparent;
            this.nameLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nameLBL.Location = new System.Drawing.Point(127, 229);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(52, 21);
            this.nameLBL.TabIndex = 52;
            this.nameLBL.Text = "Name";
            this.nameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // savePartBTN
            // 
            this.savePartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.savePartBTN.FlatAppearance.BorderSize = 0;
            this.savePartBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(120)))));
            this.savePartBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(158)))));
            this.savePartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePartBTN.ForeColor = System.Drawing.Color.White;
            this.savePartBTN.Location = new System.Drawing.Point(464, 664);
            this.savePartBTN.Name = "savePartBTN";
            this.savePartBTN.Size = new System.Drawing.Size(75, 23);
            this.savePartBTN.TabIndex = 51;
            this.savePartBTN.Text = "Save";
            this.savePartBTN.UseVisualStyleBackColor = false;
            this.savePartBTN.Click += new System.EventHandler(this.savePartBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.Location = new System.Drawing.Point(185, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 25);
            this.textBox1.TabIndex = 50;
            // 
            // idLBL
            // 
            this.idLBL.AutoSize = true;
            this.idLBL.BackColor = System.Drawing.Color.Transparent;
            this.idLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.idLBL.Location = new System.Drawing.Point(154, 164);
            this.idLBL.Name = "idLBL";
            this.idLBL.Size = new System.Drawing.Size(25, 21);
            this.idLBL.TabIndex = 49;
            this.idLBL.Text = "ID";
            this.idLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 699);
            this.Controls.Add(this.outsourcedRBTN);
            this.Controls.Add(this.inhouseRBTN);
            this.Controls.Add(this.titleLBL);
            this.Controls.Add(this.cancelPartBTN);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.catagoryLBL);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.minLBL);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.maxLBL);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.priceLBL);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.inventoryLBL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.savePartBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idLBL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(648, 738);
            this.MinimumSize = new System.Drawing.Size(648, 738);
            this.Name = "ModifyPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModifyPart";
            this.Load += new System.EventHandler(this.ModifyPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton outsourcedRBTN;
        private System.Windows.Forms.RadioButton inhouseRBTN;
        private System.Windows.Forms.Label titleLBL;
        private System.Windows.Forms.Button cancelPartBTN;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label catagoryLBL;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label minLBL;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label maxLBL;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label priceLBL;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label inventoryLBL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Button savePartBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label idLBL;
    }
}