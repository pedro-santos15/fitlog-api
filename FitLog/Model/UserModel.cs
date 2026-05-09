using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLog.Model
{
    [Table("users")]
    public class UserModel
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column("name", TypeName = "varchar(80)")]
        [MaxLength(80)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column("age", TypeName = "int")]
        [MaxLength(2)]
        public int Age { get; set; }

        [Required]
        [Column("email", TypeName = "varchar(80)")]
        [MaxLength(80)]
        public string Email { get; set; } = string.Empty;

    }
}
