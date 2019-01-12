// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Carts;
    using Sitecore.Commerce.Plugin.Fulfillment;
    using Sitecore.Framework.Rules;
    using System.Linq;

    [EntityIdentifier(nameof($safeitemname$))]
    public class $safeitemname$ : IFulfillmentCondition
    {
        /// <summary>
        /// Gets or sets the commander.
        /// </summary>
        /// <value>
        /// The commander.
        /// </value>
        protected CommerceCommander Commander { get; set; }

        /// <inheritdoc />
        /// <summary>Initializes a new instance of the <see cref="T:Sitecore.Commerce.Plugin.Fulfillment.IFulfillmentCondition" /> class.</summary>
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
            if (cart == null || !cart.Lines.Any() || !cart.HasComponent<FulfillmentComponent>())
            {
                return false;
            }

            /* Add business logic here to validate custom parameters */

            var component = cart.GetComponent<FulfillmentComponent>();

            /* Add business logic here to determine if the cart fulfillment meets the condition */

            return false;
        }
    }
}