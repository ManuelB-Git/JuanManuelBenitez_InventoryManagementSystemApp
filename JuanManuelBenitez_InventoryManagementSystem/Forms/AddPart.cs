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
    }
}
