using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTreinTry;

using System.Collections.Generic;

namespace Circustrein.UnitTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void AddAnimal_AddAnimalToNewWagon_ReturnTrue()
        {
            // zet objecten
           
            Wagon wagon = new Wagon();
            Animal animal = new Animal(true, 5);

            

            //var unsortedList = new List<Animal>
            //{
            //    new Animal(true, 1),
            //    new Animal(false, 3)
            //};



            // doet er iets mee, uitvoerne
            var result = wagon.AddAnimal(animal);



            // checken
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddAnimal_AddAnimalToExistingAvailableWagon_ReturnTrue()
    {
            Wagon wagon = new Wagon();
            wagon.AnimalList = new List<Animal> { new Nimal( };
    }
    }


}
