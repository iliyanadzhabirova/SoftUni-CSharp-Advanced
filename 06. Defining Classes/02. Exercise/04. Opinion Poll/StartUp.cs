

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main()
        {
            List<Person>people = new List<Person>();
            int lines = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
            }
            var result = people.Where(p => p.Age > 30)
                .OrderBy(p=>p.Name);

            foreach (Person person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            
        }

    }
        
    
}