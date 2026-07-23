using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.GetAll;
using Petfolio.Application.UseCases.Pets.GetById;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Application.UseCases.Pets.Update;
using Petfolio.Application.UseCases.Pets.Delete;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredPetJSON), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJSON), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestPetJSON request)
        {
            //Business logic to register the pet would go here, such as saving the pet information to a database.
            var response = new RegisterPetUseCase().Execute(request);
            return Created(string.Empty, response);
        }

        [HttpPatch]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseRegisteredPetJSON), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJSON), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJSON request)
        {
            // Business logic to update the pet would go here, such as modifying the pet information in a database
            var useCaseUpdate = new UpdatePetUseCase();
            useCaseUpdate.Execute(id, request);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetJSON), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCaseGetAll = new GetAllPetsUseCase();
            var response = useCaseGetAll.Execute();
            if (response.Pets.Count > 0)
                return Ok(response);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetJSON), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseErrorJSON), StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromRoute] int id)
        {
            var useCaseGetById = new GetPetByIdUseCase();
            var response = useCaseGetById.Execute(id);
            if (response != null)
                return Ok(response);
            return NotFound();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseErrorJSON), StatusCodes.Status400BadRequest)]
        public IActionResult Delete([FromRoute] int id)
        {
            // Business logic to delete the pet would go here, such as removing the pet information from a database
            var useCaseDelete = new DeletePetUseCase();
            useCaseDelete.Execute(id);
            return NoContent();
        }
    }
}
