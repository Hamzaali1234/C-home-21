User user1 = new User(1, "Hamzaali");
User user2 = new User(2, "Bilol");
Category category1 = new Category(1, "Разработка");
Category category2 = new Category(2, "Дизайн");
TaskManager manager = new TaskManager();
manager.users.Add(user1);
manager.users.Add(user2);
manager.categories.Add(category1);
manager.categories.Add(category2);
Task task1 = new Task(
    1, "Создать сайт", "Разработать главную страницу",
    user1, category1, 3
);
Task task2 = new Task(
    2, "Создать дизайн", "Нарисовать интерфейс",
    user2, category2, 2
);
manager.AddTask(task1);
manager.AddTask(task2);
Console.WriteLine("Все задачи:");
manager.GetInfoAboutTasks();
manager.UpdateTask(1, "Создать веб-сайт", "Разработать сайт на C#");
Console.WriteLine("После изменения:");
manager.GetInfoAboutTasks();
task1.Done = true;
manager.DeleteTask(2);
Console.WriteLine("После удаления:");
manager.GetInfoAboutTasks();
