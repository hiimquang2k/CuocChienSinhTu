using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_2_2025
{
    internal class DS_NhanVat
    {
        List<NhanVat> list = new List<NhanVat>();
        public void Nhap()
        {
            Console.WriteLine("Nhập số nhân vật: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhân vật số {i+1}");
                Console.WriteLine("Chọn nhân vật: ");
                Console.WriteLine("1. Ryu\n2. Armor Sword Man\n3. Banshee\n4. Bat Man\n5. Bomberhead");
                int luaChon = int.Parse(Console.ReadLine());
                if (luaChon == 1)
                {
                    NhanVat v = new Ryu();
                    v.Nhap();
                    list.Add(v);
                }
                if (luaChon == 2)
                {
                    NhanVat v = new Armor_Sword_Man();
                    v.Nhap();
                    list.Add(v);
                }
                if (luaChon == 3)
                {
                    NhanVat v = new Banshee();
                    v.Nhap();
                    list.Add(v);
                }
                if (luaChon == 4)
                {
                    NhanVat v = new Bat_Man();
                    v.Nhap();
                    list.Add(v);
                }
                if (luaChon == 5)
                {
                    NhanVat v = new Bomberhead();
                    v.Nhap();
                    list.Add(v);
                }
            }
        }
        public void Xuat()
        {
            foreach (var v in list)
            {
                v.Xuat();
            }
        }
        public bool KiemTra1()
        {
            Console.WriteLine("Kiểm tra 1: ");
            Console.WriteLine("Chọn nhân vật để kiểm tra va chạm: ");
            int luaChon = int.Parse(Console.ReadLine());
            foreach (var v in list)
            {
                if (v.KiemTraVaCham(list[luaChon - 1]) && v != list[luaChon - 1])
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        public void KiemTra2()
        {
            Console.WriteLine("Kiểm tra 2:");
            Console.WriteLine("Chọn nhân vật để kiểm tra va chạm: ");
            int luaChon = int.Parse(Console.ReadLine());
            int count = 0;
            foreach(var v in list)
            {
                if (v.KiemTraVaCham(list[luaChon - 1]) && v != list[luaChon-1])
                {
                    Console.WriteLine($"Nhân vật số {luaChon} đang va chạm với nhân vật: ");
                    v.Xuat();
                    foreach (var v2 in list)
                    {
                        if (v2.GetType() == v.GetType() && v2!= v)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Số lượng nhân vật có cùng loại với nhân vật {v.Ten}: {count}");
                    break;
                }
                else if (!v.KiemTraVaCham(list[luaChon - 1]))
                {
                    foreach (var v2 in list)
                    {
                        if (v2.GetType() == list[luaChon - 1].GetType() && v2 != list[luaChon - 1])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Số lượng nhân vật có cùng loại với nhân vật {luaChon}: {count}");
                    break;
                }
            }
            
        }
    }
}
