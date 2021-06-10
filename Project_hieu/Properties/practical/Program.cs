using System;

namespace Project_hieu.Properties.practical
{
    public class Program
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Phone p = new Phone("Viettell", "viettel", 200);
                p.Display();
                Console.WriteLine("_");
                MobilePhone mobile = new MobilePhone("Viettel", "Viettel", 100);
                mobile.Display();
            }
        }
    }
}