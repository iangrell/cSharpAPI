namespace cSharpAPI.Services;

public class DogsService
{
    private readonly DogsRepository _repo;
    public DogsService(DogsRepository repo)
    {
        _repo = repo;
    }

    internal List<Dog> Get()
    {
        List<Dog> dogs = _repo.Get();
        return dogs;
    }

    internal Dog Create(Dog dogData)
    {
        return _repo.Create(dogData);
    }
}