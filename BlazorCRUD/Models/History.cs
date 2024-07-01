using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Models;

public class History
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public string? Sauce { get; set; }
    public string? App { get; set; }

    public int? viewCount { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateTime { get; set; }

}
