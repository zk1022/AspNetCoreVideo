using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Data;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreVideo
{
    public class Startup
    {
       public IConfiguration Configuration { get; set; }

        //public Startup()
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json"); ;

        //    Configuration = builder.Build();
        //}

         public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            if (env.IsDevelopment()) builder.AddUserSecrets<Startup>();

            Configuration = builder.Build();
        }



 
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddSingleton<IMessageService, HardcodedMessageService>();

            var conn = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<VideoDbContext>(options => options.UseSqlServer(conn));

            services.AddMvc();
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IMessageService, ConfigurationMessageService>();
            services.AddScoped<IVideoData, MockVideoData>();
            services.AddSingleton<IVideoData, MockVideoData>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,IMessageService msg)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
           // app.UseStaticFiles();

            app.Run(async (context) =>
            {
                // await context.Response.WriteAsync("Hello,from My World!");

                /*从json中读取信息
                var message = Configuration["Message"];
                await context.Response.WriteAsync(message);*/

               // throw new Exception("Fake Exception!");

                await context.Response.WriteAsync(msg.GetMessage());


            });

            
        }
    }
}
