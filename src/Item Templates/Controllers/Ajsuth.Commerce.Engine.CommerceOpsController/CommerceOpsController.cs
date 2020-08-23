// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommerceOpsController.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Sitecore.Commerce.Core;
using System;
using System.Threading.Tasks;

namespace $rootnamespace$
{
    /// <summary>Defines the commerce ops controller</summary>
    /// <seealso cref="CommerceODataController" />
    public class CommerceOpsController : CommerceODataController
    {
        /// <summary>Initializes a new instance of the <see cref="CommerceOpsController" /> class.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="globalEnvironment">The global environment.</param>
        public CommerceOpsController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment)
            : base(serviceProvider, globalEnvironment)
        {
        }

        /* Add endpoints here */
    }
}