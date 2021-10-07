using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public interface IStoreBuilder
    {
        IServiceCollection Services { get; set; }
        IConfiguration Configuration { get; set; }
    }
}
