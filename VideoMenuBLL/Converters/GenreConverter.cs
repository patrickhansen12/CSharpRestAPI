using System;
using System.Collections.Generic;
using System.Text;
using VideoMenuBLL.BusiessObjects;
using VideoMenuBLL.BusinessObjects;
using VideoMenuDAL.Entities;

namespace VideoMenuBLL.Converters
{
    class GenreConverter
    {
        internal Genre Convert(GenreBO genre)
        {
            if (genre == null)
            {
                return null;
            }
            return new Genre()
            {
                Id = genre.Id,
                Horror = genre.Horror,
                Minecraft = genre.Minecraft,
                Romance = genre.Romance,
                Prank = genre.Prank,
                Video = new VideoConverter().Convert(genre.Video)

            };
        }
    

    internal GenreBO Convert(Genre genre)
        {
            if (genre == null)
            {
                return null;
            }
            return new GenreBO()
            {
                Id = genre.Id,
                Horror = genre.Horror,
                Minecraft = genre.Minecraft,
                Romance = genre.Romance,
                Prank = genre.Prank,
                Video = new VideoConverter().Convert(genre.Video)
            };
        }
    }
}

