using FitLog.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLog.Model
{
    [Table("Exercises")]
    public class Exercise
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
        public MuscleGroup MuscleGroup { get; set; }

        [Required]
        [Column("description", TypeName = "varchar(200)")]
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;
        
        public decimal Weight { get; set; }
    }
}
