using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LESSON_2.BaiTapCoBan.Bai1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public Person(string Name, int Age, string Adress)
        {
            this.Name = Name;
            this.Age = Age;
            this.Adress = Adress;
        }
        public virtual void HienThi()
        {
            Console.WriteLine($"Ho ten: {Name}, tuoi: {Age}, diachi: {Adress}");
        }
    }
}
