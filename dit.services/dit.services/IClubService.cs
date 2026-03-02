using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;

namespace dit.database.net;
/// <summary>
/// Interface model for retrieving club information
/// </summary>
public interface IClubService
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
    public Task<ModClubUser?> GetUserAsync(uint Id);
    /// <summary>
    /// Add new club user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public Task<ModClubUser?> AddUserAsync(ModClubUser user);
    /// <summary>
    /// Update specific club user
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public Task<ModClubUser> UpdateUserAsync(ModClubUser user);
    /// <summary>
    /// Retrieve all events
    /// </summary>
    /// <returns></returns>
    public Task<ModClubUser?> DeleteUserAsync(ModClubUser user);
    public Task<IEnumerable<ModClubEvent>> GetEventsAsync();
    /// <summary>
    /// Retrieve specific event by Id 
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>                  
    public Task<ModClubEvent?> GetEventAsync(uint Id);
    /// <summary>
    /// Add new event
    /// </summary>
    /// <param name="eventObject"></param>
    /// <returns></returns>
    public Task<ModClubEvent?> AddEventAsync(ModClubEvent eventObject);
    /// <summary>
    /// Update event
    /// </summary>
    /// <param name="eventObject"></param>
    /// <returns></returns>
    public Task<ModClubEvent?> UpdateEventAsync(ModClubEvent eventObject);
    /// <summary>
    /// Delete event
    /// </summary>
    /// <param name="eventObject"></param>
    /// <returns></returns>
    public Task<ModClubEvent?> DeleteEventAsync(ModClubEvent eventObject);
    /// <summary>v
    /// Retrieve all notifications
    /// </summary>
    /// <returns></returns>        
    public Task<IEnumerable<ModClubNotification>> GetNotificationsAsync();
    /// <summary>
    /// Retrieve all Tags
    /// </summary>
    /// <returns></returns>
    public Task<ModClubNotification?> GetNotificationAsync(uint Id);
    /// <summary>
    /// Add new notification to the queue
    /// </summary>
    /// <param name="notification"></param>
    /// <returns></returns>
    public Task<ModClubNotification?> AddNotificationAsync(ModClubNotification notification);
    /// <summary>
    /// Update notification
    /// </summary>
    /// <param name="notification"></param>
    /// <returns></returns>
    public Task<ModClubNotification?> UpdateNotificationAsync(ModClubNotification notification);
    /// <summary>
    /// Delete notification
    /// </summary>
    /// <param name="notification"></param>
    /// <returns></returns>
    public Task<ModClubNotification?> DeleteNotificationAsync(ModClubNotification notification);
    /// <summary>
    /// Get all tags
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<ModClubTag?>> GetTagsAsync();    
    /// <summary>
    /// Get specific tag
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
    public Task<ModClubTag?> GetTagAsync(uint Id);
    /// <summary>
    /// get specific tag
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    public Task<ModClubTag?> AddTagAsync(ModClubTag tag);
    /// <summary>
    /// Update tag
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    public Task<ModClubTag?> UpdateTagAsync(ModClubTag tag);
    /// <summary>
    /// Delete specific tag
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    public Task<ModClubTag?> DeleteTagAsync(ModClubTag tag);
}
