using System.ComponentModel.DataAnnotations;
namespace cSharpAPI.Models;

public class Dog
{
    public Dog(string name, string color, int age, string breed, int id)
    {
        Name = name;
        Color = color;
        Age = age;
        Breed = breed;
        Id = id;
    }


    public string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public int Id { get; set; }
}
