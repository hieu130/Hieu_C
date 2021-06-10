using System;

namespace Project_hieu.Properties.practical
{
    public class MobilePhone : Phone
    {
        public MobilePhone(string phoneName, string phoneType, float phonePrice) : base(phoneName, phoneType, phonePrice)
        {
        }

        public void Display()
        {
            Console.WriteLine("Phone: "+phoneName+", type "+phoneType+", price "+phonePrice);

        }
    }
}