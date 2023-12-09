using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =LAPTOP-85RP3868;database=TraverselDB;integrated security = true;TrustServerCertificate=True; ");

        }

        //Entity'leri SQL'e yansıtmak için gerekli olan köprü
        public DbSet<About> Abouts { get; set; } //About Entity'nin ismi Abouts tablonun ismi
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; } 
        public DbSet<Feature2> Feature2s { get; set; }
        public DbSet<Guide> Guides{ get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}
