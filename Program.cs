using System;
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
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập số lượng học sinh: ");
            int soLuongHocSinh = int.Parse(Console.ReadLine());

            List<Student> danhSachHS = new List<Student>();

            for (int i = 0; i < soLuongHocSinh; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho học sinh thứ {i + 1}:");
                Student student = new Student();
                Student hs = student;
                hs.Input(); 
                danhSachHS.Add(hs);
            }

            // In danh sách học sinh
            Console.WriteLine("\nDanh sách toàn bộ học sinh:");
            foreach (var hs in danhSachHS)
            {
                hs.Show();
            }

            TimHSTheoTuoi(danhSachHS, 15, 18);

            TimHSTheoTen(danhSachHS, "A");

            TinhTongTuoi(danhSachHS);

            TimHSTuoiLonNhat(danhSachHS);

            SapXepHSTheoTuoi(danhSachHS);
        }

        // Tìm học sinh theo độ tuổi
        static void TimHSTheoTuoi(List<Student> ds, int tuoiMin, int tuoiMax)
        {
            var hocSinhTuoiThichHop = ds.Where(hs => hs.Age >= tuoiMin && hs.Age <= tuoiMax);
            Console.WriteLine($"\nHọc sinh có tuổi từ {tuoiMin} đến {tuoiMax}:");
            foreach (var hs in hocSinhTuoiThichHop)
            {
                hs.Show();
            }
        }

        // Tìm học sinh có tên bắt đầu bằng ký tự
        static void TimHSTheoTen(List<Student> ds, string kyTu)
        {
            var hocSinhTenBatDauBang = ds.Where(hs => hs.Name.StartsWith(kyTu));
            Console.WriteLine($"\nHọc sinh có tên bắt đầu bằng chữ '{kyTu}':");
            foreach (var hs in hocSinhTenBatDauBang)
            {
                hs.Show();
            }
        }

        // Tính tổng tuổi học sinh
        static void TinhTongTuoi(List<Student> ds)
        {
            var tongTuoi = ds.Sum(hs => hs.Age);
            Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {tongTuoi}");
        }

        // Tìm học sinh có tuổi lớn nhất
        static void TimHSTuoiLonNhat(List<Student> ds)
        {
            var hocSinhTuoiLonNhat = ds.OrderByDescending(hs => hs.Age).FirstOrDefault();
            Console.WriteLine($"\nHọc sinh có tuổi lớn nhất:");
            hocSinhTuoiLonNhat.Show();
        }

        // Sắp xếp học sinh theo tuổi tăng dần
        static void SapXepHSTheoTuoi(List<Student> ds)
        {
            var dsSapXepTheoTuoi = ds.OrderBy(hs => hs.Age);
            Console.WriteLine("\nDanh sách học sinh theo tuổi tăng dần:");
            foreach (var hs in dsSapXepTheoTuoi)
            {
                hs.Show();
            }
        }
    }
}
