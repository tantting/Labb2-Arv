//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;
//Create an abstract overall class with 5 properties that all animals will have in common
public abstract class Animal
{
    public int Age { get; set; }
    public int EnergyLevel { get; set; }
    public bool Hungry { get; set; }
    public bool Sleepy { get; set; }
    
    public bool Domesticated { get; set; }
    
    public int NumberOfArmsAndLegs { get; set; }

    /// <summary>
    /// A eat method where energylevel is increased and after which the animal is not hungry anymore but sleepy instead. 
    /// </summary>
    public void Eat()
    {
        Console.WriteLine("I'm hungry! Time to eat! Yummy");
        EnergyLevel += 5;
        Hungry = false;
        Sleepy = true; 
    }
    /// <summary>
    /// after sleeping, the energylevels have increased and the animals are no longer sleepy. 
    /// </summary>
    public void Sleep()
    {
        Console.WriteLine("Zzz-zzz-zzz");
        Sleepy = false;
        EnergyLevel += 2; 
    }
    /// <summary>
    /// A method that makes little sence to define if now knowing the animal. Therefore abstract. 
    /// </summary>
    public abstract void MakeSound();
    
    /// <summary>
    /// A class to keep track of the properties that change over time for the animals
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"\nEnergy level: {EnergyLevel}, " +
                          $"Hungry: {Hungry}, Sleepy: {Sleepy}\n");
    }
}