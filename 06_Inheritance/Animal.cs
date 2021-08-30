using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public enum DietType { Herbivore =1, Omnivore, Carnivore, }
    public abstract class Animal // abstratc stops to use Animal to create new object
    {
        //fields
        //properties
        //constructor(s)
        //methods
        public int NumOfLegs { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }
        public Animal()
        {

            Console.WriteLine("this is the Animal Constructor");
        }
        //public abstract void Attack();
        public virtual void MakeSound()
        {
            Console.WriteLine("AAOOOOAOAOAOAOA");
        }


    }
}
