using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NewBlazorProject.Server.Models;
using NewBlazorProject.Shared.Models;
using NewBlazorProject.Shared.Models.MasterData;

namespace NewBlazorProject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "User", NormalizedName = "USER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        }

        public DbSet<MD_District> mD_Districts { get; set; }
        public DbSet<MD_Tehsil> mD_Tehsils { get; set; }
        public DbSet<MD_CreatedBy> mD_CreatedBy { get; set; }
        public DbSet<MD_Gender> mD_Genders { get; set; }
        public DbSet<MD_UpdatedBy> mD_UpdatedBys { get; set; }
        public DbSet<MD_Address> mD_Addresses { get; set; }
        public DbSet<MD_UploadFile> MD_UploadFiles { get; set; }
        public DbSet<MD_Directory> MD_Directories { get; set; }




    }
}