using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using login.Domain.Entities;
using login.Application.Dtos;
using login.Application.Interface;

namespace login.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IContaService _service;

        public ContaController(IContaService service)
        {
            _service = service;
        }
        [HttpGet("Listar")]

        public ActionResult<List<Conta>> Listar()
        {
           
           return Ok(_service.ListarConta());
        
        }

        [HttpPost("Cadastrar")]

        public ActionResult<Conta> Cadastrar([FromBody] CriarContaDTO dto)
        {
            try
            {
                _service.AdicionarConta(dto);

                return Ok("conta criada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Alterar")]

        public ActionResult<Conta> Alterar([FromBody] AlterarSenhaDto dto)
        {
            try
            {
                _service.AlterarSenha(dto);
                return Ok("Senha alterada com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpPost("Logar")]

        public ActionResult<Conta> Logar([FromBody] AutenticarDTO dto)
        {
            try
            {
                _service.Autenticar(dto);
                return Ok("login feito com sucesso");

            }
            catch (Exception ex)
            {
                return Unauthorized(ex.Message);
            }
        }
    
    
    }
}
