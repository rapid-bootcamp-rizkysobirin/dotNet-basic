using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorurial.Model;

public class Category
{
    public String CategoryName { get; set; }
    public int Count { get; set; }

    public Category(string categoryName, int count)
    {
        this.CategoryName = categoryName;
        this.Count = count;
    }

    public override string ToString()
    {
        return "Category { Name: " + this.CategoryName + " Jumlah: " + this.Count + "}";
    }

    public static List<Category> GetData()
    {
        List<Category> categories = new List<Category>()
        {
            new Category("Hewan", 300),
            new Category("Pesawat", 600),
            new Category("Ikan", 800)
        };
        return categories;
    }

    public static void SampleFilterCategory()
    {
        //List<Category> categories = GatData();
        //IEnumerable<Category> categoryFilter = from item in categories
                                               //where item.Count <= 600
                                               //select item;

        //foreach (Category category in categoryFilter)
        //{
        //    Console.WriteLine(category);
        //}
    }
}
