using System;
using System.Collections.Generic;

namespace FileManager.Models;

public partial class FileDetail
{
    public int FileId { get; set; }

    public string FileName { get; set; } = null!;

    public string CorelationId { get; set; } = null!;

    public string FileType { get; set; } = null!;

    public DateTime FileCreatedOn { get; set; }

    public string? FileCraetedBy { get; set; }
}
