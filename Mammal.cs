namespace Labb2_Arv;

public abstract class Mammal : Animal
{
    /// <summary>
    /// A CrazyRun method that differs between the animals and needs to be further defined in the subclasses in order to
    ///be used. 
    /// </summary>
    public abstract void CrazyRun();
    /// <summary>
    /// A method for some action. If hungry, the mammal will eat, if sleepy sleep. If neither, it will do a crazyRun.
    /// </summary>
    public void Action()
    {
        Console.WriteLine($"\nI'm bored! I need to do something");
        
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