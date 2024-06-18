using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Recipe_House.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please link the image")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Please add the title")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Please list the ingredients")]
        public string Ingredients { get; set; }
        [Required(ErrorMessage = "Please list the instructions")]
        public string Instructions { get; set; }
        [Required(ErrorMessage = "Please add the prep time")]
        [Display(Name = "Prep Time (in minutes)")]
        public int PrepTime { get; set; }
        [Required(ErrorMessage = "Please add the cook time")]
        [Display(Name = "Cook Time (in minutes)")]
        public int CookTime { get; set; }
        [ValidateNever]
        public ICollection<Comments> Comments { get; }
    }
}
