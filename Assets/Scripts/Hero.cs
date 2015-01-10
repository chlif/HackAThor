using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour {

	private Animator anim;
	private bool facingRight = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float xVelocity = GetXVelocity ();

		rigidbody2D.velocity = new Vector2 (xVelocity, rigidbody2D.velocity.y);

		if (xVelocity > 0 && !facingRight) {
			Flip ();
		} else if (xVelocity < 0 && facingRight) {
			Flip ();
		}

	}

	// Read input to get velocity
	float GetXVelocity () {
		// A - D
		float xVelocity = 0;

		if (Input.GetKey (KeyCode.A)) {
			xVelocity = -2;
		} else if (Input.GetKey (KeyCode.D)) {
			xVelocity = 2;
		}

		return xVelocity;
	}

	void Flip() {
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
		facingRight = (facingRight) ? false : true;
	}

}
