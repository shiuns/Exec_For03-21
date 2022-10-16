using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_For03___21謝孟勳
{
    //右側對齊星形三角形
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10 ; i++)
            {
                int blank = 10 - i;
                int star = i;
                string row = new string(' ', blank) +  new string('*', star);
                Console.WriteLine(row);
            }
        }
    }
}
