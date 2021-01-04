using System;

namespace home{
    public partial class hocsinh2{
        string MaHS = "ma  hoc sinh";
    }
    public class hamtuhuy{
        public static int hamtuhuy operator+(valfist a, valfist b){
            double sx = a.x + b.x;
            double sy = a.x + b.y;
            hamtuhuy v = new hamtuhuy(sx,sy);
            reutrn v;
        }
    }
}
