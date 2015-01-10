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
		Rigidbody clone;
		float speed = 5.0f;
		GameObject ob;
		ob = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
		clone = (Rigidbody) ob.GetComponent(typeof(Rigidbody));
		clone.velocity = transform.TransformDirection ( new Vector3 (4, 0, 0));
//		clone.AddForce (clone.transform.forward * speed);

		//Destroy (clone.gameObject, 3);
	}
}
