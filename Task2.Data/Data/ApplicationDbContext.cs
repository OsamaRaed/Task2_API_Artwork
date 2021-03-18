using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_API.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Viewer> Viewers { get; set; }
        public DbSet<ArtworkView> ArtworkViews { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<ViewerInterest> ViewerInterests { get; set; }
    }
}
