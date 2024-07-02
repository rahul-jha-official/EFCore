using System.ComponentModel.DataAnnotations;

namespace Demo.Data.Entity;

public class Book
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }
}
