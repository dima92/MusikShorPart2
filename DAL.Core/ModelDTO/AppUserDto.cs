using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;


namespace DAL.Core.ModelDTO
{
    public class AppUserDto : IUser
    {
        public AppUserDto()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Cookie { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUserDto> manager,
            string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }

        public static implicit operator Microsoft.AspNet.Identity.EntityFramework.IdentityUser(AppUserDto v)
        {
            throw new NotImplementedException();
        }
    }
}
