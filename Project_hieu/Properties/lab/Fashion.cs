using System;

namespace Project_hieu.Properties.lab
{
    public class Fashion : Product
    {
        public string color;
        public string size;

        public Fashion()
        {
        }

        public Fashion(string color, string size)
        {
            this.color = color;
            this.size = size;
        }

        public Fashion(int id, string name, float price, int qty, int image, int desc, string color, string size) :
            base(id, name, price, qty, image, desc)
        {
            this.color = color;
            this.size = size;
        }

        public void checkProduct()
        {
        }

        public void checkQty()
        {
            if (qty > 0)
            {
                Console.WriteLine("San Pham Con Hang");
            }
            else
            {
                Console.WriteLine("San Pham Het Hang");
            }
        }

        public void checkInfoPro()
        {
            if (color == "Xanh" && size == "L")
            {
                Console.WriteLine("San Pham Co Trong Kho");
            }

            Console.WriteLine("San Pham Khong Co Trong Kho");

        }
    }
}