using webApi_demo.Context;
using webApi_demo.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace webApi_demo.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ContatoController:ControllerBase
    {
        private readonly AppDbContext _context;
        public ContatoController(AppDbContext contexto){
            _context=contexto;
        }
        public ActionResult<IEnumerable<Contato>> Get(){
            try
            {
                return _context.Contatos.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Erro ao tentar obter as categorias do banco de dados");
            }
        }
    }
}