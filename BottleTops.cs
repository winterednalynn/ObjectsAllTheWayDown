using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAllTheWayDown
{
    public class BottleTops
    {
        
        string _Toppers; //Bottle tops  = string 

        public BottleTops(string toppers)
        {
            Toppers = toppers;
          
        }

        public string Toppers { get => _Toppers; set => _Toppers = value; }

        public override string ToString()
        {
            return $"SELECTED TOP:{_Toppers}"; // This format will be prompt when called. The waterbottle class will call _bottletops but this format will connect. ; hopefully this make sense. 
        }
    }
}
