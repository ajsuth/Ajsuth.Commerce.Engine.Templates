// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Microsoft.Extensions.Logging;
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Shops;
    using Sitecore.Framework.Rules;
    using System.Threading.Tasks;

    [EntityIdentifier(nameof($safeitemname$))]
    public class $safeitemname$ : IShopCondition
    {
        /// <summary>
        /// Gets or sets the commander.
        /// </summary>
        /// <value>
        /// The commander.
        /// </value>
        protected CommerceCommander Commander { get; set; }

        /// <inheritdoc />
        /// <summary>Initializes a new instance of the <see cref="T:Sitecore.Commerce.Plugin.Shops.IShopCondition" /> class.</summary>
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

            /* Add business logic here to validate custom parameters */

            var shop = Task.Run(() => Commander.Command<GetShopCommand>().Process(commerceContext, commerceContext.CurrentShopName())).Result;
            if (shop == null)
            {
                commerceContext.Logger.LogWarning($"{nameof($safeitemname$)}: Shop '{commerceContext.CurrentShopName()}' not found.");
                return false;
            }

            /* Add business logic here to determine if the shop meets the condition */

            return false;
        }
    }
}