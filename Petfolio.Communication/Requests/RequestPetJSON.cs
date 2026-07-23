using Petfolio.Communication.Enums;
namespace Petfolio.Communication.Requests
{
    public class RequestPetJSON
    {
        public string Name { get; set; } = String.Empty;
        public DateTime DateOfBirth { get; set; }
        public PetType PetType { get; set; }
    }
}
