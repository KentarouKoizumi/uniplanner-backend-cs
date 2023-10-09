using System.ComponentModel.DataAnnotations;

namespace Domain.Models;
public class Base
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

}