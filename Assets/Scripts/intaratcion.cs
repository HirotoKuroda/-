using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intaratcion : MonoBehaviour {

	private float timeElapsed;

	bool onoff = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timeElapsed += Time.deltaTime;

		var cam = GameObject.Find ("Main Camera");
		var cardboard = GameObject.Find ("CardboardMain");

		var dir = cam.transform.forward;
		var dir2 = new Vector3 (dir.x, 0, dir.z);

		if (timeElapsed <= 56.0f) {
			if (Cardboard.SDK.Triggered) {
				if (!onoff) {
					onoff = true;
				} else {
					onoff = false;
				}
			}

			if (onoff) {
				cardboard.transform.Translate (dir2 * 0.09f);
			}
		}

		if (timeElapsed > 56.0f) {
			if (Cardboard.SDK.Triggered) {
				if (!onoff) {
					onoff = true;
				} else {
					onoff = false;
				}
			}

			if (onoff) {
				cardboard.transform.Translate (-dir2 * 0.09f);
			}
		}
	}
}
