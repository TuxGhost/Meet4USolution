using dit.database.net.Entitities;

namespace dit.database.net;
/// <summary>
/// Interface model for retrieving club information 
/// </summary>
[Obsolete("New service model IClubServic")]
public interface IClub
{
    /// <summary>
    /// Retrieve all club users
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<ModClubUser>> GetUsersAsync();
    /// <summary>
    /// Retrieve specific club user
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    public Task<ModClubUser?> GetUserAsync(int Id);
    /// <summary>
    /// Retrieve all events
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<ModClubEvent>> GetEventsAsync();
    /// <summary>
    /// Retrieve specific event by Id 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    public Task<ModClubEvent?> GetEventAsync(int Id);
    /// <summary>
    /// Retrieve all notifications
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<ModClubNotification>> GetNotificationsAsync();
    /// <summary>
    /// Retrieve all Tags
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<ModClubTag?>> GetTagsAsync();    
}
