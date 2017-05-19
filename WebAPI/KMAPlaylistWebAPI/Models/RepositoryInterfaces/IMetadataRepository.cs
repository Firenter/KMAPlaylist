using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMAPlaylistWebAPI.Models.RepositoryInterfaces
{
    public interface IMetadataRepository
    {
        List<MetaData> GetAllSongMetadata(int songID);
    }
}
