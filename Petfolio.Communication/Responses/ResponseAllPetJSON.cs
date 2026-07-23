using System;
using System.Collections.Generic;
using System.Text;

namespace Petfolio.Communication.Responses
{
    public class ResponseAllPetJSON
    {
        public List<ResponseShortPetJSON> Pets { get; set; } = [];
    }
}
