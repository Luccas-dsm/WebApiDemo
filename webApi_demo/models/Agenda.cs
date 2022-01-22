using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webApi_demo.models
{
    [Table("Agenda")]
    public class Agenda
    {
        public Agenda ()
        {
            Contatos = new Collection<Contato>();
        }


        [Key]
        public int IdTipo { get; set; }

        [Required]
        [MaxLength(40)]
        public string PessoaFisica { get; set; }


        [Required]
        [MaxLength(40)]
        public string Endereco { get; set; }    

        public ICollection<Contato> Contatos{ get; set;}    
    }
}