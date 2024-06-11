using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Recipe_House.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        [ValidateNever]
        public Recipe Recipe { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public IdentityUser ApplicationUser { get; set; }
    }
}
