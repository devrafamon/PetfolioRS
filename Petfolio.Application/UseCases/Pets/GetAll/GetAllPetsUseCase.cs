using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJSON Execute() 
        {
            return new ResponseAllPetJSON
            {
                Pets = new List<ResponseShortPetJSON>
                {
                    new() 
                    {
                        Id = new Random().Next(1,2500),
                        Name = "Fido",
                        Type = Communication.Enums.PetType.Dog
                    }
                }
            };
        }
    }
}
