using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace webApi_demo.models
{
    [Table("Contato")]
    public class Contato
    {

        [Key]
        public int Idcontato { get; set; }


        [Required]
        [MaxLength(40)]
        
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string Endereco { get; set; }

        [Required]
        [MaxLength(14)]
        public string Telefone { get; set; }

        public Agenda Agenda { get; set; }
        public int AgendaId { get; set; }
    }
}