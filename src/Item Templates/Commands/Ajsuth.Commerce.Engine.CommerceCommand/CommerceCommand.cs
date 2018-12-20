// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Core.Commands;
    using System;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// Defines the $safeitemrootname$ command.
    /// </summary>
    public class $safeitemrootname$ : CommerceCommand
    {
        /// <summary>
        /// Gets or sets the commander.
        /// </summary>
        /// <value>
        /// The commander.
        /// </value>
        protected CommerceCommander Commander { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:$rootnamespace$.$safeitemrootname$" /> class.
        /// </summary>
        /// <param name="pipeline">
        /// The pipeline.
        /// </param>
        /// <param name="serviceProvider">The service provider</param>
        public $safeitemrootname$(CommerceCommander commander, IServiceProvider serviceProvider) : base(serviceProvider)
        {
            this.Commander = commander;
        }

        /// <summary>
        /// The process of the command
        /// </summary>
        /// <param name="commerceContext">
        /// The commerce context
        /// </param>
        /// <param name="parameter">
        /// The parameter for the command
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<CommerceEntity> Process(CommerceContext commerceContext, object parameter)
        {
            using (var activity = CommandActivity.Start(commerceContext, this))
            {
                var result = await Task.FromResult(new CommerceEntity());

                return result;
            }
        }
    }
}