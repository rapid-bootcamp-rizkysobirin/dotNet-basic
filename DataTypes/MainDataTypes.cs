using System;
namespace DataTypes
{
    public class MainDataType
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
            // Declaration with initializers (four examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 ,6,7,8,9,10,11,12,13,14,15,16,18,21};
            //contoh penggunaan linQ
            var query = from item in source
                        where item <= limit //3
                        select item;

            Console.WriteLine("Query Result :" + query);
            foreach (var item in query)
            {
                Console.WriteLine("Item Value :" +item);
            }

            var query2 = from item in source
                        where item % 2 ==1 //3
                        select item;

            Console.WriteLine("Query item with odd");
            foreach (var item in query2)
            {
                Console.WriteLine("Item Value :" + item);
            }

            var query3 = from item in source
                         where item % 2 == 0 //3
                         select item;

            Console.WriteLine("Query item with even");
            foreach (var item in query3)
            {
                Console.WriteLine("Item Value :" + item);
            }

            var query4 = from item in source
                         where item % 3 == 0 //3
                         select item;

            Console.WriteLine("Query item with multiple 3");
            foreach (var item in query4)
            {
                Console.WriteLine("Item Value :" + item);
            }
        }
    }
}


