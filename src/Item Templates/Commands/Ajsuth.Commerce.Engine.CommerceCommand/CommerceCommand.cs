// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemrootname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using System;
using System.Threading.Tasks;

namespace $rootnamespace$
{
    /// <summary>Defines the $fileinputname$ command.</summary>
    public class $safeitemrootname$ : CommerceCommand
    {
        /// <summary>Gets or sets the commander.</summary>
        /// <value>The commander.</value>
        protected CommerceCommander Commander { get; set; }

        /// <summary>Initializes a new instance of the <see cref="$safeitemrootname$" /> class.</summary>
        /// <param name="commander">The <see cref="CommerceCommander"/>.</param>
        /// <param name="serviceProvider">The service provider</param>
        public $safeitemrootname$(CommerceCommander commander, IServiceProvider serviceProvider) : base(serviceProvider)
        {
            this.Commander = commander;
        }

        /// <summary>The process of the command</summary>
        /// <param name="commerceContext">The commerce context</param>
        /// <param name="parameter">The parameter for the command</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public virtual async Task<CommerceEntity> Process(CommerceContext commerceContext, object parameter)
        {
            CommerceEntity result = null;
            
            var context = commerceContext.CreatePartialClone();
            using (var activity = CommandActivity.Start(context, this))
            {
                /* Replace the following sample code with custom logic */
                var arg = new CustomPipelineArgument(parameter);
                result = await Commander.Pipeline<ICustomPipeline>().RunAsync(arg, context.PipelineContextOptions).ConfigureAwait(false);
                
                return result;
            }
        }
    }
}