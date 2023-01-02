using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Dasar
{
    public class Logic02Soal05
    {
        public Logic02Soal05()
        {

        }
        public static void CetakData(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    if (j <= 2)
                    {
                        arr[j]=1;
                    }
                    else
                    {
                        arr[j] = arr[j - 1] + arr[j - 2] + arr[j-3];
                    }
                    if (j<=i&&j<=n-i-1 || j>=i&&j>=n-i-1)
                    //if (j <= i && j <= n / 2 && i <= n / 2 || j >= i && j >= n / 2 && i >= n / 2 || j <= i && i >= n/2 && j<=n-i-1 || j >= i && i <= n / 2 && j >=n - i - 1)
                    {
                        Console.Write(arr[j] + "\t");
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
