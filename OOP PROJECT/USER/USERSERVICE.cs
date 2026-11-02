using OOP_PROJECT.COMMON;
using OOP_PROJECT.TRAIN;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.USER
{
    internal class USERSERVICE
    {
        TrainRepository _trainrepo = new TrainRepository();
        TrainModel trainmodel = new TrainModel();
        public TrainModel search(string name)
        {
            List<TrainModel> data = _trainrepo.readalldata();

            foreach (TrainModel all in data)
            {
                if (all.trainName == name)
                {
                    return all;

                }
            }
            return null;
        }
        public void Booktrain(string train)
        {
            List<TrainModel> data = _trainrepo.readalldata();

            foreach (TrainModel all in data)
            {


                if (all.trainName == train)
                {

                    int seats = int.Parse(all.seats);
                    seats = seats - 1;
                    all.seats = seats.ToString();

                    break;

                }



            }
            _trainrepo.savealldataintofile(data);
        }
        public void sea()
        {

            Console.WriteLine("enter");
            string na = Console.ReadLine();

            List<TrainModel> se = _trainrepo.readalldata();

            foreach (TrainModel all in se)
            {
                string nam = all.trainName;
                if (na[0] == nam[0] && na[1]== nam[1])
                {
                    Console.WriteLine(all);
                }

            }
        }
        public void ran(int a ,int b) {
           


            List<TrainModel> li = _trainrepo.readalldata();
            foreach(TrainModel one in li)
            {
                int fare = int.Parse(one.fare);
                if (fare > a && fare<b) {
                    Console.WriteLine(one);
                }
            }
        
        }
    }
}
//public void sea()
//{
//    Console.WriteLine("enter");
//    string na = Console.ReadLine();

//    List<TrainModel> se = _trainrepo.readalldata();
//    foreach (TrainModel all in se)
//    {
//        string nam = all.trainName;
//        if (na[0] == nam[0])
//        {
//            Console.WriteLine(all);
//        }

//    }

//    Console.WriteLine();
//}
//if(na[0] == nam[0] && (na[0] == nam[0] && na[1] == nam[1]) && (na[0] == nam[0] && na[1] == nam[1] && na[2] == nam[2]))

//if (na[0] == nam[0])
//{
//    if (na[1] == nam[1])
//    {
//        if (na[2] == nam[2])
//        {
//            if (na[3] == nam[3])
//            {
//                if (na[4] == nam[4])
//                {
//                    Console.WriteLine(all);
//                }
//            }
//        }
//    }
//}

//else if (na[0] == nam[0])
//{
//    if (na[1] == nam[1])

//        Console.WriteLine(all);


//}
//else if (na[0] == nam[0])
//{
//    Console.WriteLine(all);
//}
                

//            }
           
//                Console.WriteLine();
//            }