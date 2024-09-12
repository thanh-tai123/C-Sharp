using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_OOP
{
    class KySu: CanBo
    {
        public string NganhDaoTao { get; set; }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Nganh: {NganhDaoTao}");
        }
    }
}
