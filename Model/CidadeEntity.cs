using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Base_Backend.Model;

[Table("city")]
public class CidadeEntity
{
    [Key]
    [Column(name:"id")]
    public int Id { get; set; }
    [Column(name: "name")]
    public string Name { get; set; }
    
    [Column(name: "country")]
    [ForeignKey("id_state")]
    public virtual PaisEntity Country { get; set; }
    
}