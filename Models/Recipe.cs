namespace The_Recipe_House.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public ICollection<Comments> Comments { get; }
    }
}
