using KMAPlaylistWebAPI.Models.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KMAPlaylistWebAPI.Models.Repositories
{
    public class MetadataRepository : IMetadataRepository
    {
        KMAEntities db = new KMAEntities();

        public List<MetaData> GetAllSongMetadata(int songID)
        {
            Song selectedSong = db.Song.Where(s => s.ID == songID).FirstOrDefault();

            return selectedSong.ConnectedMetaData.ToList();
        }
    }
}