using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            //string a = "23", h = "34";
            //string name = "{0} + {1}", a, h;
            //Console.WriteLine(name);

            Random random = new Random();
            animal dog = new animal();
            dog.CanNang = random.Next(1,99);
            dog.ChieuCao = random.Next(1, 99);
            Console.WriteLine("thong tin cua cho:");
            dog.Info();
            dog.run();

            Console.WriteLine("\n");
            animal cat = new animal();
            cat.CanNang = random.Next(1, 99);
            cat.ChieuCao = random.Next(1, 99);
            Console.WriteLine("thong tin cua meo1:");
            cat.Info();
            cat.run();

            Console.WriteLine("\n");

            Console.WriteLine("\n");
            animal cat1 = new animal();
            cat1.CanNang = random.Next(1, 99);
            cat1.ChieuCao = random.Next(1, 99);
            Console.WriteLine("thong tin cua meo1:");
            cat1.Info();
            cat1.run();

            Console.WriteLine("\n");

            animal dog1 = new animal();
            dog1.CanNang = random.Next(1, 99);
            dog1.ChieuCao = random.Next(1, 99);
            Console.WriteLine("thong tin cua cho1:");
            dog1.Info();
            dog1.run();


            DIEMHV hocvien = new DIEMHV();
            //hocvien.Nhap();
            hocvien.nhap2();
            hocvien.xuat();
            hocvien.diemtrungbinh();

          

            Console.ReadKey();
        }
    }
}
