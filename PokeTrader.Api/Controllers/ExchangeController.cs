using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokeTrader.Api.Helpers;
using PokeTrader.Domain.Dto.Exchange;
using PokeTrader.Domain.Interfaces;

namespace PokeTrader.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExchangeController : ControllerBase
    {
        private readonly IExchange _service;
        public ExchangeController(IExchange service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ExchangeCreateDto exchange)
        {
            try
            {
                var result = await _service.Post(exchange);
                if (result != null)
                    return Ok(new { message = "Troca realizada com sucesso", data = result });
                return BadRequest();
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ApiErrorResponse((int)HttpStatusCode.InternalServerError, e.Message));
            }
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var result = await _service.Get();
                if (result != null)
                    return Ok(new { message = "Registros encontrados", data = result });
                return BadRequest();
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ApiErrorResponse((int)HttpStatusCode.InternalServerError, e.Message));
            }
        }
    }
}