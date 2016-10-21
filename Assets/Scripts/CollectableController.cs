using UnityEngine;
using System.Collections;

public class CollectableController : MonoBehaviour, IGvrGazeResponder {
	[Range(50, 100)]
	public float speedRotation = 50F;

	private float rotation = 0;
	private Renderer renderer;

	void Start () {
		SceneController sceneController = GameObject.Find ("SceneController").GetComponent<SceneController> ();		
		sceneController.destroyObject += ChangeColor; 
		renderer = GetComponent<Renderer> ();
	}

	public void ChangeColor() {
		renderer.material.color = new Color (Random.value, Random.value, Random.value);

		speedRotation = 100 + Random.value * 100;
	}

	// Update is called once per frame
	void Update () {
		rotation = Time.deltaTime * speedRotation;
		transform.Rotate (new Vector3 (0, rotation, 0));
	}

	public void OnGazeEnter () {
		Debug.Log ("GAZE ENTER"); 
		ChangeColor ();
		Debug.Log ("GAZE EXIT"); 

	}

	public void OnGazeExit () {
		
	}

	public void OnGazeTrigger() {
		
	}
}
