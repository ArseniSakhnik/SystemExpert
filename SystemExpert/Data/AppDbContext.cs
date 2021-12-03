using System;
using System.Collections.Generic;
using ExpertSystem.Entities;
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
                    ParentGenreId = null
                },
                new Genre
                {
                    Id = 3,
                    Name = "Панк",
                    ParentGenreId = null 
                },
                new Genre
                {
                    Id = 4,
                    Name = "Альтернативный рок",
                    ParentGenreId = null
                },
                new Genre
                {
                    Id = index++,
                    Name = "Глэм-метал",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Ска-панк",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Гранж",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Индастриал-метал",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Хоррор-панк",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Индастриал-рок",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Ню-метал",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Фолк-панк",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Поп-панк",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Фолк-метал",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Арт-панк",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Шугейзинг",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Блэк-метал",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Пост-панк",
                    ParentGenreId = parentId++
                },
                new Genre
                {
                    Id = index++,
                    Name = "Мэдчестер",
                    ParentGenreId = parentId++
                }

            });
        }
    }
}