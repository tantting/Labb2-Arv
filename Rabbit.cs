using System.Runtime.InteropServices;
//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

public class Rabbit : Animal
{
    public bool Fertil { get; set; }

    public Rabbit()
    {
        Name = "Sigge";
        Age = 1;
        EnergyLevel = 7;
        Hungry = true;
        Sleepy = false;
        Fertil = true; 
    }

    public void Escape()
    {
        Console.WriteLine("Wohoo I'm out! Dear cabbages and carrots - here I come!");
    }
    
    //An override method for Crazyrun, where there's a difference between animals at which energy-level they are hungry.
    public override void CrazyRun()
    {
        Console.WriteLine("Oh yeah, how liberating it is to do a crazy run");
        EnergyLevel -= 3;
        if (EnergyLevel < 8)   //The rabbits are hungry already at 7 and below. 
        {
            Hungry = true; 
        } 
    }

    public override void MakeSound()
    {
        Console.WriteLine("Pip");
    }
}