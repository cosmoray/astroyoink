using UnityEngine;
using System.Collections;

public class JoystickLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate () {
		rigidbody.AddTorque (Input.GetAxis ("Vertical"), Input.GetAxis ("Horizontal"), 0);
	}
}
