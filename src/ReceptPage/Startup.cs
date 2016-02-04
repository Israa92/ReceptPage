using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using ReceptPage.Models;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;

namespace ReceptPage
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ReceptPageDB;Integrated Security=True";
            services
                .AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<RecipesContext>(
                config => config.UseSqlServer(connString));
            services.AddTransient<IRecipeRepository, RecipeTestRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Error);

            app.UseIISPlatformHandler();

            app.UseStatusCodePagesWithReExecute("/Exceptions/StatusCode{0}");

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler("/Exceptions/ErrorPage");

            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "Exceptions",
                template: "Home/ErrorPage",
                defaults: new { controller = "Exceptions", action = "ErrorPage" }
                );

                routes.MapRoute(
                name: "test",
                template: "Recipes/StatusCode404",
                defaults: new { controller = "Exceptions", action = "StatusCode404" }
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=index}/{id?}"

                        );
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
