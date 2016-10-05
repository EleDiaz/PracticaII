using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float rotationX = Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
		if (rotationX == 0) {
			rotationX = Input.GetAxis ("Mouse X") * rotationSpeed * Time.deltaTime;
		}
		float rotationY = Input.GetAxis ("Mouse Y") * rotationSpeed * Time.deltaTime;

		float translation = Input.GetAxis ("Vertical") * speed * Time.deltaTime;

		transform.Translate (new Vector3 (translation, 0, 0));
		transform.Rotate (new Vector3 (0, rotationX, 0));
	}
}
