using System;

namespace Project_hieu.Properties.practical
{
    public class Phone
    {
        protected string phoneName;
                protected string phoneType;
                protected float phonePrice;
        
                public Phone(string pn, string pt, float pp)
                {
                    this.phoneName = pn;
                    this.phoneType = pt;
                    this.phonePrice = pp;
                }
        
                public string PhoneName
                {
                    get => phoneName;
                    set => phoneName = value;
                }
        
                public string PhoneType
                {
                    get => phoneType;
                    set => phoneType = value;
                }
        
                public float PhonePrice
                {
                    get => phonePrice;
                    set => phonePrice = value;
                }
        
                public void Display()
                {
                    Console.WriteLine("Phone: "+phoneName+", type "+phoneType+", price "+phonePrice);
                }
            }
    }