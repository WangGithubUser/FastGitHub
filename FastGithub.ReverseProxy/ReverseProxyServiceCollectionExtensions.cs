﻿using FastGithub.ReverseProxy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FastGithub
{
    /// <summary>
    /// gitub反向代理的服务注册扩展
    /// </summary>
    public static class ReverseProxyServiceCollectionExtensions
    {
        /// <summary>
        /// gitub反向代理
        /// </summary>
        /// <param name="services"></param> 
        /// <returns></returns>
        public static IServiceCollection AddGithubReverseProxy(this IServiceCollection services)
        {
            services.AddHttpForwarder();
            services.AddSingleton<NoneSniHttpClient>();
            return services;
        }
    }
}
