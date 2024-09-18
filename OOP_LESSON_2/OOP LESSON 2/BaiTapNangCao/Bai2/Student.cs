using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_2.BaiTapNangCao.Bai2
{
    class Student : IStudent
    {
        public string studentid { get; set; }
        public string name { get; set; }
        private decimal grade { get; set; }
        public Student(string studentid, string name, decimal grade)
        {
            this.studentid = studentid;
            this.name = name;
            this.grade = grade;
        }

        public void updateDiem(decimal newDiem)
        {
            if (newDiem < 0 || newDiem > 10)
            {
                Console.WriteLine("Cap nhat diem khong hop le");
            }
            else
            {
                grade = newDiem;
                Console.WriteLine("Diem sau khi cap nhat " + grade);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Ma Sinh Vien: {studentid}, Ten sinh vien: {name}, diem: {grade}");
        }


    }
}
