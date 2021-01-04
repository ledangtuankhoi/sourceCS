using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18607077_ledangtuankhoi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //luôn luôn sử dụng context để làm việc với các class
            Model1 context = new StudentContextDB();
            //1. lấy tất cả các sinh viên từ bảng Student
            List<Student> listStudent = context.Students.ToList();
            //2. lấy sinh viên đầu tiên có StudentID = ID cho trước
            Student db = context.Students.FirstOrDefault(p => p.StudentID == ID);
            //3. insert 1 đối tượng sinh viên s vào database  
        }
    }
}
