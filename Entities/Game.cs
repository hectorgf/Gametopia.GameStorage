namespace Gametopia.GameStorage.Entities
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string IconUrl { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; }
    }
}