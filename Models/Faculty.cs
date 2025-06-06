﻿using Eproject.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Faculty
{
    [Key]
    public int FacultyId { get; set; }

    [Required]
    public string Department { get; set; }

    public string? Designation { get; set; }

    // Foreign Key
    [Required]
    public string UserId { get; set; }

    [ForeignKey("UserId")]
    public EprojectUser User { get; set; }
}
