using OOP_PROJECT.COMMON;
using OOP_PROJECT.TRAIN;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Booktrain(string train) {
            List <TrainModel> data = _trainrepo.readalldata();
            int count = -1;
            foreach (TrainModel all in data)
            {

                count += 1;
                if(all.trainName == train)
                {

                    int seats = int.Parse(all.seats);
                    seats = seats - 1;
                    all.seats = seats.ToString();
                    data[count] = all;
                    break;

                }
                
               
            }
            _trainrepo.savealldataintofile(data);
        }
    }
}
