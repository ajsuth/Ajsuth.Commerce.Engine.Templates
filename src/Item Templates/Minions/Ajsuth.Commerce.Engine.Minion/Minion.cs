// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Microsoft.Extensions.Logging;
    using Sitecore.Commerce.Core;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// The $safeitemname$.
    /// </summary>
    public class $safeitemname$ : Minion
    {
        /// <summary>
        /// Initialises the minion.
        /// </summary>
        /// <param name="serviceProvider">
        /// The service provider.
        /// </param>
        /// <param name="logger">
        /// The logger.
        /// </param>
        /// <param name="policy">
        /// The minion policy.
        /// </param>
        /// <param name="environment">
        /// The commerce environment.
        /// </param>
        /// <param name="globalContext">
        /// The context.
        /// </param>
        public override void Initialize(IServiceProvider serviceProvider, ILogger logger, MinionPolicy policy, CommerceEnvironment environment, CommerceContext globalContext)
        {
            base.Initialize(serviceProvider, logger, policy, environment, globalContext);
        }

        /// <summary>
        /// The execute.
        /// </summary>
        /// <returns>
        /// The <see cref="MinionRunResultsModel"/>.
        /// </returns>
        public override async Task<MinionRunResultsModel> Run()
        {
            var listCount = await GetListCount(Policy.ListToWatch);
            Logger.LogInformation($"{Name}-Review List {Policy.ListToWatch}: Count:{listCount}");
            if (listCount > 0L)
            {
                foreach (var item in (await GetListItems<AddItemTypeHere>(Policy.ListToWatch, Policy.ItemsPerBatch)).ToList())
                {
                    Logger.LogDebug($"{Name}-Processing item: {item.Id}");
                    var commerceContext = new CommerceContext(Logger, MinionContext.TelemetryClient, null);
                    commerceContext.Environment = Environment;

                    /* Add business logic here*/
                }
            }
            Logger.LogInformation($"{Name}-Items Complete: {listCount}");

            return new MinionRunResultsModel();
        }
    }
}