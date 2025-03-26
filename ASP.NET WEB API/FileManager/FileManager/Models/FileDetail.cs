using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace FileManager.Models;

public partial class FileDetail
{
    public int FileId { get; set; }

    [Required(ErrorMessage = "FileName field is required!")]
    public string FileName { get; set; } = null!;

    [Required(ErrorMessage = "CorelationId field is required!")]    
    public string CorelationId { get; set; } = null!;

    [Required(ErrorMessage = "FileType field is required!")]
    public string FileType { get; set; } = null!;

    public DateTime FileCreatedOn { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "FileType field is required!")]
    public string? FileCraetedBy { get; set; }
}
