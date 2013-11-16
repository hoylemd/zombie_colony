using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public int hp;
	public int max_hp;
	public Vector2 position;
	// Use this for initialization
	void Start () {
		this.name = "character";
		this.max_hp = 10;
		this.hp = this.max_hp;
		this.position = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale != 0) {
			this.position = new Vector2(this.position.x + 0.1f, this.position.y);
			this.gameObject.transform.position = new Vector3((float)this.position.x, 0f, (float)this.position.y);
		}
	}
}
