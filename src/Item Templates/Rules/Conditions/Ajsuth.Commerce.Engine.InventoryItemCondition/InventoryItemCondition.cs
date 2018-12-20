// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Inventory;
    using Sitecore.Framework.Rules;

    /// <inheritdoc />
    /// <summary>
    /// Defines an inventory item condition
    /// </summary>
    [EntityIdentifier("$safeitemname$")]
    public class $safeitemname$ : IInventoryItemCondition
    {
        /// <summary>
		/// Gets or sets the commander.
		/// </summary>
		/// <value>
		/// The commander.
		/// </value>
		protected CommerceCommander Commander { get; set; }

        /// <inheritdoc />
        /// <summary>Initializes a new instance of the <see cref="T:Sitecore.Commerce.Plugin.Inventory.IInventoryItemCondition" /> class.</summary>
        /// <param name="commander">The commerce commander.</param>
        public $safeitemname$(CommerceCommander commander)
        {
            this.Commander = commander;
        }

        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="context">
        /// The rule execution context.
        /// </param>
        /// <returns>
        /// The evaluation success.
        /// </returns>
        public bool Evaluate(IRuleExecutionContext context)
        {
            var commerceContext = context.Fact<CommerceContext>(null);

            var evaluation = false;

            /* Add Business Logic Here */

            return evaluation;
        }
    }
}