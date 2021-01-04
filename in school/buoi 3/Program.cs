using System;

namespace Program
{
    class Date_07122020
    {
        static void bangcuuchuong(int a, int b)
            // tu a den b
        {
            int i = a;
            
            do
            {
                int j = 1;
                //i ++;
                do
                {

                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                    j++;
                } while (j <= 9);
                i++;
                Console.WriteLine();
            } while (i <= b);
        }
        public static void Main()
        {
            Console.WriteLine("hello word!");
            //bangcuuchuong(8,9);
            sort sapxepchon = new sort(3);
            sapxepchon.select_sort();
            Console.ReadKey();
        }
        public static void Sort()
        {
            
        }
    }
    class sort
    {
        int[] arry;
        public sort(int size)
        {
            arry = new int[size];
            Random random = new Random();
            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = random.Next(0, 99);
            }
        }
        void hoanvi(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        void Outarry()
        {
            for (int i = 0; i < arry.Length; i++)
            {
                Console.Write(arry[i] + " ");
            }
        }
        public void select_sort()
        {
            int  minAD ;
            for (int i = 0; i < arry.Length; i++)
            {
                minAD = i;
                for (int j = i + 1; j < arry.Length; j++)
                {
                    if (arry[j] < arry[minAD])
                    {
                        minAD = j;
                    }
                   hoanvi(i, minAD);
                }
                Outarry();
                Console.WriteLine();
            }

        }
    }
}