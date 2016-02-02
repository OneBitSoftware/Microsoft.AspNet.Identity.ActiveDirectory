using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Identity.ActiveDirectory
{
    public class DomainUser
    {
        public string Id { get; set; }

        public string GetSidAsString()
        {
            throw new NotImplementedException();
            return string.Empty;
        }
    }
}
