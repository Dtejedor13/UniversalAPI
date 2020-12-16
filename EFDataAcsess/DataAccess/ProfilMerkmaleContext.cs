using Microsoft.EntityFrameworkCore;
using System;

namespace EFDataAcsess
{
    public class ProfilMerkmaleContext : DbContext
    {
        public DbSet<ProfilMerkmaleModel> profil { get; set; }
        public ProfilMerkmaleContext(DbContextOptions options) : base(options) 
        {
            
        }
    }
}
