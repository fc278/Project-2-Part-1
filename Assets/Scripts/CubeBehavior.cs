using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {

	public GameObject cubePrefab;

	
	// Update is called once per frame
	void OnMouseDown () {

		if (GameController.redCube != null) {
			GameController.redCube.GetComponent<Renderer> ().material.color = Color.white;

		}

		gameObject.GetComponent<Renderer> ().material.color = Color.red;
		GameController.redCube = gameObject;
	}
}
