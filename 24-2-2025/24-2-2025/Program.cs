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
            dS_NhanVat.KiemTra();
            Console.ReadLine();
        }
    }
}
