using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PetAdoption.Domain.Commands;
using PetAdoption.Domain.Entities;
using PetAdoption.Domain.Handlers;
using PetAdoption.Domain.Repositories;

namespace PetAdoption.Domain.Api.Controllers
{
    
    [ApiController]
    [Route("v1/pets")]
    public class PetController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Pet> GetAll(
            [FromServices] IPetRepository repository
        )
        {
            return repository.GetAll();
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] RegisterPetCommand command,
            [FromServices] PetHandler handler
        )
        {
            return (GenericCommandResult) handler.Handle(command);
        }
    }
}