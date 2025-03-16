using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class SinhVien
    {
        protected string MaSV;
        protected string HoTen;
        protected DateTime NgaySinh;
        protected double DiemTrungBinh;

        public SinhVien(string MaSV, string HoTen, DateTime NgaySinh, double DiemTrungBinh)
        {
            this.NgaySinh = NgaySinh;
            this.HoTen = HoTen;
            this.DiemTrungBinh = DiemTrungBinh;
            this.MaSV = MaSV;
        }
        public virtual void GetInfor()//Từ khóa virtual trong C# được dùng để khai báo một phương thức hoặc thuộc tính trong lớp cha (base class) mà các lớp con (derived class) có thể ghi đè (override) bằng cách sử dụng từ khóa override.
        {
            Console.WriteLine($"Ma Sinh Vien:{this.MaSV}");
            Console.WriteLine($"Ho ten :{this.HoTen}");
            Console.WriteLine($"Ngay Sinh: {this.NgaySinh}");
            Console.WriteLine($"Diem Trung Binh:{this.DiemTrungBinh}");
        }
        public virtual string XepLoai()
        {
            if (this.DiemTrungBinh >= 5)
            {
                return "Đạt";
            }
            return "Không đạt";
        }
    }

}
