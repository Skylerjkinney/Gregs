

namespace gregsListSharp.Services;

public class HomesService(HomesRepository repo)
{
    private readonly HomesRepository repo = repo;


    internal List<Home> GetAllHomes()
    {
        List<Home> homes = repo.GetAllHomes();
        return homes;
    }
    internal Home CreateHome(Home homeData)
    {
        Home home = repo.CreateHome(homeData);
        return home;
    }
}