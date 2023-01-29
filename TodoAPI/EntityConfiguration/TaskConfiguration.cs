using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoAPI.Data;

namespace TodoAPI.EntityConfiguration
{

    public class TodoTaskConfiguration : IEntityTypeConfiguration<TodoTask>
    {
        public void Configure(EntityTypeBuilder<TodoTask> builder)
        {
            builder.HasData(              
                new TodoTask
                {
                    Id = 1,
                    Description = "Milk",
                    Done = false,
                    ListId = 1,
                    CreationDate = DateTime.Now
                },
                new TodoTask
                {
                    Id = 2,
                    Description = "Egg",
                    Done = false,
                    ListId = 1,
                    CreationDate = DateTime.Now


                },
                new TodoTask
                {
                    Id = 3,
                    Description = "Butter",
                    Done = false,
                    ListId = 1,
                    CreationDate = DateTime.Now
                },
                new TodoTask
                {
                    Id = 4,
                    Description = "Code",
                    Done = false,
                    ListId = 2,
                    CreationDate = DateTime.Now
                },
                new TodoTask
                {
                    Id = 5,
                    Description = "Exercise",
                    Done = false,
                    ListId = 2,
                    CreationDate = DateTime.Now


                },
                new TodoTask
                {
                    Id = 6,
                    Description = "Cook dinner",
                    Done = false,
                    ListId = 2,
                    CreationDate = DateTime.Now
                }
            );
        }
    }
}
