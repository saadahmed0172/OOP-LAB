using OOP_PROJECT.ADMIN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.USER
{
    internal class USERREPOSITORY
    {

       string path = "C:\\Users\\arsla\\OneDrive\\Desktop\\OOPP\\admin1.txt";
        public void savefile(USERMODEL data)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(data.ToString());
            }
        }
        public void savealldataintofile(List<USERMODEL> datas)
        {
            File.WriteAllText(path, "");
            foreach (USERMODEL data in datas)
            {
                savefile(data);
            }

        }
        public List<USERMODEL> readalldata()
        {
            List<USERMODEL> all = new List<USERMODEL>();
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    string name = arr[0];
                    string add = arr[1];
                    string phone = arr[2];
                    string cnic = arr[3];


                    USERMODEL L1 = new USERMODEL(name, add, phone, cnic);
                    all.Add(L1);
                }
                return all;
            }


        }

    }
}
