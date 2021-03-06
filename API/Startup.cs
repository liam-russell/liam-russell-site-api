using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;

namespace LiamRussell.Api {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc(config => {
                config.EnableEndpointRouting = false;
                var stringFormatter = config.OutputFormatters.OfType<StringOutputFormatter>().FirstOrDefault();
                if (stringFormatter != null) {
                    config.OutputFormatters.Remove(stringFormatter);
                    config.OutputFormatters.Add(stringFormatter);
                }
            })
            .AddJsonOptions(options => {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Title = "Liam Russell API",
                    Version = "v1",
                    Contact = new OpenApiContact {
                        Name = "Liam Russell",
                        Url = new Uri("https://liamr.co/")
                    },
                    Description = "The API behind liamr.co and liamrussell.com.au",
                    License = new OpenApiLicense {
                        Name = "All rights reserved"
                    }
                });
                var xmlFile = $"{typeof(Startup).Assembly.GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseSwagger(c => {
                c.RouteTemplate = "spec-{documentName}.json";
            });
            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors(config => {
                config.WithOrigins(
                    //Local development origin
                    "http://localhost:3000",
                    //Production origins
                    "https://liamr.co",
                    "https://liamrussell.com.au/",
                    //Develop branch origins
                    "https://dev.liamr.co",
                    "https://dev.liamrussell.com.au/"
                );
                config.AllowAnyHeader();
                //At this stage, the API only allows data to be retrieved.
                config.WithMethods("GET", "OPTIONS", "HEAD");
            });
            app.UseMvc();
            app.UseReDoc(c => {
                c.RoutePrefix = "docs";
                c.SpecUrl = "/spec-v1.json";
                c.DocumentTitle = "Liam Russell API V1";
            });
        }
    }
}
