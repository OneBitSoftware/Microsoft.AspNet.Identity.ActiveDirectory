using Microsoft.AspNet.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Identity.ActiveDirectory
{
    /// <summary> 
    /// Extension methods for the ActiveDirectoryMiddleware
    /// </summary> 
    public static class ActiveDirectoryExtensions
    {
        /// <summary>
        /// Enables the NTLM route for challenge/response handshaking
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseNtlm(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            return app.UseMiddleware<ActiveDirectoryMiddleware>();
        }
    }
}
