using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinTry
{
    public class Wagon
    {
        private int id;
        private int maxPoints = 10;
        private int totalPoints = 0;

        List<Animal> animalList = new List<Animal>();

        public Wagon()
        {

        }


        public List<Animal> AnimalList
        {
            get { return animalList; }
            private set { animalList = value; }
        }
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public int TotalPoints
        {
            get { return totalPoints; }
            private set { totalPoints = value; }
        }

        public int MaxPoints
        {
            get { return maxPoints; }
            private set { maxPoints = value; }
        }
        public bool AddAnimal(Animal animal)
        {
            if (animalList.Count == 0)
            {
                totalPoints += (int)animal.Size;
                animalList.Add(animal);

                return true;
            }
            else
            {
                foreach (Animal beast in animalList)
                {

                    if (animal.IsCarnivore == true)
                    {
                        return false;
                    }
                    //can't add animal, cause the animal is a large carnivore.
                    else if (beast.Size == AnimalSize.large && beast.IsCarnivore == true && animal.Size == AnimalSize.large)
                    {
                        return false;
                    }
                    //add large herbivore to a medium carnivore.
                    else if ((beast.IsCarnivore == true && beast.Size == AnimalSize.medium && animal.Size == AnimalSize.large && (int)animal.Size + totalPoints <= maxPoints))
                    {
                        animalList.Add(animal);
                        totalPoints += (int)animal.Size;
                        return true;
                    }
                    //add medium herbivore to a small carnivore.
                    else if ((beast.IsCarnivore == true && beast.Size == AnimalSize.small && animal.Size == AnimalSize.medium && (int)animal.Size + totalPoints <= maxPoints))
                    {
                        animalList.Add(animal);
                        totalPoints += (int)animal.Size;
                        return true;
                    }
                    //add large herbivore to a random herbivore
                    else if ((beast.IsCarnivore == false && animal.Size == AnimalSize.large && (int)animal.Size + totalPoints <= maxPoints))
                    {
                        animalList.Add(animal);
                        totalPoints += (int)animal.Size;
                        return true;
                    }
                    //add medium herbivore to a random herbivore
                    else if ((beast.IsCarnivore == false && animal.Size == AnimalSize.medium && (int)animal.Size + totalPoints <= maxPoints))
                    {
                        animalList.Add(animal);
                        totalPoints += (int)animal.Size;
                        return true;
                    }
                    //add small herbivore to a random herbivore
                    else if ((beast.IsCarnivore == false && animal.Size == AnimalSize.small && (int)animal.Size + totalPoints <= maxPoints))
                    {
                        animalList.Add(animal);
                        totalPoints += (int)animal.Size;
                        return true;
                    }

                }
            }

            return false;
        }
    }
}
