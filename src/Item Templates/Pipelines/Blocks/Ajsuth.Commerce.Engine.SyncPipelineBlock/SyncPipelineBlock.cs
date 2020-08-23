// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Framework.Conditions;
    using Sitecore.Framework.Pipelines;

    /// <summary>Defines the synchronous executing $fileinputname$ pipeline block</summary>
    /// <seealso cref="SyncPipelineBlock{TInput, TOutput, TContext}" />
    [PipelineDisplayName("Change to <Project>Constants.Pipelines.Blocks.$fileinputname$")]
    public class $safeitemname$ : SyncPipelineBlock<PipelineArgument, PipelineArgument, CommercePipelineExecutionContext>
    {
        /// <summary>Gets or sets the commander.</summary>
        /// <value>The commander.</value>
        protected CommerceCommander Commander { get; set; }

        /// <summary>Initializes a new instance of the <see cref="$safeitemrootname$" /> class.</summary>
        /// <param name="commander">The commerce commander.</param>
        public $safeitemname$(CommerceCommander commander)
		{
            this.Commander = commander;
        }

        /// <summary>The execute.</summary>
        /// <param name="arg">The pipeline argument.</param>
        /// <param name="context">The context.</param>
        /// <returns>The <see cref="PipelineArgument"/>.</returns>
        public override PipelineArgument Run(PipelineArgument arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull($"{Name}: The argument can not be null");

            /* Add business logic here */

            return arg;
        }
    }
}