using OOP_PROJECT.ADMIN;
using OOP_PROJECT.COMMON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.TRAIN
{
    internal class TrainRepository
    {
        string path = "C:\\Users\\arsla\\OneDrive\\Desktop\\OOPP\\TrainData.txt";
        public List<TrainModel> readalldata()
        {
            List<TrainModel> all = new List<TrainModel>();
            using (StreamReader file = new StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] arr = line.Split(',');
                    string name = arr[0];
                    string starting = arr[1];
                    string ending = arr[2];
                    string seats = arr[3];
                    string fare = arr[4];

                    TrainModel L1 = new TrainModel(name, starting, ending, seats, fare);
                    all.Add(L1);
                }
                return all;
            }

        }
        public void savefile(TrainModel data)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(data.ToString());
            }
        }
        public void savealldataintofile(List<TrainModel> datas)
        {
            File.WriteAllText(path, "");
            foreach (TrainModel data in datas)
            {
                savefile(data);
            }

        }


    }
}

