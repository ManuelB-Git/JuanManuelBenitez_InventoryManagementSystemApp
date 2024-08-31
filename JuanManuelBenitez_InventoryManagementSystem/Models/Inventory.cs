
using System.ComponentModel;


namespace JuanManuelBenitez_InventoryManagementSystem.Models
{
    internal static class Inventory
    {

        

        //The Data
        ////////////////////////////////////////////////
        //Part
        // BindingList of all parts in the inventory
        public static BindingList<Part> AllParts = new BindingList<Part>();

        //Product
        // BindingList of all products in the inventory
        public static BindingList<Product> Products = new BindingList<Product>();

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
            DeletePart(LookupPart(partID));
            AddPart(part);
        }

        //Product
        // Method to update a product in the inventory
        public static void UpdateProduct(int productID, Product product)
        {
            DeleteProduct(LookupProduct(productID));
            AddProduct(product);
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
