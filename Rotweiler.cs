//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

public class Rotweiler : Dog
{
    public string Temper { get; set; }

    public Rotweiler()
    {
        Age = 6;
        EnergyLevel = 8;
        Hungry = false;
        Sleepy = false;
        Active = true;
        Temper = "calm";
        Domesticated = true;
        NumberOfArmsAndLegs = 4; 
    }

    public override void MakeSound()
    {
        Console.WriteLine("VVVOOOV, VVVOOOOV");
    }

    public void MarkTowardsOthers()
    {
        Console.WriteLine($"Hey there, I'm {Temper}! Just so you know");
    }
}