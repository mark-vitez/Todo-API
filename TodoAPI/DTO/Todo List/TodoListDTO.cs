namespace TodoAPI.DTO
{
    public class TodoListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public IEnumerable<TaskDTO> Tasks { get; set; }
    }
}
