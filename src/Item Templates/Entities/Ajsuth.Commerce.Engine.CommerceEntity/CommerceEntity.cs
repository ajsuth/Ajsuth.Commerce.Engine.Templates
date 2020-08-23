// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2018
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;

namespace $rootnamespace$
{
    /// <summary>Defines the $fileinputname$ commerce entity.</summary>
    /// <seealso cref="CommerceEntity" />
    public class $safeitemname$ : CommerceEntity
    {
        /// <summary>Initializes a new instance of the <see cref="$safeitemname$" /> class.</summary>
        public $safeitemname$()
        {
            this.DateCreated = DateTime.UtcNow;
            this.DateUpdated = this.DateCreated;
        }

        /// <summary>Initializes a new instance of the <see cref="$safeitemname$" /> class. </summary>
        /// <param name="id">The identifier.</param>
        public $safeitemname$(string id) : this()
        {
            this.Id = id;
        }

        /* Add entity properties here */
    }
}