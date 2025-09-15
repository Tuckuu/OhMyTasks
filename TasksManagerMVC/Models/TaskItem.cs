using System.ComponentModel.DataAnnotations;

namespace TasksManagerMVC.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }
    }
}