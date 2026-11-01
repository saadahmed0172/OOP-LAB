using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.ADMIN
{
    internal class MODEL
    {
        public string name;
        public string address;
        public string phone;
        public string cnic;



    public MODEL() { }
       
    
    public MODEL(string a, string b, string c, string d     )
        {
            name = a;
            address = b;
            phone = c;
            cnic = d;

        }
        public override string ToString()
        {
            return $"{name},{address},{phone},{cnic}";
        }
    }
}