using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorurial
{
    public class IntroLinq
    {
        public IntroLinq() { 
        }
        public static void Introduction()
        {
            // Specify the data source.
            int[] scores = { 97, 92, 81, 60,83,66,88,85 };

            //ini tanpa linq 
            //for untuk filter
            List<int> listScore = new List<int>();
            for(int i=0; i<scores.Length; i++)
            {
                if (scores[i] > 88)
                {
                    listScore.Add(scores[i]);
                }
            }
            
            //LazyInitializer dengan linq
            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 88
                select score;


            //for untuk menampilkan
            // Execute the query.
            foreach (int i in listScore)
            {
                Console.Write(i + " ");
            }
            foreach (int j in scoreQuery)
            {
                Console.Write(j + " ");
            }

            // Output: 97 92 81
        }
    }
}
