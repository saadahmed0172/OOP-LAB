using OOP_PROJECT.COMMON;
using OOP_PROJECT.TRAIN;
using OOP_PROJECT.USER;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.ADMIN
{
    internal class UI
    {
        TrainRepository repo = new TrainRepository();
        REPOSITORY _repo = new REPOSITORY();
        SERVICE _service = new SERVICE();
        USERREPOSITORY urepo = new USERREPOSITORY();
        
        public string AdminMenu()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine(" RAILWAY MANAGEMENT SYSTEM ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("         ADMIN MENU        ");
            Console.WriteLine("1.ADD TRAIN");
            Console.WriteLine("2.VIEW TRAIN");
            Console.WriteLine("3.REMOVE TRAIN");
            Console.WriteLine("4.UPDATE TRAIN");
            Console.WriteLine("5.ADD ADMIN INFO");
            Console.WriteLine("6.VIEW ADMINS INFO");
            Console.WriteLine("7.SEE ALL USERS ");
            Console.WriteLine("8.BACK");
            Console.WriteLine("SELECT OPTION FROM(1-8): ");
            string adminopt = Console.ReadLine();
            return adminopt;



          
        }
        public void AdminDriver()
        {
            Console.WriteLine("ENTER USERNAME");
            string m = Console.ReadLine();
            Console.WriteLine("ENTER PASSWORD");
            string p = Console.ReadLine();
            
            bool valid = _service.pass(m, p);
            if (valid)
            {

                string opt3 = AdminMenu();

                if (opt3 == "1")
                {
                     takeinput();

                    
                }
                else if (opt3 == "2")
                {
                    viewtrain();
                }
                else if (opt3 == "3")
                {
                    SERVICE s = new SERVICE();
                    Console.WriteLine("ENTER TRAIN NAME YOU WANNA REMOVE");
                    string n = Console.ReadLine();
                    s.removetrain(n);

                }
                else if (opt3 == "4")
                {
                    SERVICE s = new SERVICE();
                    Console.WriteLine("ENTER TRAIN NAME YOU WANNA UPDATE");
                    string n = Console.ReadLine();
                    Console.WriteLine("ENTER NO OF SEATS YOU WANNA UPDATE");
                    string se = Console.ReadLine();
                    Console.WriteLine("ENTER THE FARE YOU WANNA UPDATE");
                    string f = Console.ReadLine();
                    s.updatetrain(n, se, f);


                }
                else if (opt3  == "5")
                {

                    info();
                }
                else if (opt3 == "6") {
                    dispinfo();
                }
                else if (opt3 == "7")
                {
                    dis();
                }

                else if (opt3 == "8")
                {
                    rms r2 = new rms();
                    r2.MainMenu();
                }
                else
                {
                    Console.WriteLine("INVALID OPTION");
                }
            }
            else
            {
                Console.WriteLine("INCORRECT USERNAME OR PASSWORD");
            }
        }
        public void viewtrain()
        {
            List<TrainModel> all = repo.readalldata();
            foreach (TrainModel train in all)
            {
                Console.WriteLine(train.ToString());
            }



        }
        public TrainModel takeinput ()
        {
            Console.WriteLine("Add Train");
            
            Console.WriteLine("Enter train name: ");
            string train = Console.ReadLine();

            Console.WriteLine( "Enter starting terminal: ") ;
            string startingterminal = Console.ReadLine();
            
            Console.WriteLine( "Enter destination terminal: ") ;
            string destinationtermianal = Console.ReadLine();
            Console.WriteLine ( "Enter fare: ");
            string fare = Console.ReadLine();
            
            Console.WriteLine ("Enter number of seats: ");
            string seats = Console.ReadLine();

            TrainModel M1 = new TrainModel(train,startingterminal,destinationtermianal,fare,seats); 
           
            _service.savetrain(M1);
            return null;

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
            MODEL ent = new MODEL(NAME,ADD,PHO,CNIC);
            _repo.savefile(ent);


        }
        public void dispinfo()

        {
            List<MODEL> li = _repo.readalldata();
            foreach (MODEL admin in li)
            {
                
                Console.WriteLine(admin.ToString());
            }

        }
        public void dis()
        {
            List<USERMODEL> UD = _service.readuserdata();
            foreach(USERMODEL user in UD)
            {
                Console.WriteLine(user.ToString());
            }
        }


    }
}
