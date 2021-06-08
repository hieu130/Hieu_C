using System;
using System.Collections.Generic;

namespace Project_hieu.Properties.lab
{
    public class Product
    {
        
            public int id;
            public string name;
            public float price;
            public int qty;
            public int image;
            public int desc;
            public List<string> Gallery;

            public Product()
            {
            }

            public Product(int id, string name, 
                float price, int qty, int image, int desc)
            {
                this.id = id;
                this.name = name;
                this.price = price;
                this.qty = qty;
                this.image = image;
                this.desc = desc;
            }

            public void GetInfo()
            {
                Console.WriteLine("ID : " + id);
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Price : " + price );
                Console.WriteLine("Quantity : " + qty);
                Console.WriteLine("Image : " + image);
                Console.WriteLine("Descending : " + desc);
            }

            public bool CheckQty()
            {
                if (qty > 0)
                {
                    Console.WriteLine("San Pham Con Hang");
                    return true;
                }
                Console.WriteLine("San Pham Het Hang");
                return false;
            

            }

            public void ImageAdd(string img)
            {
                if (image <= 10)
                {
                    Gallery.Add(img);
                }
                else
                {
                    Console.WriteLine("So Anh Da Lon Hon 10, Yeu Cau Xoa Bot");
                }
          
            }

            public void RemoveImage(int index)
            {
                Console.WriteLine("Danh sach anh truoc khi xoa: ");
                Gallery = new List<string>()
                    {"anh1", "anh2", "anh3"};
                foreach (var imageOfGallery in Gallery)
                {
                    Console.WriteLine($"{imageOfGallery}");
                }
                Console.WriteLine("Danh sach sau khi xoa: ");
                Gallery.RemoveAt(index);
            }

        }
    }
    