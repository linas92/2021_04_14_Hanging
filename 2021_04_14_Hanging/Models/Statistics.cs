using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_14_Hanging.Models
{
    public class Statistics
    {
        [Key]
        public int StatistikaId { get; set; }
        public string ZaidejoVardas { get; set; }
        public int ZodisId { get; set; }
        public int KiekKartuSpeta { get; set; }
        public bool ArAtspejo { get; set; }
        public DateTime KadaZaide { get; set; }
    }
}