using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("green",5,9000,3);
            House house2 = new House("Blue", 700);
            House house3 = new House();

            
            //Console.WriteLine(house1.CurrentColor());
            house1.DisplayHouseInfo();
            house2.DisplayHouseInfo();
            house3.DisplayHouseInfo();
        }
    }
}
