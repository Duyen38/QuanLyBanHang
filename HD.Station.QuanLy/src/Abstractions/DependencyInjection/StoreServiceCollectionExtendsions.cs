using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuanLy.src.Abstractions.Abstractions;
using QuanLy.src.Abstractions.DependencyInjection;
using QuanLy.src.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class StoreServiceCollectionExtendsions
    {
        public static IStoreBuilder AddStoreBuilder(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<string>(configuration.GetSection("MvcDbConstr")); //optional
            return new DefaultStoreBuilder(services, configuration);
        }
        public static IStoreBuilder AddManagerBuilder(this IStoreBuilder builder)
        {
            builder.Services.AddScoped<IQuanLyNhanVien, QuanLyNhanVien>();
            builder.Services.AddScoped<IQuanLyGioiTinh, QuanLyGioiTinh>();
            builder.Services.AddScoped<IQuanLyKhachHang, QuanLyKhachHang>();
            builder.Services.AddScoped<IQuanLySanPham, QuanLySanPham>();
            builder.Services.AddScoped<IQuanLyHoaDon, QuanLyHoaDon>();
            builder.Services.AddScoped<IQuanLyChiTietHoaDon, QuanLyChiTietHoaDon>();
            return builder;
        }
    }
}
