using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hak2021v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Disk disk = new Disk();
            disk.New(@"c:\1.q", 1000);
            byte[] a = new byte[1000];
            byte[] b = new byte[1000];
            byte[] c = new byte[1000];
            Random r = new Random();
            r.NextBytes(a);
            r.NextBytes(b);
            r.NextBytes(c);
            disk.Set(a);
            disk.Set(b);
            disk.Set(c);
            Page.Note n = disk.Get(0);
            byte[] v = {1,2,3,4 };
            disk.Update(0, v);
        }
    }
}
