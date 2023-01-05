using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorurial.Model;
public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Product(String name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    public override string ToString()
    {
        return "Product { Name: " + this.Name + " Price: Rp. " + this.Price + "}";
    }

    public static List<Product> GetData()
    {
        List<Product> products = new List<Product>()
        {
            new Product("Cuma Mie", 1000),
            new Product("Ya Mie", 4000),
            new Product("Mie Lagi",9000),
            new Product("Jus Biasa", 4000),
            new Product("Jus Ayam",9000)
        };

        return products;
    }


    public static void SampleFilterProduct()
    {

        //1. buat data csource
        List<Product> products = GetData();

        //2. buat query
        IEnumerable<Product> productFilter = from item in products
                                             where item.Price >= 3000
                                             select item;

        //3. eksekusi
        foreach(var product in productFilter)
        {
            Console.WriteLine(product);
        }
    }

    public static void SampleFilterByName()
    {
        List<Product> products = GetData();

        IEnumerable<Product> productFilter = from product in products
                                             where product.Name.ToLower().Contains("jus")
                                             select product;
        foreach(var product in productFilter)
        {
            Console.WriteLine(product);
        }
    }
}


