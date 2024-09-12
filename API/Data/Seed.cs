using API.Entities;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedData(AnimalManagementContext context)
        {
            if (context.Groupings.Any() || context.Animals.Any()) return;

            var groups = new List<Grouping>
            {
                new Grouping
                {
                    Name = "Group1",
                    DateCreated = DateTime.Now
                },
                new Grouping
                {
                    Name = "Group2",
                    DateCreated = DateTime.Now
                },
                new Grouping
                {
                    Name = "Group3",
                    DateCreated = DateTime.Now
                },
                new Grouping
                {
                    Name = "Group4",
                    DateCreated = DateTime.Now
                },
                new Grouping
                {
                    Name = "Group5",
                    DateCreated = DateTime.Now
                },
            };

            await context.Groupings.AddRangeAsync(groups);
            await context.SaveChangesAsync();

            var group1 = context.Groupings.Single(g => g.Name == "Group1");
            var group2 = context.Groupings.Single(g => g.Name == "Group2");
            var group3 = context.Groupings.Single(g => g.Name == "Group3");
            var group4 = context.Groupings.Single(g => g.Name == "Group4");
            var group5 = context.Groupings.Single(g => g.Name == "Group5");

            var animals = new List<Animal>
            {
                new Animal
                {
                    GroupId = group1.Id,
                    Tag = "UK4659852 12345",
                    DateOfBirth = DateTime.Now

                },
                new Animal
                {
                    GroupId = group3.Id,
                    Tag = "UK4659852 12347",
                    DateOfBirth = DateTime.Now

                },
                new Animal
                {
                    GroupId = group5.Id,
                    Tag = "UK4659852 12389",
                    DateOfBirth = DateTime.Now

                },
            };

            await context.Animals.AddRangeAsync(animals);
            await context.SaveChangesAsync();
        }
    }
}
