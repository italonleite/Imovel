using Imovel.API.Controllers.Models.Commands;
using Imovel.Domain.Interfaces;
using Imovel.Domain.Models;
using Imovel.Domain.Services.ImmobileService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imovel.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImmobileController : ControllerBase
    {
       
        private readonly ImmobileService _immobileService;

        public ImmobileController(ImmobileService immobileService)
        {
            _immobileService = immobileService;
        }


        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] CreateImmobileCommand command)
        {
            var immobile = new Immobile(command.ImmobileType, command.Address);

            _immobileService.ValidateImmobile(immobile);

            _immobileService.Insert(immobile);

            return Ok(immobile);

        }

        [HttpGet]
        public IEnumerable<Immobile> Get()
        {

            return _immobileService.Get();

        }
    }
}
