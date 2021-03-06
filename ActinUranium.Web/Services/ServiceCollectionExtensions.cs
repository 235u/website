﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ActinUranium.Web.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConfiguredRouting(this IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.LowercaseQueryStrings = true;
                options.ConstraintMap["slugify"] = typeof(SlugifyParameterTransformer);
            });

            return services;
        }

        public static IServiceCollection AddConfiguredMvc(this IServiceCollection services)
        {
            var parameterTransformer = new SlugifyParameterTransformer();

            IMvcBuilder mvc = services.AddMvc(options =>
            {
                var convention = new RouteTokenTransformerConvention(parameterTransformer);
                options.Conventions.Add(convention);
            });

            mvc.AddRazorPagesOptions(options =>
            {
                var convention = new PageRouteTransformerConvention(parameterTransformer);
                options.Conventions.Add(convention);
            });

            mvc.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);
            mvc.AddDataAnnotationsLocalization(options =>
            {
                options.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(SharedResources));
            });

            return services;
        }

        public static IServiceCollection AddConfiguredHsts(this IServiceCollection services)
        {
            services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(365);
            });

            return services;
        }


        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                const string DatabaseName = "ActinUranium.Web";
                options.UseInMemoryDatabase(DatabaseName);
            });

            return services.AddScoped<ApplicationDbInitializer>();
        }

        public static IServiceCollection AddApplicationDbInitializer(this IServiceCollection services) =>
            services.AddScoped<ApplicationDbInitializer>();

        public static IServiceCollection AddDataStores(this IServiceCollection services) => services
            .AddTransient<CreationStore>()
            .AddTransient<CustomerStore>()
            .AddTransient<ImageStore>()
            .AddTransient<HeadlineStore>()
            .AddTransient<ReleaseStore>();
    }
}
