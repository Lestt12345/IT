using System.Collections.Generic;
using System.Reflection.Emit;
using WebApplication_COMMAND.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication_COMMAND.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Category)
                .WithMany(c => c.Events)
                .HasForeignKey(e => e.CategoryId);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Organizer)
                .WithMany(u => u.EventsOrganized)
                .HasForeignKey(e => e.OrganizerId);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Event)
                .WithMany(e => e.Registrations)
                .HasForeignKey(r => r.EventId);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.User)
                .WithMany(u => u.Registrations)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Event>()
                .HasQueryFilter(e => !e.IsDeleted);
        }
    }

}
