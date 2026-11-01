using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOP_PROJECT.COMMON;

namespace OOP_PROJECT.ADMIN
{
    internal class REPOSITORY
    {
        TrainModel trainmodel = new TrainModel();
        string path = "C:\\Users\\arsla\\OneDrive\\Desktop\\OOPP\\admin.txt";
        public void savefile(MODEL data)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(data.ToString());
            }
        }
        public void savealldataintofile(List<MODEL> datas)
        {
            File.WriteAllText(path, "");
            foreach (MODEL data in datas)
            {
                savefile (data);
            }

        }
            public List<MODEL> readalldata()
             {
                List<MODEL> all = new List<MODEL>();
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
                    

                    MODEL L1 = new MODEL(name, add, phone, cnic);
                    all.Add(L1);
                    }
                return all;
                }


            }

        }
    }
