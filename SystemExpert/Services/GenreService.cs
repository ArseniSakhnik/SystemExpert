using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SystemExpert.Data;
using SystemExpert.Entities;

namespace SystemExpert.Services
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