using System.Globalization;
using System.Runtime.InteropServices;

////Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

class Program
{
    static void Main(string[] args)
    {
        //Creates new instanses of the animal classes
        var dog = new Dog();
        var perro = new Perro();
        var rottis = new Rotweiler();
        var horse = new Horse();
        var rabbit = new Rabbit();
        var snake = new Snake();
        
        //make a list of animals that inherent from the class Animals
        var animals = new List<Animal>() { dog, perro, rottis, horse, rabbit, snake };
        
        //Run a foreach loop that print the sound of all the animals i have added to the animals list. 
        foreach (var animal in animals)
        {
            Console.Write($"{animal.GetType().Name} says ");
            animal.MakeSound();
        }
        //Create a list of mammals
        var mammals = new List<Mammal>() { dog, perro, rottis, horse, rabbit, };
        //Run the "mammal".method Activate though one of the objects that inherent from mammals
        dog.Activate(mammals);
    }
}