using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuanLy.SqlServer;
using QuanLy.SqlServer.Store;
using QuanLy.src.Abstractions.DependencyInjection;
using QuanLy.src.Abstractions.Store;
using QuanLy.src.SqlServer.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SqlServerStoreBuilderExtensions
    {
        public static IStoreBuilder UseSqlServer(this IStoreBuilder builder, IConfiguration configuration)
        {
            // Config feature’s store options
            builder.Services.Configure<StoreOptions>(builder.Configuration.GetSection("SqlServer"));
            // Get connection name from feature’s options
            var connectionString = configuration.GetConnectionString("MvcDbConstr"); ;

            builder.Services.AddDbContext<DbQuanLyContext>(o => o.UseSqlServer(connectionString)); // config DbContext
                                                                                                   // add store services
            builder.Services.AddScoped<INhanVienStore, QuanLyNhanVienStore>();
            builder.Services.AddScoped<IGioiTinhStore, GioiTinhStore>();
            builder.Services.AddScoped<IKhachHangStore, QuanLyKhachHangStore>();
            builder.Services.AddScoped<ISanPhamStore, QuanLySanPhamStore>();
            builder.Services.AddScoped<IHoaDonStore, QuanLyHoaDonStore>();
            builder.Services.AddScoped<IChiTietHoaDonStore, ChiTietHoaDonStore>();
            return builder;
        }

    }
}
