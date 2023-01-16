using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logic_Dasar
{
    public class Logic02Soal10
    {
        public Logic02Soal10() 
        { 
            
        }

        public static void CetakData(int n)
        {
            int nilaiTengah = n / 2;
            int[] numbers = new int[n];
            int startNum = 1 + (nilaiTengah + 1) * 2;
            for (int i = 0; i < n; i++)
            {
                if (i <= nilaiTengah)
                {
                    startNum -= 2;
                    numbers[i] = startNum;
                }
                else
                {
                    startNum += 2;
                    numbers[i] = startNum;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j - i >= nilaiTengah)
                    {
                        Console.Write(numbers[j - i] + "\t");
                    }
                    else if (i - j >= nilaiTengah)
                    {
                        Console.Write(numbers[n - 1 - i + j] + "\t");
                    }
                    else if (i + j <= nilaiTengah)
                    {
                        Console.Write(numbers[j + i] + "\t");
                    }
                    else if (i + j >= nilaiTengah + n - 1)
                    {
                        Console.Write(numbers[i + j - n + 1] + "\t");
                    }
                    else { Console.Write("\t"); }
                }
                Console.WriteLine("\n");
            }

        }
    }
}
