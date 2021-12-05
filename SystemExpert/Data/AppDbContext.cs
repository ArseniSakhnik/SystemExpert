using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SystemExpert.Entities;
using SystemExpert.Enums;

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
                    ParentGenreId = 2,
                    FeatureId = Feature.Классика
                },
                new Genre
                {
                    Id = 6,
                    Name = "Индастриал-метал",
                    ParentGenreId = 2,
                    FeatureId = Feature.Искаженная
                },
                new Genre
                {
                    Id = 7,
                    Name = "Ню-метал",
                    ParentGenreId = 2,
                    FeatureId = Feature.Разнообразная
                },
                new Genre
                {
                    Id = 8,
                    Name = "Фолк-метал",
                    ParentGenreId = 2,
                    FeatureId = Feature.Народная
                },
                new Genre
                {
                    Id = 9,
                    Name = "Блэк-метал",
                    ParentGenreId = 2,
                    FeatureId = Feature.Экстрим
                },

                new Genre
                {
                    Id = 10,
                    Name = "Ска-панк",
                    ParentGenreId = 3,
                    FeatureId = Feature.Политика
                },
                new Genre
                {
                    Id = 11,
                    Name = "Хоррор-панк",
                    ParentGenreId = 3,
                    FeatureId = Feature.Страшная
                },
                new Genre
                {
                    Id = 12,
                    Name = "Фолк-панк",
                    ParentGenreId = 3,
                    FeatureId = Feature.Народная
                },
                new Genre
                {
                    Id = 13,
                    Name = "Арт-панк",
                    ParentGenreId = 3,
                    FeatureId = Feature.Искусство
                },
                new Genre
                {
                    Id = 14,
                    Name = "Пост-панк",
                    ParentGenreId = 3,
                    FeatureId = Feature.Разнообразная
                },

                new Genre
                {
                    Id = 15,
                    Name = "Гранж",
                    ParentGenreId = 4,
                    FeatureId = Feature.Искаженная
                },
                new Genre
                {
                    Id = 16,
                    Name = "Индастриал-рок",
                    ParentGenreId = 4,
                    FeatureId = Feature.Разнообразная
                },
                new Genre
                {
                    Id = 17,
                    Name = "Поп-панк",
                    ParentGenreId = 4,
                    FeatureId = Feature.Расслабляющая
                },
                new Genre
                {
                    Id = 18,
                    Name = "Шугейзинг",
                    ParentGenreId = 4,
                    FeatureId = Feature.Грустная
                },
                new Genre
                {
                    Id = 19,
                    Name = "Мэдчестер",
                    ParentGenreId = 4,
                    FeatureId = Feature.Классика
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
                    ParentGenreId = 20,
                    FeatureId = Feature.Расслабляющая
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
                    ParentGenreId = 21,
                    FeatureId = Feature.Искусство
                },
                new Genre
                {
                    Id = 25,
                    Name = "Гоа-транс",
                    ParentGenreId = 21,
                    FeatureId = Feature.Расслабляющая
                },
                new Genre
                {
                    Id = 26,
                    Name = "Хард-транс",
                    ParentGenreId = 21,
                    FeatureId = Feature.Экстрим
                },
                new Genre
                {
                    Id = 27,
                    Name = "Эйсид-транс",
                    ParentGenreId = 21,
                    FeatureId = Feature.Искаженная
                },
                new Genre
                {
                    Id = 28,
                    Name = "Евротранс",
                    ParentGenreId = 21,
                    FeatureId = Feature.Классика
                },
                new Genre
                {
                    Id = 29,
                    Name = "Евроденс",
                    ParentGenreId = 22,
                    FeatureId = Feature.Классика
                },
                new Genre
                {
                    Id = 30,
                    Name = "Диско хаус",
                    ParentGenreId = 22,
                    FeatureId = Feature.Искаженная
                },
                new Genre
                {
                    Id = 31,
                    Name = "Хай-энерджи",
                    ParentGenreId = 22,
                    FeatureId = Feature.Экстрим
                },
                new Genre
                {
                    Id = 32,
                    Name = "Итало-диско",
                    ParentGenreId = 22,
                    FeatureId = Feature.Народная
                },
                new Genre
                {
                    Id = 33,
                    Name = "Ню-диско",
                    ParentGenreId = 22,
                    FeatureId = Feature.Разнообразная
                },
                new Genre
                {
                    Id = 34,
                    Name = "Теч-хаус",
                    ParentGenreId = 23,
                    FeatureId = Feature.Классика
                },
                new Genre
                {
                    Id = 35,
                    Name = "Электро-хаус",
                    ParentGenreId = 23,
                    FeatureId = Feature.Разнообразная
                },
                new Genre
                {
                    Id = 36,
                    Name = "Дип-хаус",
                    ParentGenreId = 23,
                    FeatureId = Feature.Расслабляющая
                },
                new Genre
                {
                    Id = 37,
                    Name = "Эйсид-хаус",
                    ParentGenreId = 23,
                    FeatureId = Feature.Экстрим
                },
                new Genre
                {
                    Id = 38,
                    Name = "Прогрессив-хаус",
                    ParentGenreId = 23,
                    FeatureId = Feature.Искусство
                },
                new Genre
                {
                    Id = 39,
                    Name = "Реп",
                    ParentGenreId = null
                },
                new Genre
                {
                    Id = 40,
                    Name = "Региональный",
                    ParentGenreId = 39
                },
                new Genre
                {
                    Id = 41,
                    Name = "Hard-Core",
                    ParentGenreId = 39
                },
                new Genre
                {
                    Id = 42,
                    Name = "Трэп",
                    ParentGenreId = 40
                },
                new Genre
                {
                    Id = 43,
                    Name = "Русский",
                    ParentGenreId = 40,
                    FeatureId = Feature.Народная
                },
                new Genre
                {
                    Id = 44,
                    Name = "Южный",
                    ParentGenreId = 40,
                    FeatureId = Feature.Экстрим
                },
                new Genre
                {
                    Id = 45,
                    Name = "Восточный",
                    ParentGenreId = 40,
                    FeatureId = Feature.Классика
                },
                new Genre
                {
                    Id = 46,
                    Name = "Западный",
                    ParentGenreId = 40,
                    FeatureId = Feature.Политика
                },
                new Genre
                {
                    Id = 47,
                    Name = "Мемфис",
                    ParentGenreId = 41,
                    FeatureId = Feature.Искаженная
                },
                new Genre
                {
                    Id = 48,
                    Name = "Грязный",
                    ParentGenreId = 41,
                    FeatureId = Feature.Карикатура
                },
                new Genre
                {
                    Id = 49,
                    Name = "Хоррор",
                    ParentGenreId = 41,
                    FeatureId = Feature.Страшная
                },
                new Genre
                {
                    Id = 50,
                    Name = "Ганстерский",
                    ParentGenreId = 41,
                    FeatureId = Feature.Экстрим
                },
                new Genre
                {
                    Id = 51,
                    Name = "Дрилл",
                    ParentGenreId = 42,
                    FeatureId = Feature.Страшная
                },
                new Genre
                {
                    Id = 52,
                    Name = "Латино-трэп",
                    ParentGenreId = 42,
                    FeatureId = Feature.Народная
                },
                new Genre
                {
                    Id = 53,
                    Name = "Tread",
                    ParentGenreId = 42,
                    FeatureId = Feature.Разнообразная
                },
                new Genre
                {
                    Id = 54,
                    Name = "Фонк",
                    ParentGenreId = 42,
                    FeatureId = Feature.Расслабляющая
                }
            });
        }
    }
}