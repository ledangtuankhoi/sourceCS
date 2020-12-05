using System;

namespace myfile{
    public class tuankhhoi{
        public static int solon(int n){
            return n * n;
        }
    }
    public class Log{
        public delegate void ShowLog(string mesage);

        static public void Info(string s){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", s));
            Console.ResetColor();
        } 

        static public void waring (string s){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("waring: {0}", s));
            Console.ResetColor();
        }
        static int sum(int a, int b ){
            return a + b;
        }
        public static void tinhtongTest(int x, int y)
        {   
            Func<int, int, int> tinhtong;
            tinhtong = sum;
            var ketqua = tinhtong(x, y);
            Console.WriteLine(ketqua);
        }   

    }

}
namespace home{
    public class tuankhoi{
        public static int sonho(int n = 10, int a = 1 ){
            return n * a;
        }
    }
    public class Vukhi{
        public string name = "ten vu khi";
        int dosatthuong = 0;
        public Vukhi(){
            this.dosatthuong = 1;
        }
        public Vukhi(string name, int dosatthuong){
            this.name = name;
            this.Setdosatthuong(dosatthuong);
        }
        public void Setdosatthuong(int mucdo){
            this.dosatthuong = mucdo;
        }
        public void tancong(){
            Console.Write(name + " ");
            for (int i = 0; i < dosatthuong; i++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}