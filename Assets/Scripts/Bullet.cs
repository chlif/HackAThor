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
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.name == "Zombie") {
			collision.gameObject.SendMessage("Die");
			Destroy( gameObject );
		}
	}
}
