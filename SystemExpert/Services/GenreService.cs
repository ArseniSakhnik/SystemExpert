using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ExpertSystem.Entities;
using Microsoft.EntityFrameworkCore;
using SystemExpert.Data;
using SystemExpert.Entities;

namespace ExpertSystem.Services
{
    public static class GenreService
    {
        public static async Task<Genre> GetGenreById(int id)
        {
            await using var appDbContext = new AppDbContext();
            return await appDbContext.Genres
                .SingleOrDefaultAsync(genre => genre.Id == id);
        }
    }
}