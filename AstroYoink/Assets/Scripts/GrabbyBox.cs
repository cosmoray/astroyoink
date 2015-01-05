using UnityEngine;
using System.Collections;

public class GrabbyBox : MonoBehaviour {

	public GameObject grabbableThing;

	void OnTriggerEnter(Collider other){
		if (grabbableThing){
			if (grabbableThing.tag == "Grabbable")
				grabbableThing = other.gameObject;
		}
	}
	void OnTriggerExit(Collider other){
		grabbableThing = null;
	}
}
