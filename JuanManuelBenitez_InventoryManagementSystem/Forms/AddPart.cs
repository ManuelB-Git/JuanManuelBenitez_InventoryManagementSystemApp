using JuanManuelBenitez_InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanManuelBenitez_InventoryManagementSystem.Forms
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void partsLBL_Click(object sender, EventArgs e)
        {

        }

        private void inhouseRBTN_CheckedChanged(object sender, EventArgs e)
        {
            if(inhouseRBTN.Checked == true)
                {
                catagoryLBL.Text = "Machine ID";
            }
            else
            {
                catagoryLBL.Text = "Company Name";
            }

        }

        private void cancelPartBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }

        private void savePartBTN_Click(object sender, EventArgs e)
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

                if (tempStock < tempMin || tempStock > tempMax)
                {
                    throw new Exception("Inventory should be between Min and Max");
                }

                if (inhouseRBTN.Checked == true)
                {
                    if (!int.TryParse(categoryTXT.Text, out int tempMachineID))
                    {
                        throw new Exception("Invalid Machine ID");
                    }

                    Inhouse newPart = new Inhouse()
                    {
                        InStock = tempStock,
                        Max = tempMax,
                        Min = tempMin,
                        Name = tempName,
                        PartID = tempID,
                        Price = tempPrice,
                        MachineID = tempMachineID
                    };
                    Inventory.AddPart(newPart);
                }
                else
                {
                    string tempCompanyName = categoryTXT.Text;
                    Outsourced newPart = new Outsourced()
                    {
                        InStock = tempStock,
                        Max = tempMax,
                        Min = tempMin,
                        Name = tempName,
                        PartID = tempID,
                        Price = tempPrice,
                        CompanyName = tempCompanyName
                    };
                    Inventory.AddPart(newPart);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
