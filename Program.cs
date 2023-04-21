using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAllTheWayDown
{//EDNA LYNN LAXA 
 //PROGRAMMING III 
 //APRIL 20, 2023 
 //OBJECTS, ALL THE WAY DOWN 
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //STORE FOR WATERBOTTLE  
            //WATER BOTTLE HAS A RELATIONSHIP WITH A BOTTLE TOPPER //Aggregation 
            //Material Class = Containment 

            BottleTops chosenTopper = new BottleTops("Straw Topper");
            Waterbottle waterbottle = new Waterbottle(32, chosenTopper);
          

            waterbottle.AddMaterial("Plastic", "Light Weight");
            waterbottle.AddMaterial("alumninum", "light weight");
            waterbottle.AddMaterial("stainless steel", "heavy weight");
            waterbottle.AddMaterial("glass", "light");
            waterbottle.AddMaterial("built-in infuser", "light weight");


            Console.WriteLine("WATERBOTTLE EMPIRE");
            Console.WriteLine("Material Types: ");

            for (int i = 0; i < waterbottle.TypesOfwaterbottle.Count; i++)
            {
                
                Console.WriteLine(waterbottle.TypesOfwaterbottle[i]);
            }
            Console.WriteLine();

            Console.WriteLine("USER SELECTED");
            Console.WriteLine(chosenTopper.ToString());
            Console.WriteLine(waterbottle.ToString() + waterbottle.TypesOfwaterbottle[0]);
            
            
           

 
        }
    }
}
