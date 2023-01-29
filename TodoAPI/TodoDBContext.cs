using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Data;
using TodoAPI.EntityConfiguration;

namespace TodoAPI
{
    public class TodoDBContext : IdentityDbContext<ApiUser>
    {
        public TodoDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TodoList> Lists { get; set; }
        public DbSet<TodoTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new TodoListConfiguration());
            modelBuilder.ApplyConfiguration(new TodoTaskConfiguration());
        }
    }
}
