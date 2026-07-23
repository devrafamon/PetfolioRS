using Petfolio.Communication.Responses;
namespace Petfolio.Application.UseCases.Pets.GetById
{
    public class GetPetByIdUseCase
    {
        
            public ResponsePetJSON Execute(int id)
            {
                return new ResponsePetJSON
                {
                        Id = id,
                        Name = "Fido",
                        DateOfBirth = new DateTime(year:2020, month:1, day:1),
                        PetType = Communication.Enums.PetType.Dog
                };
            }
        }
    }

