namespace cSharpAPI.Repositories;

public class DogsRepository
{
    private readonly FakeDB _db;
    public DogsRepository(FakeDB db)
    {
        _db = db;
    }

    internal List<Dog> Get()
    {
        return _db.Dogs;
    }

    internal Dog Create(Dog dogData)
    {
        int dogId = _db.Dogs[_db.Dogs.Count - 1].Id + 1;
        Dog newDog = new Dog(dogData.Name, dogData.Color, dogData.Age, dogData.Breed, dogData.Id);
        _db.Dogs.Add(newDog);
        return newDog;
    }
}