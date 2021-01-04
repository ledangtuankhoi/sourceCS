using System;
using myfile;
using home;

namespace demo
{
    class Program : Log 
    {
        private const string Format = "hahahahah: {0} {1}";


        static void Main(string[] args)
        {
            // Console.WriteLine("hello even!");
            // Publisher nhasanxuat = new Publisher();
            // nhasanxuat.Send();
            Publisher p = new Publisher();
            SubscriberA sa = new SubscriberA();
            SubscriberB sb = new SubscriberB();

            sa.Sub(p);
            sb.Sub(p);

            p.Send();

            hamtuhuy vectorsd = new hamtuhuy(2,3);
            hamtuhuy vectorer = new hamtuhuy(4,2);
            hamtuhuy v12 = vectorer + vectorsd;
            v12.showlog;try
            {
                
            }
            catch (System.Exception)
            {
                
                throw;
            }


            Console.ReadKey();
        }
    }
}
