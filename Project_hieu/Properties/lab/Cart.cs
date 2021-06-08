using System;
using System.Collections.Generic;

namespace Project_hieu.Properties.lab
{
    public class Cart
    {
        private int id;
        private string customerName;
        private float grandtotal;
        private string city;
        private string country;
        public List<Product> productList = new List<Product>();

        public Cart()
        {
        }

        public Cart(int id, string customerName, float grandTotal, string address, string country)
        {
            this.id = id;
            this.customerName = customerName;
            this.grandtotal = grandtotal;
            this.city = address;
            this.country = country;
        }

        public int ID
        {
            get => id;
            set => id = value;
        }

        public string CustomerName
        {
            get => customerName;
            set => customerName = value;
        }

        public float GrandTotal
        {
            get => grandtotal;
            set => grandtotal = value;
        }

        public string Adress
        {
            get => city;
            set => city = value;
        }



        public string Country
        {
            get => country;
            set => country = value;
        }

        public Product this[int index]
        {
            get => productList[index];
            set => productList[index] = value;
        }

        public void addPro(Product pr)
        {
            if (pr.CheckQty())
            {
                productList.Add(pr);
                pr.qty--;
                grandtotal += pr.price;
                Console.Write("Them thanh cong");

            }

            Console.WriteLine("error");
        }

        public void delPro(Product pr)
        {
            if (pr.CheckQty())
            {
                productList.Remove(pr);
                pr.qty--;
                grandtotal -= pr.price;
                Console.Write("Da xoa thanh cong");
            }

            Console.WriteLine("Delete False");
        }

        public float grandTotal()
        {
            if (city == "HN" || city == "HCM")
            {
                return  (grandtotal / grandtotal * 100) - 1;
            }
            else if (city != "HN" || city != "HCM")
            {
                return  (grandtotal / grandtotal * 100) - 2;

            }
            else if (country != "VN")
            {
                return  (grandtotal / grandtotal * 100) - 5;

            }

            return  grandtotal;
        }
    }
    }