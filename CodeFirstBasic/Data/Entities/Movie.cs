using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstBasic.Data.Entities
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get; set; } // birincil anahtar ve otomatik artan
       
        [Required]
        [MaxLength(50, ErrorMessage = "50 karakter ile sınırlıdır.")]
        public string Title { get; set; } // filmin başlığı
        
        [Required]
        [MaxLength(50, ErrorMessage = "50 karakter ile sınırlıdır.")]
        public string Genre { get; set; } // filmin türü

        [Required]
        [Range(1900,2100,ErrorMessage = " Yıl olarak 1888 ile 2100 arasında seçim yapılmalıdır.")]
        public int ReleaseYear { get; set; } // filmin çıkış yılı

    }
}
