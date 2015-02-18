using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GPS : MonoBehaviour {

	bool foundSurvivors = false;

	public Transform tardis = null;
	public Transform igloo = null;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(tardis.position, igloo.position); 
		string textBuffer = "PLANET: EARTH, TEMPERATURE: COLD, HABITABILITY: MEH";
		if (!foundSurvivors) {
			if (distance < 50) {
				textBuffer += "\nDoctor, look! An igloo! The survivors must be in there!";
				textBuffer += "\nPress TAB to pick them up!";
				if (Input.GetKeyDown (KeyCode.Tab)){
					foundSurvivors = true;
				}
			} else if (distance < 600) {
				textBuffer += "\nDoctor, look! More rafts! The survivors must be on this island!";
			} else if (distance < 1000) {
				textBuffer += "\nDoctor, look! Rafts! There are survivors somewhere!";
			} else if (distance < 2000) {
				textBuffer += "\nDoctor, look! A shipwreck!";
			} else {
				textBuffer += "\nWhat nice ice we've found.";
			}

		} else {
			textBuffer += "\nWell done, Doctor! You've saved them!";
		}

		GetComponent<Text>().text = textBuffer;
	}

}
