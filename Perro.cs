//Jenny-Ann Hayward, SUT24

using System.Security.Cryptography;

namespace Labb2_Arv;

public class Perro : Dog
{
    public bool EnjoysWater { get; set; } = true; 

    public Perro() : base()
    {
    }

    public Perro(int age, int energyLevel, bool hungry, bool sleepy, int numberOfArmsAndLegs, bool domesticated, 
        bool active, bool enjoysWater)
    {
        Age = age;
        EnergyLevel = energyLevel;
        Hungry = hungry;
        Sleepy = sleepy;
        NumberOfArmsAndLegs = numberOfArmsAndLegs;
        Domesticated = domesticated; 
        Active = active;
        EnjoysWater = enjoysWater;
    }
    /// <summary>
    /// A method where the perro encounters water. 
    /// </summary>
    public void Swim()
    {
        Console.WriteLine("Look - some water....");
        if (EnjoysWater)
        {
            Console.WriteLine("I looooove water! Weeeeiiiii.... Come on! Get in you tooo!");
        }
        else
        {
            Console.WriteLine("...I hope you do not think that I will get in? No chanse. Refuse!");
        }
    }
}