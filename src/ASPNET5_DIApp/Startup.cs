using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Autofac;
using ASPNET5_DIApp.AutoFacDependencyContainer;
using Autofac.Extensions.DependencyInjection;

namespace ASPNET5_DIApp
{
    public class Startup
    {
        

        public Startup()
        {
           

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddMvc();

        //    services.AddSingleton<IService<EmployeeInfo>, EmployeeInfoService>();
        //}

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var objectBuilder = new ContainerBuilder();
            objectBuilder.RegisterModule<DependencyRegistrationModule>();
            objectBuilder.Populate(services);

            var objectContainer = objectBuilder.Build();
            return objectContainer.Resolve<IServiceProvider>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=EmployeeInfo}/{action=Index}/{id?}");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
