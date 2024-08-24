using JuanManuelBenitez_InventoryManagementSystem.Forms;
using JuanManuelBenitez_InventoryManagementSystem.Models;
using System;

using System.Windows.Forms;

namespace JuanManuelBenitez_InventoryManagementSystem
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            
            Inhouse dummyPart1 = new Inhouse()
            {
                PartID = 1,
                Name = "Lever",
                Price = 10.00M,
                InStock = 10,
                Min = 1,
                Max = 50,
                MachineID = 1234
            };
            Inhouse dummyPart2 = new Inhouse()
            {
                PartID = 2,
                Name = "Screw",
                Price = 0.50M,
                InStock = 100,
                Min = 1,
                Max = 500,
                MachineID = 5678
            };

            Outsourced dummyPart3 = new Outsourced()
            {
                PartID = 3,
                Name = "Nut",
                Price = 0.25M,
                InStock = 200,
                Min = 1,
                Max = 1000,
                CompanyName = "Nut Company"
            };

            Outsourced dummyPart4 = new Outsourced()
            {
                PartID = 4,
                Name = "Bolt",
                Price = 0.75M,
                InStock = 150,
                Min = 1,
                Max = 750,
                CompanyName = "Bolt Company"
            };

            Inventory.AddPart(dummyPart1);
            Inventory.AddPart(dummyPart2);
            Inventory.AddPart(dummyPart3);
            Inventory.AddPart(dummyPart4);

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
      
            partDGV.DataSource = Models.Inventory.AllParts;
            productDGV.DataSource = Models.Inventory.Products;

        

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
            // Generate a new unique identifier
            Random random = new Random();

            int newPartId = random.Next(1, 9999);
            if (Inventory.LookupPart(newPartId) != null)
            {
                newPartId = random.Next(1, 9999);
            }

            AddPart addPartForm = new AddPart(newPartId);
            addPartForm.ShowDialog();
        }

        private void modifyPartBTN_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the partDGV DataGridView
            if (partDGV.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = partDGV.SelectedRows[0];

                // Get the data from the selected row (assuming the first column contains the unique identifier)
                int partId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Open the ModifyPart form with the selected partId
                ModifyPart modifyPart = new ModifyPart(partId);
                modifyPart.ShowDialog();
            }
            else
            {
                // Display an error message or perform any other action when no row is selected
                MessageBox.Show("Please select a row before modifying a part.");
            }

            this.Refresh();
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

        private void deletePartBTN_Click(object sender, EventArgs e)
        {
            if (partDGV.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = partDGV.SelectedRows[0];

                // Get the data from the selected row (assuming the first column contains the unique identifier)
                int partId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Ask the user for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Delete the part
                    Inventory.DeletePart(Models.Inventory.LookupPart(partId));
                }
            }
            else
            {
                MessageBox.Show("Please select a row before deleting a part.");
            }
        }

        private void deleteProductBTN_Click(object sender, EventArgs e)
        {

            if(productDGV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = productDGV.SelectedRows[0];
                int productId = Convert.ToInt32(selectedRow.Cells[0].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Inventory.DeleteProduct(Inventory.LookupProduct(productId));
                }
            }
            else
            {
                MessageBox.Show("Please select a row before deleting a product.");
            }
        }

        private void searchPartBTB_Click(object sender, EventArgs e)
        {
            try
            {
                int tempId = Convert.ToInt32(textBox1.Text);
                Models.Part tempPart = Models.Inventory.LookupPart(tempId);
                if (tempPart != null)
                {
                    partDGV.ClearSelection();
                    foreach (DataGridViewRow row in partDGV.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[0].Value) == tempId)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Part not found.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer to search for a part.");
            }
            textBox1.Clear();
        }

        private void searchProductBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int tempId = Convert.ToInt32(textBox2.Text);
                Models.Product tempProduct = Models.Inventory.LookupProduct(tempId);
                if (tempProduct != null)
                {
                    productDGV.ClearSelection();
                    foreach (DataGridViewRow row in productDGV.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[0].Value) == tempId)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }

            }   
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer to search for a product.");
            }
        }
    }
}
