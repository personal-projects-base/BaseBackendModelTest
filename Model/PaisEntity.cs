using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base_Backend.Model;

[Table("country")]
public class PaisEntity
{
    [Key]
    [Column(name:"id")]
    public int Id { get; set; }
    [Column(name: "name")]
    public string Name { get; set; }
}