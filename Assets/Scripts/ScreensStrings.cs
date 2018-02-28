using System;
using System.Collections;
using System.Collections.Generic;

public class ScreenStrings {

    private string[] employeeDirectory;
    static Random rnd = new Random();

    public string Menu { get; set; }
    public string News {get; set;}
    public string Directory { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Hidden { get; set; }
    public string Win { get; set; }

    public ScreenStrings()
    {
        employeeDirectory = new string[] { "Jason Holt", "Mica Alexander", "David Hall", "Solid Snake", "Ashton Holt", "Luke Skywalker", "Diego Ochoa", "Waldo Randus", "Bryson Harston", "Chuck Lewis",
            "Dustin Reyes", "Genji Shimada"};
        Menu = ShowMenu();
        News = NewsScreen();
        Directory = DirectoryScreen();
        Login = LoginScreen();
        Password = PasswordScreen();
        Email = EmailScreen();
        Hidden = HiddenScreen();
        Win = WinScreen();
    }

    private string ShowMenu()
    {
        return "Welcome to the Holtnet Command Terminal\n" + "Industry Leaders in Robotics, AI,\n" +
            "Space Exploration, and Terraforming.\n" + "---------------------------------------\n" +
            "Please Make a Selection:\n" + "1. Recent News Articles\n" + "2. Company Directory\n" +
            "3. Employee Login\n";
    }

    private string WinScreen()
    {
        return "Hadukon Cabs: YOU WIN!";
    }

    private string HiddenScreen()
    {
        return "Welcome to the Admin Console\n";
    }

    private string EmailScreen()
    {
        return "Welcome to your emails!";
    }

    private string LoginScreen()
    {
        return "Please enter your username: ";
    }

    private string PasswordScreen()
    {
        return "Please enter your password: ";
    }

    private string DirectoryScreen()
    {
        
        return "Welcome to the Employee Directory\n" + "CEO: " + employeeDirectory[rnd.Next(employeeDirectory.Length)] + "\nOffice: 124\n\n" +
            "IT: " + employeeDirectory[rnd.Next(employeeDirectory.Length)] + "\nOffice: 235\n\n";
    }

    private string NewsScreen()
    {
        return "Recent News Articles\n" + "May 23rd, 2374\n" + "Today ";
    }
}
