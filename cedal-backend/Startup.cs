using cedal_backend.ClientInterfaces;
using cedal_backend.Clients;
using cedal_backend.Data;
using cedal_backend.Interfaces;
using cedal_backend.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace cedal_backend
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
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
      services.AddDbContext<CedalContext>(item => item.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
      //Add Applicant service
      services.AddTransient<IApplicantService, ApplicantService>();

      //Add Event Service
      services.AddTransient<IEventService, EventService>();

      //Add Http Clients
      services.AddHttpClient<IEventClient, CedalEventClient>("Event");
      services.AddHttpClient<IApplicantClient, CedalApplicantClient>("Applicant");

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
      });
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
        app.UseHsts();
      }

      app.UseHttpsRedirection();

      // Enable middleware to serve generated Swagger as a JSON endpoint.
      app.UseSwagger();

      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
      });
      app.UseMvc();
    }
  }
}
