using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class animal
    {

        private double cannang;
        private double chieucao;

        public double CanNang
        {
            get { return chieucao; }
            set { cannang = value; }
        }

        public double ChieuCao
        {
            get { return chieucao; }
            set { cannang = value; }
        }
        public void run()
        {
            Console.WriteLine(" animal dang chay....");
        }

        public void Info()
        {
            Console.WriteLine("chieu cao: {0} can nang: {1}", chieucao, cannang);
        }
        public animal()
        {
            cannang = 1;
            chieucao = 1;
        }
    }
}
