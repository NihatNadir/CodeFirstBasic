using CodeFirstBasic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Context
{
    public class PatikaFirstDbContext : DbContext
    {

        public DbSet<Game> Games => Set<Game>();
        public DbSet<Movie> Movies => Set<Movie>();

        // 1. büyük
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {

        }


        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=NIHAT\SQLEXPRESS;database=PatikaCodeFirstDb1;TrustServerCertificate=true;trusted_connection=true;");
            // Windows Authentication için kullanılır

            base.OnConfiguring(optionsBuilder);
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Game>(entity =>
            {
                // entity model tanımlamasında kullanılan data annotation göre bu kısımlar düzenlenir
                entity.ToTable("Games"); // tablo adı 
                entity.HasKey(e => e.Id); // Primary Key için kullanılır dataannotation [Key]
                entity.Property(e => e.Name).IsRequired().HasMaxLength(25); // Zorunlu alan ve maximum 25 karakter alır dataannotation [Required] ve [StringLength(25,...)] 
                entity.Property(e => e.Platform).IsRequired().HasMaxLength(25); // Zorunlu alan ve maximum 25 karakter alır dataannotation [Required] ve [RegularExpression(@"^(PC|PlayStation|Xbox)$"...)] 
                entity.Property(e => e.Rating).IsRequired().HasColumnType("decimal(3, 1)"); // Zorunlu alan ve 3 basamaklı değer alır ve 1 basamağı virgülden sonrası içindir (örneğin 4.5) dataannotation [Required] ve [Range(0.0,5.0,...)] 
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movies"); // tablo adı
                entity.HasKey(e => e.Id); // Primary key için kullanılır dataannotation [Key]
                entity.Property(e => e.Genre).IsRequired().HasMaxLength(50); // Zorunlu alan ve maximum 50 karakter alır dataannotation [Required] ve [MaxLength(50,,...)]               
                entity.Property(e => e.Title).IsRequired().HasMaxLength(50); // Zorunlu alan ve maximum 50 karakter alır dataannotation [Required] ve [MaxLength(50,,...)] 
                entity.Property(e => e.ReleaseYear).IsRequired(); // Zorunlu alan dataannotation [Required] ve [Range(1900,2100,ErrorMessage = " Yıl olarak 1888 ile 2100 arasında seçim yapılmalıdır.")]

            });

            base.OnModelCreating(modelBuilder);

        }


    }
}
