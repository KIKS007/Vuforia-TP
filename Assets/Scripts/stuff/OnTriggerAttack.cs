using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class OnTriggerAttack : MonoBehaviour {

	private Animator _anim;

	// Use this for initialization
	void Start () {

		_anim = GetComponent <Animator> ();

		gameObject.AddComponent <ObservableTriggerTrigger>().OnTriggerEnterAsObservable ().Subscribe (collider => {
			Debug.Log ("BIATCH");
			transform.LookAt (collider.transform);
		}).AddTo (this);
	}
}
