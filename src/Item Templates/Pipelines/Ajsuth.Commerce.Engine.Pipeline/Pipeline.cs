// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2017
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Microsoft.Extensions.Logging;
    using Sitecore.Commerce.Core;
    using Sitecore.Framework.Pipelines;

    /// <inheritdoc />
    /// <summary>
    ///  Defines the $safeitemname$ pipeline.
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Sitecore.Commerce.Core.CommercePipeline{Namespace.PipelineArgumentOrEntity,
    ///         Namespace.PipelineArgumentOrEntity}
    ///     </cref>
    /// </seealso>
    /// <seealso cref="T:$rootnamespace$.$safeitemrootname$" />
    public class $safeitemrootname$ : CommercePipeline<PipelineArgumentOrEntity, PipelineArgumentOrEntity>, I$safeitemrootname$
	{
		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="T:$rootnamespace$.$safeitemname$" /> class.
		/// </summary>
		/// <param name="configuration">The configuration.</param>
		/// <param name="loggerFactory">The logger factory.</param>
		public $safeitemrootname$(IPipelineConfiguration<I$safeitemname$> configuration, ILoggerFactory loggerFactory)
            : base(configuration, loggerFactory)
        {
        }
    }
}

