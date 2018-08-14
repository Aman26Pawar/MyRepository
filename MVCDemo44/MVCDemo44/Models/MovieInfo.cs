using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo44.Models
{
    public class MovieInfo
    {
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Please give movie name") ]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "Please give Theatre name")]
        public string Theatre { get; set; }
        [Required(ErrorMessage = "Please give rate")]
        public decimal Rate { get; set; }
        [Required(ErrorMessage = "Please give show time")]
        public DateTime ShowTime { get; set; }
    }
}