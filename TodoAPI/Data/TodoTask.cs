using System.ComponentModel.DataAnnotations.Schema;

namespace TodoAPI.Data
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime CreationDate { get; set; }
        [ForeignKey(nameof(ListId))]
        public int ListId { get; set; }
        public TodoList List {get;set;}
    }

}
