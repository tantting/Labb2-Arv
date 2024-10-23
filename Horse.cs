namespace Labb2_Arv;

public class Horse : Animal
{
    public bool RaceHorse { get; set; }

    public Horse()
    {
        Name = "Blacky";
        Age = 5;
        EnergyLevel = 6;
        Hungry = false;
        Sleepy = false;
        RaceHorse = true;
    }

    //An override method for Crazyrun, where there's a difference between animals at which energy-level they are hungry.
    public override void CrazyRun()
    {
        Console.WriteLine("Oh yeah, how liberating it is to do a crazy run");
        EnergyLevel -= 3;
        if (EnergyLevel < 4) 
        {
            Hungry = true; 
        } 
    }
    //An additional method for 
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