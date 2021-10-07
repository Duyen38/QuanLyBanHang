using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace QuanLy.src.Abstractions.DependencyInjection
{
    public class DefaultStoreBuilder : IStoreBuilder
    {
        public DefaultStoreBuilder(IServiceCollection services, IConfiguration configuration)
        {
            Services = services;
            Configuration = configuration;
        }
        public IServiceCollection Services { get; set; }
        public IConfiguration Configuration { get; set; }
    }
}
