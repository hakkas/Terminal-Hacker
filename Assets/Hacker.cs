using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    int level = 0;

	// Use this for initialization
	void Start () {
		Terminal.WriteLine("Hi");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnUserInput(string input) {
        Terminal.WriteLine("Je zei: " + input);
    }
}
