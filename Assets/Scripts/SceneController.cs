using UnityEngine;
using System.Collections;

public delegate void EventDestroyObject();

public class SceneController : MonoBehaviour {
	public event EventDestroyObject destroyObject;

	void Awake () {
		destroyObject += myTest;
	}

	void myTest() {
		Debug.Log ("My Test");
	}

	public void DispathDestroy() {
		destroyObject ();
	}
}
