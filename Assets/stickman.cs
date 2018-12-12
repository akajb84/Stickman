using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickman : MonoBehaviour {

	public GameObject head;
	public GameObject torso;
	public GameObject leftUpperArm;
	public GameObject leftLowerArm;
	public GameObject leftHand;
	public GameObject rightUpperArm;
	public GameObject rightLowerArm;
	public GameObject rightHand;
	public GameObject leftUpperLeg;
	public GameObject leftLowerLeg;
	public GameObject rightUpperLeg;
	public GameObject rightLowerLeg;

	// Use this for initialization
	void Start () {
		
	}

	public int state = 0;
	// Update is called once per frame
	void Update () {
		if (state == 0) {
			// try to keep from falling over
		} 
	}
}
