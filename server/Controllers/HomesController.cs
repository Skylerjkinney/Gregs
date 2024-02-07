namespace gregsListSharp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HomesController : ControllerBase
{
    private readonly HomesService homesService;

    public HomesController(HomesService homesService)
    {
        this.homesService = homesService;
    }

    [HttpGet]

    public ActionResult<List<Home>> GetAllHomes()
    {
        try
        {
            List<Home> homes = homesService.GetAllHomes();
            return Ok(homes);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}