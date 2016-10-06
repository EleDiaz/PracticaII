using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame

	void Update () {
		float rotationX = Input.GetAxis ("Mouse X");
		float rotationY = Input.GetAxis ("Mouse Y");

		transform.Rotate (new Vector3 (0, rotationX, 0) * rotationSpeed * Time.deltaTime);


	}


	void FixedUpdate () {

		float moveVertical = Input.GetAxis ("Vertical"); 
		float moveHorizontal = Input.GetAxis ("Horizontal");

		rb.AddForce (transform.forward * moveVertical * speed); 
		rb.AddForce (transform.right * moveHorizontal * speed);
		//rb.AddForce (new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
	
	}

}
