//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

public class Perro : Dog
{
    public bool EnjoysWater { get; set; }

    public Perro()
    {
        Name = "Lester";
        Age = 13;
        EnergyLevel = 7;
        Hungry = false;
        Sleepy = false;
        Active = true;
        EnjoysWater = true; 
    }

    public void Swim()
    {
        if (EnjoysWater)
        {
            Console.WriteLine("Here we go....weeeeiiiii....Love water! Get in you tooo!");
        }
        else
        {
            Console.WriteLine("I hope you do not think that I will get in. No chanse. Refuse!");
        }
    }
}