using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task2_API.Data.Models;

namespace Task2_API.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ViewerInterestDbEntity>().HasKey(x => new { x.ViewerId, x.InterestId });
            builder.Entity<ArtworkViewDbEntity>().HasKey(x => new { x.ViewerId, x.ArtworkId });
        }
        public DbSet<ArtworkDbEntity> Artworks { get; set; }
        public DbSet<ViewerDbEntity> Viewers { get; set; }
        public DbSet<ArtworkViewDbEntity> ArtworkViews { get; set; }
        public DbSet<SubscriptionDbEntity> Subscriptions { get; set; }
        public DbSet<CategoryDbEntity> Categories { get; set; }
        public DbSet<InterestDbEntity> Interests { get; set; }
        public DbSet<ViewerInterestDbEntity> ViewerInterests { get; set; }
    }
}
