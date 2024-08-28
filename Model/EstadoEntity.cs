using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Base_Backend.Model;
[Table("state")]
public class EstadoEntity
{
    [Key]
    [Column(name:"id")]
    public int Id { get; set; }
    [Column(name: "name")]
    public String Name { get; set; }
    
    [IgnoreDataMember]
    [Column(name: "id_country")]
    [ForeignKey("Pais")]
    public int CountryId { get; set; }
    
    public virtual PaisEntity? Pais { get; set; }
}