using dit.database.net.Entitities;

namespace DIT.MVC.Models;

public class ClubUserModel
{
    public IEnumerable<ModClubUser> Users { get; set; } = new List<ModClubUser>();
    public string Message { get; set; } = "";
}
