using UnityEngine;
using System.Collections;

public class WarpPoint : MonoBehaviour {

	void OnTriggerEnter(Collider CardboardMain){
		CardboardMain.gameObject.transform.position = new Vector3 (-12f,0.5f,3f);
	}
}
