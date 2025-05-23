using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WebApiRest.Model;

namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObeterDataHoraAtual")]
        public IActionResult ObterDataHora ()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var messagem = $"Olé {nome}, seja bem vindo!";
            return Ok(new { messagem });
        }

        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok(new
            {
                nome = "Fábio",
                idade = 30,
                status = (30 > 18) ? "maior" : "menor"
            });
        }



        [HttpGet("alunos")]
        public ActionResult<IEnumerable<Aluno>> GetAlunos()
        {
            var alunos = new List<Aluno>
        {
            new Aluno { Id = 1, Name = "Fabio", Email = "fabio@gmail.com", Endereco = "Casa" },
            new Aluno { Id = 2, Name = "Lucas", Email = "lucas@hotmail.com", Endereco = "Apartamento" }
        };

            return Ok(alunos);
        }

    }


}
