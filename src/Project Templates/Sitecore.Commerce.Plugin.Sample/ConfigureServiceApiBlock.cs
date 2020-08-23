// © 2020 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using Microsoft.AspNet.OData.Builder;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;

namespace $safeprojectname$
{
    /// <summary>
    /// Defines a block which configures the OData model
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Sitecore.Framework.Pipelines.PipelineBlock{Microsoft.AspNetCore.OData.Builder.ODataConventionModelBuilder,
    ///         Microsoft.AspNetCore.OData.Builder.ODataConventionModelBuilder,
    ///         Sitecore.Commerce.Core.CommercePipelineExecutionContext}
    ///     </cref>
    /// </seealso>
    [PipelineDisplayName("SamplePluginConfigureServiceApiBlock")]
    public class ConfigureServiceApiBlock : SyncPipelineBlock<ODataConventionModelBuilder, ODataConventionModelBuilder, CommercePipelineExecutionContext>
    {
        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="arg">
        /// The argument.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="ODataConventionModelBuilder"/>.
        /// </returns>
        public override ODataConventionModelBuilder Run(ODataConventionModelBuilder arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull($"{Name}: The argument cannot be null.");

            // Add the entities
            arg.AddEntityType(typeof(SampleEntity));

            // Add the entity sets
            arg.EntitySet<SampleEntity>("Sample");

            // Add complex types

            // Add unbound functions

            // Add unbound actions
            var configuration = arg.Action("SampleCommand");
            configuration.Parameter<string>("Id");
            configuration.ReturnsFromEntitySet<CommerceCommand>("Commands");

            return arg;
        }
    }
}
