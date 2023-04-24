namespace cSharpAPI.Repositories;

public class FakeDB
{
    public List<Dog> Dogs;
    public FakeDB()
    {
        Dogs = new List<Dog>();
        Dogs.Add(new Dog("Stella", "Brown", 7, "Mutt", 1));
        Dogs.Add(new Dog("Max", "Black", 3, "Lab", 2));
        Dogs.Add(new Dog("Pheobe", "White", 5, "Akita", 3));
    }
}