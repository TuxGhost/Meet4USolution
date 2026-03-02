using dit.database.net.Entitities;

namespace DIT.MVC.Models;

public class ClubNotificationModel
{
    public IEnumerable<ModClubNotification> Notifications { get; set; } = new List<ModClubNotification>();
    public string Message { get; set; } = "";
}
