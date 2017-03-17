using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

	public float Force = 10;
	public float EnergyRegen = 45;
	public Transform Box, SpawnPoint;

	private Rigidbody _body;
	private bool _grounded = true;

	// Use this for initialization
	void Start () {
		_body = GetComponent <Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		Ray r = new Ray (transform.position, Vector3.down);
		RaycastHit hit;

		if (Physics.Raycast (r, out hit, 0.1f)) {
			Debug.Log (hit.collider);
			_grounded = true;
		} else
			_grounded = false;

		if(Input.GetMouseButtonDown (0) && _grounded)
		{
			_body.AddForce (Vector3.up * Force, ForceMode.Impulse);
		}
	}

	public void Respawn(){
		transform.position = SpawnPoint.position;
	}
}
