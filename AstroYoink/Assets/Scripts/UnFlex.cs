using UnityEngine;
using System.Collections;

public class UnFlex : MonoBehaviour {

	public float SpringIntensity = 100f;
	JointLimits limits;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.T))
		{
			limits = GetComponent<HingeJoint>().limits;
			limits.min = 0f;
			limits.max = 0f;

			/*
			JointLimits limits = hingeJoint.limits;
			limits.min = 0f;
			limits.max = 0f;
			*/
			Debug.Log("Unflex");
		
	}
		//else 
	
	}
}