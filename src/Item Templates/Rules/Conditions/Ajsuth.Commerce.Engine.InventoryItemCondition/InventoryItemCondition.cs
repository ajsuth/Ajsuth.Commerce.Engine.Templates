// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Microsoft.Extensions.Logging;
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Catalog;
    using Sitecore.Commerce.Plugin.Inventory;
    using Sitecore.Framework.Rules;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Defines an inventory item condition
    /// </summary>
    [EntityIdentifier(nameof($safeitemname$))]
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
        /// Gets or set the target item id.
        /// </summary>
        /// <value>
        /// The target item id.
        /// </value>
        public IRuleValue<string> TargetItemId { get; set; }

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
            var commerceContext = context.Fact<CommerceContext>();
            if (commerceContext == null)
            {
                commerceContext.Logger.LogError($"{nameof($safeitemname$)}: Cannot determine commerce context.");
                return false;
            }

            var itemId = this.TargetItemId.Yield(context);
            if (string.IsNullOrWhiteSpace(itemId))
            {
                commerceContext.Logger.LogError($"{nameof($safeitemname$)}: Target Item Id cannot be null or whitespace.");
                return false;
            }

            /* Add business logic here to validate custom parameters */

            var productArgument = ProductArgument.FromItemId(itemId);
            var sellableItem = Task.Run(() => Commander.Command<GetSellableItemCommand>().Process(commerceContext, itemId, false)).Result;
            if (sellableItem == null)
            {
                commerceContext.Logger.LogWarning($"{nameof($safeitemname$)}: Inventory item '{itemId}' not found");
                return false;
            }

            var catalog = commerceContext.GetEntity<Catalog>();
            var inventorySet = catalog?.DefaultInventorySetName;
            if (string.IsNullOrEmpty(catalog?.DefaultInventorySetName))
            {
                commerceContext.Logger.LogWarning($"{nameof($safeitemname$)}: Cannot determine catalog's default Inventory Set name");
                return false;
            }

            var inventoryInformation = Task.Run(() =>
                    Commander.Command<GetInventoryInformationCommand>().Process(
                        commerceContext,
                        $"{CommerceEntity.IdPrefix<InventorySet>()}{inventorySet}",
                        sellableItem.Id,
                        productArgument.VariantId,
                        false)).Result;

            if (inventoryInformation == null)
            {
                commerceContext.Logger.LogInformation($"{nameof($safeitemname$)}: Inventory Information not found for '{itemId}'");
                return false;
            }

            /* Add business logic here to determine if the inventory information meets the condition */

            return false;
        }
    }
}