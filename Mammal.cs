namespace Labb2_Arv;

public abstract class Mammal : Animal
{
    /// <summary>
    /// A CrazyRun method that differs between the mammals and needs to be further defined in the subclasses in order to
    ///be used. The difference between animals lyes in at which energy-level they are hungry.
    /// </summary>
    public abstract void CrazyRun();
    /// <summary>
    /// A method for some action. If hungry, the mammal will eat, if sleepy sleep. If neither, it will do a crazyRun.
    /// </summary>
    public void Action(Mammal mammal)
    {
        Console.WriteLine($"\nI'm bored! I need to do something");

        bool runLoop = true; 
        
        while (runLoop)
        {
            Console.Clear();
            Console.WriteLine($"Animal: {mammal.GetType().Name}");
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

            bool correctAnswer = false;
            while (!correctAnswer)
            {
                Console.WriteLine(
                    $"\nDo you want the {mammal.GetType().Name.ToLower()} to do what its instinct tells it to " +
                    $"do right now? [yes/no]");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    correctAnswer = true;
                }
                else if (answer == "no")
                {
                    correctAnswer = true;
                    runLoop = false;
                }
                else
                {
                    Console.WriteLine("Did not get that! Try again!");
                }
            }
        }
    }

    public void Activate(List<Mammal> mammals)
    {
        bool runOuterLoop = true;

        while (runOuterLoop)
        {
            Console.WriteLine($"\nWhich mammal would you like to activate?\n" +
                              $"[1] A {mammals[0].GetType().Name}\n" +
                              $"[2] A {mammals[1].GetType().Name}\n" +
                              $"[3] A {mammals[2].GetType().Name}\n" +
                              $"[4] A {mammals[3].GetType().Name}\n" +
                              $"[5] A {mammals[4].GetType().Name}\n");
            
            string choice = Console.ReadLine();
            Mammal mammal = null;

            switch (choice)
            {
                case "1":
                    mammals[0].Action(mammals[0]);
                    break;
                case "2":
                    mammals[1].Action(mammals[1]);  
                    break;
                case "3":
                    mammals[2].Action(mammals[2]);  
                    break;
                case "4":
                    mammals[3].Action(mammals[3]);  
                    break;
                case "5":
                    mammals[4].Action(mammals[4]);  
                    break;
                default:
                    Console.WriteLine("Invalid Input! Try again!!");
                    break;
            }

            bool correctInput = false; 

                while (!correctInput)
                {
                    Console.WriteLine("Would you like to activate a new animal? [yes/no]");
                    string answer = Console.ReadLine().ToLower(); 
                    
                    if ( answer == "yes")
                    {
                        correctInput = true;
                    }
                    else if (answer == "no")
                    {
                        correctInput = true;
                        runOuterLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("I do not understand! Try again!"); 
                    }
                }
        }
        Console.WriteLine("\nThanks for hanging out with my animals! See you soon!");
    }
}