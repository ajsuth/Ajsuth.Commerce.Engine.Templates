// © 2020 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using System;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Sitecore.Commerce.Core;

namespace $safeprojectname$
{
    /// <inheritdoc />
    /// <summary>
    /// Defines a controller
    /// </summary>
    /// <seealso cref="T:Sitecore.Commerce.Core.CommerceController" />
    [EnableQuery]
    [Route("api/Sample")]
    public class SampleController : CommerceODataController
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$safeprojectname$.SampleController" /> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="globalEnvironment">The global environment.</param>
        public SampleController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment) : base(serviceProvider, globalEnvironment)
        {
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>A <see cref="IActionResult"/></returns>
        [HttpGet("(Id={id})")]
        [EnableQuery]
        public async Task<IActionResult> Get(string id)
        {
            if (!ModelState.IsValid || string.IsNullOrEmpty(id))
            {
                return new BadRequestObjectResult(ModelState);
            }

            var command = Command<SampleCommand>();
            var result = await command.Process(CurrentContext, id).ConfigureAwait(false);
            if (result == null)
            {
                return NotFound();
            }

            return new ObjectResult(result);
        }
    }
}
