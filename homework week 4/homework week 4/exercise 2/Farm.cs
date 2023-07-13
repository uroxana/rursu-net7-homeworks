using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class Farm with the following fields:
- name - representing the name of the farm.
- area - representing the total area of the farm in square meters.
- animalCount - representing the total number of animals on the farm.

Add the following methods:
- AddAnimals(count) - adds a specified number of animals to the current farm.
- CalculateDensity() - calculates the animal density on the farm by dividing the total number of animals by the farm's area.

Write a usage example that creates a farm, adds animals to it, and displays the animal density on the farm.*/

namespace homework_week_4.exercise_2
{
    public class Farm
    {
        public Farm() 
        {
            this.farmName = farmName;
            this.area = area;
            this.animalCount = 0;
        }
        public string farmName;
        public int area;
        public int animalCount;
        public string animalName;
        List<string> farmAnimals = new List<string>();

        public void AddAnimals(int count )
        {
            this.animalCount+=count;
        }

        public double CalculateDensity()
        {
            return this.animalCount/this.area;
        }
    }
}
