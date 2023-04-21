using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAllTheWayDown
{
    public class Waterbottle 
    {
        //FIELDS 
        int _oz; //Ounces a waterbottle can hold 
        BottleTops _bottleTops; //Has a relation
        List<Materials> _typesOfwaterbottle; // Since there are multi types of waterbottle, I placed this as a list (containment) 


        //CONSTRUCTORS 
        public Waterbottle(int oz, BottleTops bottleTops)
        {
            Oz = oz;
            BottleTops = bottleTops;
            TypesOfwaterbottle = new List<Materials>(); 
        }

        public Waterbottle()
        {
            TypesOfwaterbottle = new List<Materials>();

        }

        //OVERLOADING ADD MATERIAL METHODS 
        public void AddMaterial(Materials material)
        {
            _typesOfwaterbottle.Add(material);

         
        }

        public void AddMaterial(string _typeOfmaterial, string _weight)
        {
            Materials material = new Materials(_typeOfmaterial, _weight); //LIST & it's called parameters 
            _typesOfwaterbottle.Add(material); // Using the add method 
        }

        //PROPERTIES (GET & SET) 
        public int Oz { get => _oz; set => _oz = value; }
        public BottleTops BottleTops { get => _bottleTops; set => _bottleTops = value; }
        public List<Materials> TypesOfwaterbottle { get => _typesOfwaterbottle; set => _typesOfwaterbottle = value; }

        //OVERRIDE TO STRING 
        public override string ToString()
        {
            return $"Ounces in this water bottle is {_oz},  {_bottleTops}, SELECTED  ";  // WHEN .TOSTRING IS CALLED , THIS FORMAT WILL RETURN 

        }
    }
}
