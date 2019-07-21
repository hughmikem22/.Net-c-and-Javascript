using System;
using System.Collections.Generic;
using System.Text;

namespace La_Frutas
{
    class Fruits

    {
        public string _color { set; get; }
        public string _shape  { set; get; }
        public double _weight  { set; get; }

        public Fruits(string name, string color, string shape, double weight)
        {
            _color = color;
            _shape = shape;
            _weight = weight;


        }
        public void choice()
        {
            Console.WriteLine("I only eat fruit that  have the color of{0}", _color);
        }
        public class Berries : Fruits
        {
           public string _name { get; set; }

            public Berries(string name, string color, string shape, double weight) : base(name, color, shape, weight)
            {
                
                _name = name; 
            }

            public void bite()
            {
                Console.WriteLine("mmm this {0} is quite tasty?", _name);

            }

        }
        public void pick()
        {
            Console.WriteLine("hmm which one do i want it has to look like a {0}?", _shape);

        }
        public void requestWeight()
        {
            Console.WriteLine(" how much does that weigh? ", _weight);

        }
       
    }
    
}
