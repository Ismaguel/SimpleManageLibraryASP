using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lib.Web;
using Lib.Web.Models;
using System.Reflection.Emit;

namespace Lib.Web.Data
{
    public class Context: IdentityDbContext
    {
        public Context(DbContextOptions<Context> options):base(options) 
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Imprinter>  Imprinters { get; set; }
        public DbSet<Imprint> Imprints { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BaseModel>()
            .ToTable("BaseModel") // Table pour la classe de base Item
            .HasKey(i => i.Id); // Clé primaire

            builder.Entity<BaseModel>()
                .HasDiscriminator<string>("ItemType")
                .HasValue<Book>("Book")
                .HasValue<Imprinter>("Imprinter")
                .HasValue<Imprint>("Imprint");
            builder.Entity<Imprint>()
        .HasMany(imprint => imprint.Books)
        .WithOne(book => book.Imprint)
        .HasForeignKey(book => book.ImprintId)
        .IsRequired(false);
            builder.Entity<Imprint>()
        .HasMany(imprint => imprint.Imprinters)
        .WithOne(imprinter => imprinter.Imprint)
        .HasForeignKey(imprinter => imprinter.ImprintId)
        .IsRequired(false);
        }

    }
}
