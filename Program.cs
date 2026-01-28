// Max Sultan, Jan 28th 2026, Lab 3: todo list

// Lab Steps
// Create methods inside of your class to handle the necessesary items in your ToDo list including at least:
// DisplayTask()
// DisplayDescription()
// MarkAsCompleted()
// In your program's Main method, create a list of "Task"s (whether or not you start off with an empty list or some default tasks is up to you).
// Allow the user to create a Task with a title and description. Automatically assign the ID to the next available ID. (hint: this could be as simple as newTaskId = taskList.Count).
// Display all Tasks (like the example below).
// Prompt the user to either enter i for information on a task, + to add a task, or x to toggle whether or not a task is marked as complete.
// When the user presses i the program asks which task number. If the user enters a valid task ID then task's details (including its description, which is not displayed in the task list) are printed to the console. The program then re-displays the list of tasks.
// When the user presses + the program asks for a task name and a description; uses those values to create a new Task and adds that to the list of tasks. The program then re-displays the newly-updated list.
// When the user presses x the program asks which task number the user wants to toggle. If the user enters a valid task ID that task has its IsComplete field toggled. The program then re-displays the newly-updated list.

static void Main()
{
    
}

Main();

class Task()
{
    public int ID {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    public bool IsComplete {get; set;}


    public void DisplayTask(int index)
    {
        Console.WriteLine($"[{(IsComplete ? ' ' : 'X')}] {index} {Title}");
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