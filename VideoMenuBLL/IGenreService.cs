using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuBLL.BusiessObjects;

namespace VideoMenuBLL
{
   public interface IGenreService
    {
        GenreBO Create(GenreBO genre);

        List<GenreBO> GetAll();
        GenreBO Get(int Id);

        GenreBO Update(GenreBO genre);

        GenreBO Delete(int Id);
    }
}
