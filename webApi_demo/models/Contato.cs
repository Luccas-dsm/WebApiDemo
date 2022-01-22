namespace webApi_demo.models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Agenda Agenda { get; set; }
        public int AgendaId { get; set; }
    }
}