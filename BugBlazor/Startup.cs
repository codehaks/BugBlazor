using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugBlazor.Data;
using BugBlazor.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BugBlazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BugDb>(options =>
             options.UseSqlite("DataSource=bug.sqlite"));

            services.AddRazorPages()
                .AddRazorRuntimeCompilation();
            services.AddServerSideBlazor();
            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<BugHub>("/bughub");
                endpoints.MapHub<CounterHub>("/counterhub");
                endpoints.MapBlazorHub();
                endpoints.MapRazorPages();
                //endpoints.MapFallbackToPage("/index");
            });
        }
    }
}
