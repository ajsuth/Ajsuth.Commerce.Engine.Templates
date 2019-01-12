// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Core.Commands;
    using Sitecore.Commerce.Plugin.Customers;
    using Sitecore.Commerce.Plugin.Orders;
    using Sitecore.Framework.Rules;
    using System.Linq;
    using System.Threading.Tasks;

    [EntityIdentifier(nameof($safeitemname$))]
    public class $safeitemname$ : ICustomerCondition
    {
        /// <summary>
        /// Gets or sets the commander.
        /// </summary>
        /// <value>
        /// The commander.
        /// </value>
        protected CommerceCommander Commander { get; set; }

        /// <inheritdoc />
        /// <summary>Initializes a new instance of the <see cref="T:Sitecore.Commerce.Plugin.Customers.ICustomerCondition" /> class.</summary>
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
            if (commerceContext == null || !commerceContext.CurrentUserIsRegistered())
            {
                return false;
            }

            /* Add business logic here to validate custom parameters */

            var listName = string.Format(commerceContext.GetPolicy<KnownOrderListsPolicy>().CustomerOrders, commerceContext.CurrentCustomerId());
            var orders = Task.Run(() => Commander.Command<FindEntitiesInListCommand>().Process<Order>(commerceContext, listName, 0, int.MaxValue)).Result?.Items.ToList();
            if (orders == null || !orders.Any())
            {
                return false;
            }

            /* Add business logic here to determine if the customer order meets the condition */

            return false;
        }
    }
}
