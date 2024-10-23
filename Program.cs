using System.Globalization;
////Jenny-Ann Hayward, SUT24
namespace Labb2_Arv;

class Program
{
    static void Main(string[] args)
    {
        var dog = new Dog();
        var perro = new Perro();
        var rottis = new Rotweiler();
        var horse = new Horse();
        var rabbit = new Rabbit(); 
        
        dog.MakeSound();
        perro.MakeSound();
        rottis.MakeSound();
        horse.MakeSound();
        rabbit.MakeSound();
        
        rottis.Action();
        
    }
}