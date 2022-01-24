using Microsoft.EntityFrameworkCore.Migrations;

namespace webApi_demo.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Contato (Nome,Endereco,Telefone) Values('Luccas', 'Rua Berlim', '31 99999-9999')");
            mb.Sql("Insert into Contato (Nome,Endereco,Telefone) Values('Victor', 'Rua Baco', '31 99999-8888')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql( "Delete from Contato");
        }
    }
}
