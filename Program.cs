﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> DSHS = new List<Student>
            {
                new Student { Id = 1, Name = "An", Age = 17 },
                new Student { Id = 2, Name = "Bình", Age = 16 },
                new Student { Id = 3, Name = "Anh", Age = 18 },
                new Student { Id = 4, Name = "Dương", Age = 15 },
                new Student { Id = 5, Name = "Cường", Age = 20 }
            };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sách toàn bộ học sinh:");
            foreach (var hs in DSHS)
            {
                Console.WriteLine($"ID: {hs.Id}, Tên: {hs.Name}, Tuổi: {hs.Age}");
            }

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            var HSAge15den18 = DSHS.Where(hs => hs.Age >= 15 && hs.Age <= 18);
            Console.WriteLine("\nDanh sách học sinh có tuổi từ 15 đến 18:");
            foreach (var hs in HSAge15den18)
            {
                Console.WriteLine($"ID: {hs.Id}, Tên: {hs.Name}, Tuổi: {hs.Age}");
            }

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            var HSNameA = DSHS.Where(hs => hs.Name.StartsWith("A"));
            Console.WriteLine("\nDanh sách học sinh có tên bắt đầu bằng chữ 'A':");
            foreach (var hs in HSNameA)
            {
                Console.WriteLine($"ID: {hs.Id}, Tên: {hs.Name}, Tuổi: {hs.Age}");
            }

            // d. Tính tổng tuổi của tất cả học sinh trong danh sách
            var tongTuoi = DSHS.Sum(hs => hs.Age);
            Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {tongTuoi}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            var HSAgeMax = DSHS.OrderByDescending(hs => hs.Age).First();
            Console.WriteLine($"\nHọc sinh có tuổi lớn nhất: ID: {HSAgeMax.Id}, Tên: {HSAgeMax.Name}, Tuổi: {HSAgeMax.Age}");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var danhSachSapXep = DSHS.OrderBy(hs => hs.Age);
            Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
            foreach (var hs in danhSachSapXep)
            {
                Console.WriteLine($"ID: {hs.Id}, Tên: {hs.Name}, Tuổi: {hs.Age}");
            }
            Console.ReadKey();  
        }
    }
}
