

namespace PokemonTrainer;

public class StartUp
{
   static void Main()
    {
        Person Peter = new Person();      
        Person George = new( 18);
        var Jose = new Person("Jose", 43);

        Console.WriteLine($"{Peter.Name} {Peter.Age}");
        Console.WriteLine($"{George.Name} {George.Age}");
        Console.WriteLine($"{Jose.Name} {Jose.Age}");

    }
}