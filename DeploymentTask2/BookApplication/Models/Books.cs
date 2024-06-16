using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorPagesBook.Models;

public class Book
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [Display(Name = "Start date")]
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }

    [Display(Name = "Finish date")]
    public DateTime FinishDate { get; set; }
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Progress { get; set; }

    public double Rating { get; set; }

    public string? Author { get; set; }
}