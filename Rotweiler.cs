//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

public class Rotweiler : Dog
{
    public string Temper { get; set; } = "calm";
    public Rotweiler() : base()
    {
    }

    public Rotweiler(int age, int energyLevel, bool hungry, bool sleepy, int numberOfArmsAndLegs, bool domesticated, 
        bool active, string temper)
    {
        Age = age;
        EnergyLevel = energyLevel;
        Hungry = hungry;
        Sleepy = sleepy;
        NumberOfArmsAndLegs = numberOfArmsAndLegs;
        Domesticated = domesticated; 
        Active = active;
        Temper = temper;
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