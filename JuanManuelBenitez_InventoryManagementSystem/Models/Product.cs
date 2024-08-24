using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanManuelBenitez_InventoryManagementSystem.Models
{
    internal class Product
    {
        // List of associated parts for the product
        BindingList<Part> AssociatedParts = new BindingList<Part>();


        // Product properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // Method to add an associated part to the product
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        // Method to remove an associated part from the product
        public void RemoveAssociatedPart(Part part)
        {
            AssociatedParts.Remove(part);
        }

        // Method to lookup an associated part by its ID
        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
