using System.ComponentModel.DataAnnotations.Schema;

namespace TodoAPI.Data
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual IList<TodoTask> TodoTasks { get; set; }
        
        [ForeignKey(nameof(ApiUser))]
        public string UserId { get; set; }        
    }
}
