﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class House
    {
        private string color;
        private int rooms;
        private int size;
        private int doors;

        public House()
        {
            this.color = "Grey";
            this.rooms = 1;
            this.size = 500;
            this.doors = 1;
        }

        public House(string color, int size)
        {
            this.color = color;
            this.size = size;
            this.rooms = 1;
            this.doors = 1;

        }

        public House(string color, int rooms,int size )
        {
            this.color = color;
            this.size = size;
            this.rooms = rooms;
            this.doors = 1;

        }

        public House(string color, int rooms,int size, int doors)
        {
            this.color = color;
            this.rooms = rooms;
            this.size = size;
            this.doors = doors;
        }

        

        public void Paint(string color)
        {
            this.color = color;
        }

        public string CurrentColor()
        {
            return color;
        }

        public void DisplayHouseInfo()
        {
            Console.Write("House Color: " + this.color + ",");
            Console.Write(" with " + this.rooms + " rooms, ");
            Console.Write(" Size of the house: " + this.size + "sq/ft,");
            Console.WriteLine(" with " + this.doors + " doors");
        }
    }

    
}
