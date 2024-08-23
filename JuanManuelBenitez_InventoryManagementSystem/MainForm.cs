using JuanManuelBenitez_InventoryManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanManuelBenitez_InventoryManagementSystem
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPartBTN_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart();
            addPartForm.ShowDialog();
        }

        private void modifyPartBTN_Click(object sender, EventArgs e)
        {
            ModifyPart modifyPart = new ModifyPart();
            modifyPart.ShowDialog();    
        }

        private void addProductBTN_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void modifyProductBTN_Click(object sender, EventArgs e)
        {
            ModifyProducts modifyProducts = new ModifyProducts();
            modifyProducts.ShowDialog();    
        }
    }
}
