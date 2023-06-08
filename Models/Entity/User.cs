using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {

        public User(){
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        // create at with anottation
        [DataType(DataType.DateTime)]
        public DateTime? CreatedAt { get; set; }
        // update at with anottation
        [DataType(DataType.DateTime)]
        public DateTime? UpdatedAt { get; set; }

    }
}