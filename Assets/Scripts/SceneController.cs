using UnityEngine;
using System.Collections;

public delegate void EventDestroyObject();

public class SceneController : MonoBehaviour {
	public event EventDestroyObject destroyObject;

	void Awake () {
		destroyObject += myTest;
		Cursor.lockState = CursorLockMode.Locked;
	}

	void myTest() {
		Debug.Log ("My Test");
	}

	public void DispathDestroy() {
		destroyObject ();
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
