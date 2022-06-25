using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace site2.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<anaSayfa>anaSayfas { get; set; }
        public DbSet<blog> blogs { get; set; }
        public DbSet<hakkimizda> hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<yorumlar> yorumlars { get; set; }
    }
}