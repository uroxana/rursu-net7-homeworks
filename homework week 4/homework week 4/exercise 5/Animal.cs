using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*Create a class Animal with one constructor and the following fields:
- name
- species
- breed
- age
- color
- weight
- isSpayedOrNeutered

Add the following methods:
- GetName() - returns the animal's name.
- GetSpecies() - returns the animal's species.
- GetBreed() - returns the animal's breed.
- GetAge() - returns the animal's age.
- GetColor() - returns the animal's color.
- GetWeight() - returns the animal's weight.
- IsSpayedOrNeutered() - returns a boolean value indicating whether the animal has been spayed or neutered.
- SetName(string name) - sets the animal's name.
- SetSpecies(string species) - sets the animal's species.
- SetBreed(string breed) - sets the animal's breed.
- SetAge(int age) - sets the animal's age.
- SetColor(string color) - sets the animal's color.
- SetWeight(double weight) - sets the animal's weight.
- SetIsSpayedOrNeutered(bool isSpayedOrNeutered) - sets a boolean value indicating whether the animal has been spayed or neutered.

The following program should work after you implement missing classes:

Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);

Console.WriteLine(animal.GetName()); // Outputs "Max"
Console.WriteLine(animal.GetSpecies()); // Outputs "Dog"
Console.WriteLine(animal.GetBreed()); // Outputs "Labrador Retriever"
Console.WriteLine(animal.GetAge()); // Outputs 2
Console.WriteLine(animal.GetColor()); // Outputs "Yellow"
Console.WriteLine(animal.GetWeight()); // Outputs 75
Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs true

animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine(animal.GetName()); // Outputs "Buddy"
Console.WriteLine(animal.GetSpecies()); // Outputs "Cat"
Console.WriteLine(animal.GetBreed()); // Outputs "Siamese"
Console.WriteLine(animal.GetAge()); // Outputs 5
Console.WriteLine(animal.GetColor()); // Outputs "Gray"
Console.WriteLine(animal.GetWeight()); // Outputs 12
Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs false*/

namespace homework_week_4.exercise_5
{
    public class Animal
    {
        public Animal(string name, string species, string breed, int age, string color, double weight,bool isSpayedOrNeutered) 
        {
            this.name = name;
            this.species = species;
            this.breed = breed;
            this.age = age;
            this.color = color;
            this.weight = weight;
            this.isSpayedOrNeutered = isSpayedOrNeutered;
        }
        public string name;
        public string species;
        public string breed;
        public int age;
        public string color;
        public double weight;
        public bool isSpayedOrNeutered;
       public string GetName()
        { return this.name; }
        public string GetSpecies()
        { return this.species; }
        public string GetBreed()
        { return this.breed; }
        public int GetAge()
        { return this.age; }
        public string GetColor()
        { return this.color; }
        public double GetWeight()
        { return this.weight; }
        public bool IsSpayedOrNeutered()
        { return this.isSpayedOrNeutered; }
        public string SetName(string name)
        { 
            this.name = name;
            return name;
        }
        public string SetSpecies(string species)
        { 
            this.species = species;
            return species;
        }
        public string SetBreed(string breed)
        { 
            this.breed = breed;
            return breed;
        }
        public int SetAge(int age)
        { 
            this.age = age;
            return age;
        }
        public string SetColor(string color)
        { 
            this.color = color;
            return color;
        }
        public double SetWeight(double weight)
        { 
            this.weight = weight;
            return weight;
        }
        public bool SetIsSpayedOrNeutered(bool isSpayedOrNeutered)
        { 
            this.isSpayedOrNeutered = isSpayedOrNeutered;
            return this.isSpayedOrNeutered;
        }
    }
}
