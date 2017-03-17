using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour {

	public static StarManager Instance { get; private set; }

	public int StarsRecolted { get; set; }

	void Awake(){
		if(Instance)
		{
			Destroy (gameObject);
			return;
		}
		Instance = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
