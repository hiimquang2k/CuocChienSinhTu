using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2_2025
{
    internal class NhanVat
    {
        public string Ten { get; set; }
        public int ChieuDai { get; set; }
        public int ChieuCao { get; set; }
        public int TungDo {  get; set; }
        public int HoanhDo { get; set; }
        public void Nhap()
        {
            Console.WriteLine("Nhập hoành độ (x): ");
            this.HoanhDo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tung độ (y): ");
            this.TungDo = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Tên: {this.Ten}");
            Console.WriteLine($"Chiều dài: {this.ChieuDai}");
            Console.WriteLine($"Chiều cao: {this.ChieuCao}");
            Console.WriteLine($"Tung độ (x): {this.TungDo}");
            Console.WriteLine($"Hoành độ (y): {this.HoanhDo}");
        }
        public bool KiemTraVaCham(NhanVat B)
        {
            if (((this.HoanhDo >= B.HoanhDo) && (B.HoanhDo + B.ChieuDai >= this.HoanhDo)) || ((this.HoanhDo < B.HoanhDo) && (this.HoanhDo + this.ChieuDai >= B.HoanhDo)))
            {
                if ((this.TungDo >= B.TungDo) && (B.TungDo >= this.TungDo - this.ChieuCao))
                { return true; }
                else if ((this.TungDo < B.TungDo) && (B.TungDo - B.ChieuDai <= this.TungDo))
                { return true; }
            }
            return false;
        }
    }
}
