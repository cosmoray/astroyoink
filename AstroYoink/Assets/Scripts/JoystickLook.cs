using UnityEngine;
using System.Collections;

public class JoystickLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate () {
		rigidbody.AddRelativeTorque (Input.GetAxis ("Vertical"), Input.GetAxis ("Horizontal"), 0);
		float x = rigidbody.angularVelocity.x;
		float y = rigidbody.angularVelocity.y;
		rigidbody.angularVelocity.Set (x, y, 0f);
	}
}
