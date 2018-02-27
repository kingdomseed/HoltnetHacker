using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Hacker : MonoBehaviour {

    private int level;
    private string[] levelsArray = { "1", "2", "3", "4" };
    private enum Screen { MainMenu, News, Directory, Login, Hidden, Win};
    private Screen currentScreen = Screen.MainMenu;

	public void Start ()
    {
        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to the Holtnet Command Terminal");
        Terminal.WriteLine("Industry Leaders in Robotics, AI,");
        Terminal.WriteLine("Space Exploration, and Terraforming.");
        Terminal.WriteLine("---------------------------------------");
        Terminal.WriteLine("Please Make a Selection:");
        Terminal.WriteLine("1. Recent News Articles");
        Terminal.WriteLine("2. Company Directory");
        Terminal.WriteLine("3. Employee Login");
    }

    private void OnUserInput(string input)
    {
        if(input.ToLower().Equals("main menu"))
        {
            ShowMainMenu();
        }
        else if (levelsArray.Contains(input))
        {
            level = Convert.ToInt32(input);
            OnLevelSelect(level);
        }
        else
        {
            Terminal.WriteLine("Please choose a valid input paramter.");
        }
        
    }

    private void OnLevelSelect(int level)
    {
        switch(level)
        {
            case 1:
                currentScreen = Screen.News;
                break;
            case 2:
                currentScreen = Screen.Directory;
                break;
            case 3:
                currentScreen = Screen.Login;
                break;
            case 4:
                currentScreen = Screen.Hidden;
                break;
            default:
                currentScreen = Screen.Win;
                break;
        }
    }
}
