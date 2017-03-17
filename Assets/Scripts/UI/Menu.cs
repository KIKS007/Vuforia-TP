using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown (0)){
			Ray r = Camera.main.ScreenPointToRay (Camera.main.WorldToScreenPoint (transform.position));
			var obj = Physics2D.Raycast (Camera.main.WorldToScreenPoint (transform.position), Vector2.zero).collider.gameObject;
			if(obj)
			{
				obj.GetComponent <Button>().onClick.Invoke() ;
			}
		}
	}

	public void LoadScene(string sceneName){
		UnityEngine.SceneManagement.SceneManager.LoadScene (sceneName);
	}
}
