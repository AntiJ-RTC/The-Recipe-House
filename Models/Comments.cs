using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Recipe_House.Models
{
    public class Comments
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please input your comment")]
        public string Comment { get; set; }
        [Required(ErrorMessage = "Please input your rating")]
        [Column(TypeName = "decimal(3, 1)")]
        [Range(0, 10.0)]
        public int Rating { get; set; }
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        [ValidateNever]
        public Recipe Recipe { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public IdentityUser ApplicationUser { get; set; }
    }
}
