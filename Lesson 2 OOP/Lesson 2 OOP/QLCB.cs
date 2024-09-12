using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_OOP
{
    class QLCB
    {
        private List<CanBo> dsCanBo = new List<CanBo>();
        public void themCanBo(CanBo c)
        {
            dsCanBo.Add(c);
        }
        public CanBo Timkiem(string hoten)
        {
            return dsCanBo.Find(cb => cb.hoTen.Equals(hoten, StringComparison.OrdinalIgnoreCase));
        }
        public void hienThiDS()
        {
            foreach(var cb in dsCanBo)
            {
                cb.HienThi();
                Console.WriteLine("------------");
            }
        }
    }
}
