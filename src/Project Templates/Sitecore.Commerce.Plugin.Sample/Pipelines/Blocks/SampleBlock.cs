// © 2020 Sitecore Corporation A/S. All rights reserved. Sitecore® is a registered trademark of Sitecore Corporation A/S.

using System;
using System.Threading.Tasks;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;

namespace $safeprojectname$
{
    /// <summary>
    /// Defines a block
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Sitecore.Framework.Pipelines.PipelineBlock{$safeprojectname$.SampleArgument,
    ///         $safeprojectname$.SampleEntity, Sitecore.Commerce.Core.CommercePipelineExecutionContext}
    ///     </cref>
    /// </seealso>
    [PipelineDisplayName("Sample.SampleBlock")]
    public class SampleBlock : AsyncPipelineBlock<SampleArgument, SampleEntity, CommercePipelineExecutionContext>
    {
        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="arg">
        /// The SampleArgument argument.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="SampleEntity"/>.
        /// </returns>
        public override async Task<SampleEntity> RunAsync(SampleArgument arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull($"{Name}: The argument can not be null");
            var result = await Task.Run(() => new SampleEntity()
            {
                Id = Guid.NewGuid().ToString()
            }).ConfigureAwait(false);

            return result;
        }
    }
}
