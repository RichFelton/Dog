using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Dog
    { 
        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;

        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }


        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Dog() //default constructor
        {

        }

        public void Run()
        {

        }

        public void Bark()
        {

        }

        public void Potty()
        {

        }
        public void Cuddle()
        {

        }

        public Dog(int hairLength, int height, int runningSpeed, int weight)  //loaded constructor
        {
                this.hairLength = hairLength;
                this.height = height;
                this.runningSpeed = runningSpeed;
                this.weight = weight;
        }

    
    }
}
