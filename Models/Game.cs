using Shop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{

    public class Game
    {
        [Key]
        public Guid GameId { get; set; }
        [Display(Name = "Game Title")]
        [Required(ErrorMessage = "Game Title is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 50 chars")]
        public string GameTitle { get; set; }

        [Display(Name = "Game Genre")]
        [Required(ErrorMessage = "Game Genre is required")]
        public Genre Genre { get; set; }

        [Display(Name = "Game Price")]
        [Required(ErrorMessage = "Game Price is required")]
        [Range(0, float.MaxValue, ErrorMessage = "Please enter valid number")]
        public float Price { get; set; }

        [Display(Name = "Game Picture URL")]
        public string GamePictureURL { get; set; }
        public List<Games_Person> OwnedGames { get; set; }

    }
}
