using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { 
    class Village
    {
        public static int numberofvillages = 0;
        public Village nextvillage;
        public Village previousvillage;
        public string villagename;
        public bool isAstrildehere = false; 

        public Village() { Village.numberofvillages++; } 
        
        }
    class Countryside
    {
        public Village Maple;
        public Village Toronto;

        public Village ajax;
            public void MapInitializer()
            {
                Maple = new Village();
                Maple.villagename = "Maple";
                Maple.previousvillage = null;
                Toronto = new Village();
                Toronto.villagename = "Toronto";
                Toronto.previousvillage = null;
                ajax = new Village();
                ajax.villagename = "Ajax";
                ajax.nextvillage = null;
                ajax.previousvillage = Toronto;
                ajax.isAstrildehere = true;
            }

        }
    }
}

