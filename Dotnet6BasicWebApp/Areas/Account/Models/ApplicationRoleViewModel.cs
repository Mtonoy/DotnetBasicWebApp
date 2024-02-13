using Dotnet6BasicWebApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnet6BasicWebApp.Areas.Account.Models
{
    public class ApplicationRoleViewModel
    {
        public string? RoleId { get; set; }
        public string? PreRoleId { get; set; }
        public string[]?  roleIdList { get; set; }
        public string? userId { get; set; }
        public string? aspUserId { get; set; }
        public string? comment1 { get; set; }
        public string? comment2 { get; set; }

        public string? userName { get; set; }

        public string? RoleName { get; set; }

        public string? nid { get; set; }

        public string? mobile { get; set; }

        public string? gdTime { get; set; }

        public int? rankId { get; set; }

        public int? designationId { get; set; }

        public int? moduleId { get; set; }

        public int? Id { get; set; }
        public int? MasterId { get; set; }
        public int? OndutyOfficer { get; set; }

        public string? description { get; set; }

        public string? moduleName { get; set; }
        public IEnumerable<ApplicationRoleViewModel>? roleViewModels { get; set; }
        public IEnumerable<ApplicationUser>? userList { get; set; }
    }
}
