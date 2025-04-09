using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class PokemonDataService
    {
        private readonly List<Pokemon> _pokemons;

        public PokemonDataService()
        {
            _pokemons = GeneratePokemonData();
        }

        public List<Pokemon> GetAllPokemons() => _pokemons;

        public Pokemon GetPokemonById(int id) => _pokemons.FirstOrDefault(p => p.Id == id);

        public List<Pokemon> GetPokemonsByGeneration(int generation) =>
            _pokemons.Where(p => p.Generation == generation).ToList();

        public List<Pokemon> GetPaginatedPokemons(int page, int pageSize) =>
            _pokemons.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        private List<Pokemon> GeneratePokemonData()
        {
            return new List<Pokemon>
            {
                // Generation 3 - Treecko
                new Pokemon {
                    Id = 252, Name = "Treecko", Types = new List<string> { "Grass" },
                    Generation = 3, NextEvolutionId = 253, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/treecko.jpg",
                    Height = 50, Weight = 500
                },
                new Pokemon {
                    Id = 253, Name = "Grovyle", Types = new List<string> { "Grass" },
                    Generation = 3, NextEvolutionId = 254, BaseEvolutionId = 252,
                    ImageUrl = "https://img.pokemondb.net/artwork/grovyle.jpg",
                    Height = 90, Weight = 2160
                },
                new Pokemon {
                    Id = 254, Name = "Sceptile", Types = new List<string> { "Grass" },
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 252,
                    ImageUrl = "https://img.pokemondb.net/artwork/sceptile.jpg",
                    Height = 170, Weight = 5220
                },

                // Torchic
                new Pokemon {
                    Id = 255, Name = "Torchic", Types = new List<string> { "Fire" },
                    Generation = 3, NextEvolutionId = 256, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/torchic.jpg",
                    Height = 40, Weight = 250
                },
                new Pokemon {
                    Id = 256, Name = "Combusken", Types = new List<string> { "Fire", "Fight" },
                    Generation = 3, NextEvolutionId = 257, BaseEvolutionId = 255,
                    ImageUrl = "https://img.pokemondb.net/artwork/combusken.jpg",
                    Height = 90, Weight = 1950
                },
                new Pokemon {
                    Id = 257, Name = "Blaziken", Types = new List<string> { "Fire", "Fight" },
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 255,
                    ImageUrl = "https://img.pokemondb.net/artwork/blaziken.jpg",
                    Height = 190, Weight = 5200
                },

                // Mudkip
                new Pokemon {
                    Id = 258, Name = "Mudkip", Types = new List<string> { "Water" },
                    Generation = 3, NextEvolutionId = 259, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/mudkip.jpg",
                    Height = 40, Weight = 760
                },
                new Pokemon {
                    Id = 259, Name = "Marshtomp", Types = new List<string> { "Water", "Ground" },
                    Generation = 3, NextEvolutionId = 260, BaseEvolutionId = 258,
                    ImageUrl = "https://img.pokemondb.net/artwork/marshtomp.jpg",
                    Height = 70, Weight = 2800
                },
                new Pokemon {
                    Id = 260, Name = "Swampert", Types = new List<string> { "Water", "Ground" },
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 258,
                    ImageUrl = "https://img.pokemondb.net/artwork/swampert.jpg",
                    Height = 150, Weight = 8190
                },

                // Poochyena 
                new Pokemon {
                    Id = 261, Name = "Poochyena", Types = new List<string> { "Dark" },
                    Generation = 3, NextEvolutionId = 262, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/poochyena.jpg",
                    Height = 50, Weight = 1360
                },
                new Pokemon {
                    Id = 262, Name = "Mightyena", Types = new List<string> { "Dark" },
                    Generation = 3, NextEvolutionId = 263, BaseEvolutionId = 261,
                    ImageUrl = "https://img.pokemondb.net/artwork/mightyena.jpg",
                    Height = 100, Weight = 3700
                },
                new Pokemon {
                    Id = 263, Name = "Zigzagoon", Types = new List<string> { "Normal" },
                    Generation = 3, NextEvolutionId = 264, BaseEvolutionId = 261,
                    ImageUrl = "https://img.pokemondb.net/artwork/zigzagoon.jpg",
                    Height = 40, Weight = 1750
                },
                 new Pokemon {
                    Id = 264, Name = "Linoone", Types = new List<string> { "Normal" },
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 261,
                    ImageUrl = "https://img.pokemondb.net/artwork/linoone.jpg",
                    Height = 50, Weight = 3250
                 },

                // Wurmple 2 moods
                new Pokemon {
                    Id = 265, Name = "Wurmple", Types = new List<string> { "Bug" },
                    Generation = 3, NextEvolutionId = 266, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/wurmple.jpg",
                    Height = 30, Weight = 360
                },
                new Pokemon {
                    Id = 266, Name = "Silcoonn", Types = new List<string> { "Bug" },
                    Generation = 3, NextEvolutionId = 267, BaseEvolutionId = 265,
                    ImageUrl = "https://img.pokemondb.net/artwork/silcoon.jpg",
                    Height = 60, Weight = 1000
                },
                new Pokemon {
                    Id = 267, Name = "Beautifly", Types = new List<string> { "Bug", "Flying" },
                    Generation = 3, NextEvolutionId= null, BaseEvolutionId = 265,
                    ImageUrl =  "https://img.pokemondb.net/artwork/beautifly.jpg",
                    Height = 100, Weight = 2840
                },
                new Pokemon {
                    Id = 268, Name = "Cascoon", Types =  new List<string> {"Bug"},
                    Generation = 3, NextEvolutionId = 269, BaseEvolutionId = 265,
                    ImageUrl = "https://img.pokemondb.net/artwork/cascoon.jpg",
                    Height =  70, Weight = 1150
                },
                new Pokemon {
                    Id = 269, Name = "Dustox", Types =  new List<string> {"Bug", "Poison"},
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 265,
                    ImageUrl = "https://img.pokemondb.net/artwork/dustox.jpg",
                    Height =  120, Weight = 3160
                },

                // Lotad 
                new Pokemon {
                    Id = 270, Name = "Lotad", Types =  new List<string> {"Water", "Grass"},
                    Generation = 3, NextEvolutionId = 271, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/lotad.jpg",
                    Height =  50, Weight = 260
                },
                new Pokemon {
                    Id = 271, Name = "Lombre", Types =  new List<string> {"Water", "Grass"},
                    Generation = 3, NextEvolutionId = 272, BaseEvolutionId = 270,
                    ImageUrl = "https://img.pokemondb.net/artwork/lombre.jpg",
                    Height =  120, Weight = 3250
                },
                new Pokemon {
                    Id = 272, Name = "Ludicolo", Types =  new List<string> {"Water", "Grass"},
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 270,
                    ImageUrl = "https://img.pokemondb.net/artwork/ludicolo.jpg",
                    Height =  150, Weight = 5500
                },

                // Seedot 
                new Pokemon {
                    Id = 273, Name = "Seedot", Types =  new List<string> {"Grass"},
                    Generation = 3, NextEvolutionId = 274, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/seedot.jpg",
                    Height =  50, Weight = 400
                },
                new Pokemon {
                    Id = 274, Name = "Nuzleaf", Types =  new List<string> {"Dark", "Grass"},
                    Generation = 3, NextEvolutionId = 275, BaseEvolutionId = 273,
                    ImageUrl = "https://img.pokemondb.net/artwork/nuzleaf.jpg",
                    Height =  100, Weight = 2800
                },
                new Pokemon {
                    Id = 275, Name = "Shiftry", Types =  new List<string> {"Dark", "Grass"},
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 273,
                    ImageUrl = "https://img.pokemondb.net/artwork/shiftry.jpg",
                    Height =  130, Weight = 5960
                },

                // Taillow
                new Pokemon {
                    Id = 276, Name = "Taillow", Types =  new List<string> {"Normal", "Flying"},
                    Generation = 3, NextEvolutionId = 277, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/taillow.jpg",
                    Height =  30, Weight = 230
                },
                new Pokemon {
                    Id = 277, Name = "Swellow", Types =  new List<string> {"Normal", "Flying"},
                    Generation = 3, NextEvolutionId = 278, BaseEvolutionId = 276,
                    ImageUrl = "https://img.pokemondb.net/artwork/swellow.jpg",
                    Height =  70, Weight = 1980
                },
                new Pokemon {
                    Id = 278, Name = "Wingull", Types =  new List<string> {"Water", "Flying"},
                    Generation = 3, NextEvolutionId = 279, BaseEvolutionId = 276,
                    ImageUrl = "https://img.pokemondb.net/artwork/wingull.jpg",
                    Height =  60, Weight = 950
                },
                new Pokemon {
                    Id = 279, Name = "Pelipper", Types =  new List<string> {"Water", "Flying"},
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 276,
                    ImageUrl = "https://img.pokemondb.net/artwork/pelipper.jpg",
                    Height =  120, Weight = 2800
                },
                
                //Ralts 
                new Pokemon {
                 Id = 280, Name = "Ralts", Types =  new List<string> {"Psychic", "Fairy"},
                 Generation = 3, NextEvolutionId = 281, BaseEvolutionId = null,
                 ImageUrl = "https://img.pokemondb.net/artwork/ralts.jpg",
                 Height =  40, Weight = 660
                },
                new Pokemon {
                Id = 281, Name = "Kirlia", Types = new List<string> { "Psychic", "Fairy" },
                 Generation = 3, NextEvolutionId = 282, BaseEvolutionId = 280,
                 ImageUrl = "https://img.pokemondb.net/artwork/kirlia.jpg",
                 Height = 80, Weight = 2020
                },
                new Pokemon {
                Id = 282, Name = "Gardevoir", Types = new List<string> { "Psychic", "Fairy" },
                Generation = 3, NextEvolutionId = null, BaseEvolutionId = 280,
                ImageUrl = "https://img.pokemondb.net/artwork/gardevoir.jpg",
                Height = 160, Weight = 4840
                },

                //Surskit
                new Pokemon {
                Id = 283, Name = "Surskit", Types = new List<string> { "Bug", "Water" },
                Generation = 3, NextEvolutionId = 284, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/surskit.jpg",
                Height = 50, Weight = 170
                },
                new Pokemon {
                Id = 284, Name = "Masquerain", Types = new List<string> { "Bug", "Flying" },
                Generation = 3, NextEvolutionId = null, BaseEvolutionId = 283,
                ImageUrl = "https://img.pokemondb.net/artwork/masquerain.jpg",
                Height = 80, Weight = 36
                },
                new Pokemon {
                Id = 285, Name = "Shroomish", Types = new List<string> { "Grass" },
                Generation = 3, NextEvolutionId = 286, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/shroomish.jpg",
                 Height = 40, Weight = 45
                },
                new Pokemon {
                Id = 286, Name = "Breloom", Types = new List<string> { "Grass", "Fighting" },
                Generation = 3, NextEvolutionId = null, BaseEvolutionId = 285,
                ImageUrl = "https://img.pokemondb.net/artwork/breloom.jpg",
                Height = 120, Weight = 396
                },

                //Slakoth 
                new Pokemon {
                Id = 287, Name = "Slakoth", Types = new List<string> { "Normal" },
                Generation = 3, NextEvolutionId = 288, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/slakoth.jpg",
                Height = 80, Weight = 240
                },
                new Pokemon {
                    Id = 288, Name = "Vigoroth", Types = new List<string> { "Normal" },
                    Generation = 3, NextEvolutionId = 289, BaseEvolutionId = 287,
                    ImageUrl = "https://img.pokemondb.net/artwork/vigoroth.jpg",
                    Height = 140, Weight = 465
                },
                new Pokemon {
                    Id = 289, Name = "Slaking", Types = new List<string> { "Normal" },
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 287,
                    ImageUrl = "https://img.pokemondb.net/artwork/slaking.jpg",
                    Height = 200, Weight = 13050
                },
                
                
                //nincada
                new Pokemon {
                    Id = 290, Name = "Nincada", Types = new List<string> { "Bug", "Ground" },
                    Generation = 3, NextEvolutionId = 291, BaseEvolutionId = null,
                    ImageUrl = "https://img.pokemondb.net/artwork/nincada.jpg",
                    Height = 50, Weight = 550
                },
                new Pokemon {
                    Id = 291, Name = "Ninjask", Types = new List<string> { "Bug", "Flying" },
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 290,
                    ImageUrl = "https://img.pokemondb.net/artwork/ninjask.jpg",
                    Height = 80, Weight = 120
                },
                new Pokemon {
                    Id = 292, Name = "Shedinja", Types = new List<string> { "Bug", "Ghost" },
                    Generation = 3, NextEvolutionId = null, BaseEvolutionId = 290,
                    ImageUrl = "https://img.pokemondb.net/artwork/shedinja.jpg",
                    Height = 80, Weight = 12
                },


                // Whismur 
                new Pokemon {
                Id = 293, Name = "Whismur", Types = new List<string> { "Normal" },
                Generation = 3, NextEvolutionId = 294, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/whismur.jpg",
                Height = 60, Weight = 163
                },
                new Pokemon {
                Id = 294, Name = "Loudred", Types = new List<string> { "Normal" },
                Generation = 3, NextEvolutionId = 295, BaseEvolutionId = 293,
                ImageUrl = "https://img.pokemondb.net/artwork/loudred.jpg",
                Height = 100, Weight = 405
                },
                new Pokemon {
                Id = 295, Name = "Exploud", Types = new List<string> { "Normal" },
                Generation = 3, NextEvolutionId = null, BaseEvolutionId = 293,
                ImageUrl = "https://img.pokemondb.net/artwork/exploud.jpg",
                Height = 150, Weight = 840
                },


                //Makuhita 
                new Pokemon {
                Id = 296, Name = "Makuhita", Types = new List<string> { "Fighting" },
                Generation = 3, NextEvolutionId = 297, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/makuhita.jpg",
                Height = 100, Weight = 864
                },
                new Pokemon {
                Id = 297, Name = "Hariyama", Types = new List<string> { "Fighting" },
                Generation = 3, NextEvolutionId = null, BaseEvolutionId = 296,
                ImageUrl = "https://img.pokemondb.net/artwork/hariyama.jpg",
                Height = 230, Weight = 25380
                },

                //Azurill
                new Pokemon {
                Id = 298, Name = "Azurill", Types = new List<string> { "Normal", "Fairy" },
                Generation = 3, NextEvolutionId = 183, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/azurill.jpg",
                Height = 20, Weight = 20
                },

                // Nosepass
                new Pokemon {
                Id = 299, Name = "Nosepass", Types = new List<string> { "Rock" },
                Generation = 3, NextEvolutionId = null, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/nosepass.jpg",
                Height = 100, Weight = 970
                },

                // Skitty 
                new Pokemon {
                Id = 300, Name = "Skitty", Types = new List<string> { "Normal" },
                Generation = 3, NextEvolutionId = 301, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/skitty.jpg",
                Height = 60, Weight = 110
                },
                new Pokemon {
                Id = 301, Name = "Delcatty", Types = new List<string> { "Normal" },
                Generation = 3, NextEvolutionId = null, BaseEvolutionId = 300,
                ImageUrl = "https://img.pokemondb.net/artwork/delcatty.jpg",
                Height = 110, Weight = 326
                },


                // Sableye 
                new Pokemon {
                Id = 302, Name = "Sableye", Types = new List<string> { "Dark", "Ghost" },
                Generation = 3, NextEvolutionId = null, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/sableye.jpg",
                Height = 50, Weight = 110
                },


                // END OF GEN 3 50 POKEMONS
                // Start OF GEN 4 50 POKEMONS
                

                new Pokemon {
                Id = 387, Name = "Turtwig", Types = new List<string> { "Grass" },
                Generation = 4, NextEvolutionId = 388, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/turtwig.jpg",
                Height = 40, Weight = 1020
            },
            new Pokemon {
                Id = 388, Name = "Grotle", Types = new List<string> { "Grass" },
                Generation = 4, NextEvolutionId = 389, BaseEvolutionId = 387,
                ImageUrl = "https://img.pokemondb.net/artwork/grotle.jpg",
                Height = 110, Weight = 9700
            },
            new Pokemon {
                Id = 389, Name = "Torterra", Types = new List<string> { "Grass", "Ground" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 387,
                ImageUrl = "https://img.pokemondb.net/artwork/torterra.jpg",
                Height = 220, Weight = 31000
            },
            new Pokemon {
                Id = 390, Name = "Chimchar", Types = new List<string> { "Fire" },
                Generation = 4, NextEvolutionId = 391, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/chimchar.jpg",
                Height = 50, Weight = 62
            },
            new Pokemon {
                Id = 391, Name = "Monferno", Types = new List<string> { "Fire", "Fighting" },
                Generation = 4, NextEvolutionId = 392, BaseEvolutionId = 390,
                ImageUrl = "https://img.pokemondb.net/artwork/monferno.jpg",
                Height = 90, Weight = 220
            },
            new Pokemon {
                Id = 392, Name = "Infernape", Types = new List<string> { "Fire", "Fighting" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 390,
                ImageUrl = "https://img.pokemondb.net/artwork/infernape.jpg",
                Height = 120, Weight = 550
            },
            new Pokemon {
                Id = 393, Name = "Piplup", Types = new List<string> { "Water" },
                Generation = 4, NextEvolutionId = 394, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/piplup.jpg",
                Height = 40, Weight = 52
            },
            new Pokemon {
                Id = 394, Name = "Prinplup", Types = new List<string> { "Water" },
                Generation = 4, NextEvolutionId = 395, BaseEvolutionId = 393,
                ImageUrl = "https://img.pokemondb.net/artwork/prinplup.jpg",
                Height = 80, Weight = 230
            },
            new Pokemon {
                Id = 395, Name = "Empoleon", Types = new List<string> { "Water", "Steel" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 393,
                ImageUrl = "https://img.pokemondb.net/artwork/empoleon.jpg",
                Height = 170, Weight = 845
            },
            new Pokemon {
                Id = 396, Name = "Starly", Types = new List<string> { "Normal", "Flying" },
                Generation = 4, NextEvolutionId = 397, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/starly.jpg",
                Height = 30, Weight = 20
            },
            new Pokemon {
                Id = 397, Name = "Staravia", Types = new List<string> { "Normal", "Flying" },
                Generation = 4, NextEvolutionId = 398, BaseEvolutionId = 396,
                ImageUrl = "https://img.pokemondb.net/artwork/staravia.jpg",
                Height = 60, Weight = 155
            },
            new Pokemon {
                Id = 398, Name = "Staraptor", Types = new List<string> { "Normal", "Flying" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 396,
                ImageUrl = "https://img.pokemondb.net/artwork/staraptor.jpg",
                Height = 120, Weight = 249
            },
            new Pokemon {
                Id = 399, Name = "Bidoof", Types = new List<string> { "Normal" },
                Generation = 4, NextEvolutionId = 400, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/bidoof.jpg",
                Height = 50, Weight = 200
            },
            new Pokemon {
                Id = 400, Name = "Bibarel", Types = new List<string> { "Normal", "Water" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 399,
                ImageUrl = "https://img.pokemondb.net/artwork/bibarel.jpg",
                Height = 100, Weight = 315
            },
            new Pokemon {
                Id = 401, Name = "Kricketot", Types = new List<string> { "Bug" },
                Generation = 4, NextEvolutionId = 402, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/kricketot.jpg",
                Height = 30, Weight = 22
            },
            new Pokemon {
                Id = 402, Name = "Kricketune", Types = new List<string> { "Bug" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 401,
                ImageUrl = "https://img.pokemondb.net/artwork/kricketune.jpg",
                Height = 100, Weight = 255
            },
            new Pokemon {
                Id = 403, Name = "Shinx", Types = new List<string> { "Electric" },
                Generation = 4, NextEvolutionId = 404, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/shinx.jpg",
                Height = 50, Weight = 95
            },
            new Pokemon {
                Id = 404, Name = "Luxio", Types = new List<string> { "Electric" },
                Generation = 4, NextEvolutionId = 405, BaseEvolutionId = 403,
                ImageUrl = "https://img.pokemondb.net/artwork/luxio.jpg",
                Height = 90, Weight = 305
            },
            new Pokemon {
                Id = 405, Name = "Luxray", Types = new List<string> { "Electric" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 403,
                ImageUrl = "https://img.pokemondb.net/artwork/luxray.jpg",
                Height = 140, Weight = 420
            },
            new Pokemon {
                Id = 406, Name = "Budew", Types = new List<string> { "Grass", "Poison" },
                Generation = 4, NextEvolutionId = 315, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/budew.jpg",
                Height = 20, Weight = 12
            },
            new Pokemon {
                Id = 407, Name = "Roserade", Types = new List<string> { "Grass", "Poison" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 315,
                ImageUrl = "https://img.pokemondb.net/artwork/roserade.jpg",
                Height = 90, Weight = 145
            },
            new Pokemon {
                Id = 408, Name = "Cranidos", Types = new List<string> { "Rock" },
                Generation = 4, NextEvolutionId = 409, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/cranidos.jpg",
                Height = 90, Weight = 315
            },
            new Pokemon {
                Id = 409, Name = "Rampardos", Types = new List<string> { "Rock" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 408,
                ImageUrl = "https://img.pokemondb.net/artwork/rampardos.jpg",
                Height = 160, Weight = 1025
            },
            new Pokemon {
                Id = 410, Name = "Shieldon", Types = new List<string> { "Rock", "Steel" },
                Generation = 4, NextEvolutionId = 411, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/shieldon.jpg",
                Height = 50, Weight = 570
            },
            new Pokemon {
                Id = 411, Name = "Bastiodon", Types = new List<string> { "Rock", "Steel" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 410,
                ImageUrl = "https://img.pokemondb.net/artwork/bastiodon.jpg",
                Height = 130, Weight = 1495
            },
            new Pokemon {
                Id = 412, Name = "Burmy", Types = new List<string> { "Bug" },
                Generation = 4, NextEvolutionId = 413, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/burmy.jpg",
                Height = 20, Weight = 34
            },
            new Pokemon {
                Id = 413, Name = "Wormadam", Types = new List<string> { "Bug", "Grass" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 412,
                ImageUrl = "https://img.pokemondb.net/artwork/wormadam.jpg",
                Height = 50, Weight = 65
            },
            new Pokemon {
                Id = 414, Name = "Mothim", Types = new List<string> { "Bug", "Flying" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 412,
                ImageUrl = "https://img.pokemondb.net/artwork/mothim.jpg",
                Height = 90, Weight = 233
            },
            new Pokemon {
                Id = 415, Name = "Combee", Types = new List<string> { "Bug", "Flying" },
                Generation = 4, NextEvolutionId = 416, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/combee.jpg",
                Height = 30, Weight = 55
            },
            new Pokemon {
                Id = 416, Name = "Vespiquen", Types = new List<string> { "Bug", "Flying" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 415,
                ImageUrl = "https://img.pokemondb.net/artwork/vespiquen.jpg",
                Height = 120, Weight = 385
            },
            new Pokemon {
                Id = 417, Name = "Pachirisu", Types = new List<string> { "Electric" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/pachirisu.jpg",
                Height = 40, Weight = 39
            },
            new Pokemon {
                Id = 418, Name = "Buizel", Types = new List<string> { "Water" },
                Generation = 4, NextEvolutionId = 419, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/buizel.jpg",
                Height = 70, Weight = 295
            },
            new Pokemon {
                Id = 419, Name = "Floatzel", Types = new List<string> { "Water" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 418,
                ImageUrl = "https://img.pokemondb.net/artwork/floatzel.jpg",
                Height = 110, Weight = 335
            },
            new Pokemon {
                Id = 420, Name = "Cherubi", Types = new List<string> { "Grass" },
                Generation = 4, NextEvolutionId = 421, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/cherubi.jpg",
                Height = 40, Weight = 33
            },
            new Pokemon {
                Id = 421, Name = "Cherrim", Types = new List<string> { "Grass" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 420,
                ImageUrl = "https://img.pokemondb.net/artwork/cherrim.jpg",
                Height = 50, Weight = 93
            },
            new Pokemon {
                Id = 422, Name = "Shellos", Types = new List<string> { "Water" },
                Generation = 4, NextEvolutionId = 423, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/shellos.jpg",
                Height = 30, Weight = 63
            },
            new Pokemon {
                Id = 423, Name = "Gastrodon", Types = new List<string> { "Water", "Ground" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 422,
                ImageUrl = "https://img.pokemondb.net/artwork/gastrodon.jpg",
                Height = 90, Weight = 299
            },
            new Pokemon {
                Id = 424, Name = "Ambipom", Types = new List<string> { "Normal" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 190,
                ImageUrl = "https://img.pokemondb.net/artwork/ambipom.jpg",
                Height = 120, Weight = 203
            },
            new Pokemon {
                Id = 425, Name = "Drifloon", Types = new List<string> { "Ghost", "Flying" },
                Generation = 4, NextEvolutionId = 426, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/drifloon.jpg",
                Height = 40, Weight = 12
            },
            new Pokemon {
                Id = 426, Name = "Drifblim", Types = new List<string> { "Ghost", "Flying" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 425,
                ImageUrl = "https://img.pokemondb.net/artwork/drifblim.jpg",
                Height = 120, Weight = 150
            },
            new Pokemon {
                Id = 427, Name = "Buneary", Types = new List<string> { "Normal" },
                Generation = 4, NextEvolutionId = 428, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/buneary.jpg",
                Height = 40, Weight = 55
            },
            new Pokemon {
                Id = 428, Name = "Lopunny", Types = new List<string> { "Normal" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 427,
                ImageUrl = "https://img.pokemondb.net/artwork/lopunny.jpg",
                Height = 120, Weight = 333
            },
            new Pokemon {
                Id = 429, Name = "Mismagius", Types = new List<string> { "Ghost" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 200,
                ImageUrl = "https://img.pokemondb.net/artwork/mismagius.jpg",
                Height = 90, Weight = 44
            },
            new Pokemon {
                Id = 430, Name = "Honchkrow", Types = new List<string> { "Dark", "Flying" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 198,
                ImageUrl = "https://img.pokemondb.net/artwork/honchkrow.jpg",
                Height = 90, Weight = 273
            },
            new Pokemon {
                Id = 431, Name = "Glameow", Types = new List<string> { "Normal" },
                Generation = 4, NextEvolutionId = 432, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/glameow.jpg",
                Height = 50, Weight = 39
            },
            new Pokemon {
                Id = 432, Name = "Purugly", Types = new List<string> { "Normal" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 431,
                ImageUrl = "https://img.pokemondb.net/artwork/purugly.jpg",
                Height = 100, Weight = 438
            },
            new Pokemon {
                Id = 433, Name = "Chingling", Types = new List<string> { "Psychic" },
                Generation = 4, NextEvolutionId = 358, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/chingling.jpg",
                Height = 20, Weight = 60
            },
            new Pokemon {
                Id = 434, Name = "Stunky", Types = new List<string> { "Poison", "Dark" },
                Generation = 4, NextEvolutionId = 435, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/stunky.jpg",
                Height = 40, Weight = 192
            },
            new Pokemon {
                Id = 435, Name = "Skuntank", Types = new List<string> { "Poison", "Dark" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 434,
                ImageUrl = "https://img.pokemondb.net/artwork/skuntank.jpg",
                Height = 100, Weight = 380
            },
            new Pokemon {
                Id = 436, Name = "Bronzor", Types = new List<string> { "Steel", "Psychic" },
                Generation = 4, NextEvolutionId = 437, BaseEvolutionId = null,
                ImageUrl = "https://img.pokemondb.net/artwork/bronzor.jpg",
                Height = 50, Weight = 605
            },
            new Pokemon {
                Id = 437, Name = "Bronzong", Types = new List<string> { "Steel", "Psychic" },
                Generation = 4, NextEvolutionId = null, BaseEvolutionId = 436,
                ImageUrl = "https://img.pokemondb.net/artwork/bronzong.jpg",
                Height = 130, Weight = 1870
            },

            //End of DB



            };
        }
    }
}
