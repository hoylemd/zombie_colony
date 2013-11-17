using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public int hp;
	public int max_hp;
	public int speed;
	
	private Vector3 targetPosition;
	private float journeyLength;
	
    private float startTime;
	// Use this for initialization
	void Start () {
		this.name = "character";
		this.max_hp = 10;
		this.hp = this.max_hp;
		this.speed = 1;
		targetPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		// Mouse moves and attacks
		if(Input.GetKeyDown(KeyCode.Mouse0)){
			Plane playerPlane = new Plane(Vector3.up, Vector3.zero);
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			float hitdist = 0.0f;
        	startTime = Time.time;
			
			if (playerPlane.Raycast(ray, out hitdist)) {
				targetPosition = ray.GetPoint(hitdist);
				targetPosition = new Vector3(targetPosition.x, transform.position.y, targetPosition.z);
				transform.rotation = Quaternion.LookRotation(targetPosition - transform.position);
        		journeyLength = Vector3.Distance(transform.position, targetPosition);
			}
		}
		
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
