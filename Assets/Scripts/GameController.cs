using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject currentCube;
	public static GameObject redCube;
	int xPosition;
	Vector3 cubePosition;
	GameObject[]cubeRow = new GameObject [16];
	public GameObject cubePrefab;


	// Use this for initialization
	void Start () {
		xPosition = 2;
		cubePosition = new Vector3 (-15, 0, 0);

		for (int i = 0; i < 16; i++) {
			
		cubeRow[i] = (GameObject)Instantiate (cubePrefab, cubePosition, Quaternion.identity);
		cubePosition += new Vector3 (xPosition, 0, 0);

		cubeRow[i].GetComponent<Renderer> ().material.color = Color.white;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


//Thanks!! That helps a lot. I thought that we had to use a range method.(-16, 0, 0) inside the for loop, so that the cubes can line up in order as 'i' increments 1.