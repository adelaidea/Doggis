using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Doggis.Application.Mapper
{
    public static class MapperConfig
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
