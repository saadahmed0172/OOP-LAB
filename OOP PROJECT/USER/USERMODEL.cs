using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.USER
{
    internal class USERMODEL
    {
        public string name;
        public string address;
        public string phone;
        public string cnic;
       






        public USERMODEL(string a, string b, string c, string d)
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
