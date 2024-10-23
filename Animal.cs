//Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;
//Create an abstract overall class with 5 properties that all animals will have in common
public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int EnergyLevel { get; set; }
    public bool Hungry { get; set; }
    public bool Sleepy { get; set; }

    //A eat method where energylevel is increased and after which the animal is not hungry anymore but sleepy instead. 
    public void Eat()
    {
        Console.WriteLine("I'm hungry! Time to eat! Yummy");
        EnergyLevel += 5;
        Hungry = false;
        Sleepy = true; 
    }
    //after sleeping, the energylevels have increased and the animals are no longer sleepy. 
    public void Sleep()
    {
        Console.WriteLine("Zzz-zzz-zzz");
        Sleepy = false;
        EnergyLevel += 2; 
    }
    //A CrazyRun method that differs between the animals and needs to be further defined in the subclasses in order to
    //be used. 
    public abstract void CrazyRun();
    //A method that makes little sence to define if now knowing the animal. Therefore abstract. 
    public abstract void MakeSound();
    
    //A class to keep track of the properties that change over time for the animals
    public void Print()
    {
        Console.WriteLine($"\nEnergy level: {EnergyLevel}, " +
                          $"Hungry: {Hungry}, Sleepy: {Sleepy}\n");
    }
    //A method for some action. If hungry, the animal will eat, if sleepy sleep. If neither, it will do a crazyRun
    public void Action()
    {
        Console.WriteLine($"\nHi! I'm {Name}! I'm bored! I need to do something");
        
        do
        {
            Print();
            if (Hungry)
            {
                Eat();
            }
            else if (Sleepy)
            {
                Sleep();
            }
            else
            {
                CrazyRun();
            }

            Console.WriteLine("One more go? [ja/nej]");
        } while (Console.ReadLine().ToLower() == "ja");
    }
}