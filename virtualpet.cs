using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtPet
{
    class virtualpet
    {
        //fields
        private string name = "Barry the Blowfish";
        private int energy = 10;
        private int hunger = 10;
        private string color;
        private int thirst = 10;
        private int bored = 10;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.color = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Bored
        {
            get { return this.bored; }
            set { this.bored = value; }
        }

        //constructors

        public void InteractivePet(int hunger, int energy, string color, int bored, int thirst)
        {
            this.hunger = hunger;
            this.energy = energy;
            this.color = color;
            this.bored = bored;
            this.thirst = thirst;
        }

        public void InteractivePet(int hunger, int energy, int bored, int thirst)
        {
            this.hunger = 10;
            this.energy = 10;
            this.bored = 10;
            this.thirst = 10;
        }

        //method

        public void ShowBarrytheBlowfish()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Barry the Blowfish hunger level is: " + hunger);
            Console.WriteLine("Barry the Blowfish energy level is: " + energy);
            Console.WriteLine("Barry the Blowfish thirst level is: " + thirst);
            Console.WriteLine("Barry the Blowfish bored level is: " + bored);
        }
    }
}
  
