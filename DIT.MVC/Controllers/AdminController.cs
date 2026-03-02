using DIT.MVC.Areas.Identity.Models;
using DIT.MVC.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DIT.MVC.Controllers;
/// <summary>
/// Contains function to administer all authorisation objects
/// </summary>
[Authorize]
public class AdminController : Controller
{    
    private readonly ApplicationDbContext context;
    private IdentityUserModel userModel = new IdentityUserModel();
    public AdminController(ApplicationDbContext context)
    {
        this.context = context;
    }
    public async Task<IActionResult> Index()
    {
        var users = await context.Users.ToListAsync();
        return View(users);
    }
    public async Task<IActionResult> Account(string id)
    {
        var user = await context.Users.FindAsync(id);
        if (user == null)
        {
            return Problem();
        }
        userModel.User = user!;
        userModel.AvailableRoles = await context.Roles.ToListAsync();   
        userModel.UserRoles = await context.UserRoles
            .Where(ur => ur.UserId == id)
            .Join(context.Roles, ur => ur.RoleId, r => r.Id, (ur, r) => r.Name)
            .ToListAsync();
        return View(userModel);
    }
    public async Task<IActionResult> RemoveAccount(string id)
    {
        var user = await context.Users.FindAsync(id);
        if(user == null)
            return Problem();
        context.Users.Remove(user);
        _ = await context.SaveChangesAsync();
        return RedirectToAction("Index");
    }
    public async Task<IActionResult> Roles()
    {
        var roles = await context.Roles.ToListAsync();
        return View(roles);
    }
    [HttpPost]
    public async Task<IActionResult> AddRole(string rolename)
    {
        _ = context.Roles.Add( new Microsoft.AspNetCore.Identity.IdentityRole { Name = rolename });
        _ = await context.SaveChangesAsync();
        var roles = await context.Roles.ToListAsync();
        return View(nameof(Roles));
    }
    /// <summary>
    /// Remove role from the database
    /// </summary>
    /// <param name="id">unique key role</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> RemoveRoleJson(string id)
    {
        var role = await context.Roles.FindAsync(id);
        if(role != null)
        {
            context.Roles.Remove(role);
            await context.SaveChangesAsync();
            return Ok();
        }            
        return NotFound();
    }
    [HttpPost]
    public async Task<IActionResult> AddUserRole(string  userId, string roleId)
    {
        var nw = new IdentityUserRole<string>
        {
            RoleId = roleId,
            UserId = userId
        };
        context.UserRoles.Add(nw);
        _ = await context.SaveChangesAsync();
        return Redirect($"/admin/account/{userId}");
    }
    [HttpPost]
    public async Task<IActionResult> RemoveUserRole(string userId, string roleName)
    {
        var userRolesToRemove = await context.UserRoles
            .Join(context.Roles,
                  userRole => userRole.RoleId,
                  role => role.Id,
                  (userRole, role) => new { UserRole = userRole, Role = role })
            .Where(joinResult => joinResult.UserRole.UserId == userId && joinResult.Role.Name == roleName)
            .Select(joinResult => joinResult.UserRole)
            .FirstOrDefaultAsync();
        if(userRolesToRemove != null)
        {
            context.UserRoles.Remove(userRolesToRemove);
            await context.SaveChangesAsync();
        }
        return Redirect($"/admin/account/{userId}");

    }
    [HttpPost]
    public async Task<IActionResult> ConfirmEmail(string id)
    {
        var userRole= await context.Users.Where(r => r.Id == id).FirstOrDefaultAsync();
        if(userRole != null)
        {
            userRole.EmailConfirmed= true;
            userRole.LockoutEnabled = false;
            context.Users.Update(userRole);
            await context.SaveChangesAsync();
        }
        return Redirect($"/admin/account/{id}");            
    }
}
