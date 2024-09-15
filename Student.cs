using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Age { get; set; } 

        public void Input()
        {
            Console.Write("Nhập mã số: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Nhập tên: ");
            Name = Console.ReadLine();

            Console.Write("Nhập tuổi: ");
            Age = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"Mã số: {this.Id}, Tên: {this.Name}, Tuổi: {this.Age}");
        }
    }
}

