using Petfolio.Communication.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petfolio.Communication.Responses
{
    public class ResponsePetJSON
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime DateOfBirth { get; set; }
        public PetType PetType { get; set; }

    }
}
