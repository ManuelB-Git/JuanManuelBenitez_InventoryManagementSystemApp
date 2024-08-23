using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanManuelBenitez_InventoryManagementSystem.Models
{
    internal static class Inventory
    {
        //The Data
        ////////////////////////////////////////////////
        //Part
        // List of all parts in the inventory
        public static List<Part> AllParts = new List<Part>();

        //Product
        // List of all products in the inventory
        public static List<Product> Products = new List<Product>();


        //The Add
        ////////////////////////////////////////////////
        //Part
        // Method to add a part to the inventory
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        //Product
        // Method to add a product to the inventory
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }


        //The Lookup
        ////////////////////////////////////////////////
        //Part
        // Method to lookup a part by its ID
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        //Product
        // Method to lookup a product by its ID
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }


        //The Update
        ////////////////////////////////////////////////
        //Part
        // Method to update a part in the inventory
        public static void UpdatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = part;
                }
            }
        }

        //Product
        // Method to update a product in the inventory
        public static void UpdateProduct(int productID, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = product;
                }
            }
        }


        //The Delete
        ////////////////////////////////////////////////
        //Part
        // Method to delete a part from the inventory
        public static bool DeletePart(Part part)
        {
            return AllParts.Remove(part);
        }

        //Product
        // Method to delete a product from the inventory
        public static bool DeleteProduct(Product product)
        {
            return Products.Remove(product);
        }
    }
}
