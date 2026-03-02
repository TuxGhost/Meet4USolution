using dit.database.net;
using dit.database.net.Entitities;
using DIT.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace DIT.MVC.Controllers;
[Authorize]
public class ClubController : Controller
{
    private readonly IClubService club;
    private ClubUserModel ClubUserModel { get; set; } = new();
    private ClubEventModel ClubEventModel { get; set; } =new();
    private ClubNotificationModel ClubNotificationModel { get; set; } = new();

    public ClubController(IClubService club)
    {
        this.club = club;
    }
    [Authorize(Roles = "Administrator")]
    public async Task<IActionResult> Index()
    {
        var leden = await club.GetUsersAsync();
        if(leden != null)        
            ClubUserModel.Users = leden;
        else
            ClubUserModel.Message = "De data kon niet geladen worden";
                
        return View(ClubUserModel);
    }
    public async Task<IActionResult> Leden()
    {
        var leden = await club.GetUsersAsync();
        if (leden != null)
            ClubUserModel.Users = leden;
        else
            ClubUserModel.Message = "De data kon niet geladen worden";

        return View(ClubUserModel);
    }
    [HttpGet("api/leden")]
    public async Task<IActionResult> LedenJson()
    {
        var leden = await club.GetUsersAsync();
        if (leden != null)
            ClubUserModel.Users = leden;
        else
            ClubUserModel.Message = "De data kon niet geladen worden";

        return Ok(ClubUserModel.Users);
    }
    public async Task<IActionResult> Lid(uint id)
    {
        var lid = await club.GetUserAsync(id);
        return View(lid);
    }
    /// <summary>
    /// Editeer lid
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<IActionResult> LidEdit(uint id)
    {
        var lid = await club.GetUserAsync(id);
        return View(lid);
    }
    /// <summary>
    /// Post update to club user
    /// </summary>
    /// <param name="lid"></param>
    /// <returns></returns>
    public async Task<IActionResult> LidEditPost(ModClubUser lid)
    {
        var lidDb = await club.GetUserAsync(lid.Id);
        if(lidDb != null)
        {
            lidDb.Email = lid.Email;
            lidDb.Telephone = lid.Telephone;
            lidDb.City = lid.City;
            lidDb.Address = lid.Address;
            var newLid = await club.UpdateUserAsync(lidDb);
            return View(nameof(lid), newLid);
        }
        return View(nameof(Lid), lid);
    }
    public IActionResult LidCreate()
    {
        var nieuwLid = new ModClubUser()
        {
            Username = " ",
            Country = " ",
            Telephone = " ",
            Telephone2 = " ",
            Type="0",
            BoardType = " ",
            BoardFunction = " ",
            Comments = " ",
            CommentsIntern = "Na jag beheer ",
            Referrer = " ",
            ReferrerExtra = " ",
            Gender = "m"
        };
        return View(nieuwLid);
    }
    [HttpPost]
    public async Task<IActionResult> LidCreatePost(ModClubUser lid)
    {
        if(ModelState.IsValid)
        {
            var nieuwLid = await club.AddUserAsync(lid);
            return View(nameof(Lid), nieuwLid);
        }
        return View(nameof(LidCreate),lid);
    }
    public async Task<IActionResult> Evenement(uint id)
    {
        var evenement = await club.GetEventAsync(id);
        return View(evenement);
    }
    public async Task<IActionResult> Evenementen()
    {
        var events = await club.GetEventsAsync();
        if (events != null)
            ClubEventModel.Events = events;
        else
            ClubUserModel.Message = "De data kon niet geladen worden";

        return View(ClubEventModel);
    }
    [HttpGet("api/events")]
    public async Task<IActionResult> EvenementenJson()
    {
        var events = await club.GetEventsAsync();
        if (events != null)
            ClubEventModel.Events = events;
        else
            ClubUserModel.Message = "De data kon niet geladen worden";

        return Ok(ClubEventModel.Events);
    }
    public async Task<IActionResult> Notifications()
    {
        var notifications = await club.GetNotificationsAsync();
        if (notifications != null)
            ClubNotificationModel.Notifications = notifications;
        else
            ClubUserModel.Message = "De data kon niet geladen worden";

        return View(ClubNotificationModel);
    }
    /// <summary>
    ///     Retrieve json data of notifications
    /// </summary>
    /// <returns></returns>
    [HttpGet("api/notifications")]
    public async Task<IActionResult> NotificationsJson()
    {
        var notifications = await club.GetNotificationsAsync();
        if (notifications != null)
            ClubNotificationModel.Notifications = notifications;
        else
            ClubUserModel.Message = "De data kon niet geladen worden";

        return Ok(ClubNotificationModel.Notifications);
    }
    public IActionResult EvenementCreate()
    {
        DateTime start = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,DateTime.Now.Hour+1,0,0);
        ModClubEvent evenement =  new()
        {
            EventStart = start,
            EventRepeat = "Once",
            EventEnd = start,
            EventTill = start.AddHours(2),
            Image = "None",
            Country= "BE",
            AliasNl = "ToBeDefined"
        };
        return View(evenement);
    }
    [HttpPost]
    public async Task<IActionResult> EvenementCreatePost(ModClubEvent evenement)
    {
        if(ModelState.IsValid)
        {
            evenement.AliasNl = evenement.NameNl;
            await club.AddEventAsync(evenement);            
            return View(nameof(Evenementen), ClubEventModel);
        }
        return View(nameof(EvenementCreate), evenement);
    }
    [HttpGet]
    public async Task<IActionResult> EvenementEdit(uint id)
    {                
        ModClubEvent? eventObject = await club.GetEventAsync(id);        
        if (eventObject != null) 
            return View(nameof(EvenementEdit), eventObject);
        return View(nameof(Evenementen));
    }
    public async Task<IActionResult> EvenementEditPost(ModClubEvent evenement)
    {
        if (ModelState.IsValid)
        {
            var result = await club.UpdateEventAsync(evenement);
            return View(nameof(Evenementen), ClubEventModel);
        }
        return View(nameof(EvenementEdit), evenement);
    }
}
