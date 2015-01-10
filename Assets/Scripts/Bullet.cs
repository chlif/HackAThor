using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	/*
	 * Only single 'bullet' can be moving at one time
	 * Shotguns shoot 'bullet's
	 */

	// whether bullet is moving atm
	bool isMoving = false;
	float bulletSpeed = 8f;
	float timeUntilReset = 1.5f;
	private float timeElapsed = 0.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	//Check for time validity
		if(timeElapsed > timeUntilReset){
			// TODO transform back to outside of the screen
			// TODO set velocity to zero
		}else{
			timeElapsed += Time.deltaTime;
		}
	//Update position
		this.gameObject.transform.position += bulletSpeed * this.gameObject.transform.forward;



	}

	//Check for collision events
	void onCollisionEnter(Collision collision){
		if(collision.gameObject.name == "Zombie"){ // gameObject type!
			Destroy(collision.gameObject);
			//TODO transform this.gameObject back to outside of the screen
		}
	}
}
