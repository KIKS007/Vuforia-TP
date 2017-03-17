using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Security.Cryptography;

public class Star : MonoBehaviour {

	private bool _recolted = false;

	void OnTriggerEnter(Collider other){
		if (_recolted)
			return;

		_recolted = true;
		StarManager.Instance.StarsRecolted++;
		transform.DOScale (0, 0.4f).SetEase (Ease.InOutBack).OnComplete (()=> Destroy (gameObject));
	}
}
