using Microsoft.EntityFrameworkCore;
using EFDataAccessCore.Models;

namespace EFDataAccessCore
{
    public class ProfilMerkMaleContext : DbContext
    {
        public DbSet<ProfilMerkmalModel> ProfilMerkmaleDBSet { get; set; }
        public ProfilMerkMaleContext(DbContextOptions options) : base(options) { } //Construktor
    }
}
