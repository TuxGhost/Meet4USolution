using dit.database.net.Entitities;

namespace DIT.MVC.Models;

public class ClubEventModel
{
    public IEnumerable<ModClubEvent> Events { get; set; } = new List<ModClubEvent>();
    public string Message { get; set; } = "";
}
