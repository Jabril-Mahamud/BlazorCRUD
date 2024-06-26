using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD;

public class History
{
    public int Id { get; set; }
    public string? Content { get; set; }
    public string? Sauce { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateTime { get; set; }

}
