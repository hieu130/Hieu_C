using System;
using System.Threading;

namespace Project_hieu.Properties.session5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(Run20Times);
            t1.Start();
            Thread t2 = new Thread( new Program().Show20Times);
            t2.Start();
        }

        public static void Run20Times()
        {
            for (int i = 0 ; i < 20 ; i++)
            {
                Console.WriteLine("Running ....." +i);
                try
                {
                    Thread.Sleep(1000);
                }catch (Exception e){}
            }
        }

        public void Show20Times(object o)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Show.... "+i);
                try
                {
                    Thread.Sleep(1000);
                }catch (Exception e){}
            }
        }
    }
}