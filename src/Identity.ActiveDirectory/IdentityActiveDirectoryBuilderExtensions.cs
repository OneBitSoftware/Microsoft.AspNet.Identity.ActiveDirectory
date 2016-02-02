using Microsoft.AspNet.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetIdentity = Microsoft.AspNet.Identity;
namespace Microsoft.AspNetCore.Identity.ActiveDirectory
{
    public static class IdentityActiveDirectoryBuilderExtensions
    {
        public static IdentityBuilder AddActiveDirectoryStore(this IdentityBuilder builder)
        {
            builder.Services.AddScoped(
                typeof(AspNetIdentity.IUserStore<DomainUser>),
                typeof(ActiveDirectory.UserStore<DomainUser>));

            builder.Services.AddScoped(
                typeof(AspNetIdentity.IRoleStore<DomainGroup>),
                typeof(ActiveDirectory.RoleStore<DomainGroup>));

            return builder;
        }
    }
}
