// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiController.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Microsoft.AspNetCore.Mvc;
    using Sitecore.Commerce.Core;
    using System;
    using System.Threading.Tasks;
    using System.Web.Http.OData;

    /// <inheritdoc />
    /// <summary>
    /// Defines an api controller
    /// </summary>
    /// <seealso cref="T:Sitecore.Commerce.Core.CommerceController" />
    [Route("api")]
    public class ApiController : CommerceController
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$rootnamespace$.ApiController" /> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="globalEnvironment">The global environment.</param>
        public ApiController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment)
            : base(serviceProvider, globalEnvironment)
        {
        }
    }
}