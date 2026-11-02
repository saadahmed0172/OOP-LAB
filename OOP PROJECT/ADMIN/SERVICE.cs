using OOP_PROJECT.COMMON;
using OOP_PROJECT.TRAIN;
using OOP_PROJECT.USER;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_PROJECT.ADMIN
{
    internal class SERVICE
    {

        TrainModel trainmodel = new TrainModel();
        USERREPOSITORY _userrepo = new USERREPOSITORY();
        TrainRepository _trainrepo = new TrainRepository();
        REPOSITORY repo = new REPOSITORY();
        public SERVICE() { }
        public void savetrain(TrainModel model)
        {
            
            _trainrepo.savefile(model);
        }
        
        public bool removetrain(string name)
        {
            List<TrainModel> all = _trainrepo.readalldata();
            int count = 0;
            foreach (TrainModel train in all)
            {
                if (train.trainName == name) {
                    all.RemoveAt(count); 

                    _trainrepo.savealldataintofile(all);
                    return true;
                }

                count++;
            }

            return false;
        }
        public void updatetrain(string name,string newseats,string newfare)
        {
            
            List<TrainModel> all = _trainrepo.readalldata();
            foreach(TrainModel train in all)
            {
                
                if (train.trainName == name) {
                    train.seats = newseats;
                    train.fare = newfare;
                    
                    _trainrepo.savealldataintofile(all);
                    break;


                }
                
            }
            
        }
        public bool pass(string username,string pass) {
            if (username == "saad" && pass == "1234") {
                return true;
            }
            else
            {
                return false;
            }

                }
        public List<USERMODEL> readuserdata()
        {
            List<USERMODEL> list = _userrepo.readalldata();
            return list;
        }

        

    }
}
