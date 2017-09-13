using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoMenuDAL.Context;
using VideoMenuDAL.Entities;

namespace VideoMenuDAL.Repository
{
    class VideoRepositoryEFMemory : IVideoRepository
    {
        VideoAppContext _context;

        public VideoRepositoryEFMemory(VideoAppContext context)
        {
            _context = context;
        }

        public Video Create(Video video)
        {
            _context.Videos.Add(video);
            return video;
        }

        public Video Delete(int Id)
        {
            var vid = Get(Id);
            _context.Videos.Remove(vid);
            return vid;
        }

        public Video Get(int Id)
        {
            return _context.Videos.FirstOrDefault(x => x.Id == Id);
        }

        public List<Video> GetAll()
        {
            return _context.Videos.ToList();
        }
    }
}
