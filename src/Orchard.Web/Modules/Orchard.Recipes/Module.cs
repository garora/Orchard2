﻿using Microsoft.Extensions.DependencyInjection;
using Orchard.Recipes.Services;

namespace Orchard.Recipes
{
    /// <summary>
    /// These services are registered on the tenant service collection
    /// </summary>
    public class Module : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRecipeParser, RecipeParser>();
            services.AddScoped<IRecipeHarvester, RecipeHarvester>();
            services.AddScoped<IRecipeManager, RecipeManager>();

            services.AddRecipeOptions();
            services.AddRecipeExtension("*.recipe.json");
        }
    }
}