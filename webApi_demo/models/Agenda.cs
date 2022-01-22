using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace webApi_demo.models
{
    public class Agenda
    {
        public Agenda ()
        {
            Contatos = new Collection<Contato>();
        }
        public string PessoaFisica { get; set; }
        public string Endereco { get; set; }    

        public ICollection<Contato> Contatos{ get; set;}    
    }
}