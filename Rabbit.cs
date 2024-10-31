using System.Runtime.InteropServices;
//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

public class Rabbit : Mammal
{
    public bool Fertil { get; set; } = true; 

    public Rabbit()
    {
        Hungry = true;
        Domesticated = true; 
    }

    public Rabbit(int age, int energyLevel, bool hungry, bool sleepy, int numberOfArmsAndLegs, bool domesticated, 
        bool fertil)
    {
        Age = age;
        EnergyLevel = energyLevel;
        Hungry = hungry;
        Sleepy = sleepy;
        NumberOfArmsAndLegs = numberOfArmsAndLegs;
        Domesticated = domesticated; 
        Fertil = fertil; 
    }
    /// <summary>
    /// The rabbit has found a hole in the fence and escapes. 
    /// </summary>
    public void Escape()
    {
        Console.WriteLine("Wohoo I'm out! Dear cabbages and carrots - here I come!");
    }
    
    /// <summary>
    /// An override method for Crazyrun, where there's a difference between animals at which energy-level they are hungry.
    /// </summary>
    public override void CrazyRun()
    {
        Console.WriteLine("I have so much energy - must doooo aaaa Craaaazy Ruuuun! Weeeeiiiiiiii!!");
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