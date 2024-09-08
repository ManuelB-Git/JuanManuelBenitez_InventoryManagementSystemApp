using JuanManuelBenitez_InventoryManagementSystem.Models;
using System;

using System.Windows.Forms;

namespace JuanManuelBenitez_InventoryManagementSystem.Forms
{
    public partial class ModifyProducts : Form
    {
        private int productID;
        public ModifyProducts(int productID)
        {
            InitializeComponent();
            this.productID = productID;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyProducts_Load(object sender, EventArgs e)
        {
            partDGV.DataSource = Inventory.AllParts;
            dataGridView1.DataSource = Inventory.LookupProduct(productID).AssociatedParts;



            idTXT.Text = Inventory.LookupProduct(productID).ProductID.ToString();
            nameTXT.Text = Inventory.LookupProduct(productID).Name;
            priceTXT.Text = Inventory.LookupProduct(productID).Price.ToString();
            inventoryTXT.Text = Inventory.LookupProduct(productID).InStock.ToString();
            minTXT.Text = Inventory.LookupProduct(productID).Min.ToString();
            maxTXT.Text = Inventory.LookupProduct(productID).Max.ToString();

          

        }

        private void searchPartBTB_Click(object sender, EventArgs e)
        {
            try
            {
                int tempId = Convert.ToInt32(searchTXT.Text);
                Part tempPart = Inventory.LookupPart(tempId);
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
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid id integer to search for a part.");
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (partDGV.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a row to add.");
                }

                foreach (DataGridViewRow row in partDGV.SelectedRows)
                {
                    int partId = Convert.ToInt32(row.Cells[0].Value);
                    // Use the partId variable as needed
                    Part part = Inventory.LookupPart(partId);


                    if (Inventory.LookupProduct(productID).AssociatedParts.Contains(part))
                    {
                        MessageBox.Show("Part is already included.");
                    }
                    else
                    {
                        Inventory.LookupProduct(productID).AddAssociatedPart(part);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a row to delete the part.");
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete the part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int partId = Convert.ToInt32(row.Cells[0].Value);
                        // Use the partId variable as needed
                        Part part = Inventory.LookupPart(partId);

                        if (Inventory.LookupProduct(productID).AssociatedParts.Contains(part))
                        {
                            Inventory.LookupProduct(productID).RemoveAssociatedPart(part);
                        }
                        else
                        {
                            MessageBox.Show("Part is not included.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the values from the text boxes
                string name = nameTXT.Text;
                decimal price = Convert.ToDecimal(priceTXT.Text);
                int inventory = Convert.ToInt32(inventoryTXT.Text);
                int min = Convert.ToInt32(minTXT.Text);
                int max = Convert.ToInt32(maxTXT.Text);

                // Check if max is larger than min
                if (max <= min)
                {
                    throw new Exception("Max must be larger than Min.");
                }

                // Check if inventory is between min and max
                if (inventory < min || inventory > max)
                {
                    throw new Exception("Inventory must be between Min and Max.");
                }

                // Update the product properties
                Product product = new Product() {
                    ProductID = productID,
                    Name = name, 
                    Price = price, 
                    InStock = inventory, 
                    Min = min, 
                    Max =max};
                Inventory.UpdateProduct(productID, product);

                MessageBox.Show("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
            this.Close();
        }
    }
}
