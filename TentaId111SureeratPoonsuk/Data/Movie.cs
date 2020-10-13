using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TentaId111SureeratPoonsuk.Data
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int GradeExpected { get; set; }
        public int GradeActual { get; set; }
        public int GradeRemember { get; set; }
    }
}
