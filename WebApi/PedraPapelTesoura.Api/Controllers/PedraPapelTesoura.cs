using Microsoft.AspNetCore.Mvc;
using PedraPapelTesoura.Application.Interface;
using PedraPapelTesoura.Domain.Enum;

namespace PedraPapelTesoura.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedraPapelTesoura : ControllerBase
    {
        public readonly IPedraPapelTesouraApplication _pedraPapelTesouraApplication;
        public PedraPapelTesoura(IPedraPapelTesouraApplication pedraPapelTesouraApplication)
        {
            _pedraPapelTesouraApplication = pedraPapelTesouraApplication;
        }

        [HttpGet("{escolha}")]
        public IActionResult Inclui(PPT escolha)
        {
            var retorno = _pedraPapelTesouraApplication.ProcessoPPT(escolha);
            return Ok(retorno.Message);
        }

        [HttpGet("Contador/{vc}")]
        public IActionResult Inclui(bool vc)
        {
            var retorno = _pedraPapelTesouraApplication.Contador(vc);
            return Ok(retorno);
        }
    }
}