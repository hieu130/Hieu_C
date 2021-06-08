using System;

namespace Project_hieu.Properties.lab
{
    public class Diamond : Product
    {
        public int cara;

        public Diamond()
        {
        }

        public Diamond(int cara)
        {
            this.cara = cara;
        }

        public Diamond(int id, string name, float price, int qty, int image, int desc, int cara) : base(id, name, price, qty, image, desc)
        {
            this.cara = cara;
        }

        public void Test()
        {
            if(cara > 1.7)
            {
                Console.WriteLine("Real");
            }
            else
            {
                Console.WriteLine("Fake");
            }
        }
        
    }
}