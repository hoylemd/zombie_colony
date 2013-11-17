using UnityEngine;
using System.Collections;

public class Player : Character {
	
	// Update is called once per frame
	new void Update () {
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
		
		base.Update();
		
	}
}
