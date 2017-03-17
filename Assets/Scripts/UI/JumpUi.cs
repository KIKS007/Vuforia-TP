using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpUi : MonoBehaviour {

	public Transform Target;
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = Target.position;
	}
}
