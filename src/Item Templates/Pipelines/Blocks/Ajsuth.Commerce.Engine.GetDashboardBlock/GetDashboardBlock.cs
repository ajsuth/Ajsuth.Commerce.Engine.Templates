// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.EntityViews;
    using Sitecore.Framework.Conditions;
    using Sitecore.Framework.Pipelines;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a get dashboard pipeline block
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Sitecore.Framework.Pipelines.PipelineBlock{Sitecore.Commerce.EntityViews.EntityView,
    ///         Sitecore.Commerce.EntityViews.EntityView, Sitecore.Commerce.Core.CommercePipelineExecutionContext}
    ///     </cref>
    /// </seealso>
    [PipelineDisplayName("Change to <Project>Constants.Pipelines.Blocks.Get$entity$DashboardView")]
    public class $safeitemname$ : PipelineBlock<EntityView, EntityView, CommercePipelineExecutionContext>
    {
        /// <inheritdoc />
        /// <summary>Initializes a new instance of the <see cref="T:$rootnamespace$.$safeitemname$" /> class.</summary>
        public $safeitemname$()
          : base(null)
        {
        }

        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="entityView">
        /// The current <see cref="Sitecore.Commerce.EntityViews.EntityView"/>.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The current <see cref="Sitecore.Commerce.EntityViews.EntityView"/>.
        /// </returns>
        public override async Task<EntityView> Run(EntityView entityView, CommercePipelineExecutionContext context)
        {
            Condition.Requires(entityView).IsNotNull($"{this.Name}: The argument cannot be null.");

            var entityViewArgument = context.CommerceContext.GetObjects<EntityViewArgument>().FirstOrDefault();
            if (string.IsNullOrEmpty(entityViewArgument?.ViewName) ||
                    !entityViewArgument.ViewName.Equals(context.GetPolicy<Known$entity$ViewsPolicy>().$entity$Dashboard, StringComparison.OrdinalIgnoreCase))
            {
                return entityView;
            }

            entityView.Icon = "information";

            return await Task.FromResult(entityView);
        }
    }
}