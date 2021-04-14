using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_14_Hanging.Models
{
    public class Hang
    {
        public static readonly List<string> LithuanianNames = new List<string> { "Tomas", "Darius", "Alfonsas", "Karolis", "Edgaras",
            "Margarita", "Simona", "Onute", "Olga", "Pamela"};
        public static readonly List<string> LithuanianCities = new List<string> { "Kaunas", "Vilnius", "Marijampole",
                    "Vilkaviskis", "Alytus", "Jieznas", "Lazdijai", "Pakruojis", "Sakiai"};
        public static readonly List<string> WorldCountryNames = new List<string> { "Australija", "Bulgarija", "Danija", "Filipinai",
            "Japonija", "Kanada", "Maldyvai", "Norvegija", "Prancūzija", "Senegalas"};
        public static readonly List<string> Animals = new List<string> { "Elephant", "Lion", "Tiger", "Koala", "Shark",
                    "Whale", "Octopus", "Snake", "Kangaroo", "Bear", "Lizard", "Squirrel","Cow",
                    "Crocodile", "Pelican", "Dolphin", "Bat", "Frog", "Badger","Wolf","Cow", "Ox",
                    "Reindeer", "Fox", "Bat", "Sparrow", "Chimpanzee"};
    }
}