using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SystemExpert.Entities;

namespace SystemExpert.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        private string DbPath { get; set; }

        public AppDbContext()
        {
            const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}expertSystem.db";
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasMany(genre => genre.ChildGenres)
                .WithOne(childGenre => childGenre.ParentGenre)
                .HasForeignKey(genre => genre.ParentGenreId);

            var index = 5;
            var parentId = 2;
            
            modelBuilder.Entity<Genre>().HasData(new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    Name = "Рок",
                    ParentGenreId = null
                },
                new Genre
                {
                    Id = 2,
                    Name = "Метал",
                    ParentGenreId = 1
                },
                new Genre
                {
                    Id = 3,
                    Name = "Панк",
                    ParentGenreId = 1
                },
                new Genre
                {
                    Id = 4,
                    Name = "Альтернативный рок",
                    ParentGenreId = 1
                },
                new Genre
                {
                    Id = 5,
                    Name = "Глэм-метал",
                    ParentGenreId = 2
                },
                new Genre
                {
                    Id = 6,
                    Name = "Ска-панк",
                    ParentGenreId = 3
                },
                new Genre
                {
                    Id = 7,
                    Name = "Гранж",
                    ParentGenreId = 4
                },
                new Genre
                {
                    Id = 8,
                    Name = "Индастриал-метал",
                    ParentGenreId = 5
                },
                new Genre
                {
                    Id = 9,
                    Name = "Хоррор-панк",
                    ParentGenreId = 6
                },
                new Genre
                {
                    Id = 10,
                    Name = "Индастриал-рок",
                    ParentGenreId = 7
                },
                new Genre
                {
                    Id = 11,
                    Name = "Ню-метал",
                    ParentGenreId = 8
                },
                new Genre
                {
                    Id = 12,
                    Name = "Фолк-панк",
                    ParentGenreId = 9
                },
                new Genre
                {
                    Id = 13,
                    Name = "Поп-панк",
                    ParentGenreId = 10
                },
                new Genre
                {
                    Id = 14,
                    Name = "Фолк-метал",
                    ParentGenreId = 11
                },
                new Genre
                {
                    Id = 15,
                    Name = "Арт-панк",
                    ParentGenreId = 12
                },
                new Genre
                {
                    Id = 16,
                    Name = "Шугейзинг",
                    ParentGenreId = 13
                },
                new Genre
                {
                    Id = 17,
                    Name = "Блэк-метал",
                    ParentGenreId = 14
                },
                new Genre
                {
                    Id = 18,
                    Name = "Пост-панк",
                    ParentGenreId = 15
                },
                new Genre
                {
                    Id = 19,
                    Name = "Мэдчестер",
                    ParentGenreId = 16
                },
                new Genre
                {
                    Id = 20,
                    Name = "ПОП-Музыка",
                    ParentGenreId = null
                },
                new Genre
                {
                    Id = 21,
                    Name = "Транс",
                    ParentGenreId = 20
                },
                new Genre
                {
                    Id = 22,
                    Name = "Диско",
                    ParentGenreId = 20
                },
                new Genre
                {
                    Id = 23,
                    Name = "Хаус",
                    ParentGenreId = 20
                },
                new Genre
                {
                    Id = 24,
                    Name = "Прогрессив-транс",
                    ParentGenreId = 21
                },
                new Genre
                {
                    Id = 25,
                    Name = "Гоа-транс",
                    ParentGenreId = 21
                },
                new Genre
                {
                    Id = 26,
                    Name = "Хард-транс",
                    ParentGenreId = 21
                },
                new Genre
                {
                    Id = 27,
                    Name = "Эйсид-транс",
                    ParentGenreId = 21
                },
                new Genre
                {
                    Id = 28,
                    Name = "Евротранс",
                    ParentGenreId = 21
                },
                new Genre
                {
                    Id = 29,
                    Name = "Евроденс",
                    ParentGenreId = 22
                },
                new Genre
                {
                    Id = 30,
                    Name = "Диско хаус",
                    ParentGenreId = 22
                },
                new Genre
                {
                    Id = 31,
                    Name = "Хай-энерджи",
                    ParentGenreId = 22
                },
                new Genre
                {
                    Id = 32,
                    Name = "Итало-диско",
                    ParentGenreId = 22
                },
                new Genre
                {
                    Id = 33,
                    Name = "Ню-диско",
                    ParentGenreId = 22
                },
                new Genre
                {
                    Id = 34,
                    Name = "Теч-хаус",
                    ParentGenreId = 23
                },
                new Genre
                {
                    Id = 35,
                    Name = "Электро-хаус",
                    ParentGenreId = 23
                },
                new Genre
                {
                    Id = 36,
                    Name = "Дип-хаус",
                    ParentGenreId = 23
                },
                new Genre
                {
                    Id = 37,
                    Name = "Эйсид-хаус",
                    ParentGenreId = 23
                },
                new Genre
                {
                    Id = 38,
                    Name = "Прогрессив-хаус",
                    ParentGenreId = 23
                },
            });
        }
    }
}