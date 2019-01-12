// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Get$safeitemname$NavigationViewBlock.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.EntityViews;
    using Sitecore.Framework.Conditions;
    using Sitecore.Framework.Pipelines;
    using System.Threading.Tasks;

    public class Get$safeitemname$NavigationViewBlock : PipelineBlock<EntityView, EntityView, CommercePipelineExecutionContext>
    {
        public override Task<EntityView> Run(EntityView entityView, CommercePipelineExecutionContext context)
        {
            Condition.Requires(entityView).IsNotNull($"{Name}: The argument cannot be null.");

            var dashboardName = "My Dashboard";

            // var dashboardName = context.GetPolicy<Known$safeitemname$ViewsPolicy>().$safeitemname$Dashboard;

            entityView.ChildViews.Add(new EntityView
            {
                Name = dashboardName,
                ItemId = dashboardName,
                Icon = "about",
                DisplayRank = 100
            });

            return Task.FromResult(entityView);
        }

        public Get$safeitemname$NavigationViewBlock()
          : base(null)
        {
        }
    }
}