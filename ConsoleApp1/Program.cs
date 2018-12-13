using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // this is develop branch
            Console.WriteLine("Hello GIT");
            Log.Logger.Information("hello Nav");
            Console.ReadLine();
        }


    }
}
