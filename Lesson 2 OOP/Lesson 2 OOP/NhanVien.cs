using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_OOP
{
    class NhanVien : CanBo
    {
        public string CongViec {  get; set; }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Cong Viec: {CongViec}");
        }
    }
}
