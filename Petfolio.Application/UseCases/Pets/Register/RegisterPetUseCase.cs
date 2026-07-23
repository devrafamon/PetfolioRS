using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petfolio.Application.UseCases.Pets.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisteredPetJSON Execute(RequestPetJSON request)
        {
            // Business logic to register the pet would go here, such as saving the pet information to a database.
            return new ResponseRegisteredPetJSON
            {
                Id = new Random().Next(1, 1000), // Simulating an ID generation for the registered pet.
                Name = request.Name
            };
        }
    }
}
