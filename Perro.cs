//Jenny-Ann Hayward, SUT24

using System.Security.Cryptography;

namespace Labb2_Arv;

public class Perro : Dog
{
    //Perro de agua Espanol (Spanish water dog) have tradionally been active in water (their fur etc are well adapted 
    //for it, but not all individuals like water or swimming. 
    public bool EnjoysWater { get; set; }

    public Perro()
    {
        Age = 13;
        EnergyLevel = 7;
        Hungry = false;
        Sleepy = false;
        Active = true;
        EnjoysWater = true;
        NumberOfArmsAndLegs = 4;
        Domesticated = true; 
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