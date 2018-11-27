using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinTry
{
    public class Train
    {
        List<Wagon> wagonList = new List<Wagon>();
        List<Animal> unsortedList = new List<Animal>();


        public void FillUnsortedList()
        {

            unsortedList.Add(new Animal(false, AnimalSize.large));
            unsortedList.Add(new Animal(false, AnimalSize.large));
            unsortedList.Add(new Animal(true, AnimalSize.large));
            unsortedList.Add(new Animal(false, AnimalSize.medium));
            unsortedList.Add(new Animal(true, AnimalSize.medium));
            unsortedList.Add(new Animal(false, AnimalSize.medium));
            unsortedList.Add(new Animal(false, AnimalSize.small));
            unsortedList.Add(new Animal(true, AnimalSize.small));
            unsortedList.Add(new Animal(false, AnimalSize.small));
            unsortedList.Add(new Animal(true, AnimalSize.small));
            unsortedList.Add(new Animal(false, AnimalSize.small));
            unsortedList.Add(new Animal(false, AnimalSize.small));
            unsortedList.Add(new Animal(false, AnimalSize.large));
            unsortedList.Add(new Animal(false, AnimalSize.medium));
            unsortedList.Add(new Animal(true, AnimalSize.medium));
            unsortedList.Add(new Animal(true, AnimalSize.large));
            unsortedList.Add(new Animal(false, AnimalSize.medium));
            unsortedList.Add(new Animal(false, AnimalSize.medium));
            unsortedList.Add(new Animal(false, AnimalSize.large));
            unsortedList.Add(new Animal(false, AnimalSize.large));

        }

        public void TransferAnimalToWagon()
        {

            foreach (Animal animalToTransfer in unsortedList)
            {
                Arrange(animalToTransfer);
            }
        }

        //TODO; Change the return type of this method to 'void' becausse return value is not used, and is always 
        public void Arrange(Animal animal)
        {
            if (wagonList.Count == 0)
            {
                Wagon newWagon = new Wagon();
                newWagon.AddAnimal(animal);
                wagonList.Add(newWagon);
                return;
            }
            else
            {
                foreach (Wagon wagon in wagonList)
                {
                    //if (wagon.AddAnimal(animal) == false)
                    //{
                    //    Wagon newWagon = new Wagon();
                    //    newWagon.AddAnimal(animal);
                    //    return true;
                    //}
                    //else if (wagon.AddAnimal(animal) == true)
                    //{
                    //    wagon.AddAnimal(animal);
                    //    return true;
                    //}
                    if (wagon.AddAnimal(animal) == true)
                    {
                        //Animal fits in this wagon, so add it and return true.
                        wagon.AddAnimal(animal);
                        return;
                    }               
                }

                //Animal didn't fit in all existing wagons, so create a new wagon and add it there
                Wagon newWagon = new Wagon();
                wagonList.Add(newWagon);
                newWagon.AddAnimal(animal);
                return;
            }

        }
    }
}
