using OOP_PROJECT.ADMIN;
using OOP_PROJECT.COMMON;
using OOP_PROJECT.TRAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.USER
{
    internal class USERUI
    {
        rms r3 = new rms();
       
        TrainRepository _trainrepo = new TrainRepository();
        USERSERVICE userservice = new USERSERVICE();
        USERREPOSITORY urepo = new USERREPOSITORY();

        public string UserMenu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine(" RAILWAY MANAGEMENT SYSTEM ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("          USER MENU        ");
            Console.WriteLine("1.range filter");
            Console.WriteLine("2.BOOK TRAIN");
            Console.WriteLine("3.SEARCH TRAIN");
            Console.WriteLine("4.ADD USER INFO");
            Console.WriteLine("5.BACK");
            Console.WriteLine("ENTER YOUR DESIRED OPTION");
            string useropt = Console.ReadLine();
            return useropt;



        }
        public void USERDRIVER()
        {
            string opt = UserMenu();

            if (opt == "1")
            {

                ra();

            }
            else if (opt == "2")
            {
                BookTrain();

            }
            else if (opt == "3")
            {
                SearchTrain();

            }
            else if(opt == "4")
            {
                info();
            }
            else if (opt == "6")
            {
                r3.MainMenu();
            }
            else {
                Console.WriteLine("INVALID OPTION ");
                    }
            }
        public void viewtrain()
        {
            List<TrainModel> all = _trainrepo.readalldata();
            foreach (TrainModel train in all)
            {
                Console.WriteLine(train.ToString());
            }



        }
        public void BookTrain()
        {
            viewtrain();
            Console.WriteLine("ENTER TRAIN NAME TO BOOK:");
            string choice = Console.ReadLine();
            userservice.Booktrain(choice);
            

        }
        public void SearchTrain()
        {
            Console.WriteLine("Enter Train Name To Search: ");
            string name = Console.ReadLine();
            Console.WriteLine(userservice.search(name));
            Console.ReadKey();
        }
        public void info()
        {
            Console.WriteLine("ENTER YOUR NAME ");
            string NAME = Console.ReadLine();
            Console.WriteLine("ENTER YOUR ADDRESS ");
            string ADD = Console.ReadLine();
            Console.WriteLine("ENTER YOUR PHONE ");
            string PHO = Console.ReadLine();
            Console.WriteLine("ENTER YOUR CNIC ");
            string CNIC = Console.ReadLine();
            USERMODEL UM = new USERMODEL(NAME, ADD, PHO, CNIC);
            urepo.savefile(UM);

            


        }
        public void ra()
        {
            Console.WriteLine("enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a");
            int b = int.Parse(Console.ReadLine());
            userservice.ran(a, b);
            

        }
        public void cat()
        {
           
        }
    }
}

