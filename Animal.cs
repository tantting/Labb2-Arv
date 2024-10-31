//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;
//Create an abstract overall class with six properties that all animals will have in common
public abstract class Animal
{
    public int Age { get; set; } = 5;
    public int EnergyLevel { get; set; } = 5;
    public bool Hungry { get; set; } = false;
    public bool Sleepy { get; set; } = false;

    public bool Domesticated { get; set; } = false;
    public int NumberOfArmsAndLegs { get; set; } = 4; 

    /// <summary>
    /// A eat method where energy level is increased and after which the animal is not hungry anymore but sleepy instead. 
    /// </summary>
    public void Eat()
    {
        Console.WriteLine("I'm hungry! Time to eat! Yummy");
        EnergyLevel += 5;
        Hungry = false;
        Sleepy = true; 
    }
    /// <summary>
    ///When sleeping, the energy levels increase and sleepy is set to false.  
    /// </summary>
    public void Sleep()
    {
        Console.WriteLine("Zzz-zzz-zzz");
        Sleepy = false;
        EnergyLevel += 2; 
    }
    /// <summary>
    /// A method for animal sound. Abstrsact since I want it defined in the subclasses.  
    /// </summary>
    public abstract void MakeSound();
    
    /// <summary>
    /// A class to keep track of the properties that change the most over time.
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"\nEnergy level: {EnergyLevel}, " +
                          $"Hungry: {Hungry}, Sleepy: {Sleepy}\n");
    }
}