using System;
using System.Collections.Generic;
using System.Linq;
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
                FeatureId = Feature.Классика,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Kiss"
                    },
                    new MusicalGroup
                    {
                        Name = "Crue"
                    },
                    new MusicalGroup
                    {
                        Name = "Twisted Sisted"
                    }
                }
            },
            new Genre
            {
                Name = "Индастриал-метал",
                FeatureId = Feature.Искаженная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Rammstein"
                    },
                    new MusicalGroup
                    {
                        Name = "Oomph!"
                    },
                    new MusicalGroup
                    {
                        Name = "Marilyn Manson"
                    }
                }
            },
            new Genre
            {
                Name = "Ню-метал",
                FeatureId = Feature.Разнообразная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "System of a down"
                    },
                    new MusicalGroup
                    {
                        Name = "Korn"
                    },
                    new MusicalGroup
                    {
                        Name = "Slipknot"
                    }
                }
            },
            new Genre
            {
                Name = "Фолк-метал",
                FeatureId = Feature.Народная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Korpiklaani"
                    },
                    new MusicalGroup
                    {
                        Name = "Finntroll"
                    },
                    new MusicalGroup
                    {
                        Name = "Enisferum"
                    }
                }
            },
            new Genre
            {
                Name = "Блэк-метал",
                FeatureId = Feature.Экстрим,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Burzum"
                    },
                    new MusicalGroup
                    {
                        Name = "Immortal"
                    },
                    new MusicalGroup
                    {
                        Name = "Dimmu Borqir"
                    }
                }
            }
        };

        public static List<Genre> PunkGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Ска-панк",
                FeatureId = Feature.Политика,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Distemper"
                    },
                    new MusicalGroup
                    {
                        Name = "Reel Big Fish"
                    },
                    new MusicalGroup
                    {
                        Name = "Mad Caddies"
                    }
                }
            },
            new Genre
            {
                Name = "Хоррор-панк",
                FeatureId = Feature.Страшная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Misfits"
                    },
                    new MusicalGroup
                    {
                        Name = "Murderdolls"
                    },
                    new MusicalGroup
                    {
                        Name = "Король и шут"
                    }
                }
            },
            new Genre
            {
                Name = "Фолк-панк",
                FeatureId = Feature.Народная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Dropkick"
                    },
                    new MusicalGroup
                    {
                        Name = "Murphys"
                    },
                    new MusicalGroup
                    {
                        Name = "Against Me"
                    },
                    new MusicalGroup
                    {
                        Name = "Flogging Molly"
                    }
                }
            },
            new Genre
            {
                Name = "Арт-панк",
                FeatureId = Feature.ЛюбовьКИскусству,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Yeah Yeah Yeahs"
                    },
                    new MusicalGroup
                    {
                        Name = "Wire"
                    },
                    new MusicalGroup
                    {
                        Name = "Talking Heads"
                    }
                }
            },
            new Genre
            {
                Name = "Пост-панк",
                FeatureId = Feature.Разнообразная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Joy Division"
                    },
                    new MusicalGroup
                    {
                        Name = "The Cure"
                    },
                    new MusicalGroup
                    {
                        Name = "Interpol"
                    }
                }
            }
        };

        public static List<Genre> AltGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Гранж",
                FeatureId = Feature.Искаженная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Nirvana"
                    },
                    new MusicalGroup
                    {
                        Name = "Foo Fighters"
                    },
                    new MusicalGroup
                    {
                        Name = "Pearl Jan"
                    }
                }
            },
            new Genre
            {
                Name = "Индастриал-рок",
                FeatureId = Feature.Разнообразная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Nine Inch Nails"
                    },
                    new MusicalGroup
                    {
                        Name = "Skinny Puppy"
                    },
                    new MusicalGroup
                    {
                        Name = "Ministry"
                    }
                }
            },
            new Genre
            {
                Name = "Поп-панк",
                FeatureId = Feature.Расслабляющая,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Blink-I82"
                    },
                    new MusicalGroup
                    {
                        Name = "Paramore"
                    },
                    new MusicalGroup
                    {
                        Name = "Green Day"
                    }
                }
            },
            new Genre
            {
                Name = "Шугейзинг",
                FeatureId = Feature.Грустная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "My Bloodiy Valentine"
                    },
                    new MusicalGroup
                    {
                        Name = "Slowdive"
                    },
                    new MusicalGroup
                    {
                        Name = "M83"
                    }
                }
            },
            new Genre
            {
                Name = "Мэдчестер",
                FeatureId = Feature.Классика,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "The Stone Roses"
                    },
                    new MusicalGroup
                    {
                        Name = "Happy Mondays"
                    },
                    new MusicalGroup
                    {
                        Name = "The Charlatans"
                    }
                }
            }
        };

        public static List<Genre> DiscoGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Евроденс",
                FeatureId = Feature.Классика,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Руки вверх!"
                    },
                    new MusicalGroup
                    {
                        Name = "Haddaway"
                    },
                    new MusicalGroup
                    {
                        Name = "Aqua"
                    }
                }
            },
            new Genre
            {
                Name = "Диско хаус",
                FeatureId = Feature.Искаженная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Avicii"
                    },
                    new MusicalGroup
                    {
                        Name = "David Guetta"
                    },
                    new MusicalGroup
                    {
                        Name = "Calvin Harris"
                    }
                }
            },
            new Genre
            {
                Name = "Хай-энерджи",
                FeatureId = Feature.Экстрим,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Britney Spears"
                    },
                    new MusicalGroup
                    {
                        Name = "Rihanna"
                    },
                    new MusicalGroup
                    {
                        Name = "Capella"
                    }
                }
            },
            new Genre
            {
                Name = "Итало-диско",
                FeatureId = Feature.Народная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Radiorama"
                    },
                    new MusicalGroup
                    {
                        Name = "Savage"
                    },
                    new MusicalGroup
                    {
                        Name = "Capella"
                    }
                }
            },
            new Genre
            {
                Name = "Ню-диско",
                FeatureId = Feature.Разнообразная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Michael Jackson"
                    },
                    new MusicalGroup
                    {
                        Name = "Caroline Rose"
                    },
                    new MusicalGroup
                    {
                        Name = "Lady Gaga"
                    }
                }
            }
        };

        public static List<Genre> TranceGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Прогрессив-хаус",
                FeatureId = Feature.ЛюбовьКИскусству,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "OceanaLab"
                    },
                    new MusicalGroup
                    {
                        Name = "Rank 1"
                    },
                    new MusicalGroup
                    {
                        Name = "BT"
                    }
                }
            },
            new Genre
            {
                Name = "Гоа-транс",
                FeatureId = Feature.Расслабляющая,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "RiWe"
                    },
                    new MusicalGroup
                    {
                        Name = "X-Dream"
                    },
                    new MusicalGroup
                    {
                        Name = "Filteria"
                    }
                }
            },
            new Genre
            {
                Name = "Хард-транс",
                FeatureId = Feature.Экстрим,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Cosmic Gate"
                    },
                    new MusicalGroup
                    {
                        Name = "Yoji"
                    },
                    new MusicalGroup
                    {
                        Name = "Drax"
                    }
                }
            },
            new Genre
            {
                Name = "Эйсид-транс",
                FeatureId = Feature.Искаженная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Balil"
                    },
                    new MusicalGroup
                    {
                        Name = "SkyLab"
                    },
                    new MusicalGroup
                    {
                        Name = "HardFloor"
                    }
                }
            },
            new Genre
            {
                Name = "Евротранс",
                FeatureId = Feature.Классика,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "ATB"
                    },
                    new MusicalGroup
                    {
                        Name = "Blank & Jones"
                    },
                    new MusicalGroup
                    {
                        Name = "Sash!"
                    }
                }
            }
        };

        public static List<Genre> HouseGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Теч-хаус",
                FeatureId = Feature.Классика,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Steve Aoki"
                    },
                    new MusicalGroup
                    {
                        Name = "Gui Boratto"
                    },
                    new MusicalGroup
                    {
                        Name = "Max Cooper"
                    }
                }
            },
            new Genre
            {
                Name = "Электро-хаус",
                FeatureId = Feature.Разнообразная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Zedd"
                    },
                    new MusicalGroup
                    {
                        Name = "Martin Garrix"
                    },
                    new MusicalGroup
                    {
                        Name = "The Chainsmokers"
                    }
                }
            },
            new Genre
            {
                Name = "Диа-хаус",
                FeatureId = Feature.Расслабляющая,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Solomun"
                    },
                    new MusicalGroup
                    {
                        Name = "Fouk"
                    },
                    new MusicalGroup
                    {
                        Name = "SVGO"
                    }
                }
            },
            new Genre
            {
                Name = "Эйсид-хаус",
                FeatureId = Feature.Экстрим,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Bam Bam"
                    },
                    new MusicalGroup
                    {
                        Name = "Lil Louis"
                    },
                    new MusicalGroup
                    {
                        Name = "Josh Wink"
                    }
                }
            },
            new Genre
            {
                Name = "Прогрессив-хаус",
                FeatureId = Feature.ЛюбовьКИскусству,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Nick Warred"
                    },
                    new MusicalGroup
                    {
                        Name = "Lefferied"
                    },
                    new MusicalGroup
                    {
                        Name = "Pryda"
                    }
                }
            }
        };

        public static List<Genre> RegionGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Русский",
                FeatureId = Feature.Народная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Ак-47"
                    },
                    new MusicalGroup
                    {
                        Name = "Ноггано"
                    },
                    new MusicalGroup
                    {
                        Name = "Баста"
                    },
                    new MusicalGroup
                    {
                        Name = "Nintendo"
                    } 
                }
            },
            new Genre
            {
                Name = "Южный",
                FeatureId = Feature.Экстрим,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Lil Baby"
                    },
                    new MusicalGroup
                    {
                        Name = "Outkast"
                    },
                    new MusicalGroup
                    {
                        Name = "Migos"
                    }
                }
            },
            new Genre
            {
                Name = "Восточный",
                FeatureId = Feature.Классика,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Jay-Z"
                    },
                    new MusicalGroup
                    {
                        Name = "Nas"
                    },
                    new MusicalGroup
                    {
                        Name = "Prodigy"
                    }
                }
            },
            new Genre
            {
                Name = "Западный",
                FeatureId = Feature.Политика,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Ice Cube"
                    },
                    new MusicalGroup
                    {
                        Name = "Dr.Dre"
                    },
                    new MusicalGroup
                    {
                        Name = "2Pac"
                    }
                }
            }
        };

        public static List<Genre> HardcoreGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Мефис",
                FeatureId = Feature.Искаженная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "T-Rock"
                    },
                    new MusicalGroup
                    {
                        Name = "C-Rock"
                    },
                    new MusicalGroup
                    {
                        Name = "Gangsta Pat"
                    }
                }
            },
            new Genre
            {
                Name = "Грязный",
                FeatureId = Feature.Карикатура,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Plies"
                    },
                    new MusicalGroup
                    {
                        Name = "Lil Wayne"
                    },
                    new MusicalGroup
                    {
                        Name = "Lil' Kim"
                    }
                }
            },
            new Genre
            {
                Name = "Хоррор",
                FeatureId = Feature.Страшная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Insane Clown"
                    },
                    new MusicalGroup
                    {
                        Name = "Posse"
                    },
                    new MusicalGroup
                    {
                        Name = "Twiztid"
                    },
                    new MusicalGroup
                    {
                        Name = "Necor"
                    }
                }
                
            },
            new Genre
            {
                Name = "Гангстерский",
                FeatureId = Feature.Экстрим,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Conejo"
                    },
                    new MusicalGroup
                    {
                        Name = "Mr Criminal"
                    },
                    new MusicalGroup
                    {
                        Name = "T.I."
                    }
                }
            }
        };

        public static List<Genre> TrapGenres = new List<Genre>
        {
            new Genre
            {
                Name = "Дрилл",
                FeatureId = Feature.Страшная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Young Chop"
                    },
                    new MusicalGroup
                    {
                        Name = "Chief Keef"
                    },
                    new MusicalGroup
                    {
                        Name = "Lil Durk"
                    }
                }
            },
            new Genre
            {
                Name = "Латино-трэп",
                FeatureId = Feature.Народная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Bad Bunny"
                    },
                    new MusicalGroup
                    {
                        Name = "Jon Z"
                    },
                    new MusicalGroup
                    {
                        Name = "El Alfa"
                    }
                }
            },
            new Genre
            {
                Name = "Tread",
                FeatureId = Feature.Народная,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "Lil Yachty"
                    },
                    new MusicalGroup
                    {
                        Name = "5 Finger Posse"
                    }
                }
            },
            new Genre
            {
                Name = "ФОНК",
                FeatureId = Feature.Расслабляющая,
                Groups = new List<MusicalGroup>
                {
                    new MusicalGroup
                    {
                        Name = "LXST CENTURY"
                    },
                    new MusicalGroup
                    {
                        Name = "DVRST"
                    }
                }
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

        public static List<string> GetCurrentGenreFeatures()
        {
            return CurrentGenres
                .Select(genre => GetFeatureString(genre.FeatureId))
                .ToList();
        }

        private static string GetFeatureString(Feature feature)
        {
            return feature switch
            {
                Feature.Грустная => "Грустная",
                Feature.Нет => "Нет",
                Feature.Расслабляющая => "Расслабляющая",
                Feature.Искаженная => "Искаженная",
                Feature.Классика => "Классика",
                Feature.Разнообразная => "Разнообразная",
                Feature.Народная => "Народная",
                Feature.Экстрим => "Экстрим",
                Feature.Политика => "Политика",
                Feature.Страшная => "Страшная",
                Feature.Искусство => "Искусство",
                Feature.Карикатура => "Карикатура",
                Feature.ЛюбовьКИскусству => "Любовь к искусству",
                _ => throw new ArgumentOutOfRangeException(nameof(feature), feature, null)
            };
        }
    }
}