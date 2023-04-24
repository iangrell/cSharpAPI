

namespace cSharpAPI.Controllers;
[ApiController]
[Route("api/[controller]")]
public class DogsController : ControllerBase
{
    private readonly DogsService _dogsService;
    public DogsController(DogsService dogsService)
    {
        _dogsService = dogsService;
    }

    // public DogsService Get_dogsService()
    // {
    //     return _dogsService;
    // }

    [HttpGet]
    public ActionResult<List<Dog>> Get()
    {
        try
        {
            List<Dog> dogs = _dogsService.Get();
            return Ok(dogs);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Dog> Create([FromBody] Dog dogData)
    {
        try
        {
            Dog dog = _dogsService.Create(dogData);
            return Ok(dog);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}