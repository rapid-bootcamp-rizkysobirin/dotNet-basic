﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Dasar
{
    public class Logic02Soal07
    {
        public Logic02Soal07() 
        { 
            
        }

        public static void CetakData(int n)
        {
            int[] arr = new int[n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<n; j++)
                {
                    if (j<=1)
                    {
                        arr[j] = 1;
                    }
                    else
                    {
                        arr[j] = arr[j - 1] + arr[j - 2];
                    }

                    if (j<=n/2 && j>=n-i-1 || j >= n / 2 && j <= n - i - 1 || j<=n-i-1 && j<=n/2)
                    {
                        Console.Write(arr[i] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    
                }
                Console.WriteLine("\n");
            }
        }
    }
}
