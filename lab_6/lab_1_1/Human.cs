using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lab_1_1
{
    internal class Human
    {
        private int _weight;
        private int _height;
        private int _age;

        public Human()
        {
            _weight = 10;
            _height = 50;
            _age = 1;
        }
        public Human(int weight, int height, int age) 
        {
            this._weight = weight;
            this._height = height;
            this._age = age;
        }
        public Human(Human human)
        { 
            this._weight = human._weight;
            this._height = human._height;
            this._age = human._age;
        }


        public int Age
        {
            get
            {
                return this._age;
            }
            set 
            {
                this._age = value; 
            }
        }
        public int Weight
        {
            get
            { 
                return this._weight; 
            }
            set 
            { 
                this._weight = value;
            }
        }
        public int Height
        {
            get
            { 
                return this._height; 
            }
            set 
            { 
                this._height = value;
            }
        }

        public int Multiplication()
        {
            return (this._weight * this._height * this._age);
        }
        public override string ToString()
        {
            return "рост " + this._height + " вес " + this._weight + " лет " + this._age;
        }
        
    }
}
