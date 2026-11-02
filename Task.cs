public class Task
{
    public int TaskId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public User Assignee { get; set; }

    public Category TaskCategory { get; set; }
    public int TaskPriority { get; set; }
    public bool Done { get; set; }
    public DateTime CreatedAt { get; }
    public DateTime Createdat { get; set; }

    public Task(int taskId, string title, string description,
       User assignee, Category taskCategory, int taskPriority)
    {
        TaskId = taskId;
        Title = title;
        Description = description;
        Assignee = assignee;
        TaskCategory = taskCategory;
        TaskPriority = taskPriority;
        Done = false;
        CreatedAt = DateTime.Now;
    }

}
