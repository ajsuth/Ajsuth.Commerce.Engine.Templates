// © 2020 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;

namespace $safeprojectname$
{
    /// <summary>
    /// Defines the ISamplePipeline interface
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Sitecore.Framework.Pipelines.IPipeline{$safeprojectname$.SampleArgument,
    ///         $safeprojectname$.SampleEntity, Sitecore.Commerce.Core.CommercePipelineExecutionContext}
    ///     </cref>
    /// </seealso>
    [PipelineDisplayName("SamplePipeline")]
    public interface ISamplePipeline : IPipeline<SampleArgument, SampleEntity, CommercePipelineExecutionContext>
    {
    }
}
