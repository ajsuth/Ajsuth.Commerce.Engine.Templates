// © 2020 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using Sitecore.Commerce.Core;

namespace $safeprojectname$
{
    /// <inheritdoc />
    /// <summary>
    /// Defines a model
    /// </summary>
    /// <seealso cref="T:Sitecore.Commerce.Core.Model" />
    public class SampleModel : Model
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$safeprojectname$.SampleModel" /> class.
        /// </summary>
        public SampleModel()
        {
            Id = string.Empty;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; private set; }
    }
}
