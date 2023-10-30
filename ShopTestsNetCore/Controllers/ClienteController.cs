using Microsoft.AspNetCore.Mvc;
using ShopTestsNetCore.Models;
using ShopTestsNetCore.Services;
using System.Collections.Generic;

namespace ShopTestsNetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> GetAll() => _clienteService.findAll();

        [HttpPost]
        [Route("addClient")]
        public IActionResult AddCliente([FromBody] Cliente cli)
        {
            _clienteService.Insert(cli);
            return Ok();
        }
    }
}
