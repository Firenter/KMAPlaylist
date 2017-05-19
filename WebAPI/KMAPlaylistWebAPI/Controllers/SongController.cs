using KMAPlaylistWebAPI.Models.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KMAPlaylistWebAPI.Controllers
{
    [RoutePrefix("song")]
    public class SongController : ApiController
    {
        ISongRepository songRepo;

        public SongController(ISongRepository repo)
        {
            songRepo = repo;
        }

        [Route("")]
        public IHttpActionResult GetSongs()
        {
            try
            {
                var songs = songRepo.GetAllSongs();

                if (songs != null)
                {
                    return Ok(songs);
                }
                else
                {
                    return NotFound();
                }

            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

    }
}
