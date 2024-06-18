using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Recipe_House.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Bio { get; set; }
        public string ProfileImg { get; set; }
        [Display(Name = "User Email (Make sure it matches the one on the top right corner!)")]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public IdentityUser ApplicationUser { get; set; }
    }
}
