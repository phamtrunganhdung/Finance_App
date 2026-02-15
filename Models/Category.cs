using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models;

public class Category
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public string? Note { get; set; }

    public string? Icon { get; set; }

    public ICollection<Transaction>? Transactions { get; set; }
}
