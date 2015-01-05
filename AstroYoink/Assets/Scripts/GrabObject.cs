using UnityEngine;
using System.Collections;

public class GrabObject : MonoBehaviour {

	public float SpringIntensity = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.G))
		{
			gameObject.GetComponent<SpringJoint>().spring =  SpringIntensity;
		
	}
		if(Input.GetKeyUp(KeyCode.G))
		{
			gameObject.GetComponent<SpringJoint>().spring =  0f;
		}
	}
}