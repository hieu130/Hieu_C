using System;

namespace Project_hieu.Properties.practical
{
    
        public delegate int PrimeNumberFinder(int n);
        public class Prime{
            public event PrimeNumberFinder OnPrimeNumber;
            private int n;
            public static bool FindPrime(int n)
            {
                if (n < 2) return false;
                if (n < 3) return true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                    if (n % i == 0) return false;
                return true;
            }
    }
}