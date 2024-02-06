namespace PokemonTrainer;
public class Person
{
    private string name;
    private int age;

    public string Name

    {
        get => name;      
        set => name = value; 
       
    }
    public int Age

    {
        get => age;
        set => age = value;

    }
    public Person()
    {
        name = "No name";
        age = 1;
    }
    public Person(int age)
        :this()
    {
        this.age = age;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

}


