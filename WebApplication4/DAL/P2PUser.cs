using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.DAL
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class P2PUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<P2PUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public string PersoNunmber { set; get; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { set; get; }
        
        // public virtual ICollection<UserInfoData> UserInfoData ;
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public UserStatus Status { set; get; }
        public UserType Type { set; get; }


        public virtual ICollection<UserChangeLog> UserChangeLogs { set; get; }
        public virtual ICollection<UserInfoData> UserInfoData { set; get; }
        public virtual ICollection<LoanApplication> LoanApplications { set; get; }
        public virtual ICollection<LoanAccount> LoanAccounts { set; get; }


        public P2PUser()
        {
            // this.CreationDate = DateTime.Today;
            
        }
    }
}