using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_OOP
{
    class CanBo
    {
        public String hoTen {  get; set; }
        public int tuoi { get; set; }
        public String gioiTinh { get; set; }
        public String diaChi { get; set; }
        public virtual void HienThi()
        {
            Console.WriteLine($"Ho ten: {hoTen}, tuoi: {tuoi}, gioiTinh: {gioiTinh}, diachi: {diaChi}");
        }

    }
}
