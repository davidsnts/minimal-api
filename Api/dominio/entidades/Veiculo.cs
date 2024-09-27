using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api.dominio.entidades
{
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public required string Nome { get; set; }
        [Required]
        public required string Marca { get; set; }
        [Required]
        public int Ano { get; set; }

    }
}