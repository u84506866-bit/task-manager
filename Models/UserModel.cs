namespace TaskManagerApplication.Models;

class User(string username, string phone_Number, string password)
{
    string Username {get;set;} = username;
    string Phone_Number {get;set;} = phone_Number;
    string Password {get;set;} = password;
}

class ValidatePhoneNumber{
    public validate()
    {
    throw new Exception("Not Implemented yet!");
    }
}

class ValidatePhoneUsername{
    public validate()
    {
    throw new Exception("Not Implemented yet!");
    }
}

class ValidatePhonePassword{
    public validate()
    {
    throw new Exception("Not Implemented yet!");
    }
}
