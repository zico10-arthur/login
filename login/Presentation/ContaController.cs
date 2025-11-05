using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using login.Domain.Entities;
using login.Application.ContaService;
using login.Application.Dtos;

namespace login.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly ContaService _service;

        public ContaController(ContaService service)
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
