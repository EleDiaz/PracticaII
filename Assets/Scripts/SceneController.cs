using UnityEngine;
using System.Collections;

public delegate void EventDestroyObject();

public class SceneController : MonoBehaviour {
	public event EventDestroyObject destroyObject;

	void Awake () {
		//Cursor.lockState = CursorLockMode.Locked;
	}

	public void DispathDestroy() {
		if (destroyObject != null) {
			destroyObject ();
		}
	}

	public void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Cursor.lockState = CursorLockMode.None;
			#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
			#else
			Application.Quit();
			#endif
		} 
	}
}
