

using System.Drawing;
using System.Windows.Forms;

namespace JuanManuelBenitez_InventoryManagementSystem.Utilities
{
    public static class SetPlaceHolder
    {
        public static void SetPlaceHolderText(TextBox textBox, string placeHolderText)
        {
            textBox.Text = placeHolderText;
            textBox.ForeColor = Color.Gray;

            textBox.Leave += (source, e) =>
            {
                if (textBox.Text == "")
                {
                    textBox.Text = placeHolderText;
                    textBox.ForeColor = Color.Gray;
                }
            };

            textBox.Enter += (source, e) =>
            {
                if (textBox.Text == placeHolderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };
        }

    }
}
