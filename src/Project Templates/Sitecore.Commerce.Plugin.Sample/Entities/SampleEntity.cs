// © 2020 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using System;
using System.Collections.Generic;
using Microsoft.AspNet.OData.Builder;
using Sitecore.Commerce.Core;

namespace $safeprojectname$
{
    /// <inheritdoc />
    /// <summary>
    /// SampleEntity model.
    /// </summary>
    public class SampleEntity : CommerceEntity
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$safeprojectname$.SampleEntity" /> class.
        /// </summary>
        public SampleEntity()
        {
            DateCreated = DateTime.UtcNow;
            DateUpdated = DateCreated;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$safeprojectname$.SampleEntity" /> class. 
        /// Public Constructor
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public SampleEntity(string id) : this()
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets the list of child components in the SampleEntity
        /// </summary>
        [Contained]
        public IEnumerable<SampleComponent> ChildComponents { get; set; }
    }
}
