using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private SceneController sceneController;

	void Awake () {
		sceneController = GameObject.Find ("SceneController").GetComponent<SceneController>();

		if (sceneController == null) {
			Debug.Log ("No sceneController");
		}
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
