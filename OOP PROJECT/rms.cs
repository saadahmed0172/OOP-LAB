using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    internal class rms
    {
        //MAIN MENU OF APP
        public string MainMenu()
        {
           
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine(" RAILWAY MANAGEMENT SYSTEM ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("      USER MENU           ");
            Console.WriteLine("1.ADMIN LOGIN");
            Console.WriteLine("2.USER");
            Console.WriteLine("3.EXIT");
            Console.WriteLine("ENTER YOUR DESIRED OPTION");
            string opt = Console.ReadLine();
            return opt;



        }
    }
}
