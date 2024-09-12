namespace API.Entities
{
    public class Grouping
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();
    }
}
