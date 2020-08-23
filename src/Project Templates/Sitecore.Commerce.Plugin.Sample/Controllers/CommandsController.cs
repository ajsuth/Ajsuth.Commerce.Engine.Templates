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
    public class CommandsController : CommerceODataController
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$safeprojectname$.CommandsController" /> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="globalEnvironment">The global environment.</param>
        public CommandsController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment)
            : base(serviceProvider, globalEnvironment)
        {
        }

        /// <summary>
        /// Samples the command.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A <see cref="IActionResult"/></returns>
        [HttpPut]
        [Route("SampleCommand()")]
        public async Task<IActionResult> SampleCommand([FromBody] ODataActionParameters value)
        {
            if (!ModelState.IsValid || value == null)
            {
                return new BadRequestObjectResult(ModelState);
            }

            if (!value.ContainsKey("Id") || string.IsNullOrEmpty(value["Id"]?.ToString()))
            {
                return new BadRequestObjectResult(value);
            }

            var id = value["Id"].ToString();
            var command = Command<SampleCommand>();
            var result = await command.Process(CurrentContext, id).ConfigureAwait(false);

            return new ObjectResult(command);
        }
    }
}
