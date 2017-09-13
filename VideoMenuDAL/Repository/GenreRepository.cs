using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VideoMenuDAL.Context;
using VideoMenuDAL.Entities;

namespace VideoMenuDAL.Repository
{
    class GenreRepository : IGenreRepository
    {
        private VideoAppContext _context;
        public GenreRepository(VideoAppContext context)
        {
            _context = context;
        }
        public Genre Create(Genre genre)
        {
            if (genre.Video != null)
            {
                _context.Entry(genre.Video).State = EntityState.Unchanged;
            }
            _context.Genres.Add(genre);
            return genre;
        }

        public List<Genre> GetAll()
        {
            return _context.Genres.Include(g=>g.Video).ToList();
        }

        public Genre Get(int Id)
        {
            return _context.Genres.FirstOrDefault(g => g.Id == Id);
        }

        public Genre Delete(int Id)
        {
            var genre = Get(Id);
            _context.Genres.Remove(genre);
            return genre;
        }
    }
}
