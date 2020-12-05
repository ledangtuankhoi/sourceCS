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
            Console.WriteLine("Hello World!");
            /*
            int n = 8;
            // int n = int.Parse(Console.ReadLine());
            Console.WriteLine(tuankhhoi.solon(n));

            Console.WriteLine(tuankhoi.sonho(n));
            Console.WriteLine(value: tuankhoi.sonho(n,2));

            //log delegate
            myfile.Log.ShowLog showlog;
            // showlog = Log.Info; 
            // showlog("hello tuan khoi");
            // Console.WriteLine(showlog);
            // showlog = Log.waring;
            
            // showlog("hello word");
            showlog = null;
            showlog += Log.Info;
            showlog += Log.waring;
            showlog("hello");
            Log.ShowLog showlog1 = (x) => Console.WriteLine(string.Format("<---{0}--->", x));
            var all = showlog1 + showlog + showlog1;
            all("hi");
            tinhtongTest(5,6);
            Action<string> showaas = null;
            showaas = Info;
            showaas("kkk");
            // tinhtongTest2();
            // TestTinhTong33("hahah");
            int? nul1 = null;
            // int? nul3 = true;
            // Console.WriteLine(Format, nul1);
            */
            // class member
            var sungluc = new Vukhi();
            sungluc.name = "Sungs Lucj";
            sungluc.Setdosatthuong(5);
            var sungtruong = new Vukhi();
            sungtruong.name = "Sung truong";
            sungtruong.Setdosatthuong(10);

            sungluc.tancong();
            sungtruong.tancong();


            // Console.ReadKey();
        }
    }
}
