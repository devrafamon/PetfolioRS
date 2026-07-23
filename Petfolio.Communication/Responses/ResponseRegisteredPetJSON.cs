using Petfolio.Communication.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petfolio.Communication.Responses
{
    public class ResponseRegisteredPetJSON
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
    }

    public class ResponseShortPetJSON : ResponseRegisteredPetJSON
    {
        public PetType Type { get; set; }
    }
}
