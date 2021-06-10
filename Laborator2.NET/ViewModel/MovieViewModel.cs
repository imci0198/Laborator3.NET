using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Laborator2.NET.ViewModel
{
    public class MovieViewModel
    {
        public int id { get; set; }
       public string Title { get; set; }
        public string Description { get; set; }
        [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
        public enum GenreType { Action, Comedy, Horror, Thriller }
        public GenreType Genre { get; set; }
        public float DurationMin { get; set; }
        public int YearOfRelease { get; set; }
        public string Director { get; set; }
        public int YearAdded { get; set; }
        public int? Rating { get; set; }
        public bool Watched { get; set; }
    }
}
