using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Legends LH1 = new Legends("Aurinian", "Diamond", "Long Sword", 34528);
            Legends LH2 = new Legends("Evandegeldar", "Dark", "Shadow Katana", 29444);


            Legends WLH1 = new WhiteLegends("Terranto", "Lava", "galaxy Morning star", 30222);
            Legends WLH2 = new WhiteLegends("Hakachi", "Forrest", "Forrest Shuriken/Dagger", 26555);


            LH1.traitor(LH2._name);
            LH2.attack(LH1._name);
            
            WLH2.rescue(LH2._name);
            LH2.failedRescue(WLH1._name);
            LH1.UsePower(1);
           
        }
    }
}
