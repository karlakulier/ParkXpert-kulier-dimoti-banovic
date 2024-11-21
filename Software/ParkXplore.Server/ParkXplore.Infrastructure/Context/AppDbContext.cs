using Microsoft.EntityFrameworkCore;
using ParkXplore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ParkXplore.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Parking>? Parkings { get; set; }
        public DbSet<ParkingSpot>? ParkingSpots { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Parking>()
                .Property(p => p.Type)
                .HasConversion<string>();

           
            modelBuilder.Entity<ParkingSpot>()
                .Property(ps => ps.Type)
                .HasConversion<string>(); 

           
            modelBuilder.Entity<ParkingSpot>()
                .HasOne(ps => ps.Parking)
                .WithMany(p => p.ParkingSpots)
                .HasForeignKey(ps => ps.ParkingId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.ParkingSpot)
                .WithMany(ps => ps.Reservations)
                .HasForeignKey(r => r.ParkingSpotId);
        }
    }
}
