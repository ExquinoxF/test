using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raffle_Game
{
    class Class1
    {
        public string[] path = Directory.GetFiles(@"D:\C#\程序\Raffle Game\用户头像\");
        Random ran = new Random();
        public int generate(int y)
        {
            int x=ran.Next(0,path.Length-1);
            while (x == y)
            {
                x = ran.Next(0, path.Length - 1);    
            }
                return x;
        }
        public int Rgenrate(int a, int b)
        {
            int c = ran.Next(0, path.Length - 1);
            while (c == a || c == b)
            {
                c = ran.Next(0, path.Length - 1);
            }
            return c;
        }
    }
}
