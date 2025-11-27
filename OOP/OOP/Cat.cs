using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Cat
    {

        public string Name { get; }

 
        public Gender Gender { get; }


        private double _energy;

        
        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;

       
        public double Energy
        {
            get
            {
                return _energy;
            }
            private set
            {
                if (value < MinEnergy)
                {
                    throw new Exception("Not enough energy to jump");
                }
                else if (value > MaxEnergy)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }

       
        public Cat(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy; 
        }

 
        public void Jump()
        {
            Energy -= JumpEnergyDrain;
        }

        public void Sleep()
        {
            Energy += SleepEnergyGain;
        }
    }
}
