// © 2020 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;

namespace $safeprojectname$
{
    /// <inheritdoc />
    /// <summary>
    ///  Defines the SamplePipeline pipeline.
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Sitecore.Commerce.Core.CommercePipeline{$safeprojectname$.SampleArgument,
    ///         $safeprojectname$.SampleEntity}
    ///     </cref>
    /// </seealso>
    /// <seealso cref="T:$safeprojectname$.ISamplePipeline" />
    public class SamplePipeline : CommercePipeline<SampleArgument, SampleEntity>, ISamplePipeline
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$safeprojectname$.SamplePipeline" /> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="loggerFactory">The logger factory.</param>
        public SamplePipeline(IPipelineConfiguration<ISamplePipeline> configuration, ILoggerFactory loggerFactory)
            : base(configuration, loggerFactory)
        {
        }
    }
}
