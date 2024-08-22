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
    [IgnoreDataMember]
    [Column(name: "id_state")]
    public int StateId { get; set; }
    
    public virtual EstadoEntity EstadoEntity { get; set; }
}