using OmniAPI.Domain.Models;

namespace OmniAPI.Main.DataAccess
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
        Task<Movie> GetEpisodesByIdAsync(int movieId);
    }
}
