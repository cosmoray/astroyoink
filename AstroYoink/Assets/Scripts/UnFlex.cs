using UnityEngine;
using System.Collections;

public class UnFlex : MonoBehaviour {

	JointLimits limits;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.T))
		{
			limits = gameObject.GetComponent<HingeJoint>().limits;
			limits.min = 0f;
			limits.max = 0f;
			Debug.Log(limits.max);
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