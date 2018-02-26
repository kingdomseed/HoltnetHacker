using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    private int level;

	void Start ()
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
        bool inputCheck = input.Equals("1") || input.Equals("2") || input.Equals("3") || input.Equals("4");
        if (inputCheck)
        {
            level = Convert.ToInt32(input);
            switch(level)
            {
                case 1:
                    StartGame(level);
                    break;
                case 2:
                    StartGame(level);
                    break;
                case 3:
                    StartGame(level);
                    break;
                default:
                    StartGame(level);
                    break;
            }
            
        } else if(input.ToLower().Equals("main menu"))
        {
            ShowMainMenu();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid input paramter.");
        }
        
    }

    private void StartGame(int level)
    {
        Terminal.WriteLine("You've selected level " + level);
    }
}
