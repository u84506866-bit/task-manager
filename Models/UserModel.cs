namespace TaskManagerApplication.Models;

class User(string username, string phone_Number, string password)
{
    string Username {get;set;} = username;
    string Phone_Number {get;set;} = phone_Number;
    string Password {get;set;} = password;
}
