// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;

namespace $rootnamespace$
{
	/// <summary>Defines the $fileinputname$ pipeline interface</summary>
    /// <seealso cref="IPipeline{TInput, TOutput, TContext}" />
	[PipelineDisplayName("Change to <Project>Constants.Pipeline.$fileinputname$")]
    public interface $safeitemrootname$ : IPipeline<PipelineArgumentOrEntity, PipelineArgumentOrEntity, CommercePipelineExecutionContext>
    {
    }
}
