using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DS_NhanVat dS_NhanVat = new DS_NhanVat();
            dS_NhanVat.Nhap();
            Console.WriteLine(dS_NhanVat.KiemTra1() ? "Có va chạm" : "Không va chạm");
            dS_NhanVat.KiemTra2();
            Console.ReadLine();
        }
    }
}
