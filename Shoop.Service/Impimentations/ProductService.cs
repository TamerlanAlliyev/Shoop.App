using Shoop.Core.Models;
using Shoop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shoop.Service.Impimentations
{
    public class ProductService : IProductService
    {
        Product[] Products = { };

     
        public void CreateProduct()
        {
            Console.WriteLine("Add Name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Add Price :");
            double Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Add Catagory :");
            string Catagory = Console.ReadLine();
            Console.WriteLine("Add Stock Count");
            int StockCount = int.Parse(Console.ReadLine());


            Product product = new();
            product.Name = Name;
            product.Price=Price;
            product.Catagory = Catagory;
            product.StockCount = StockCount;
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public void ShowProduct()
        {
           for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine(Products[i]);
            }
        }

        public void GetProductById()
        {

        }

        public string ValidateString(string data)
        {
            while (string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("pleasa add valid value");
                data = Console.ReadLine();
            }
            return data;
        }

        public void ShowMenu()
        {
            Console.WriteLine("1.Create student");
            Console.WriteLine("2.Show students");
            Console.WriteLine("0.close");
        }

    }
}
