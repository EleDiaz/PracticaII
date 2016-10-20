using UnityEngine;
using System.Collections;

public class PlatformPlaneController : MonoBehaviour {
	public Material lighterMaterial;
	public Material defaultMaterial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		Renderer rend = GetComponent<Renderer> ();
		rend.material = lighterMaterial;
	}

	void OnCollisionExit(Collision collision) {
		Renderer rend = GetComponent<Renderer> ();
		rend.material = defaultMaterial;
	}
}
