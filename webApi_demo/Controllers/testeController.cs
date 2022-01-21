using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webApi_demo.Controllers
{
    [Route("api/[controller]")] //serve para acessar o conteudo da minha API
    [ApiController]
    public class testeController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() // metodo que retorna uma lista de string
        {
             return new string[]{"teste", "teste2"};
        }

        [HttpGet("pessoas")]
        public ActionResult<IEnumerable<Pessoa>> GetPessoas() // metodo que retorna uma lista de string
        {
            return new[] 
            {
                new Pessoa{
                Nome="Luiza"

                 },
                  new Pessoa{
                Nome="Marcelly"

                 },
                  new Pessoa{
                Nome ="Marcia"

                 }
            };
        }
        //POST api/values
            [HttpPost]
            public void Post([FromBody] string value){

            }
        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
        //DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
        public class Pessoa{
            public string Nome { get; set; }
        }
    }
    
}