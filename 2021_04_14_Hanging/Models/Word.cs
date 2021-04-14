using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_14_Hanging.Models
{
    public class Word
    {
        [Key]
        public int WordId { get; set; }
        public string Themes { get; set; }
        public string Words { get; set; }
        public int AmountGuessed { get; set; }
        public int GoodGuessAmount { get; set; }
    }
}