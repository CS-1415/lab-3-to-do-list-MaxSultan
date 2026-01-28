// Max Sultan, Jan 28th 2026, Lab 3: todo list

static void Main()
{
    List<Task> Todos = [
        new Task("Do Laundry", "There are clothes all over your bedroom", false),
        new Task("Make Lunch", "You will be hungry, trust me", false),
        new Task("Do Homework", "Lab 3: todo list", false),
    ];
    ConsoleKey userInput;
    Console.WriteLine("Welcome to Todo List app");

    do
    {    
        Todos.ForEach(task => task.DisplayTask());
        Console.WriteLine("Press '+' to add a task. Press 'x' to toggle whether or not the task is complete. Press 'i' to view a task's information.");
        userInput = Console.ReadKey().Key;
        Console.WriteLine("\n");
        if(userInput == ConsoleKey.Add)
        {
            Console.Write("Enter a task title: ");
            string title = Console.ReadLine();
            Console.Write("Enter a task description: ");
            string description = Console.ReadLine();
            Todos.Add(new Task(title, description, false));
        } 
        else if (userInput == ConsoleKey.I)
        {
            Console.Write("Enter the ID of the task: ");
            string todoID = Console.ReadLine();
            if(int.TryParse(todoID, out int parsedTodoID)){
                if(Todos.Select(todo => todo.ID).Contains(parsedTodoID))
                {
                    Task selectedTodo = Todos.Find(todo => todo.ID == parsedTodoID);
                    selectedTodo.DisplayDescription();
                }
                else
                    Console.WriteLine("This ID does not exist in the list");
            } else
                Console.WriteLine("Invalid Input");
        } 
        else if (userInput == ConsoleKey.X)
        {
            Console.Write("Enter the ID of the task: ");
            string todoID = Console.ReadLine();
            if(int.TryParse(todoID, out int parsedTodoID)){
                if(Todos.Select(todo => todo.ID).Contains(parsedTodoID))
                {
                    Task selectedTodo = Todos.Find(todo => todo.ID == parsedTodoID);
                    selectedTodo.MarkAsCompleted();
                }
                else
                    Console.WriteLine("This ID does not exist in the list");
            } else
                Console.WriteLine("Invalid Input");
        }
        Console.WriteLine("\n");
    } while (userInput != ConsoleKey.Escape);
}

Main();

class Task
{
    public static int NextId = 0;
    public int ID {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    public bool IsComplete {get; set;}

    public Task(string title, string description, bool isComplete)
    {
        ID = NextId;
        NextId++;
        Description = description;
        Title = title;
        IsComplete = isComplete;
    }


    public void DisplayTask()
    {
        Console.WriteLine($"[{(IsComplete ? 'X' : ' ')}] {ID} {Title}");
    }
    public void DisplayDescription()
    {
        Console.WriteLine(Description);
    }
    public void MarkAsCompleted()
    {
        IsComplete = true;
    }
}