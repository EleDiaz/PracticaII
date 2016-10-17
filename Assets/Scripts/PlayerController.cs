﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;

	private SceneController sceneController;
	private Rigidbody rb;

	void Awake () {
		sceneController = GameObject.Find ("SceneController").GetComponent<SceneController>();

		if (sceneController == null) {
			Debug.Log ("No sceneController");
		}
	}


	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		float rotationX = Input.GetAxis ("Mouse X");

		transform.Rotate (new Vector3 (0, rotationX, 0) * rotationSpeed * Time.deltaTime);
	}


	void FixedUpdate () {

		float moveVertical = Input.GetAxis ("Vertical"); 
		float moveHorizontal = Input.GetAxis ("Horizontal");

		rb.AddForce (transform.forward * moveVertical * speed); 
		rb.AddForce (transform.right * moveHorizontal * speed);	
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("On trigger Enter " + collision.gameObject.tag);
		if (collision.gameObject.tag == "collectable") {
			SceneController sceneController = GameObject.Find ("SceneController").GetComponent<SceneController> ();		
			sceneController.destroyObject -= collision.gameObject.GetComponent<CollectableController>().ChangeColor;
			Destroy (collision.gameObject);
			if (sceneController != null) {
				sceneController.DispathDestroy ();
			} else {
				Debug.Log ("Lost SceneController");
			}
		}
	}
}
