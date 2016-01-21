using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Identity.ActiveDirectory
{
    public class ActiveDirectoryMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        /// <summary>
        /// Creates a new instance of the ActiveDirectoryMiddleware.
        /// </summary>
        /// <param name="next">The next middleware in the pipeline.</param>
        /// <param name="options">The configuration options.</param>
        /// <param name="loggerFactory">An <see cref="ILoggerFactory"/> instance used to create loggers.</param>
        public ActiveDirectoryMiddleware(RequestDelegate next, IHostingEnvironment hostingEnv, ILoggerFactory loggerFactory)
        {
            if (next == null)
            {
                throw new ArgumentNullException(nameof(next));
            }

            if (hostingEnv == null)
            {
                throw new ArgumentNullException(nameof(hostingEnv));
            }

            //if (options == null)
            //{
            //    throw new ArgumentNullException(nameof(options));
            //}

            if (loggerFactory == null)
            {
                throw new ArgumentNullException(nameof(loggerFactory));
            }

            _next = next;
            _logger = loggerFactory.CreateLogger<ActiveDirectoryMiddleware>();
        }


        public async Task Invoke(HttpContext context)
        {
        
        }
    }
}
