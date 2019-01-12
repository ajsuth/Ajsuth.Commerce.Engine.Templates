// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Feature.Carts.Engine.Conditions
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Carts;
    using Sitecore.Framework.Rules;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Defines an inventory item condition
    /// </summary>
    [EntityIdentifier(nameof($safeitemname$))]
    public class $safeitemname$ : CartTargetItemId, ICartsCondition
    {
        /// <summary>
		/// Gets or sets the commander.
		/// </summary>
		/// <value>
		/// The commander.
		/// </value>
		protected CommerceCommander Commander { get; set; }

        /// <inheritdoc />
        /// <summary>Initializes a new instance of the <see cref="T:Sitecore.Commerce.Plugin.Carts.CartTargetItemId" /> class.</summary>
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
            if (commerceContext == null)
            {
                commerceContext.Logger.LogError($"{nameof($safeitemname$)}: Cannot determine commerce context.");
                return false;
            }

            var cart = commerceContext?.GetObject<Cart>();
            if (cart == null)
            {
                commerceContext.Logger.LogWarning($"{nameof($safeitemname$)}: Cart not found.");
                return false;
            }

            var itemId = this.TargetItemId.Yield(context);
            if (string.IsNullOrWhiteSpace(itemId))
            {
                commerceContext.Logger.LogError($"{nameof($safeitemname$)}: Target item id cannot be null or whitespace.");
                return false;
            }

            /* Add business logic here to validate custom parameters */

            return this.MatchingLines(context).Any(line =>
            {
                /* Add business logic here to determine if line meets the condition */

                return false;
            });
        }
    }
}