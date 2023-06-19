using Microsoft.EntityFrameworkCore;
using OmniAPI.Data;
using OmniAPI.Domain.Models;

namespace OmniAPI.Main.DataAccess
{
    public class MovieRespository : GenericRepository<Movie, OmniContext>,
                                   IMovieRepository
    {
        public MovieRespository(OmniContext context)
          : base(context)
        {
        }

        public async Task<Movie> GetEpisodesByIdAsync(int movieId)
        {
            return await Context.Movies
              .Include(m => m.EpisodesOverall)
              .SingleAsync(m => m.Id == movieId);
        }
    }
}
