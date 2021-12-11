using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SystemExpert.Entities;
using SystemExpert.Enums;

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

        public static async Task<Genre> GetGenreByParent(GenreEnum genreEnumId)
        {
            await using var appDbContext = new AppDbContext();

            return genreEnumId switch
            {
                GenreEnum.Поп => await LoadParentGenreWithChildren(20, null),
                GenreEnum.Реп => await LoadParentGenreWithChildren(39, null),
                GenreEnum.Рок => await LoadParentGenreWithChildren(1, null),
                _ => throw new ArgumentOutOfRangeException(nameof(genreEnumId), genreEnumId, null)
            };
        }

        public static async Task<Genre> LoadParentGenreWithChildren(int id, Genre genre)
        {
            await using var appDbContext = new AppDbContext();
            var gen = new Genre();

            if (genre is null)
            {
                var first = await appDbContext.Genres
                    .Include(genreDb => genreDb.ChildGenres)
                    .SingleOrDefaultAsync(genreDb => genreDb.Id == id);

                gen = new Genre
                {
                    Id = first.Id,
                    ChildGenres = first.ChildGenres,
                    Name = first.Name
                };

                foreach (var childGenre in gen.ChildGenres)
                {
                    await LoadParentGenreWithChildren(childGenre.Id, childGenre);
                }
            }
            else
            {
                var child = await appDbContext.Genres
                    .Include(genreDb => genreDb.ChildGenres)
                    .SingleOrDefaultAsync(genreDb => genreDb.Id == id);

                if (child is null)
                {
                    return null;
                }

                genre.ChildGenres = new List<Genre>
                {
                    new Genre
                    {
                        Id = child.Id,
                        ChildGenres = child.ChildGenres,
                        Name = child.Name
                    }
                };

                foreach (var childGenre in child.ChildGenres)
                {
                    if (childGenre.ChildGenres is null)
                    {
                        return childGenre;
                    }
                    
                    await LoadParentGenreWithChildren(child.Id, genre);
                }
            }

            return gen;
        }
    }
}