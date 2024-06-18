using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Recipe_House.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Bio { get; set; }
        public string ProfileImg { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public IdentityUser ApplicationUser { get; set; }
    }
}
