using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

	public string NextScene;

	void OnTriggerEnter(){
		SceneManager.LoadScene (NextScene);
	}
}
