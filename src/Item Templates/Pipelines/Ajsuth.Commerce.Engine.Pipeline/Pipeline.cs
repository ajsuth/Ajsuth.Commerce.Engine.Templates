// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;

namespace $rootnamespace$
{
    /// <summary>Defines the $fileinputname$ pipeline.</summary>
    /// <seealso cref="CommercePipeline{TArg, TResult}" />
    /// <seealso cref="I$safeitemrootname$" />
    public class $safeitemrootname$ : CommercePipeline<PipelineArgumentOrEntity, PipelineArgumentOrEntity>, I$safeitemrootname$
	{
		/// <summary>Initializes a new instance of the <see cref="$safeitemname$" /> class.</summary>
		/// <param name="configuration">The configuration.</param>
		/// <param name="loggerFactory">The logger factory.</param>
		public $safeitemrootname$(IPipelineConfiguration<I$safeitemname$> configuration, ILoggerFactory loggerFactory)
            : base(configuration, loggerFactory)
        {
        }
    }
}

