//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

public class Dog : Animal
{
    //Add an additional property for dogs. 
    public bool Active { get; set; }

    //A constructor where initial values for new instanses of the dog-klass are set. 
    public Dog()
    {
        Name = "Fido";
        Age = 8;
        EnergyLevel = 10;
        Hungry = false;
        Sleepy = false;
        Active = true; 
    }
    //an additonal method for dogs  
    public void Track()
    {
        Console.WriteLine($"Vad ska {Name} spåra upp?");
        string answer = Console.ReadLine();
        Console.WriteLine($"Hittat! {answer} låg under soffan! ");
    }
    //An override method for Crazyrun, where there's a difference between animals at which energy-level they are hungry. 
    public override void CrazyRun()
    {
            Console.WriteLine("I have so much energy - must doooo aaaa Craaaazy Ruuuun!!!");
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