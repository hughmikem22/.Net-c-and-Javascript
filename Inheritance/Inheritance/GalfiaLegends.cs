using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Legends
    {
        public string _name { set; get; }
        public string _element { set; get; }
        public string _weapon { set; get; }
        public int _powerLVL { set; get; }

        public Legends(string name, string element, string weapon, int powerLVL )
        {
            _name = name;
            _element = element;
            _weapon = weapon;
            _powerLVL = powerLVL;

            


        }

        public class GLegends : Legends
        {
            public string _nationality { set; get; }
            public string _affiliation { set; get; }

            public  GLegends(string name, string element, string weapon, int powerLVL, string nat) : base(name, element, weapon, powerLVL)
            {
                _name = name;
                _element = element;
                _weapon = weapon;
                _powerLVL = powerLVL;
                _nationality = nat;
               


            }
          


        }


        public void rescue(string rescuedPersonname)
        {
            Console.WriteLine("{0} saved {1}! ", _name, rescuedPersonname);
        }

        public void UsePower(int timesPowerUsed)   // for loop method
        {
            for (int i = 0; i < timesPowerUsed; i++)
            {
                Console.WriteLine("You used your  hero power!", _weapon);
            }
        }
        public void attack(string attackTheEnemy)
        {
            Console.WriteLine("{0} fought and vanquished {1}!", _name, attackTheEnemy);
        }
        public void traitor(string youhaveBetrayedme)
        {
            Console.WriteLine( "{0} says: you have betrayed me, fight to the death you bastard they call {1}!!!!", _name, youhaveBetrayedme);
        }

        public void failedRescue(string failedAttempt)
        {
            Console.WriteLine("{0} says: you have failed once again, and for your insolance I shall... ERASE YOU FROM EXISTENCE {1} ", _name, failedAttempt);
        }
       
    }

    public class WhiteLegends : Legends
    {
        public WhiteLegends(string name, string element, string weapon, int powerLVL) : base(name, element, weapon, powerLVL)
        {
            _name = name;
            _element = element;
            _weapon = weapon;
            _powerLVL = powerLVL;

        }
    }

}
