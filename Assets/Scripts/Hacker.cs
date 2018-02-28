using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // Game state
    private int level;
    private ScreenStrings screenStrings;
    private string[] levelsArray = { "1", "2", "3", "4" };
    private enum Screen { MainMenu, News, Directory, Login, Hidden, Win};
    private Screen currentScreen = Screen.MainMenu;

	public void Start ()
    {
        screenStrings = new ScreenStrings();
        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(screenStrings.Menu);
    }

    private void OnUserInput(string input)
    {
        if(input.ToLower().Equals("menu"))
        {
            ShowMainMenu();
        }
        else if (levelsArray.Contains(input))
        {
            level = int.Parse(input);
            OnLevelSelect(level);
        }
        else
        {
            Terminal.WriteLine("Your input is invalid.");
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
                Debug.LogWarning("OnLevelSelect activated the default case somehow. currentScreen will not be updated.");
                break;
        }
        ChangeScreen();
    }

    private void ChangeScreen()
    {
        Terminal.ClearScreen();
        switch(currentScreen)
        {
            case Screen.News:
                Terminal.WriteLine(screenStrings.News);
                break;
            case Screen.Directory:
                Terminal.WriteLine(screenStrings.Directory);
                break;
            case Screen.Login:
                Terminal.WriteLine(screenStrings.Login);
                break;
            case Screen.Hidden:
                Terminal.WriteLine(screenStrings.Hidden);
                break;
            case Screen.Win:
                Terminal.WriteLine(screenStrings.Win);
                break;
            default:
                Debug.LogWarning("Terminal has encountered an error and is returning you to the main menu.");
                ShowMainMenu();
                break;
        }
    }
}
