﻿namespace Authorization.Entities;

public class User:BaseEntities
{
    public User(string name, string password)
    {
        Name = name;
        Password = password;
    }

    public string Name { get; set; }
    public string Password { get; set; }
        
}