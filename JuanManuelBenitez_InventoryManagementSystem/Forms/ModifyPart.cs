using JuanManuelBenitez_InventoryManagementSystem.Models;
using System;

using System.Windows.Forms;

namespace JuanManuelBenitez_InventoryManagementSystem.Forms
{
    public partial class ModifyPart : Form
    {
        private int partId; // Add a private field to store the part ID

        public ModifyPart(int partId) // Modify the constructor to accept an int parameter
        {
            InitializeComponent();
            this.partId = partId; // Assign the part ID to the private field
        }

        private void cancelPartBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inhouseRBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (inhouseRBTN.Checked)
            {
                catagoryLBL.Text = "Machine ID";
            }
            else
            {
                catagoryLBL.Text = "Company Name";
            }
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
            textBox1.Text = Inventory.LookupPart(partId).PartID.ToString();
            textBox2.Text = Inventory.LookupPart(partId).Name;
            textBox4.Text = Inventory.LookupPart(partId).Price.ToString();
            textBox3.Text = Inventory.LookupPart(partId).InStock.ToString();
            textBox6.Text = Inventory.LookupPart(partId).Min.ToString();
            textBox5.Text = Inventory.LookupPart(partId).Max.ToString();
            if (Inventory.LookupPart(partId) is Inhouse)
            {
                inhouseRBTN.Checked = true;
                textBox7.Text = ((Inhouse)Inventory.LookupPart(partId)).MachineID.ToString();
            }
            else
            {
                outsourcedRBTN.Checked = true;
                textBox7.Text = ((Outsourced)Inventory.LookupPart(partId)).CompanyName;
            }

        }

        private void savePartBTN_Click(object sender, EventArgs e)
        {
            try 
            { 
                int tempID = int.Parse(textBox1.Text);
                string tempName = textBox2.Text;
                decimal tempPrice = decimal.Parse(textBox4.Text);
                int tempStock = int.Parse(textBox3.Text);
                int tempMin = int.Parse(textBox6.Text);
                int tempMax = int.Parse(textBox5.Text);

                if (tempMin >= tempMax)
                {
                    throw new Exception("Min should be less than Max");
                }

                if (tempStock < tempMin || tempStock > tempMax)
                {
                    throw new Exception("Inventory should be between Min and Max");
                }

                if (inhouseRBTN.Checked)
                {
                    int tempMachineID = int.Parse(textBox7.Text);
                    Inhouse inhousePart = new Inhouse()
                    { 
                        InStock = tempStock,
                        Max = tempMax,
                        Min = tempMin,
                        Name = tempName,
                        PartID = tempID,
                        Price = tempPrice,
                        MachineID = tempMachineID
                    };
                    Inventory.UpdatePart(tempID, inhousePart);
                }
                else
                {
                    string tempCompanyName = textBox7.Text;
                    Outsourced outsourcedPart = new Outsourced() 
                    {
                        InStock = tempStock,
                        Max = tempMax,
                        Min = tempMin,
                        Name = tempName,
                        PartID = tempID,
                        Price = tempPrice,
                        CompanyName = tempCompanyName
                    };
                    Inventory.UpdatePart(tempID, outsourcedPart);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
