using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoAPI.Data;


namespace TodoAPI.EntityConfiguration
{

    public class TodoListConfiguration : IEntityTypeConfiguration<TodoList>
    {
        public void Configure(EntityTypeBuilder<TodoList> builder)
        {
            builder.HasData(
                new TodoList
                {
                    Id = 1,
                    Name = "Shopping list",
                    CreationDate = DateTime.Now,
                    UserId = "95595cef-679e-4eb0-b92a-d816dfe5bb32",
                }, new TodoList
                {
                    Id = 2,
                    Name = "For today",
                    CreationDate = DateTime.Now - TimeSpan.FromDays(1),
                    UserId = "d5fcf5c6-f9f7-4225-ad57-a49a531e45c8"
                }
            );
        }
    }
}
