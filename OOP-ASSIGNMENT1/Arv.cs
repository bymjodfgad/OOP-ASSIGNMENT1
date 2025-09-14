using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ASSIGNMENT1
{
   class Vehicle
    {
        public void Start() 
        {
            Console.WriteLine("Bilen startar");
        }
    }
    
    class Car : Vehicle
    
    {
    public void Drive()
        {
            Start();
            Console.WriteLine("bilen kör");
        }
    
    }


}
