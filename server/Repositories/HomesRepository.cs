


namespace gregsListSharp.Repositories;

public class HomesRepository(IDbConnection db)
{
    private readonly IDbConnection db = db;

    internal Home CreateHome(Home homeData)
    {
        string sql = @"
        INSERT INTO homes
        (Design, Description, Color, Bathrooms, Bedrooms, ImgUrl, Price)
        VALUES
        (@Design, @Description, @Color, @Bathrooms, @Bedrooms, @ImgUrl, @Price);

        SELECT
        *
        FROM cars
        WHERE id = LAST_INSERT_ID();
        ";
        Home home = db.Query<Home>(sql, homeData).FirstOrDefault();
        return home;
    }
}