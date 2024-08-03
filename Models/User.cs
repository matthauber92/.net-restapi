using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.RestApi;

public class User
{
    public int Id { get; set; }
    [StringLength(100)]
    public string? Username { get; set; }
    [StringLength(50)]
    public string? Password { get; set; }
    [StringLength(100)]
    public string? Email { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}