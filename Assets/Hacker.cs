using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    string[] wilNamen = { "Henk", "sjaak", "harry" };
    //int level = 0;

	// Use this for initialization
	void Start () {
        int wilIndex = Random.Range(0, wilNamen.Length); //rnd.Next(0, wilNamen.Length);
		Terminal.WriteLine(wilNamen[wilIndex]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnUserInput(string input) {
        Terminal.WriteLine("Je zei: " + input);
    }
}
