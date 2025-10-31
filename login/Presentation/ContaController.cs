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
        [HttpGet("Listar")]

        public ActionResult<List<Conta>> Listar()
        {
           
           return Ok(ContaService.ListarConta());
        
        }

        [HttpPost("Cadastrar")]

        public ActionResult<Conta> Cadastrar([FromBody] Conta conta)
        {
            try
            {
                ContaService.AdicionarConta(conta);

                return Ok(conta);
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
                ContaService.AlterarSenha(new Conta { Email = dto.Email}, dto.NovaSenha);
                return Ok("Senha alterada com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    
    
    }
}
