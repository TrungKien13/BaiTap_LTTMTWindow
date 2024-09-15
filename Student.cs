using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan2
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;

        public Student()
        {
        }

        public Student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

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

