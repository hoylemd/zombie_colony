using UnityEngine;
using System.Collections;

public class main_bar : MonoBehaviour {
	private int height = 80;
	private int horizontal_offset = 10;
	private int vertical_offset = 10;
	
	void Start () {
		this.height = 80;
		this.horizontal_offset = 10;
		this.vertical_offset = 10;
		Debug.Log ("wat");
	}
	
	void OnGUI () {
		// make the background box
		GUI.Box (
			new Rect(
				this.horizontal_offset,
				Screen.height - (this.vertical_offset + this.height),
				Screen.width - (2 * this.horizontal_offset), this.height
			),
			"Main Bar"
		);
		
	}
}
