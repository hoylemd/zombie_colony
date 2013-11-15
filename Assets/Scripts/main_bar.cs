using UnityEngine;
using System.Collections;

public class main_bar : MonoBehaviour {
	// general UI sizes and offsets
	private Rect rectangle;
	
	// measurements for the sections
	private int character_width;
	private int commands_width;
	private int minimap_width;
	
	// initialize the sizes and offsets
	void Start () {
		// initial offsets
		int horizontal_offset = 10;
		int vertical_offset = 10;
		int height = 180;
		
		// initialize character information measurements
		this.character_width = 200;
		this.minimap_width = 200;
		this.commands_width = Screen.width - 2 * horizontal_offset - (this.character_width + this.minimap_width);
		
		// set up the rectangle
		this.rectangle = new Rect(
			horizontal_offset,
			Screen.height - (vertical_offset + height),
			Screen.width - (2 * horizontal_offset),
			height
		);
	}
	
	void OnGUI () {
		// make the character section
		GUI.Box (
			new Rect(
				this.rectangle.x,
				this.rectangle.y,
				this.character_width,
				this.rectangle.height
			),
			"Character Information"
		);	
		
		// make the commands section
		GUI.Box (
			new Rect(
				this.rectangle.x + this.character_width,
				this.rectangle.y,
				this.commands_width,
				this.rectangle.height
			),
			"Commands"
		);	
		
		// make the minimap section
		GUI.Box (
			new Rect(
				this.rectangle.x + this.character_width + this.commands_width,
				this.rectangle.y,
				this.minimap_width,
				this.rectangle.height
			),
			"Minimap"
		);	
	}
}
