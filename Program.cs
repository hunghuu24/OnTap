//Nguyễn Hữu Hưng 2415053122322
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    internal class Program
    {
        class Product
        {
            public int ID, price;
            public String Name;
            public String Category;
            public void Xuat()
            {
                Console.WriteLine($"{ID} - {Name} - {price} - {Category}");
            }
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product {ID = 1, Name = "Chuoi", price = 6000, Category = "Hang moi nhap"},
                new Product {ID = 2, Name = "Xoai", price = 5000, Category = "Hang moi nhap"},
                new Product {ID = 3, Name = "Oi", price = 4000, Category = "Hang moi nhap"},
                new Product {ID = 4, Name = "Man", price = 300, Category = "Hang moi nhap"},
                new Product {ID = 5, Name = "Coc", price = 100, Category = "Hang moi nhap"},
                new Product {ID = 6, Name = "Chom chom", price = 2000, Category = "Hang moi nhap"}
            };

            var giaLonHon500 = from s in products
                               where s.price > 500
                               select s;
           Console.WriteLine("San pham gia > 500:");
            foreach (var p in giaLonHon500)
                p.Xuat();

            var tangDan = products.OrderBy(p => p.price);
            Console.WriteLine("\nSap xep tang dan:");
            foreach (var p in tangDan)
                p.Xuat();

            var reNhat = products.OrderBy(p => p.price).Take(3);
            Console.WriteLine("\n3 san pham re nhat:");
            foreach (var p in reNhat)
                p.Xuat();

            Console.Write("\nNhap ten can tim: ");
            string keyword = Console.ReadLine();
            var timKiem = products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()));
            if( timKiem.Count() > 0)
            {
                Console.WriteLine("Ket qua tim kiem:");
                foreach (var p in timKiem)
                    p.Xuat();
            }
            else
                Console.WriteLine("Khong tim thay san pham");
            double tong = products.Sum(p => p.price);
            Console.WriteLine($"\nTong gia tri: {tong}");

            double trungBinh = products.Average(p => p.price);
            Console.WriteLine($"Gia trung binh: {trungBinh}");
        }
    }
}
