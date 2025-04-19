using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Batch
{
    [Key]
    public int BatchId { get; set; }

    [Required]
    public string BatchName { get; set; }

    public int Year { get; set; }

    // Navigation Property: One-to-Many (Batch → Students)
    public ICollection<Student> Students { get; set; }
}
