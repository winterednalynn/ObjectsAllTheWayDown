using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAllTheWayDown
{
    public class Materials
    {
        string _typeOfmaterial; //TYPE OF MATERIAL , EX: Alumni, Plastic, Stainless Steel, and ETC 
        string _weight; // Did not use an int as I was aiming for an adjective(describing the weight)EX: Light weight, heavy weight. 

        public Materials(string typeOfmaterial, string weight)
        {
            TypeOfmaterial = typeOfmaterial;
            Weight = weight;
        }

        public string TypeOfmaterial { get => _typeOfmaterial; set => _typeOfmaterial = value; }
        public string Weight { get => _weight; set => _weight = value; }

        public override string ToString()
        {
            return $"Material of waterbottle: {_typeOfmaterial}, Weight of waterbottle: {_weight}" ; 
        }
    }
}
