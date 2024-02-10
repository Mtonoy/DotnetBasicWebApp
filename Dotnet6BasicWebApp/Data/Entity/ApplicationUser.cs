using Microsoft.AspNetCore.Identity;

namespace Dotnet6BasicWebApp.Data.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }

        public string? Citizenship { get; set; }

        public string? NationalIdentityNo { get; set; }

        public string? ImagePath { get; set; }

        public string? otpCode { get; set; }

        public int? isVarified { get; set; }

        public int? isActive { get; set; }

        public int? isChangePassword { get; set; }

        public DateTime? createdAt { get; set; }

        public string? createdBy { get; set; }

        public DateTime? updatedAt { get; set; }

        public string? updatedBy { get; set; }
    }
}
