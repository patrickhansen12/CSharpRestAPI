using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoMenuBLL.BusiessObjects;
using VideoMenuBLL.Converters;
using VideoMenuDAL;

namespace VideoMenuBLL.Services
{
    public class GenreService : IGenreService
    {
        private DALFacade _facade;
        GenreConverter conv = new GenreConverter();

        public GenreService(DALFacade facade)
        {
            _facade = facade;


        }


        public GenreBO Create(GenreBO genre)
        {
            using (var ouw = _facade.UnitOfWork)
            {
                var genreEntity = ouw.GenreRepository.Create(conv.Convert(genre));
                ouw.Complete();
                return conv.Convert(genreEntity);
            }
        }


        public GenreBO Delete(int Id)
        {
            using (var ouw = _facade.UnitOfWork)
            {
                var genreEntity = ouw.GenreRepository.Delete(Id);
                ouw.Complete();
                return conv.Convert(genreEntity);
            }
        }

        public GenreBO Get(int Id)
        {
            using (var ouw = _facade.UnitOfWork)
            {
                var genreEntity = ouw.GenreRepository.Get(Id);
                return conv.Convert(genreEntity);
            }
        }

        public List<GenreBO> GetAll()
        {
            using (var ouw = _facade.UnitOfWork)
            {
                return ouw.GenreRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public GenreBO Update(GenreBO genre)
        {
            using (var ouw = _facade.UnitOfWork)
            {
                var genreEntity = ouw.GenreRepository.Get(genre.Id);
                if (genreEntity == null)
                {
                    throw new InvalidOperationException("Genre not found");
                }
                genreEntity.Horror = genre.Horror;
                genreEntity.Minecraft = genre.Minecraft;
                genreEntity.Romance = genre.Romance;
                genreEntity.Prank = genre.Prank;
                ouw.Complete();
                return conv.Convert(genreEntity);
            }
        }
    }
}
