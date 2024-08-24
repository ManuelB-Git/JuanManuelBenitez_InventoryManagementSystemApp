using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            Part existingPart = LookupPart(partID);
            if (existingPart != null)
            {
                existingPart.Name = part.Name;
                existingPart.Price = part.Price;
                existingPart.InStock = part.InStock;
                existingPart.Min = part.Min;
                existingPart.Max = part.Max;
            }
        }

        //Product
        // Method to update a product in the inventory
        public static void UpdateProduct(int productID, Product product)
        {
            Product existingProduct = LookupProduct(productID);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.InStock = product.InStock;
                existingProduct.Min = product.Min;
                existingProduct.Max = product.Max;
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
