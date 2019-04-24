
using GraphAPI.Graph;
using GraphAPI.GraphQL;
using GraphAPI.GraphQL.GraphFace;
using GraphAPI.GraphQL.GraphOwner;
using GraphAPI.GraphQL.GraphPlate;
using GraphAPI.Models;
using GraphAPI.Mutations;
using GraphAPI.Repository.Implements;
using GraphAPI.Repository.Interfaces;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GraphAPI
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
            //services.AddDbContext<GraphDbContext>(context =>
            //{
            //    context.UseInMemoryDatabase("GraphDemo");
            //});
            services.AddDbContext<GraphDbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:GraphDB"]));
            services.AddScoped<IPlateRepository, PlateManager>();
            services.AddScoped<IDataRepository<Face>, FaceManager>();
            services.AddScoped<IDataRepository<Owner>, OwnerManager>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<OwnerQuery>();
            services.AddSingleton<OwnerType>();
            services.AddSingleton<OwnerInputType>();
            services.AddSingleton<OwnerMutation>();
            //services.AddSingleton<PlateQuery>();
            services.AddSingleton<PlateType>();
            //services.AddSingleton<FaceQuery>();
            services.AddSingleton<FaceType>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new GraphSchema(new FuncDependencyResolver(type => sp.GetService(type))));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
         
            app.UseHttpsRedirection();
            app.UseGraphiQl("/graphql");
            app.UseMvc();
        }

     
    }
}
