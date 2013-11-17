using UnityEngine;
using System.Collections;

public class input : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Space bar pauses and unpauses
		if(Input.GetKeyDown("space")) {
			Debug.Log ("space");
			if (Time.timeScale == 0) {
				Time.timeScale = 1;	
			} else {
				Time.timeScale = 0;	
			}
		}
		
		
 	}
}
