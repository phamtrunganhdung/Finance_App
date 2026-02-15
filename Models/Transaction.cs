using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models;

public class Transaction
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public decimal Amount { get; set; }

    public DateTime Date { get; set; }

    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    public bool IsIncome { get; set; }

    public string? Note { get; set; }
}