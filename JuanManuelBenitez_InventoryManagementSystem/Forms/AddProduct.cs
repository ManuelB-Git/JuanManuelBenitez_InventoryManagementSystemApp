using JuanManuelBenitez_InventoryManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace JuanManuelBenitez_InventoryManagementSystem.Forms
{
    public partial class AddProduct : Form
    {
        private int newID;
        public AddProduct(int newID)
        {
            InitializeComponent();
            this.newID = newID;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            productDGV2.Columns.Add("PartID", "Part ID");
            productDGV2.Columns.Add("Name", "Name");
            productDGV2.Columns.Add("Price", "Price");
            productDGV2.Columns.Add("InStock", "In Stock");
            productDGV2.Columns.Add("Min", "Min");
            productDGV2.Columns.Add("Max", "Max");

            idTXT.Text = newID.ToString();
            productDGV1.DataSource = Inventory.AllParts;
        }

        private void searchPartBTB_Click(object sender, EventArgs e)
        {
            try
            {
                int tempId = Convert.ToInt32(searchTXT.Text);
                Part tempPart = Inventory.LookupPart(tempId);
                if (tempPart != null)
                {
                    productDGV1.ClearSelection();
                    foreach (DataGridViewRow row in productDGV1.Rows)
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

        private void nameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int tempID = int.Parse(idTXT.Text);
                string tempName = nameTXT.Text;
                decimal tempPrice = decimal.Parse(priceTXT.Text);
                int tempStock = int.Parse(inventoryTXT.Text);
                int tempMin = int.Parse(minTXT.Text);
                int tempMax = int.Parse(maxTXT.Text);

                if (tempMin >= tempMax)
                {
                    throw new Exception("Min should be less than Max");
                }

                if (tempStock < tempMin || tempStock >tempMax )
                {
                    throw new Exception("Inventory should be between Min and Max");
                }

                Product newProduct = new Product();
                newProduct.ProductID = tempID;
                newProduct.Name = tempName;
                newProduct.Price = tempPrice;
                newProduct.InStock = tempStock;
                newProduct.Min = tempMin;
                newProduct.Max = tempMax;

                foreach (DataGridViewRow row in productDGV1.SelectedRows)
                {
                    int partID = Convert.ToInt32(row.Cells[0].Value);
                    Part part = Inventory.LookupPart(partID);
                    if (part != null)
                    {
                        newProduct.AddAssociatedPart(part);
                    }
                }

                Inventory.AddProduct(newProduct);
                this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (productDGV1.SelectedRows.Count == 0)
                {
                    throw new Exception("You must select a row to add.");
                }

                foreach (DataGridViewRow row in productDGV1.SelectedRows)
                {
                    int partID = Convert.ToInt32(row.Cells[0].Value);
                    Part part = Inventory.LookupPart(partID);

                    // Check if the part is already added
                    bool isPartAdded = false;
                    foreach (DataGridViewRow addedRow in productDGV2.Rows)
                    {
                        int addedPartID = Convert.ToInt32(addedRow.Cells[0].Value);
                        if (addedPartID == partID)
                        {
                            isPartAdded = true;
                            break;
                        }
                    }

                    if (isPartAdded)
                    {
                        MessageBox.Show("Part already added.");
                    }
                    else
                    {
                        productDGV2.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
                    }
                }
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (productDGV2.SelectedRows.Count == 0)
            {
                MessageBox.Show("You must select a row to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in productDGV2.SelectedRows)
                {
                    productDGV2.Rows.Remove(row);
                }
            }
        }
    }
}
