using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinTry
{
    public class Animal
    {
        private bool isCarnivore;
        private AnimalSize size;

        public Animal(bool isCarnivore, AnimalSize size)
        {
            this.isCarnivore = isCarnivore;
            this.size = size;
        }
        public bool IsCarnivore
        {
            get { return isCarnivore;} private set { isCarnivore = value; }
        }

        public AnimalSize Size {
            get { return size; } private set { size = value; }
        }
    }
}

public enum AnimalSize
{
    small = 1,
    medium = 3,
    large = 5
}
