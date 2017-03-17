using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float Force = 10;
	public float EnergyRegen = 45;
	public Transform Box;

	private Rigidbody _body;

	private float _energy = 100;


	// Use this for initialization
	void Start () {
		_body = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown (0) && _energy >= 50)
		{
			_body.AddForce (Box.up * Force, ForceMode.Impulse);
			_energy -= 50;
		}

		_energy = Mathf.Clamp (_energy + Time.deltaTime * EnergyRegen, 0, 100);
	}
}
