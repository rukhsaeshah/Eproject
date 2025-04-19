using Eproject.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Student
{
    [Key]
    public int StudentId { get; set; }

    public string? EnrollmentNumber { get; set; }

    // Foreign Key to Batch
    [Required]
    public int BatchId { get; set; }

    [ForeignKey("BatchId")]
    public Batch Batch { get; set; }

    // Foreign Key to EprojectUser
    [Required]
    public string UserId { get; set; }

    [ForeignKey("UserId")]
    public EprojectUser User { get; set; }
}
