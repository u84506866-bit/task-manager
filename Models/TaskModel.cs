namespace TaskManagerApplication.Models;

public class Task(string taskTitle, string taskDescription, bool isDone = false)
{
    string TaskTitle {get;set;}= taskTitle;
    string TaskDescription {get;set;} = taskDescription;
    bool IsDone {get;set;} = isDone;
}

