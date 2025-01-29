﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Models
{
    [Table("Movie")]
    [PrimaryKey("movieId")]
    public class Movie
    {
        [Column("movieId")]
        public int movieId { get; set; }
        [Column("Title")]
        public string Title { get; set; }
        [Column("Rating")]
        public string Rating { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("RuntimeMins")]
        public string RuntimeMins { get; set; }
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
        [Column("moviesOnScreens")]
        public List<MovieOnScreen> moviesOnScreens { get; set; } 
        
    }
}
