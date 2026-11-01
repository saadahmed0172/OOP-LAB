using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_PROJECT.ADMIN;
using OOP_PROJECT.USER;

namespace OOP_PROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rms r1 = new rms();
            while (true)
            {

                string opt2 = r1.MainMenu();
                if (opt2 == "1")
                {
                    UI m1 = new UI();
                    m1.AdminDriver();


                }
                if (opt2 == "2")
                {
                   USERUI u = new USERUI();
                    u.USERDRIVER();


                }
                if (opt2 == "3")
                {
                    break;
                }
            }
        }
    }
}
