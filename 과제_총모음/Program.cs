using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230619
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coin = 5000;

        

            Map map = new Map();
            map.MapOpen(ref coin);
        }
    }
}
