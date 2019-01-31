using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] Args)
        {
            countryside Ontario = new countryside();
            Ontario.run();
        }
    }
    class Village
    {
        public static int numberOfVillage = 0;
        public Village nextVillage;
        public Village previousvillage;
        public string villagename;
        public bool isAstrildaHere = false;
        public Village()
        {

            Village.numberOfVillage++;
        }
    }
    class Countryside
    {
        public Village maple;
        public Village toronto;
        public Village ajax;
        public Village head;
        public Village tail;
        public Village temp;

        public void Run()
        { 
            this.MapInitializer();
            public void MapInitializer()
            {
                maple = new Village();
                maple.villagename = "maple";
                maple.previousvillage = null;
                maple.nextVillage = toronto;
                maple.isAstrildaHere = true;
                toronto = new Village();
                toronto.previousvillage = maple;
                toronto.villagename = "toronto";
                toronto.nextVillage = ajax;
                ajax = new Village();
                ajax.villagename = "ajax";
                ajax.nextVillage = null;
                ajax.previousvillage = toronto;
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
            public void lookForAstrilda()
            { head = maple;
                if (head.isAstrildaHere)
                {
                    Console.WriteLine("yeah she is in + head.villagename");
                }
            }
            }
        }
    