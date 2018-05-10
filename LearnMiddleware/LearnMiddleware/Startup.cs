using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnMiddleware.Interfaces;
using LearnMiddleware.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LearnMiddleware
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
            services.AddScoped<IMonitoring, MySQLMonitoring>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            //app.UseMvc();


            app.Use(async (context, next) =>
            {
//                if (!context.Request.IsHttps)
//                {
//                    context.Abort();
//                }

                context.RequestServices.GetService<IConfigurationRoot>();

                await next.Invoke();
            });

            //terminate application pipeline and return response
            app.Run(async context => { await context.Response.WriteAsync("Hello"); });
        }
    }
}
