// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2017
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Framework.Pipelines;

	/// <summary>
	/// Defines the $safeitemrootname$ interface
	/// </summary>
	/// <seealso>
	///     <cref>
	///         Sitecore.Framework.Pipelines.IPipeline{PipelineArgumentOrEntity,
	///         PipelineArgumentOrEntity, Sitecore.Commerce.Core.CommercePipelineExecutionContext}
	///     </cref>
	/// </seealso>
	[PipelineDisplayName("[Insert Project Name].Pipeline.$safeitemrootname$")]
    public interface $safeitemrootname$ : IPipeline<PipelineArgumentOrEntity, PipelineArgumentOrEntity, CommercePipelineExecutionContext>
    {
    }
}
