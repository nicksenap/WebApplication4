using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication4.DAL
{

    public class P2PDbContext : IdentityDbContext<P2PUser>
    {
        public P2PDbContext(): base("P2PConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<LoanApplication> LoanApplications { get; set; }
        public DbSet<InvestApplication> InvestApplications { get; set; }
        public DbSet<LoanAccount> LoanAccounts { get; set; }
        public DbSet<InvestAccount> InvestAccounts { get; set; }
        public DbSet<UserInfoData> UserInfoDatas { get; set; }
        public DbSet<UserInfoType> UserInfoTypes { get; set; }
        public DbSet<UserChangeLog> UserChangeLogs { get; set; }


        public static P2PDbContext Create()
        {
            return new P2PDbContext();
        }
    }
}