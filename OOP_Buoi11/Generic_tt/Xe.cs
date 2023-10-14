using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tt
{
    internal class Xe
    {
        public string Maxe { get; set; }
        public int Tan { get; set; }
        public Xe() { }

        public void nhap()
        {
            Console.WriteLine("Mã xe");
            Maxe = Console.ReadLine();
            Console.WriteLine("Trọng tải");
            Tan = int.Parse(Console.ReadLine());
        }

        public void xuat() 
        {
            Console.WriteLine($"Mã xe: {Maxe}, Trọng tải: {Tan}" );
        }
    }
}
