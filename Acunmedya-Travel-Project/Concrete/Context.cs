using Acunmedya_Travel_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace Acunmedya_Travel_Project.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasKey(e => e.service_id);
            modelBuilder.Entity<Service>().Property(e => e.title).HasMaxLength(150);
            modelBuilder.Entity<Service>().Property(e => e.description).HasColumnType("text");
            modelBuilder.Entity<Service>().Property(e => e.image_url).HasColumnType("nvarchar(max)");
        }
    }
}
