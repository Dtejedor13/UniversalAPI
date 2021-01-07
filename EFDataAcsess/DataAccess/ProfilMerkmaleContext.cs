using Microsoft.EntityFrameworkCore;
using System;

namespace EFDataAcsess
{
    public class ProfilMerkmaleContext : DbContext
    {
        public DbSet<ProfilMerkmaleModel> profilmerkmal { get; set; }
        public ProfilMerkmaleContext(DbContextOptions options) : base(options) // Constructor
        {
            
        }
    }
}
