using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_tt
{
    internal class DSXE
    {
        public Queue<Xe> ds = new Queue<Xe>();
        public DSXE() { }

        public void nhap()
        {
            int n;
            Console.Write("Nhập số lượng xe: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Xe a = new Xe();
                a.nhap();
                ds.Enqueue(a);
            }
        }
        public void check() 
        {
            int l = ds.Count;
            int tong = 0;

            for (int i = 0; i <= l; i++)
            {
                if (ds.Peek().Tan + tong<=18)
                {
                    tong += ds.Peek().Tan;
                    ds.Dequeue().xuat();
                }
            }
        }
    }
}
