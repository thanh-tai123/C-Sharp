using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_OOP
{
    class CongNhan : CanBo
    {
        public int Bac;
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bac: {Bac}");
        }
    }
}
