// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Carts;
    using Sitecore.Commerce.Plugin.Pricing;
    using Sitecore.Framework.Rules;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Defines a cart action
    /// </summary>
    [EntityIdentifier("Change to <Project>Constants.Rules.Actions.<Action Name>")]
    public class $safeitemname$ : ICartLineAction
    {
        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="context">
        /// The rule execution context.
        /// </param>
        public void Execute(IRuleExecutionContext context)
        {
            var commerceContext = context.Fact<CommerceContext>(null);
            var cart = commerceContext?.GetObject<Cart>();
            var totals = commerceContext?.GetObject<CartTotals>();
            if (cart == null || !cart.Lines.Any() || (totals == null || !totals.Lines.Any()))
            {
                return;
            }

            /* Add business logic here to validate custom parameters */

            var list = new List<CartLineComponent>();
            
            /* Add business logic here to determine applicable line items for discount */

            if (!list.Any())
            {
                return;
            }

            list.ForEach(line =>
            {
                if (!totals.Lines.ContainsKey(line.Id) || !line.HasPolicy<PurchaseOptionMoneyPolicy>())
                {
                    return;
                }

                var propertiesModel = commerceContext.GetObject<PropertiesModel>();
                var discount = commerceContext.GetPolicy<KnownCartAdjustmentTypesPolicy>().Discount;
                var discountValue = new Decimal();

                /* Add business logic here to calculate discount value */

                if (commerceContext.GetPolicy<GlobalPricingPolicy>().ShouldRoundPriceCalc)
                {
                    discountValue = Decimal.Round(
                            discountValue,
                            commerceContext.GetPolicy<GlobalPricingPolicy>().RoundDigits,
                            commerceContext.GetPolicy<GlobalPricingPolicy>().MidPointRoundUp ?
                                MidpointRounding.AwayFromZero :
                                MidpointRounding.ToEven
                        );
                }

                var amount = (line.GetPolicy<PurchaseOptionMoneyPolicy>().SellPrice.Amount - discountValue) * Decimal.MinusOne;
                var adjustments = line.Adjustments;
                adjustments.Add(new CartLineLevelAwardedAdjustment()
                {
                    Name = (propertiesModel?.GetPropertyValue("PromotionText") as string ?? discount),
                    DisplayName = (propertiesModel?.GetPropertyValue("PromotionCartText") as string ?? discount),
                    Adjustment = new Money(commerceContext.CurrentCurrency(), amount),
                    AdjustmentType = discount,
                    IsTaxable = false,
                    AwardingBlock = nameof($safeitemname$)
                });
                line.GetPolicy<PurchaseOptionMoneyPolicy>().SellPrice.Amount = discountValue;
                totals.Lines[line.Id].SubTotal.Amount = discountValue;
                line.GetComponent<MessagesComponent>().AddMessage(
                    commerceContext.GetPolicy<KnownMessageCodePolicy>().Promotions,
                    $"PromotionApplied: {propertiesModel?.GetPropertyValue("PromotionId") ?? nameof($safeitemname$)}");
            });
        }
    }
}
