using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DIEMHV
    {
        private double diemVan, diemToan, diemHoa;
        string nameHV;
        Random random = new Random();

        void kiemtraDiem(ref double diem, string tenMON)
        {
            while (true)
            {
                try
                {
                    Console.Write("diem {0}: ", tenMON);
                    diem = random.Next(1, 10);
                    //diem = double.Parse(Console.ReadLine());          
                    if (diem < 0 || diem > 10)
                    {
                        Console.WriteLine("chi nhap trong dan 1 -> 10");
                    }
                    else
                        return;
                }
                catch
                {
                    Console.WriteLine("nhap sai kieu du lieu");
                }
            }

        }

        public void Nhap()
        {
            Console.Write("nhap ten: ");
            nameHV = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.Write("diem HOA: ");
                    diemHoa = double.Parse(Console.ReadLine());
                    if (diemHoa < 0 || diemHoa > 10)
                    {
                        Console.WriteLine("chi nhap trong dan 1 -> 10");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("nhap sai kieu du lieu");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("diem TOAN: ");
                    diemToan = double.Parse(Console.ReadLine());
                    if (diemToan < 0 || diemToan > 10)
                    {
                        Console.WriteLine("chi nhap trong dan 1 -> 10");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("nhap sai kieu du lieu");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("diem HOA: ");
                    diemHoa = double.Parse(Console.ReadLine());
                    if (diemHoa < 0 || diemHoa > 10)
                    {
                        Console.WriteLine("chi nhap trong dan 1 -> 10");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("nhap sai kieu du lieu");
                }
            }

        }

        public void nhap2()
        {
            Console.Write("nhap ten: ");
            //nameHV = Console.ReadLine();
            string[] tenArr = new string[] {"ha", "hoa", "han"};
            string[] hoArr = new string[] { "ha", "hoa", "han" };
            //ten = ("ha", "hoa", "han");
            nameHV = "";

            //diemHoa = double.Parse(Console.ReadLine());
            kiemtraDiem(ref diemHoa, "HOA");
            //diemToan = double.Parse(Console.ReadLine());
            kiemtraDiem(ref diemToan, "TOAN");
            //diemVan = double.Parse(Console.ReadLine());
            kiemtraDiem(ref diemVan, "VAN");
        }

        public void diemtrungbinh()
        {
            Console.WriteLine("diem trung binh: " + (diemVan + diemToan + diemHoa) / 3);
        }
        public void xuat()
        {
            Console.WriteLine("\n");
            Console.WriteLine("ten HOCVIEN " + nameHV);
            Console.WriteLine("diem HOA: " + diemHoa);
            Console.WriteLine("diem TOAN: " + diemToan);
            Console.WriteLine("diem VAN: " + diemVan);
        }
    }
   
}
