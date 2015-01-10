using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


	}

	//Check for collision events
	void onCollisionEnter(Collision collision){
		print ("Colission");
		if (collision.gameObject.name == "Zombie"){ 
			print("To a zombie!");
			Destroy(collision.gameObject);
		}
	}
}
