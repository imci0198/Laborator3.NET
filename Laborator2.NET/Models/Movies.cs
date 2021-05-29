using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Laborator2.NET.Models
{
    public class Movies
    {
        public int id { get; set; }
        [Required][MinLength (3)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum GenreType { Action, Comedy, Horror, Thriller }
        [Required]
        public GenreType Genre { get; set; }
        [Required]
        public float DurationMin { get; set; }
        [Required]
        public int YearOfRelease { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public int YearAdded { get; set; }
        [Required]
        public int? Rating { get; set; }
        public bool Watched { get; set; }
    }
}
