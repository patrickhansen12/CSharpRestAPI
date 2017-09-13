using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuDAL.Entities;

namespace VideoMenuDAL.Context
{
    class VideoAppContext : DbContext
    {
        static DbContextOptions<VideoAppContext> options =
            new DbContextOptionsBuilder<VideoAppContext>()
                .UseInMemoryDatabase("TheDB").Options;

        public VideoAppContext() : base(options)
        {
            
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
