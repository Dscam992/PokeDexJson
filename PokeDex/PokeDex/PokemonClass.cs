using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Console;
using System.Text.Json.Serialization;


namespace PokeDex
{
    class PokemonClass
    {
        public string type { get; set; }
        public string move { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string pic { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public int hp { get; set; }
    }
}
