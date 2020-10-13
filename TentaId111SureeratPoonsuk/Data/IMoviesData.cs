using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TentaId111SureeratPoonsuk.Data
{
    interface IMoviesData
    {
        Task<List<Movie>> GetData();
        Task InsertMovie(Movie movie);
        Task UpdateMovie(Movie movie);
        Task DeleteMovie(int movieId);
    }
}
