public class TaskManager
{
    public List<Task> tasks;
    public List<User> users;
    public List<Category> categories;
    public TaskManager()
    {
        tasks = new List<Task>();
        users = new List<User>();
        categories = new List<Category>();
    }
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }
    public List<Task> GetAllTasks()
    {
        return tasks;
    }
    public Task GetTaskById(int id)
    {
        foreach (Task task in tasks)
        {
            if (task.TaskId == id)
            {
                return task;
            }
        }
        return null;
    }
    public void UpdateTask(int id, string title, string description)
    {
        Task task = GetTaskById(id);
        if (task != null)
        {
            task.Title = title;
            task.Description = description;
        }
    }
    public void DeleteTask(int id)
    {
        Task task = GetTaskById(id);
        if (task != null)
        {
            tasks.Remove(task);
        }
    }
    public void GetInfoAboutTasks()
    {
        foreach (Task task in tasks)
        {
            Console.WriteLine("ID: " + task.TaskId);
            Console.WriteLine("Название: " + task.Title);
            Console.WriteLine("Описание: " + task.Description);
            Console.WriteLine("Пользователь: " + task.Assignee.UserName);
            Console.WriteLine("Категория: " + task.TaskCategory.CategoryName);
            Console.WriteLine("Приоритет: " + task.TaskPriority);
            Console.WriteLine("Выполнено: " + task.Done);
            Console.WriteLine("Создано: " + task.CreatedAt);
        }
    }
    public List<Task> GetCompletedTasks()
    {
        List<Task> result = new List<Task>();
        foreach (Task task in tasks)
        {
            if (task.Done == true)
            {
                result.Add(task);
            }
        }
        return result;
    }
    public List<Task> GetNotCompletedTasks()
    {
        List<Task> result = new List<Task>();

        foreach (Task task in tasks)
        {
            if (task.Done == false)
            {
                result.Add(task);
            }
        }
        return result;
    }
    public List<Task> GetTasksByCategoryId(int id)
    {
        List<Task> result = new List<Task>();

        foreach (Task task in tasks)
        {
            if (task.TaskCategory.CategoryId == id)
            {
                result.Add(task);
            }
        }
        return result;
    }
    public List<Task> GetSortedTasks()
    {
        List<Task> result = new List<Task>(tasks);

        result.Sort((a, b) => b.CreatedAt.CompareTo(a.CreatedAt));

        return result;
    }
    public List<Task> GetTasksByPriority(int priority)
    {
        List<Task> result = new List<Task>();

        foreach (Task task in tasks)
        {
            if (task.TaskPriority == priority)
            {
                result.Add(task);
            }
        }
        return result;
    }
}