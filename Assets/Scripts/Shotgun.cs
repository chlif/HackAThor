using UnityEngine;
using System.Collections;

public class Shotgun : MonoBehaviour {

	public Bullet bullet;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown( KeyCode.G )) { 
			fireShotgun();
		}
	}

	void fireShotgun(){
		CreateNewBullet ();
		//bullet.transform.position( this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z );
	}

	void CreateNewBullet() {
		Rigidbody2D clone;
		float speed = 5.0f;
		GameObject ob;
		ob = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
		clone = (Rigidbody2D) ob.GetComponent(typeof(Rigidbody2D));
		clone.AddForce (clone.transform.forward * speed);

		Destroy (clone.gameObject, 3);
	}
}
