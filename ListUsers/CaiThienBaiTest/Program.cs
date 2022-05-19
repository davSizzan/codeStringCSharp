using System;
using System.Collections.Generic;
using System.Numerics;

namespace CaiThienBaiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] ar = new BigInteger[] { 6, 4, 2, 7, 2, 9, 12 };
            int n = 5;
            BigInteger sum = new BigInteger(0);
            for(int i=0; i<n;i++)
            {
                sum += ar[i];
            }
            Console.WriteLine(sum);
        }
    }
}
