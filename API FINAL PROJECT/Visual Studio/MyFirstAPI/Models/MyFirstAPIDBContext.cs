using System;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using MyFirstAPI.Models;
using Microsoft.Extensions.Configuration;

namespace MyFirstAPI.Models
{
    public class MyFirstAPIDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MyFirstAPIDBContext(DbContextOptions<MyFirstAPIDBContext> options, IConfiguration configuration)
            : base (options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("CustomerDataService");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
    }
}
