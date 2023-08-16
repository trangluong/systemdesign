using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UserService.Domain.Entities;


namespace UserService.Infrastructure.Persistence
{
	public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

		public DbSet<User> Users { get; set; }

        public AppDbContext(IConfiguration configuration )
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

