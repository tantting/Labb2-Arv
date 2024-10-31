//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

public class Dog : Mammal
{
    public bool Active { get; set; } = true;
    //An empty constructor and one for setting other values for all properties
    public Dog()
    {
        Domesticated = true;
    }

    public Dog(int age, int energyLevel, bool hungry, bool sleepy, int numberOfArmsAndLegs, bool domesticated, 
        bool active, bool enjoysWater)
    {
        Age = age;
        EnergyLevel = energyLevel;
        Hungry = hungry;
        Sleepy = sleepy;
        NumberOfArmsAndLegs = numberOfArmsAndLegs;
        Domesticated = domesticated; 
        Active = active;
    }
    //an additonal method for dogs  
    public void Track()
    {
        Console.WriteLine($"Vad ska jag spåra upp åt dig?");
        string answer = Console.ReadLine();
        Console.WriteLine($"Hittat! {answer} låg under soffan! ");
    }
    //An override method for Crazyrun, where there's a difference between animals at which energy-level they are hungry. 
    public override void CrazyRun()
    {
            Console.WriteLine("I have so much energy - must doooo aaaa Craaaazy Ruuuun! Weeeeiiiiiiii!!");
            EnergyLevel -= 3;
            if (EnergyLevel < 5)   
            {
                Hungry = true; 
            } 
    }
    public override void MakeSound()
    {
        Console.WriteLine("Vov vov");
    }
}