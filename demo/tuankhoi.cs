using System;

namespace myfile
{
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
namespace home
{
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
    public class hocsinh{
        string name = "ten hoc sinh";
        // string maHS = "ma hoc sinh";
        public string Name{
            set{
                Console.WriteLine("ghi du lieu: " + value);
                name = value;
            }
            get{
                return "tem la; " + name;
            }
        }
        
    }
    public partial class hocsinh2{
        
        public string Mahs{
            set{
                
                Console.WriteLine("ghi du lieu: " + MaHS);
                MaHS = value;
            }
            get{
                return "ten laf: " + MaHS;
            }
        }
    }
    public class dynamicVSanonymous{
        public dynamicVSanonymous(){
            var vodanh = new {
                name = "vodanh",
                age = 15
            };

            var vodanh2 = vodanh;
            // vodanh2.name = "vodanh 2";
            Console.WriteLine(vodanh2);
        }
        public void Dynamic2(dynamic dvar ){
            Console.WriteLine(dvar.age);    
        }
        
    }
    /*
        Publisher là lớp phát đi sự kiện, bằng cách gọi
        một deleage trong phương thức Send
    */
    public class Publisher {
        public delegate void NotifyNews (object data);

        public NotifyNews event_news;

        public void Send () {
            event_news?.Invoke ("Co tin moi");
        }
    }

    // SubscriberA lớp này đăng ký nhận sự kiện từ Publisher,
    // bằng phương thức Sub, khi sự kiện xảy ra nó sẽ gọi ReceiverFromPublisher
    public class SubscriberA {
        public void Sub (Publisher p) {
            p.event_news = null;
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher (object data) {
            Console.WriteLine ("SubscriberA: " + data.ToString ());
        }
    }

    // SubscriberA lớp này đăng ký nhận sự kiện từ Publisher,
    // bằng phương thức Sub - khi đăng ký nó hủy việc nhận sự kiện của các đối tượng khác,
    // khi sự kiện xảy ra nó sẽ gọi ReceiverFromPublisher
    public class SubscriberB {
        public void Sub (Publisher p) {
            p.event_news = null;  // Hủy các đối tượng khác nhận sự kiện
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher (object data) {
            Console.WriteLine ("SubscriberB: " + data.GetHashCode());
        }
    }
}