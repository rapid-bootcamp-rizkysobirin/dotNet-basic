﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Dasar
{
    public class Logic02Soal03
    {
        public Logic02Soal03() 
        { 
        }
        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++) 
            {
                int angka = 0;
                for (int j=0; j<n; j++)
                {
                    if(i==0 || j==0 || i==n-1 || j==n-1 || i==j || i + j == n - 1)
                    {
                        Console.Write(angka + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    angka += 2;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
