using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Spike : MonoBehaviour {

	public float WaitSecond = 3f;

	// Use this for initialization
	void Start () {
		Hide ();
	}

	public void Hide(){
		transform.DOScale (0, 0.3f).SetEase (Ease.OutBack);
		DOVirtual.DelayedCall (WaitSecond, ()=>{
			Show ();
		});
	}

	public void Show(){
		transform.DOScale (1, 0.3f).SetEase (Ease.OutBack);
		DOVirtual.DelayedCall (WaitSecond, ()=>{
			Hide ();
		});
	}

	void OnTriggerEnter(Collider other){
		var ball = other.GetComponent <Ball>();
		if (ball)
		{
			ball.Respawn ();
		}
	}
}
