using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            //Fetching Connection string from APPSETTINGS.JSON
           
            //services.AddDbContext<DbQuanLyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MvcDbConstr")));
            
            services.AddRazorPages().AddRazorPagesOptions( o => {
                o.RootDirectory = "/Features";
                o.Conventions.AddPageRoute("/Home", "/");
            });
            services.AddStoreBuilder(Configuration.GetSection("Demo")).AddManagerBuilder().UseSqlServer(Configuration);
            services.AddControllersWithViews();

            services.Configure<RazorViewEngineOptions>(o =>
            {
                //// {2} is area, {1} is controller,{0} is the action   
                o.AreaViewLocationFormats.Clear();
                o.ViewLocationFormats.Add("/Views/{0}" + RazorViewEngine.ViewExtension);
                o.ViewLocationFormats.Add("/Shared/{0}" + RazorViewEngine.ViewExtension);
                o.ViewLocationFormats.Add("Features/Home/Views/{0}" + RazorViewEngine.ViewExtension);

                o.AreaViewLocationFormats.Clear();
                o.AreaViewLocationFormats.Add("/Features/{2}/{1}/Views/{0}.cshtml");
                o.AreaViewLocationFormats.Add("/Features/{1}/Views/{0}.cshtml");
                o.AreaViewLocationFormats.Add("/Features/{2}/Views/Shared/{0}.cshtml");
                o.AreaViewLocationFormats.Add("/Features/Shared/{0}.cshtml");

                //o.ViewLocationFormats.Clear();

                //o.ViewLocationFormats.Add("/Views/{1}/{0}" + RazorViewEngine.ViewExtension);
                //o.ViewLocationFormats.Add("/Views/{0}" + RazorViewEngine.ViewExtension);
                //o.ViewLocationFormats.Add("/Controllers/Shared/Views/{0}" + RazorViewEngine.ViewExtension);

                //// Untested. You could remove this if you don't care about areas.
                //o.AreaViewLocationFormats.Clear();
                //o.AreaViewLocationFormats.Add("/Features/{2}/{1}/Views/{0}" + RazorViewEngine.ViewExtension);
                //o.AreaViewLocationFormats.Add("/Areas/{2}/Controllers/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
                //o.AreaViewLocationFormats.Add("/Areas/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
                //o.AreaViewLocationFormats.Clear();
                //o.ViewLocationFormats.Add("/Views/{0}" + RazorViewEngine.ViewExtension);
                //o.AreaViewLocationFormats.Add("/Features/{2}/{1}/Views/{0}" + RazorViewEngine.ViewExtension);
                //o.AreaViewLocationFormats.Add("/Features/{1}/Views/{0}" + RazorViewEngine.ViewExtension);

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}/{maSP?}"); 
                endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Home}/{action=Index}/{id?}/{maSP?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
