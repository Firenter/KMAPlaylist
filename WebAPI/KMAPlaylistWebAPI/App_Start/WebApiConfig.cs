﻿using KMAPlaylistWebAPI.Models.Repositories;
using KMAPlaylistWebAPI.Models.RepositoryInterfaces;
using KMAPlaylistWebAPI.Resolver;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace KMAPlaylistWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<ISongRepository, SongRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IMetadataRepository, MetadataRepository>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}