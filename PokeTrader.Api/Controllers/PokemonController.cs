using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokeTrader.Api.Helpers;
using PokeTrader.Domain.Interfaces;

namespace PokeTrader.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _service;
        public PokemonController(IPokemonService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery()] int? offset = 20, int? limit = 0)
        {
            try
            {
                var result = await _service.Get(offset.Value, limit.Value);
                return Ok(new { message = "Registros encontrados", data = result });
            }
            catch(Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ApiErrorResponse((int)HttpStatusCode.InternalServerError, e.Message));
            }
           
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = await _service.Get(id);
                return Ok(new { message = "Registro encontrado", data = result });
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ApiErrorResponse((int)HttpStatusCode.InternalServerError, e.Message));
            }
           
        }
    }
}