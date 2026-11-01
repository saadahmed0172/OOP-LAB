using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.COMMON
{
    internal class TrainModel
    {
        public string trainName;
        public string startingTerminal;
        public string destinationterminal;
        public string seats;
        public string fare;

    
        public TrainModel(){

        }
        public TrainModel(string a, string b, string c, string d, string e)
        {
            trainName = a;
            startingTerminal = b;
            destinationterminal = c;
            seats = d;
            fare = e;

        }
        public override string ToString()
        {
            return $"{trainName},{startingTerminal},{destinationterminal},{seats},{fare}";
        }


    }
}
