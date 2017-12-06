using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theapi.Controllers;


namespace theconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloController HC = new HelloController();
            string rez = HC.GetHello();
            Console.Write(rez);
            Console.Read();
        }
    }
}
