List<string> tasks = new List<string>();
static List<string> AddTasks(List<string> tasks)
{
    Console.WriteLine("Enter quantiy tasks:");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter new task:");
    for(int i = 0; i <= quantity - 1; i++)
    {
        string newTasks = Console.ReadLine();
        tasks.Add(newTasks);
    }
   
    return tasks;
}
AddTasks(tasks);
Console.WriteLine("Your tasks is:");
foreach (string task in tasks)
{
    Console.WriteLine(task);
}

static List<string> ChangeTasks(List<string> tasks)
{
    Console.WriteLine("Enter index task for change(index first task is 0): ");
    int indexChange = Convert.ToInt32(Console.ReadLine());
    tasks[indexChange] = Console.ReadLine();
    return tasks;
}

ChangeTasks(tasks);
Console.WriteLine("List of tasks with change:");
foreach (string task in tasks)
{
    Console.WriteLine(task);
}

static List<string> DeleteTask(List<string> tasks)
{
    Console.WriteLine("Enter index task for delete(index first task is 0):");
    int indexDelete = Convert.ToInt32(Console.ReadLine());
    tasks.RemoveAt(indexDelete);
    return tasks;
}
DeleteTask(tasks);
Console.WriteLine("Your list of tasks after removal:");
foreach (string task in tasks)
{
    Console.WriteLine(task);
}