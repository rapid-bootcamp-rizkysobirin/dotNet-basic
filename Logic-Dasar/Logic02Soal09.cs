using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logic_Dasar
{
    public class Logic02Soal09
    {
        public Logic02Soal09() 
        { 
            
        }

        public static void CetakData(int n)
        {
            int nilaiTengah = n / 2;
            for (int i=0; i<n; i++)
            {
                int num = 1;
                for (int j=0; j<n; j++)
                {
                    if (j - i <= nilaiTengah && i - j <= nilaiTengah && i + j >= nilaiTengah && i + j <= nilaiTengah + n - 1)
                    {
                        if (j < nilaiTengah)
                        {
                            Console.Write(num + "\t");
                            num += 2;
                        }
                        else
                        {
                            Console.Write(num + "\t");
                            num -= 2;
                        }
                    }
                    else { Console.Write("\t"); }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
