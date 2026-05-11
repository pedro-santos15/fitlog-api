using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLog.Model
{
    [Table("users")]
    public class User
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
        public int Age { get; set; }

        [Required]
        [Column("email", TypeName = "varchar(80)")]
        [MaxLength(80)]
        public string Email { get; set; } = string.Empty;

        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();

    }
}
