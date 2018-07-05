using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gamecontroller : MonoBehaviour {

	private float timeElapsed;

	private static GameObject Statue;
	private static GameObject tree;
	private static GameObject tomb;
	private static GameObject tomb2;
	private static GameObject walls;
	private static GameObject walls2;
	private static GameObject house;
	private static GameObject warphouse;
	private static GameObject walls3;
	private static GameObject walls4;
	private static GameObject prop;
	private static GameObject Statue2;
	private static GameObject house2;
	private static GameObject Chaser;
	private static GameObject Chaser1;
	private static GameObject Chaser2;

	private static GameObject BGM;
	private static GameObject BGM2;

	void Start (){
		Statue = GameObject.Find ("statue");
		tree = GameObject.Find ("tree");
		tomb = GameObject.Find ("tomb");
		tomb2 = GameObject.Find ("tomb2");
		walls = GameObject.Find ("walls");
		walls2 = GameObject.Find ("walls2");
		house = GameObject.Find ("house");
		warphouse = GameObject.Find ("warphouse");
		walls3 = GameObject.Find ("walls3");
		walls4 = GameObject.Find ("walls4");
		prop = GameObject.Find ("prop");
		Statue2 = GameObject.Find ("statue2");
		house2 = GameObject.Find ("house2");
		Chaser = GameObject.Find ("Chaser");
		Chaser1 = GameObject.Find ("Chaser1");
		Chaser2 = GameObject.Find ("Chaser2");

		BGM = GameObject.Find ("BGM");
		BGM2 = GameObject.Find ("BGM2");

		BGM2.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed >= 23.0f) {
			Statue.SetActive(false);
		}
		if (timeElapsed >= 29.0f) {
			tree.SetActive(false);
		}
		if (timeElapsed >= 31.0f) {
			tomb.SetActive(false);
		}
		if (timeElapsed >= 34.0f) {
			tomb2.SetActive(false);
		}
		if (timeElapsed >= 36.0f) {
			walls.SetActive(false);
		}
		if (timeElapsed >= 39.0f) {
			walls2.SetActive(false);
		}
		if (timeElapsed >= 42.0f) {
			house.SetActive(false);
		}
		if (timeElapsed >= 45.0f) {
			warphouse.SetActive(false);
		}
		if (timeElapsed >= 48.0f) {
			walls3.SetActive(false);
		}
		if (timeElapsed >= 51.0f) {
			walls4.SetActive(false);
		}
		if (timeElapsed >= 56.0f) {
			BGM2.SetActive(true);
		}
		if (timeElapsed >= 60.0f) {
			Statue2.SetActive(false);
		}
		if (timeElapsed >= 64.0f) {
			house2.SetActive(false);
		}
		if (timeElapsed >= 85.0f) {
			BGM.SetActive(false);
			BGM2.SetActive(false);
			prop.SetActive(false);
		}
		if (timeElapsed >= 95.0f) {
			Chaser.SetActive(false);
			Chaser1.SetActive(false);
			Chaser2.SetActive(false);
		}
		if (timeElapsed >= 100.0f) {
			SceneManager.LoadScene("Clear");
		}
	}
}
