namespace Labb2_Arv;

public class Horse : Mammal
{
    public bool RaceHorse { get; set; }

    public Horse()
    {
        Domesticated = true; 
    }

    public Horse(int age, int energyLevel, bool hungry, bool sleepy, int numberOfArmsAndLegs, bool domesticated, 
        bool raceHorse)
    {
        Age = age;
        EnergyLevel = energyLevel;
        Hungry = hungry;
        Sleepy = sleepy;
        NumberOfArmsAndLegs = numberOfArmsAndLegs;
        Domesticated = domesticated; 
        RaceHorse = raceHorse; 
    }

    //An override method for Crazyrun, where there's a difference between animals at which energy-level they are hungry.
    public override void CrazyRun()
    {
        Console.WriteLine("I have so much energy - must doooo aaaa Craaaazy Ruuuun! Weeeeiiiiiiii!!");
        EnergyLevel -= 3;
        if (EnergyLevel < 4) 
        {
            Hungry = true; 
        } 
    }
    //An additional method for horses
    public void RaceDay()
    {
        if (RaceHorse)
        {
            EnergyLevel -= 4;
            if (EnergyLevel < 4)
            {
                Hungry = true;
            }

            Sleepy = true;
        }
        else
        {
            Console.WriteLine("A nice, while the others are off racing, I have the entire field for myself!");
        }
    }
    public override void MakeSound()
    {
        Console.WriteLine("Neeeeiiiggghhhh");
    }
}