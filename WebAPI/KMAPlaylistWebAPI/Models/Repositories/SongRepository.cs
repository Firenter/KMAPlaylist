using KMAPlaylistWebAPI.Models.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMAPlaylistWebAPI.Models.Repositories
{
    public class SongRepository : ISongRepository
    {
        KMAEntities db = new KMAEntities();

        public List<Song> GetAllSongs()
        {
            return db.Song.ToList();
        }

    }
}