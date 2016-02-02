using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Identity.ActiveDirectory
{
    public class DomainGroup
    {
        public SecurityIdentifier Sid { get; set; }

        public GroupPrincipal Principal { get; set; }

    }
}
