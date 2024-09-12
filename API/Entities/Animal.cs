using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Animal
    {
        public Guid Id { get; set; }
        public Guid GroupId { get; set; }
        public string Tag { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [ForeignKey("GroupId")]
        public Grouping Grouping { get; set; }
    }
}
