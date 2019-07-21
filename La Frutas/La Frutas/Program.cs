using System;

namespace La_Frutas
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruits FRT1 = new Fruits("Banana", "Yellow","Like a Sausage",4.8);

            FRT1.choice();
            FRT1.pick();
            FRT1.requestWeight();
        }

    }
}
