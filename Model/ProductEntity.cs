using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base_Backend.Model
{
    [Table("product")]
    public class ProductEntity
    {
        [Key]
        [Column(name:"id")]
        public int Id { get; set; }
        [Column(name: "name")]
        public string Name { get; set; }
        [Column(name: "preco")]
        public decimal Preco { get; set; }

        [Column(name: "datacriacao")]
        public DateTime DataCriacao { get; set; }
    }
}
