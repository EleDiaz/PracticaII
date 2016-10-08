using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float rotationY = Input.GetAxis ("Mouse Y");
		transform.Rotate (new Vector3 (-rotationY, 0, 0) * 300.0F * Time.deltaTime);
	}
}
