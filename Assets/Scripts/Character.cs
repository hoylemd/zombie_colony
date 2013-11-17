using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public int hp;
	public int max_hp;
	public int speed; 
	
	public Vector3 targetPosition;
	public float journeyLength;
	
    public float startTime;
	// Use this for initialization
	void Start () {
		this.max_hp = 10;
		this.hp = this.max_hp;
		this.speed = 1;
		targetPosition = transform.position;
	}
	
	// Update is called once per frame
	public void Update () {
		// Move if we are not paused
		if (Time.timeScale != 0) {
			if (targetPosition != transform.position) {
				float distCovered = (Time.time - startTime) * (speed * 0.5f);
        		float fracJourney = distCovered / journeyLength;
				transform.position = Vector3.Lerp (transform.position, targetPosition, fracJourney);
			}
		}
	}
}
