using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexJonesInventorySystem.Classes
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        static Inventory()
        {
            Product product1 = new Product() { ProductId = 1, Name = "GameStation 5", Price = 499.99m, InStock = 1, Min = 0, Max = 10 };
            Product product2 = new Product() { ProductId = 2, Name = "Gamebox Series X", Price = 399.99m, InStock = 5, Min = 0, Max = 15 };
            Product product3 = new Product() { ProductId = 3, Name = "Gametendo Switch", Price = 299.99m, InStock = 10, Min = 0, Max = 12 };
            Product product4 = new Product() { ProductId = 4, Name = "Gamecast VR", Price = 599.99m, InStock = 2, Min = 0, Max = 5 };

            Products.Add(product1);
            Products.Add(product2);
            Products.Add(product3);
            Products.Add(product4);

            Outsourced part1 = new Outsourced() { PartID = 1, Name = "Console", Price = 299.99m, InStock = 1, Min = 0, Max = 10, CompanyName = "Fony" };
            Outsourced part2 = new Outsourced() { PartID = 2, Name = "Controller", Price = 69.99m, InStock = 5, Min = 0, Max = 15, CompanyName = "Games R Us" };
            Inhouse part3 = new Inhouse() { PartID = 3, Name = "Download code", Price = 79.99m, InStock = 10, Min = 0, Max = 12, MachineId = 0 };
            Inhouse part4 = new Inhouse() { PartID = 4, Name = "Memory Card", Price = 199.99m, InStock = 2, Min = 0, Max = 5, MachineId = 1 };

            AllParts.Add(part1);
            AllParts.Add(part2);
            AllParts.Add(part3);
            AllParts.Add(part4);
        }

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int searchId)
        {
           bool result = false;
           foreach(Product p in Products)
            {
                
                if (searchId == p.ProductId)
                {
                    Products.Remove(p);
                    result = true;
                }
                else
                {
                    MessageBox.Show("Error: Removal Failed.");
                    result = false;
                }  
            }
            return result;
        }

        public static Product LookupProduct(int searchId)
        {
            foreach (Product p in Products)
            {
                if (searchId == p.ProductId)
                {
                    return p;
                }
            }
            Product emptyProduct = new Product();
            return emptyProduct;
        }

        public static void UpdateProduct(int prodId, Product updatedProduct)
        {
            foreach (Product p in Products)
            {
                if (p.ProductId == prodId)
                {
                   p.Name = updatedProduct.Name;
                   p.InStock = updatedProduct.InStock;
                   p.Price = updatedProduct.Price;
                   p.Max = updatedProduct.Max;
                   p.Min = updatedProduct.Min;
                   p.AssociatedParts = updatedProduct.AssociatedParts;  
                }
            }
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }

        public static Part LookupPart(int searchId)
        {
            foreach(Part p in AllParts)
            {
                if( p.PartID == searchId )
                {
                    return p;
                }
            }
            Part emptyPart = new Inhouse();
            return emptyPart;
        }

        public static void AddPart(int searchId, Part part)
        {
            DeletePart(searchId);
            AddPart(part);
        }

        public static bool HasSpecial(string s1, string s2, string s3, string s4)
        {
            var regexItem = new Regex(@"^*[0-9\.]+$");
            if (regexItem.IsMatch(s1) && regexItem.IsMatch(s2) && regexItem.IsMatch(s3) && regexItem.IsMatch(s4))
            {
                return false;
            }
            else return true;
        }
        
    }
}
