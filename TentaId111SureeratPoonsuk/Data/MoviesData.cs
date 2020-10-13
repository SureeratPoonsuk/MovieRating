using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TentaId111SureeratPoonsuk.Data
{
    public class MoviesData : IMoviesData
    {
        private readonly ISqlDataAccess _db;

        public MoviesData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task DeleteMovie(int movieId)
        {
            string sql = @"delete dbo.Movies WHERE MovieId=@MovieId";
            return _db.SaveData(sql, new { MovieId = movieId });
        }

        public Task<List<Movie>> GetData()
        {
            string sql = "select * from dbo.Movies";
            return _db.LoadData<Movie, dynamic>(sql, new { });
        }

        public Task InsertMovie(Movie movie)
        {
            string sql = @"insert into dbo.Movies (MovieName, GradeExpected)
                            values (@MovieName, @GradeExpected);";
            return _db.SaveData(sql, movie);
        }

        public Task UpdateMovie(Movie movie)
        {

            string sql = @"Update dbo.Movies set MovieName = @MovieName, GradeExpected = @GradeExpected, GradeActual = @GradeActual, GradeRemember = @GradeRemember
                            where MovieId = @MovieId;";
            return _db.SaveData(sql, movie);
        }
    }
}
