using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstBasic.Data.Entities
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public int Id { get; set; } // birincil anahtar ve otomatik artan
        
        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Minimum 2 karakter ve Maximum 25 karakter ile sınırlıdır.")]
        public string Name { get; set; } // oyunun adı

        [Required]
        [RegularExpression(@"^(PC|PlayStation|Xbox)$", ErrorMessage = "Platform yalnızca 'PC', 'PlayStation' veya 'Xbox' olabilir.")]
        public string Platform { get; set; } // oyunun oynandığı flatform
        
        [Required]
        [Range(0.0,5.0,ErrorMessage ="0 ile 5 arasında bir değer girilebilir.")]
        public decimal Rating { get; set; } // oyunun puanı
    }
}
