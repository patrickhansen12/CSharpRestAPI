﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using VideoMenuBLL;
using VideoMenuBLL.BusiessObjects;
using VideoMenuBLL.BusinessObjects;
using VideoMenuDAL.Entities;

namespace VideoRestAPI
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
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                var facade = new BLLFacade();
                var vid = facade.VideoService.Create(new VideoBO()
                {
                    Name = "Flying cat",
                    
                     
                });
               
                facade.VideoService.Create(new VideoBO()
                {
                    Name = "testvideo.mp4"
                });
                facade.GenreService.Create(new GenreBO()
                {
                 
                    Horror = "yes",
                    Romance = "no",
                    Minecraft = "yes",
                    Prank = "yes",
                    Video = vid
                    
                   

                });
            }

            app.UseMvc();
        }
    }
}
