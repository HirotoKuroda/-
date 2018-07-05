using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
	GameObject cb;
	// Use this for initialization
	void Start () {
		cb = GameObject.Find ("CardboardMain");
	}

	// Update is called once per frame
	void Update () {
//		if(Input.GetKeyDown("return")) {
//			if(Input.GetKeyDown("return")) {
//				SceneManager.LoadScene("Demo6");
//			}
//		}
		if (Input.GetMouseButton(0)) {
			Destroy (cb);
			SceneManager.LoadScene("Demo6");
		}
	}
}