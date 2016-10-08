﻿using UnityEngine;
using System.Collections;

public class CollectableController : MonoBehaviour {
	[Range(50, 100)]
	public float speedRotation = 50F;

	private float rotation = 0;
	private Renderer renderer;

	void Start () {
		SceneController sceneController = GameObject.Find ("SceneController").GetComponent<SceneController> ();		
		sceneController.destroyObject += ChangeColor; 
		renderer = GetComponent<Renderer> ();
	}

	void ChangeColor() {
		renderer.material.color = new Color (Random.value, Random.value, Random.value);
	}

	// Update is called once per frame
	void Update () {
		rotation = Time.deltaTime * speedRotation;
		transform.Rotate (new Vector3 (0, rotation, 0));
	}
}
