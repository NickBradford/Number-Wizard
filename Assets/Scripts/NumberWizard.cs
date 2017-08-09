using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	//declare variables
	int max;
	int minimum;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("Up arrow was pressed");
			minimum = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("Down arrow was pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won.");
			StartGame();
		}
	}

	//run when the game starts
	void StartGame() {

		//intialize the values
		minimum = 1;
		max = 1000;
		guess = 500;



		//print the start dialouge
		print ("==============================================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me.");
		print ("The highest number you can pick is " + max;
		print ("The lowest number you can pick is " + minimum);
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down arrow for lower, return for equal");

		//allow 1000 as a number
		max = max + 1;

	}

	//get the next AI guess
	void NextGuess() {
		guess = (max + minimum)/2;
		print ("Higher or lowar than " + guess + "?");
		print ("Up arrow for higher, down arrow for lower, return for equal");
	}
}
