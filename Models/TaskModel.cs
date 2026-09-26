namespace TaskManagerApplication.Models;

public class Task(string taskTitle, string taskDescription, bool isDone = false, Priority priority = Priority.Low)
{
    public string TaskTitle {get;set;}= taskTitle;
    public string TaskDescription {get;set;} = taskDescription;
    public bool IsDone {get;set;} = isDone;
    public Priority Priority {get;set;} = priority;
}

public enum Priority
{
    Low = 1,
    Medium = 2,
    High = 3,
    Critical = 4,
}

