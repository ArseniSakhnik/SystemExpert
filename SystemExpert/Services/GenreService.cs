using System;
using System.Collections.Generic;
using SystemExpert.Entities;
using SystemExpert.Enums;

namespace SystemExpert.Services
{
    public static class GenreService
    {
        public static List<Genre> MetalGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Глэм-метал",
                FeatureId = Feature.Классика
            },
            new Genre
            {
                Name = "Индастриал-метал",
                FeatureId = Feature.Искаженная
            },
            new Genre
            {
                Name = "Ню-метал",
                FeatureId = Feature.Разнообразная
            },
            new Genre
            {
                Name = "Фолк-метал",
                FeatureId = Feature.Народная
            },
            new Genre
            {
                Name = "Блэк-метал",
                FeatureId = Feature.Экстрим
            }
        };

        public static List<Genre> PunkGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Ска-панк",
                FeatureId = Feature.Политика
            },
            new Genre
            {
                Name = "Хоррор-панк",
                FeatureId = Feature.Страшная
            },
            new Genre
            {
                Name = "Фолк-панк",
                FeatureId = Feature.Народная
            },
            new Genre
            {
                Name = "Арт-панк",
                FeatureId = Feature.ЛюбовьКИскусству
            },
            new Genre
            {
                Name = "Пост-панк",
                FeatureId = Feature.Разнообразная
            }
        };

        public static List<Genre> AltGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Гранж",
                FeatureId = Feature.Искаженная
            },
            new Genre
            {
                Name = "Индастриал-рок",
                FeatureId = Feature.Разнообразная
            },
            new Genre
            {
                Name = "Поп-панк",
                FeatureId = Feature.Расслабляющая
            },
            new Genre
            {
                Name = "Шугейзинг",
                FeatureId = Feature.Грустная
            },
            new Genre
            {
                Name = "Мэдчестер",
                FeatureId = Feature.Классика
            }
        };

        public static List<Genre> DiscoGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Евроденс",
                FeatureId = Feature.Классика
            },
            new Genre
            {
                Name = "Диско хаус",
                FeatureId = Feature.Искаженная
            },
            new Genre
            {
                Name = "Хай-энерджи",
                FeatureId = Feature.Экстрим
            },
            new Genre
            {
                Name = "Итало-диско",
                FeatureId = Feature.Народная
            },
            new Genre
            {
                Name = "Ню-диско",
                FeatureId = Feature.Разнообразная
            }
        };

        public static List<Genre> TranceGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Прогрессив-хаус",
                FeatureId = Feature.ЛюбовьКИскусству,
            },
            new Genre
            {
                Name = "Гоа-транс",
                FeatureId = Feature.Расслабляющая
            },
            new Genre
            {
                Name = "Хард-транс",
                FeatureId = Feature.Экстрим
            },
            new Genre
            {
                Name = "Эйсид-транс",
                FeatureId = Feature.Искаженная
            },
            new Genre
            {
                Name = "Евротранс",
                FeatureId = Feature.Классика
            }
        };

        public static List<Genre> HouseGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Теч-хаус",
                FeatureId = Feature.Классика
            },
            new Genre
            {
                Name = "Электро-хаус",
                FeatureId = Feature.Разнообразная
            },
            new Genre
            {
                Name = "Диа-хаус",
                FeatureId = Feature.Расслабляющая
            },
            new Genre
            {
                Name = "Эйсид-хаус",
                FeatureId = Feature.Экстрим
            },
            new Genre
            {
                Name = "Прогрессив-хаус",
                FeatureId = Feature.ЛюбовьКИскусству
            }
        };

        public static List<Genre> RegionGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Русский",
                FeatureId = Feature.Народная
            },
            new Genre
            {
                Name = "Южный",
                FeatureId = Feature.Экстрим
            },
            new Genre
            {
                Name = "Восточный",
                FeatureId = Feature.Классика
            },
            new Genre
            {
                Name = "Западный",
                FeatureId = Feature.Политика
            }
        };

        public static List<Genre> HardcoreGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Мефис",
                FeatureId = Feature.Искаженная
            },
            new Genre
            {
                Name = "Грязный",
                FeatureId = Feature.Карикатура
            },
            new Genre
            {
                Name = "Хоррор",
                FeatureId = Feature.Страшная
            },
            new Genre
            {
                Name = "Гангстерский",
                FeatureId = Feature.Экстрим
            }
        };

        public static List<Genre> TrapGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Дрилл",
                FeatureId = Feature.Страшная
            },
            new Genre
            {
                Name = "Латино-трэп",
                FeatureId = Feature.Народная
            },
            new Genre
            {
                Name = "Tread",
                FeatureId = Feature.Народная
            },
            new Genre
            {
                Name = "ФОНК",
                FeatureId = Feature.Расслабляющая
            },
        };

        public static List<Genre> CurrentGenres = null;
        
        public static void SetCurrentGenre(GenresTypeEnum genreTypeId)
        {
            CurrentGenres = genreTypeId switch
            {
                GenresTypeEnum.Метал => MetalGenres,
                GenresTypeEnum.Панк => PunkGenres,
                GenresTypeEnum.Альт => AltGenres,
                GenresTypeEnum.Диско => DiscoGenres,
                GenresTypeEnum.Транс => TranceGenres,
                GenresTypeEnum.Хаус => HouseGenres,
                GenresTypeEnum.Региональный => RegionGenres,
                GenresTypeEnum.Хардкор => HardcoreGenres,
                GenresTypeEnum.Трэп => TrapGenres,
                _ => throw new ArgumentOutOfRangeException(nameof(genreTypeId), genreTypeId, null)
            };
        }
    }
}