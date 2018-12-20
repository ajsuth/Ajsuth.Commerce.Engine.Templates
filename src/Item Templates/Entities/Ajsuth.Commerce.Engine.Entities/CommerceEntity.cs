// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2018
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using System;
    using System.Collections.Generic;
    using Sitecore.Commerce.Core;

    /// <inheritdoc />
    /// <summary>
    /// $safeitemname$ model.
    /// </summary>
    public class $safeitemname$ : CommerceEntity
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$rootnamespace$.$safeitemname$" /> class.
        /// </summary>
        public $safeitemname$()
        {
            this.Components = new List<Component>();
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = this.DateCreated;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$rootnamespace$.$safeitemname$" /> class. 
        /// Public Constructor
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public $safeitemname$(string id) : this()
        {
            this.Id = id;
        }
    }
}