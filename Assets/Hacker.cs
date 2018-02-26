using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	void Start () {
        ShowMainMenu();
    }
	
	void Update () {
		
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
}
