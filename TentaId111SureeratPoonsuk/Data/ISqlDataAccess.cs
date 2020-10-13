using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TentaId111SureeratPoonsuk.Data
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}
