using dit.database.net;
using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;


namespace dit.services;

public class Club : IClubService
{
    private readonly DitDbContext ditDbContext = null!;
    private List<ModClubUser> Users { get; set; } = null!;
    private List<ModClubEvent> Events { get; set; } = null!;
    private List<ModClubNotification> Notifications { get; set; } = null!;
    private List<ModArticle> Articles { get; set; } = null!;
    public Club() { }
    public Club(DitDbContext ditDbContext)
    {
        this.ditDbContext = ditDbContext;
    }

    public async Task<IEnumerable<ModClubUser>> GetUsersAsync()
    {                
        if(Users == null)
            Users = await ditDbContext.ModClubUsers.ToListAsync();
        return Users;
    }
    [Obsolete("GetUserAsync signint int is obsolete. Use the one with unsigned")]
    public async Task<ModClubUser?> GetUserAsync(int Id)
    {
        ModClubUser? user = await ditDbContext.ModClubUsers.FindAsync(Id);
        return user;
    }

    public async Task<IEnumerable<ModClubEvent>> GetEventsAsync()
    {
        if(Events == null)
            Events = await ditDbContext.ModClubEvents.ToListAsync();
        return Events;
    }
    [Obsolete("GetEventAsync signint int is obsolete. Use the one with unsigned")]
    public async Task<ModClubEvent?> GetEventAsync(int Id)
    {
        var result = await ditDbContext.ModClubEvents.FindAsync(Id);
        return result!;
    }

    public async Task<IEnumerable<ModClubNotification>> GetNotificationsAsync()
    {
        if(Notifications == null)
            Notifications = await ditDbContext.ModClubNotifications.ToListAsync();        
        return Notifications;
    }
    public async Task<ModClubNotification?> GetNotificationAsync(int id)
    {
        var notification = await ditDbContext.ModClubNotifications.FindAsync(id);
        return notification;
    }
    public async Task<IEnumerable<ModClubTag?>> GetTagsAsync()
    {
        var result = await ditDbContext.ModClubTags.ToListAsync();
        return result;
    }

    public async Task<ModClubUser?> GetUserAsync(uint Id)
    {
        ModClubUser? user = await ditDbContext.ModClubUsers.FindAsync(Id);
        return user;
    }

    public async Task<ModClubEvent?> GetEventAsync(uint Id)
    {
        var result = await ditDbContext.ModClubEvents.FindAsync(Id);
        return result!;
    }

    public async Task<ModClubTag?> GetTagAsync(uint id)
    {
        var result = await ditDbContext.ModClubTags.FindAsync(id);
        return result!;
    }

    public async Task<IEnumerable<ModArticle>> GetArticles()
    {
        if(Articles == null)
            Articles = await ditDbContext.ModArticles.ToListAsync();
        return Articles;
    }

    public async Task<ModArticle?> GetArticleAsync(uint id)
    {
        ModArticle? article = null;
        if (Articles == null)
        {
            article = await ditDbContext.ModArticles.FindAsync(id);
        }
        else {
            article = Articles.Find(x => x.ArticlesId == id);
        }        
        return article;
    }

    public async Task<ModClubUser?> AddUserAsync(ModClubUser user)
    {        
        if (Users == null)
            Users = new();
        if (user.BoardFunction == null)
            user.BoardFunction = string.Empty;
        if (user.BoardType == null)
            user.BoardType = string.Empty;
        if (user.BoardFunction == null)
            user.BoardFunction = string.Empty;
        if(user.Comments == null)
            user.Comments = string.Empty;
        if(user.Telephone2 == null) 
            user.Telephone2 = string.Empty;
        if(user.Country == null)
            user.Country = string.Empty;
        if (user.Type == null)
            user.Type = "0";
        if(user.CommentsIntern == null)
            user.CommentsIntern = string.Empty;
        if (user.Referrer == null)
            user.Referrer = string.Empty;
        if(user.ReferrerExtra == null)
            user.ReferrerExtra = string.Empty;
        if(user.Telephone ==  null)
            user.Telephone = string.Empty;
        Users.Add(user);
        var result = await ditDbContext.ModClubUsers.AddAsync(user);
        if (result != null)
        {
            await ditDbContext.SaveChangesAsync();
            return result.Entity;
        }            
        return null;           
    }

    public async Task<ModClubUser> UpdateUserAsync(ModClubUser user)
    {
        var result = ditDbContext.ModClubUsers.Update(user);
        var r = await ditDbContext.SaveChangesAsync();
        return user;
    }

    public async Task<ModClubUser?> DeleteUserAsync(ModClubUser user)
    {
        var userObject = ditDbContext.Remove(user);
        var result = await ditDbContext.SaveChangesAsync();
        return userObject.Entity;
    }

    public async Task<ModClubEvent?> AddEventAsync(ModClubEvent eventObject)
    {
        var r1 = ditDbContext.ModClubEvents.Add(eventObject);
        var r2 = await ditDbContext.SaveChangesAsync();
        return r1.Entity;
    }

    public async Task<ModClubEvent?> UpdateEventAsync(ModClubEvent eventObject)
    {
        var r1 = ditDbContext.ModClubEvents.Update(eventObject);
        var r2 = await ditDbContext.SaveChangesAsync();
        return r1.Entity;
    }

    public async Task<ModClubEvent?> DeleteEventAsync(ModClubEvent eventObject)
    {
        var r1 = ditDbContext.ModClubEvents.Remove(eventObject);
        var r2 = await ditDbContext.SaveChangesAsync();
        return r1.Entity; 
    }

    public async Task<ModClubNotification?> GetNotificationAsync(uint Id)
    {
        var notifcation = await ditDbContext.ModClubNotifications.FindAsync(Id);
        return notifcation;
    }

    public async Task<ModClubNotification?> AddNotificationAsync(ModClubNotification notification)
    {
        var r1 = await ditDbContext.ModClubNotifications.AddAsync(notification);
        return r1.Entity;
    }

    public async Task<ModClubNotification?> UpdateNotificationAsync(ModClubNotification notification)
    {
        var r1 = ditDbContext.ModClubNotifications.Update(notification);
        var r2 = await ditDbContext.SaveChangesAsync();
        return r1.Entity;
    }

    public async Task<ModClubNotification?> DeleteNotificationAsync(ModClubNotification notification)
    {
        var r1 = ditDbContext.ModClubNotifications.Remove(notification);
        var r2 = await  ditDbContext.SaveChangesAsync();
        return r1.Entity;
    }

    public async Task<ModClubTag?> AddTagAsync(ModClubTag tag)
    {
        var r1 = await ditDbContext.ModClubTags.AddAsync(tag);
        return r1.Entity;
    }

    public async Task<ModClubTag?> UpdateTagAsync(ModClubTag tag)
    {
        var r1 = ditDbContext.ModClubTags.Update(tag);
        var r2 = await ditDbContext.SaveChangesAsync();
        return r1.Entity;
    }

    public async Task<ModClubTag?> DeleteTagAsync(ModClubTag tag)
    {
        var r1 = ditDbContext.ModClubTags.Remove(tag);
        var r2 = await ditDbContext.SaveChangesAsync();
        return r1.Entity;
    } 
}