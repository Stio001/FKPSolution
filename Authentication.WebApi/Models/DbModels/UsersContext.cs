using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.WebApi.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication.WebApi.Models.DbModels
{
    public class UsersContext : IdentityDbContext<AppUser>
    {
        public UsersContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }

        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = "4F980B53-6D51-422B-9537-34425B5418F4",
                Name = "admin",
                NormalizedName = "ADMIN"
            }, new IdentityRole()
            {
                Id = "A492270E-5B79-4F10-8940-5692CD88B4A4",
                Name = "user",
                NormalizedName = "USER"
            }, new IdentityRole()
            {
                Id = "67303D22-E86B-413B-BDF6-B516EFFB2CCD",
                Name = "manager",
                NormalizedName = "MANAGER"
            });

            builder.Entity<AppUser>().HasData(new AppUser()
            {
                Id = "43DA5F5E-8874-471B-BCA9-01855FA47DA4",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.ru",
                NormalizedEmail = "ADMIN@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin"),
                SecurityStamp = string.Empty
            }, new AppUser()
            {
                Id = "D13A28A4-939C-4101-98B2-EA4288059C8F",
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@mail.ru",
                NormalizedEmail = "USER@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "user123"),
                SecurityStamp = string.Empty
            }, new AppUser()
            {
                Id = "6B8F18E6-7BC4-4FAB-BCBF-7A67E8531645",
                UserName = "manager",
                NormalizedUserName = "MANAGER",
                Email = "manager@mail.ru",
                NormalizedEmail = "MANAGER@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "manager"),
                SecurityStamp = string.Empty
            }, new AppUser()
            {
                Id = "2F9AC7C3-8870-4CF5-BFCC-2CF2957DB5BD",
                UserName = "pepega",
                NormalizedUserName = "PEPEGA",
                Email = "pepega@mail.ru",
                NormalizedEmail = "PEPEGA@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "pepega"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
            {
                UserId = "43DA5F5E-8874-471B-BCA9-01855FA47DA4",
                RoleId = "4F980B53-6D51-422B-9537-34425B5418F4"
            }, new IdentityUserRole<string>()
            {
                UserId = "D13A28A4-939C-4101-98B2-EA4288059C8F",
                RoleId = "A492270E-5B79-4F10-8940-5692CD88B4A4"
            }, new IdentityUserRole<string>()
            {
                UserId = "6B8F18E6-7BC4-4FAB-BCBF-7A67E8531645",
                RoleId = "67303D22-E86B-413B-BDF6-B516EFFB2CCD"
            }, new IdentityUserRole<string>()
            {
                UserId = "2F9AC7C3-8870-4CF5-BFCC-2CF2957DB5BD",
                RoleId = "67303D22-E86B-413B-BDF6-B516EFFB2CCD"
            }, new IdentityUserRole<string>()
            {
                UserId = "2F9AC7C3-8870-4CF5-BFCC-2CF2957DB5BD",
                RoleId = "4F980B53-6D51-422B-9537-34425B5418F4"
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionsStrings.UsersConnection);
        }
    }
}
