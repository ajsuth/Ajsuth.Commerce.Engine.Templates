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
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Defines a cart action
    /// </summary>
    [EntityIdentifier("$safeitemname$")]
    public class $safeitemname$ : ICartAction
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
            if (cart == null || !cart.Lines.Any())
            {
                return;
            }

            var discountValue = new Decimal();

            /* Add business logic here */

            if (discountValue == Decimal.Zero)
            {
                return;
            }

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

            var discount = commerceContext.GetPolicy<KnownCartAdjustmentTypesPolicy>().Discount;
            var propertiesModel = commerceContext.GetObject<PropertiesModel>();
            var amount = discountValue * Decimal.MinusOne;
            cart.Adjustments.Add(new CartLevelAwardedAdjustment()
            {
                Name = propertiesModel?.GetPropertyValue("PromotionText") as string ?? discount,
                DisplayName = propertiesModel?.GetPropertyValue("PromotionCartText") as string ?? discount,
                Adjustment = new Money(commerceContext.CurrentCurrency(), amount),
                AdjustmentType = discount,
                IsTaxable = false,
                AwardingBlock = nameof($safeitemname$)
            });

            cart.GetComponent<MessagesComponent>().AddMessage(
                commerceContext.GetPolicy<KnownMessageCodePolicy>().Promotions,
                $"PromotionApplied: {propertiesModel?.GetPropertyValue("PromotionId") ?? nameof($safeitemname$)}"
            );
        }
    }
}