namespace gregsListSharp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HomesController : ControllerBase
{
    private readonly HomesService homesService;
    {
        this.homesService = homesService;
    }
}