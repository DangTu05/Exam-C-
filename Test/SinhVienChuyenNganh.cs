using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class SinhVienChuyenNganh : SinhVien
    {
        private string ChuyenNganh;
        public SinhVienChuyenNganh(string MaSV, string HoTen, DateTime NgaySinh, double DiemTrungBinh, string ChuyenNganh) : base(MaSV, HoTen, NgaySinh, DiemTrungBinh)
        {
            this.ChuyenNganh = ChuyenNganh;
        }
        public override void GetInfor()
        {
            base.GetInfor();
            Console.WriteLine($"Chuyên ngành: {this.ChuyenNganh}");
        }
        public override string XepLoai()
        {
            base.XepLoai();
            if (this.ChuyenNganh == "CNTT")
            {
                if (this.DiemTrungBinh > 8)
                {
                    return "Giỏi";
                }
            }
            if (this.DiemTrungBinh >= 8.2)
            {
                return "Giỏi";
            }
            return "";
        }
    }
}
