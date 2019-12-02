using Microsoft.EntityFrameworkCore;

namespace ValeWebLivre.Models {
    public class ValeWebLivreDbContext : DbContext {
        public ValeWebLivreDbContext (DbContextOptions<ValeWebLivreDbContext> options) : base (options) { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}