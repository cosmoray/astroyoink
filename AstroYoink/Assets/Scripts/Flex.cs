using UnityEngine;
using System.Collections;

public class Flex : MonoBehaviour {

	public float SpringIntensity = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
		{
			gameObject.GetComponent<SpringJoint>().spring =  SpringIntensity;
			Debug.Log("Flex deez nuts");
		
	}
		else gameObject.GetComponent<SpringJoint>().spring =  0f;
	
	}
}