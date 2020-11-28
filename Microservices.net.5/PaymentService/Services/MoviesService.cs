using PaymentService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Services
{
    public class MoviesService
    {
        public Task<List<Movie>> GetAll()
        {
            var res = new List<Movie> {
                new  Movie(1, "Aba Ganuv",""),
                new Movie(1, "Aba Ganuv", ""),
                new Movie(1, "Aba Ganuv", ""),
                new Movie(1, "Aba Ganuv", ""),
                new Movie(1, "Aba Ganuv", ""),
                new Movie(1, "Aba Ganuv", ""),
                new Movie(1, "Aba Ganuv", ""),
            };
            return Task.FromResult<List<Movie>>(res);
        }

    }
}
