using Dotnet6BasicWebApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet6BasicWebApp.Services.Auth.Interfaces
{
  public interface IUserInfoService
    {
        Task<ApplicationUser> GetUserBasicInfoes(string userName);
        Task<bool> DeleteRoleById(string? Id);
        Task<IEnumerable<ApplicationUser>> GetUserList();
        Task<List<string>> UsersRoles(string? name);
    }
}
