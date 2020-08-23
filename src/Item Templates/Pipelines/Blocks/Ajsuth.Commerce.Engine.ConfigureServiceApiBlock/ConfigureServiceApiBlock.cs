// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigureServiceApiBlock.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Microsoft.AspNet.OData.Builder;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;

namespace $rootnamespace$
{
    /// <summary>Defines the configure service api block, which configures the OData model for api endpoints</summary>
    /// <seealso cref="SyncPipelineBlock{TInput, TOutput, TContext}" />
    [PipelineDisplayName("Change to <Project>Constants.Pipelines.Blocks.ConfigureServiceApi")]
    public class ConfigureServiceApiBlock : SyncPipelineBlock<ODataConventionModelBuilder, ODataConventionModelBuilder, CommercePipelineExecutionContext>
    {
        /// <summary>The execute.</summary>
        /// <param name="modelBuilder">The <see cref="ODataConventionModelBuilder"/>.</param>
        /// <param name="context">The context.</param>
        /// <returns>The <see cref="ODataConventionModelBuilder"/>.</returns>
        public override ODataConventionModelBuilder Run(ODataConventionModelBuilder modelBuilder, CommercePipelineExecutionContext context)
        {
            Condition.Requires(modelBuilder).IsNotNull($"{this.Name}: The argument cannot be null.");

            // Add the entities

            // Add the entity sets

            // Add complex types

            // Add unbound functions

            // Add unbound actions

            return modelBuilder;
        }
    }
}