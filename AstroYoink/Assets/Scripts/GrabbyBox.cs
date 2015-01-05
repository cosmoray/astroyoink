using UnityEngine;
using System.Collections;

public class GrabbyBox : MonoBehaviour {

	GameObject grabbableThing;

	void OnTriggerEnter(Collider other){
		if (grabbableThing.tag == "Grabbable")
			grabbableThing = other.gameObject;
	}
	void OnTriggerExit(Collider other){
		grabbableThing = null;
	}
}
